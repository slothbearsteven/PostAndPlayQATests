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

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div[2]/form/input")]
        public IWebElement messageInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div[2]/form/div/button")]
        public IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div[1]/div/div[1]/div/div[2]/p")]
        public IWebElement messageSent;

    }
}
