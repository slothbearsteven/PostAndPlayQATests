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
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[2]/div/div[2]/div/div/strong/a")]
        public IWebElement chatLink { get; private set; }

        public ChatPage NavigateToChat()
        {
            chatLink.Click();

            return new ChatPage(driver);
        }

    }
}
