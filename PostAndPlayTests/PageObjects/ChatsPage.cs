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
          
        }

        public IWebElement chatNameInput => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[1]/div/form/input[1]"));

        public IWebElement chatDescriptionInput => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/form/input[2]"));

        public IWebElement createChatButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/form/button"));

        public IWebElement recentlyCreatedChat => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/strong/div[1]/strong"));

        public IWebElement deleteChatButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/form/input[2]"));
    }
}
