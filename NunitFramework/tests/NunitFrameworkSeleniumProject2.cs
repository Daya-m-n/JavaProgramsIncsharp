using NunitFramework.Utilities;
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
    [Parallelizable(ParallelScope.Self)]
    internal class NunitFrameworkSeleniumProject2 : Base
    {

        [Test]
        public void SortVegetablesAndValidate()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            List<string> beforeSort = new List<string>();
            List<string> afterSort = new List<string>();
            // driver.FindElement(By.Id("//a[text()='Top Deals']")).Click();
            SelectElement select = new SelectElement(driver.Value.FindElement(By.Id("page-menu")));
            select.SelectByValue("20");

            IList<IWebElement> veggies = driver.Value.FindElements(By.XPath("//tr/td[1]"));
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

            driver.Value.FindElement(By.XPath("//th[contains(@aria-label,'Veg/fruit name')]")).Click();

            IList<IWebElement> sortedVeggies = driver.Value.FindElements(By.XPath("//tr/td[1]"));
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
            driver.Value.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Value.FindElement(By.Id("name")).SendKeys(name);
            driver.Value.FindElement(By.Id("confirmbtn")).Click();
            Thread.Sleep(1500);
            string? actualText = driver.Value.SwitchTo().Alert().Text;
            driver.Value.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();
            //driver.SwitchTo().Alert().SendKeys("Hi");
            StringAssert.Contains(name, actualText);
        }

        [Test]
        public void AutoSuggestionDropdown()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Value.FindElement(By.Id("autocomplete")).SendKeys("Ind");
            IList<IWebElement> countries = driver.Value.FindElements(By.CssSelector(".ui-menu-item div"));
            foreach (IWebElement country in countries)
            {
                if (country.Text.Equals("India"))
                {
                    country.Click();
                }
            }
            Assert.That(driver.Value.FindElement(By.Id("autocomplete")).GetAttribute("value"), Is.EqualTo("India"));
        }

        [Test]
        public void ActionClassMouseHover()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            IWebElement element = driver.Value.FindElement(By.Id("mousehover"));
            Actions action = new Actions(driver.Value);
            action.ScrollToElement(element).Perform();
            Thread.Sleep(1500);
            action.MoveToElement(element).Perform();
            driver.Value.FindElement(By.LinkText("Reload")).Click();
        }


        [Test, Category("Smoke")]
        public void ActionClassDragAndDrop()
        {
            driver.Value.Url = "https://demoqa.com/droppable";
            Actions action = new Actions(driver.Value);
            IWebElement source = driver.Value.FindElement(By.XPath("//div[@id='draggable']"));
            IWebElement target = driver.Value.FindElement(By.XPath("//div[@id='draggable']/following-sibling::div/p"));
            action.DragAndDrop(source, target).Perform();
            //action.ClickAndHold(source).MoveToElement(target).Release().Build().Perform();
        }

        [Test,Category("Smoke")]
        public void IFrameHandling()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            IWebElement element = driver.Value.FindElement(By.Id("courses-iframe"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver.Value;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.Value.SwitchTo().Frame("courses-iframe");
            driver.Value.FindElement(By.XPath("(//a[text()='All Access plan'])[1]")).Click();
            Console.WriteLine(driver.Value.FindElement(By.TagName("h1")).Text);

            //To switch back to main page we use defaultContent method
            driver.Value.SwitchTo().DefaultContent();
            Console.WriteLine(driver.Value.FindElement(By.TagName("h1")).Text);

        }

        [Test, Category("Sanity")]
        public void IFrameNestedFrames()
        {
            driver.Value.Url = "https://demoqa.com/nestedframes";
            driver.Value.SwitchTo().Frame("frame1").SwitchTo().Frame(0);
            string childFrameText = driver.Value.FindElement(By.TagName("p")).Text;
            Console.WriteLine($"Child frame text is :{childFrameText}");

            driver.Value.SwitchTo().ParentFrame();
            string parentFrameText = driver.Value.FindElement(By.TagName("body")).Text;
            Console.WriteLine($"Parent frame text is :{parentFrameText}");

            driver.Value.SwitchTo().DefaultContent();
            string mainPageText = driver.Value.FindElement(By.TagName("h1")).Text;
            Console.WriteLine($"Main webpage text is :{mainPageText}");
        }

        [Test]
        public void WindowHandling()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Value.FindElement(By.PartialLinkText("Free Access to InterviewQues")).Click();

            string parentWindowHandle = driver.Value.CurrentWindowHandle;

            IList<string> windowHandles = driver.Value.WindowHandles;
            foreach (string windowHandle in windowHandles)
            {
                Console.WriteLine($"Windowhandle name is : {windowHandle}");
            }

            driver.Value.SwitchTo().Window(windowHandles[1]);
            string text = driver.Value.FindElement(By.XPath("//p[contains(@class,'red')]")).Text;
            Console.WriteLine(text);

            string emailID=text.Split("at")[1].Trim().Split(" ")[0];
            driver.Value.SwitchTo().Window(parentWindowHandle);
            driver.Value.FindElement(By.Id("username")).SendKeys(emailID);
        }
    }
}
