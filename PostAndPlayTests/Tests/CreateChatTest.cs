using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.PageObjects;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class CreateChatTest
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void CreateChat()
       {   LoginMethods loginMethods = new LoginMethods();
            ChatsMethods chatsMethods = new ChatsMethods();

            loginMethods.HappyPathLogin(driver);
            chatsMethods.ChatCreationHappy(driver);

            ChatsPage chatsPage = new ChatsPage(driver);
     
            string expectedText = "automated test Chat";
            

            Assert.AreEqual(expectedText, chatsPage.FindMostRecentChat(0).Text);




        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
