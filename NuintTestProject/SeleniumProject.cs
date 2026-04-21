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
    internal class SeleniumProject
    {
        private IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            //options.AddUserProfilePreference("credentials_enable_service", false);
            //options.AddUserProfilePreference("profile.password_manager_enabled", false);
            driver = new ChromeDriver(options);
            //driver = new EdgeDriver();
            //driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }


        [Test]
        public void TestMethod()
        {
            
            Console.WriteLine($"Title of the web page is : {driver.Title}"); 
            Console.WriteLine($"URL of the web page is : {driver.Url}");
            //driver.SwitchTo().Window("hj");
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("Learning@830$3mK2?");
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();

            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();

            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("alert-danger")));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(By.Id("signInBtn"), "Sign In"));

            string errorMessage=driver.FindElement(By.ClassName("alert-danger")).Text;

            Console.WriteLine($"{errorMessage}");
            TestContext.Progress.WriteLine(errorMessage);

            IWebElement element=driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            string? actualURL = element.GetAttribute("href");
            string expectedURL = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expectedURL, actualURL);

        }

        [Test]
        public void StaticDropDown()
        {
            IWebElement element = driver.FindElement(By.CssSelector("select.form-control"));
            SelectElement select = new SelectElement(element);
            Thread.Sleep(1500);
            select.SelectByText("Teacher");
            Thread.Sleep(1500);
            select.SelectByValue("consult");
            Thread.Sleep(1500);
            select.SelectByIndex(0);
        }

        [Test]
        public void RadioButton()
        {
            ReadOnlyCollection<IWebElement> radio=driver.FindElements(By.XPath("//input[@type='radio']"));
            foreach(IWebElement element in radio)
            {
                if (element.GetAttribute("value").Equals("user"))
                {
                    element.Click();
                   
                    break;
                }
            }
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okayBtn")));
            driver.FindElement(By.Id("okayBtn")).Click();
            bool isSelected=driver.FindElement(By.XPath("//input[@value='user']")).Selected;
            Console.WriteLine($"Radio button is {isSelected}");
            Thread.Sleep(1500);
        }

        [Test]
        public void AddMobilesToCart()
        {
            string[] mobiles = { "iphone X" , "Blackberry" };
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("Learning@830$3mK2");
            //checkbox
            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
            //sign in
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

            IList mobileList=driver.FindElements(By.TagName("app-card"));

            foreach(IWebElement element in mobileList)
            {
               if(mobiles.Contains(element.FindElement(By.CssSelector(".card-title a")).Text)){
                    element.FindElement(By.CssSelector(".card-footer button")).Click();
                }
            }

            driver.FindElement(By.PartialLinkText("Checkout")).Click();
            Thread.Sleep(1500);
        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Dispose();
            driver?.Quit();
        }
    }
}
