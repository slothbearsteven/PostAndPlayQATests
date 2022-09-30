using PostAndPlayTests.PageObjects;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.FreqMethods
{
    internal class ChatsMethods
    {
        public void ChatCreationHappy(IWebDriver driver)
        {
           
            HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            homePage.chatsButton.Click();


            ChatsPage chatsPage = new ChatsPage(driver);
            chatsPage.chatNameInput.Click();
            chatsPage.chatNameInput.SendKeys("automated test Chat");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            chatsPage.createChatButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }


        public void ChatSubscription(IWebDriver driver)
        {

        }
    }
}
