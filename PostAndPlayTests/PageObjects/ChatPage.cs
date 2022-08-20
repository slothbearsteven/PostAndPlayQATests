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
    internal class ChatPage
    {
        private IWebDriver driver;

        public ChatPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".grid-ipnut")]
        private IWebElement messageInput;

        [FindsBy(How = How.CssSelector, Using = ".btn .btn-info button[type='submit']")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div[1]/div/div[1]")]
        private IWebElement messageSent;

        public void SendMessage()
        {
            messageInput.SendKeys("This is an automated test");
            submitButton.Click();
        }

        public string GetMessageContent()
        {
            return messageSent.Text;

        }
    }
}
