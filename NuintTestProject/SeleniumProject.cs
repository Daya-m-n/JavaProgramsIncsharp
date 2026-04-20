using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
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
            driver = new ChromeDriver();
        }


        [Test]
        public void TestMethod()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://app.netlify.com/signup-questions";
            Console.WriteLine($"Title of the web page is : {driver.Title}"); 
        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Dispose();
            driver?.Quit();
        }
    }
}
