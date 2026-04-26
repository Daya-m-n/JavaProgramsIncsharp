using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework.pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h4 a")]
        private IList<IWebElement> mobilesList;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Checkout ')]")]
        private IWebElement checkoutButton;

        public IList<IWebElement> GetMobilesList()
        {
            return mobilesList;
        }

        public ConfirmationPage ClickOnCheckoutButton()
        {
            checkoutButton.Click();
            return new ConfirmationPage(driver);
        }
    }
}
