using NunitFramework.pages;
using NunitFramework.utilities;
using NunitFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuintTestProject
{
    [Parallelizable(ParallelScope.Self)]
    internal class NunitFrameworkSeleniumProject : Base
    {

        [Test]
        public void TestMethod()
        {

            Console.WriteLine($"Title of the web page is : {driver.Value.Title}");
            Console.WriteLine($"URL of the web page is : {driver.Value.Url}");
            //driver.SwitchTo().Window("hj");

            LoginPage loginPage = new LoginPage(GetDriver());
            loginPage.ValidLogin("rahulshettyacademy", "Learning@830$3mK2?");

            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("alert-danger")));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(By.Id("signInBtn"), "Sign In"));

            string errorMessage = driver.Value.FindElement(By.ClassName("alert-danger")).Text;

            Console.WriteLine($"{errorMessage}");
            TestContext.Progress.WriteLine(errorMessage);

            IWebElement element = driver.Value.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            string? actualURL = element.GetAttribute("href");
            string expectedURL = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expectedURL, actualURL);

        }

        [Test, Category("Smoke")]
        public void StaticDropDown()
        {
            IWebElement element = driver.Value.FindElement(By.CssSelector("select.form-control"));
            SelectElement select = new SelectElement(element);
            Thread.Sleep(1500);
            select.SelectByText("Teacher");
            Thread.Sleep(1500);
            select.SelectByValue("consult");
            Thread.Sleep(1500);
            select.SelectByIndex(0);
        }

        [Test, Category("Smoke")]
        public void RadioButton()
        {
            ReadOnlyCollection<IWebElement> radio = driver.Value.FindElements(By.XPath("//input[@type='radio']"));
            foreach (IWebElement element in radio)
            {
                if (element.GetAttribute("value").Equals("user"))
                {
                    element.Click();

                    break;
                }
            }
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okayBtn")));
            driver.Value.FindElement(By.Id("okayBtn")).Click();
            bool isSelected = driver.Value.FindElement(By.XPath("//input[@value='user']")).Selected;
            Console.WriteLine($"Radio button is {isSelected}");
            Thread.Sleep(1500);
        }

        //[Test]
        //[TestCase("rahulshettyacademy", "Learning@830$3mK2")]
        //[TestCase("rahulshettyacademy", "Learning@830$3mK2")]
        [Test, TestCaseSource("GetTestData"), Category("Sanity")]
        [Parallelizable(ParallelScope.All)]
        public void AddMobilesToCart(string userName, string password, string[] expectedMobiles)
        {
            string[] actualMobiles = new string[2];

            LoginPage loginPage = new LoginPage(GetDriver());
            ProductsPage productPage = loginPage.ValidLogin(userName, password);
            productPage.WaitForPageDisplay();

            IList<IWebElement> mobileList = productPage.GetMobileList();
            foreach (IWebElement element in mobileList)
            {
                if (expectedMobiles.Contains(element.FindElement(productPage.GetCardTitle()).Text))
                {
                    element.FindElement(productPage.GetAddToCartButton()).Click();
                }
            }
            CheckoutPage checkoutPage = productPage.CheckOut();
            IList<IWebElement> mobiles = checkoutPage.GetMobilesList();
            for (int i = 0; i < mobiles.Count; i++)
            {
                actualMobiles[i] = mobiles[i].Text;
            }
            Assert.That(actualMobiles, Is.EqualTo(expectedMobiles));
            ConfirmationPage confirmationPage = checkoutPage.ClickOnCheckoutButton();

            confirmationPage.GetCountryTextField().SendKeys("Ind");
            confirmationPage.WaitTillAutoCountrySuggestions();
            confirmationPage.EnterCheckoutDetailsAndValidateSuccessMessage();
            Thread.Sleep(1500);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
           yield return new TestCaseData(JsonParserInitializer().ReadJsonFile("username"), JsonParserInitializer().ReadJsonFile("password"), JsonParserInitializer().ReadJsonDataArray("products"));
           yield return new TestCaseData(JsonParserInitializer().ReadJsonFile("username"), JsonParserInitializer().ReadJsonFile("password"), JsonParserInitializer().ReadJsonDataArray("products"));
        }
    }
}
