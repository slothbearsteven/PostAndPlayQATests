using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.PageObjects
{
    internal class NavBar
    {
        private IWebDriver driver;
        public NavBar(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/div/div[2]/a/button")]
        public IWebElement chatsButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "///*[@id='nav']/div/a")]
        public IWebElement homeButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/div/div[1]/a/button")]
        public IWebElement charactersButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/div/div[2]/div/div/button")]
        public IWebElement diceButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/div/div[1]/div/div/button")]
        public IWebElement logoutButton { get; private set; }


    }
}
