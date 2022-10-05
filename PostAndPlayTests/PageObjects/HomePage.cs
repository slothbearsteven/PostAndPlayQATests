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
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
           
        }

        public IWebElement chatLink => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[2]/div/div/strong/a"));

        public IWebElement chatsButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[2]/a/button"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='nav']/div/a"));
        public IWebElement charactersButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[1]/a/button"));
        public IWebElement diceButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[2]/div/div/button"));
        public IWebElement logoutButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[1]/div/div/button"));


        //Begin Dice Modal elements
        public IWebElement rollD20Button => driver.FindElement(By.XPath("//*[@id=\"diceModal\"]/div/div/div[2]/div/div[1]/div[1]/button"));
        public IWebElement diceResult => driver.FindElement(By.Id("results"));
        //End Dice Modal elements

        public IWebElement firstUnsubscribeButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[2]/div/div/button/b"));

        public int amountSubscribedChats => driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/*")).Count;


        public ChatPage NavigateToSubscribedChat()
        {
            chatLink.Click();

            return new ChatPage(driver);
        }

    }
}
