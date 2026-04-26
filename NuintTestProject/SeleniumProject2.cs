using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuintTestProject
{
    internal class SeleniumProject2
    {
        private IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void SortVegetablesAndValidate()
        {
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            List<string> beforeSort = new List<string>();
            List<string> afterSort = new List<string>();
            // driver.FindElement(By.Id("//a[text()='Top Deals']")).Click();
            SelectElement select = new SelectElement(driver.FindElement(By.Id("page-menu")));
            select.SelectByValue("20");

            IList<IWebElement> veggies = driver.FindElements(By.XPath("//tr/td[1]"));
            foreach (IWebElement veggie in veggies)
            {
                beforeSort.Add(veggie.Text);
            }

            foreach (string veggie in beforeSort)
            {
                Console.WriteLine(veggie);
            }

            beforeSort.Sort();
            Console.WriteLine("After Sorting");

            foreach (string veggie in beforeSort)
            {
                Console.WriteLine(veggie);
            }

            driver.FindElement(By.XPath("//th[contains(@aria-label,'Veg/fruit name')]")).Click();

            IList<IWebElement> sortedVeggies = driver.FindElements(By.XPath("//tr/td[1]"));
            foreach (IWebElement veggie in sortedVeggies)
            {
                afterSort.Add(veggie.Text);
            }
            //Assert.AreEqual(beforeSort, afterSort);
            Assert.That(afterSort, Is.EqualTo(beforeSort));
        }

        [Test]
        public void AlertTextValidation()
        {
            string name = "Daya";
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.FindElement(By.Id("name")).SendKeys(name);
            driver.FindElement(By.Id("confirmbtn")).Click();
            Thread.Sleep(1500);
            string? actualText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();
            //driver.SwitchTo().Alert().SendKeys("Hi");
            StringAssert.Contains(name, actualText);
        }

        [Test]
        public void AutoSuggestionDropdown()
        {
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.FindElement(By.Id("autocomplete")).SendKeys("Ind");
            IList<IWebElement> countries = driver.FindElements(By.CssSelector(".ui-menu-item div"));
            foreach (IWebElement country in countries)
            {
                if (country.Text.Equals("India"))
                {
                    country.Click();
                }
            }
            Assert.That(driver.FindElement(By.Id("autocomplete")).GetAttribute("value"), Is.EqualTo("India"));
        }

        [Test]
        public void ActionClassMouseHover()
        {
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            IWebElement element = driver.FindElement(By.Id("mousehover"));
            Actions action = new Actions(driver);
            action.ScrollToElement(element).Perform();
            Thread.Sleep(1500);
            action.MoveToElement(element).Perform();
            driver.FindElement(By.LinkText("Reload")).Click();
        }


        [Test]
        public void ActionClassDragAndDrop()
        {
            driver.Url = "https://demoqa.com/droppable";
            Actions action = new Actions(driver);
            IWebElement source = driver.FindElement(By.XPath("//div[@id='draggable']"));
            IWebElement target = driver.FindElement(By.XPath("//div[@id='draggable']/following-sibling::div/p"));
            action.DragAndDrop(source, target).Perform();
            //action.ClickAndHold(source).MoveToElement(target).Release().Build().Perform();
        }

        [Test]
        public void IFrameHandling()
        {
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            IWebElement element = driver.FindElement(By.Id("courses-iframe"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.SwitchTo().Frame("courses-iframe");
            driver.FindElement(By.XPath("(//a[text()='All Access plan'])[1]")).Click();
            Console.WriteLine(driver.FindElement(By.TagName("h1")).Text);

            //To switch back to main page we use defaultContent method
            driver.SwitchTo().DefaultContent();
            Console.WriteLine(driver.FindElement(By.TagName("h1")).Text);

        }

        [Test]
        public void IFrameNestedFrames()
        {
            driver.Url = "https://demoqa.com/nestedframes";
            driver.SwitchTo().Frame("frame1").SwitchTo().Frame(0);
            string childFrameText = driver.FindElement(By.TagName("p")).Text;
            Console.WriteLine($"Child frame text is :{childFrameText}");

            driver.SwitchTo().ParentFrame();
            string parentFrameText = driver.FindElement(By.TagName("body")).Text;
            Console.WriteLine($"Parent frame text is :{parentFrameText}");

            driver.SwitchTo().DefaultContent();
            string mainPageText = driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine($"Main webpage text is :{mainPageText}");
        }

        [Test]
        public void WindowHandling()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.FindElement(By.PartialLinkText("Free Access to InterviewQues")).Click();

            string parentWindowHandle=driver.CurrentWindowHandle;

            IList<string> windowHandles = driver.WindowHandles;
            foreach (string windowHandle in windowHandles)
            {
                Console.WriteLine($"Windowhandle name is : {windowHandle}");
            }

            driver.SwitchTo().Window(windowHandles[1]);
            string text = driver.FindElement(By.XPath("//p[contains(@class,'red')]")).Text;
            Console.WriteLine(text);

            string emailID=text.Split("at")[1].Trim().Split(" ")[0];
            driver.SwitchTo().Window(parentWindowHandle);
            driver.FindElement(By.Id("username")).SendKeys(emailID);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(1500);
            driver.Quit();
        }
    }
}
