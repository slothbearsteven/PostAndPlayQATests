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

        public IWebElement chatNameInput { get; private set; }

        public IWebElement chatDescriptionInput { get; private set; }

        public IWebElement createChatButton { get; private set; }

        public IWebElement recentlyCreatedChat { get; private set; }

        public IWebElement deleteChatButton { get; private set; }
    }
}
