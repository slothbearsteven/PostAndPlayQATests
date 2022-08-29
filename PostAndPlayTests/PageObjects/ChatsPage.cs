using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.PageObjects
{
    internal class ChatsPage
    {
        private IWebDriver driver;
        public ChatsPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[1]/div/form/input[1]")]
        public IWebElement chatNameInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[1]/div/form/input[2]")]
        public IWebElement chatDescriptionInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[1]/div/form/button")]
        public IWebElement createChatButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[2]/strong/div[1]/strong")]
        public IWebElement recentlyCreatedChat { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div/div[1]/div/form/input[2]")]
        public IWebElement deleteChatButton { get; private set; }
    }
}
