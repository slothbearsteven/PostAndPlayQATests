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
           
        }
        [Test]
        public void CreateChat()
        {
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

          HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            homePage.chatsButton.Click();


            ChatsPage chatsPage = new ChatsPage(driver);    
            chatsPage.chatNameInput.Click();
            chatsPage.chatNameInput.SendKeys("automated test Chat");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            chatsPage.createChatButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
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
