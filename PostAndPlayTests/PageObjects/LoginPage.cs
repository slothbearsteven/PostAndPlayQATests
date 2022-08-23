using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Pages
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/form/input[1]")]
        public IWebElement emailField;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/form/input[2]")]
        public IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/form/button")]
        public IWebElement submitButton;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://post-n-play.herokuapp.com/#/login");
        }

        public HomePage SubmitAccount()
        {
         
            submitButton.Click();

            return new HomePage(driver);
        }


    }
}
