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
        private IWebElement email;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/form/input[2]")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/form/button")]
        private IWebElement submit;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://post-n-play.herokuapp.com/#/login");
        }

        public HomePage Login()
        {
            email.SendKeys("s@s.com");
            password.SendKeys("steven");
            submit.Click();

            return new HomePage(driver);
        }


    }
}
