using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class SubsribeToChatTest
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [Test]

        public void SubscribeToChat()
        {
            LoginMethods loginMethods = new LoginMethods();
            ChatsMethods chatsMethods = new ChatsMethods();

            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
            //grab ammount subscribed to on the screen currently
            int originalAmountSubscribed = homePage.amountSubscribedChats;
            chatsMethods.ChatSubscription(driver);
            ChatPage chatPage = new ChatPage(driver);
            chatPage.NavigateToHome();
            int updatedAmountSubscribed = homePage.amountSubscribedChats;
            Assert.AreNotEqual(originalAmountSubscribed, updatedAmountSubscribed);


            
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}
