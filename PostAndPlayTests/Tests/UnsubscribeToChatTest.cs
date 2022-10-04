using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class UnsubscribeToChatTest
    {
        private IWebDriver driver;
        [SetUp]
       public void Setup()
        {
            this.driver = new ChromeDriver();   
        }
        [Test]

        public void UnsubscribeChat()
        {   LoginMethods loginMethods = new LoginMethods();
            ChatsMethods chatsMethods = new ChatsMethods();

            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
          
            chatsMethods.ChatSubscription(driver);
            ChatPage chatPage = new ChatPage(driver);
            chatPage.NavigateToHome();
            
            int originalAmountSubscribed = homePage.amountSubscribedChats;
             

            //Unsubscribe button clicked

            //Unsubscribed chat is removed from list, refresh for best result

            //Assert originalAmountSubscribed and afterUnsubscribe are NOT equal

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
