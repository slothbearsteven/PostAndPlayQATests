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

        IWebElement chatNameInput;
        
        IWebElement chatDescriptionInput;

        IWebElement createChatButton;

        IWebElement recentlyCreatedChat;

        IWebElement deleteChatButton;
    }
}
