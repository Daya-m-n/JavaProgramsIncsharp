using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework.pages
{
    public class ConfirmationPage
    {
        private IWebDriver driver;
        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement countryTextField;

        [FindsBy(How = How.LinkText, Using = "India")]
        private IWebElement autoSuggestedCountryOption;

        [FindsBy(How = How.XPath, Using = "//label[@for='checkbox2']")]
        private IWebElement termsAndConditionCheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'alert-success')]")]
        private IWebElement successMessageText;

        public IWebElement GetCountryTextField()
        {
            return countryTextField;
        }

        public void WaitTillAutoCountrySuggestions()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("India")));
        }

        public void EnterCheckoutDetailsAndValidateSuccessMessage()
        {
            autoSuggestedCountryOption.Click();
            termsAndConditionCheckbox.Click();
            submitButton.Click();
            StringAssert.Contains("Success", successMessageText.Text, "Text is not matching"); 
        }
    }
}
