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
            Thread.Sleep(500);
            
            int originalAmountSubscribed = homePage.amountSubscribedChats;

            //Unsubscribe button clicked
            homePage.firstUnsubscribeButton.Click();
            //Unsubscribed chat is removed from list, refresh for best result
            driver.Navigate().Refresh();
            Thread.Sleep(500);

            int newAmountSubscribed = homePage.amountSubscribedChats;

            //Assert originalAmountSubscribed and afterUnsubscribe are NOT equal
            Assert.AreNotEqual(originalAmountSubscribed, newAmountSubscribed);





        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
