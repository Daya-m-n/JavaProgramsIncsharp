using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using NunitFramework.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework.Utilities
{
    public class Base
    {
        string browserName;
        public ExtentReports extent;
        public ExtentTest test;
        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        [OneTimeSetUp]
        public void Setup()
        {
            string currentPath = TestContext.CurrentContext.TestDirectory;
            string projectPath = Directory.GetParent(currentPath).Parent.Parent.FullName;
            string filePath = Path.Combine(projectPath, "reports", "index.html");
            extent = new ExtentReports();
            ExtentSparkReporter sparkReporter = new ExtentSparkReporter(filePath);
            extent.AttachReporter(sparkReporter);
            extent.AddSystemInfo("Env", "QA");
            extent.AddSystemInfo("QA", "Daya");
        }
        //protected IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            test=extent.CreateTest(TestContext.CurrentContext.Test.Name);
            browserName = TestContext.Parameters["browserName"];
            if (browserName==null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }
            InitBrowser(browserName);
            driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Value.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--incognito");
                    driver.Value = new ChromeDriver(options);
                    break;

                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.AddArgument("--inprivate");
                    driver.Value = new EdgeDriver(edgeOptions);
                    break;

                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--incognito");
                    driver.Value = new FirefoxDriver(firefoxOptions);
                    break;

                default:
                    ChromeOptions optionsDefault = new ChromeOptions();
                    optionsDefault.AddArgument("-private");
                    driver.Value = new ChromeDriver(optionsDefault);
                    break;
            }
        }

        public static JsonReader JsonParserInitializer()
        {
            return new JsonReader();
        }
        public IWebDriver GetDriver()
        {
            return driver.Value;
        }

        [TearDown]
        public void CloseBrowser()
        {
            var status=TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace=TestContext.CurrentContext.Result.StackTrace;
            DateTime time = DateTime.Now;
            string fileName = "SCreenshot_" + time.ToString("h_mm_ss") + ".png";
            if (status== TestStatus.Failed)
            {
                test.Fail("Test Failed", CaptureScreenshot(driver.Value, fileName));
                test.Log(Status.Fail, stackTrace);
            }
            else if (status == TestStatus.Passed)
            {

            }
            extent.Flush();
            Thread.Sleep(1500);
            driver.Value.Quit();
        }

        public Media CaptureScreenshot(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot ss = (ITakesScreenshot)driver;
            string screenshot = ss.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }
    }
}
