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
    internal class ChatPage
    {
        private IWebDriver driver;

        public ChatPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }


        public IWebElement messageInput => driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/form/input"));

        public IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/form/div/button"));

        public IWebElement messageSent => driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[1]/div/div[1]/div/div[2]/p"));

        public IWebElement subscribeButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div/div[1]/h3/button"));

        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id=\"nav\"]/div/a"));

        public HomePage NavigateToHome()
        {
            homeButton.Click();
            return new HomePage(driver);
        }
   
    }
}
