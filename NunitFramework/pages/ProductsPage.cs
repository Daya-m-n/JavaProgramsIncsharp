using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework.pages
{
    public class ProductsPage
    {
        IWebDriver driver;
        By cardTitle = By.CssSelector(".card-title a");
        By cardFooter = By.CssSelector(".card-footer button");
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.TagName, Using = "app-card")]
        private IList<IWebElement> mobileList;


        [FindsBy(How = How.PartialLinkText, Using = "Checkout")]
        private IWebElement checkOutButton;

        public CheckoutPage CheckOut()
        {
            checkOutButton.Click();
            return new CheckoutPage(driver);
        }

        public void WaitForPageDisplay()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));
        }

        public IList<IWebElement> GetMobileList()
        {
            return mobileList;
        }

        public By GetCardTitle()
        {
            return cardTitle;
        }

        public By GetAddToCartButton()
        {
            return cardFooter;
        }
    }
}
