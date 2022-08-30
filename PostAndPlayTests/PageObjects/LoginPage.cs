using OpenQA.Selenium;
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
          
        }

        public IWebElement emailField => driver.FindElement(By.XPath("//*[@id='app']/div/div/form/input[1]"));
        public IWebElement passwordField => driver.FindElement(By.XPath("//*[@id='app']/div/div/form/input[2]"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/form/button"));


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
