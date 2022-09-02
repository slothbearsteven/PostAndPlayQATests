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
            LoginPage loginPage = new LoginPage(driver);
            loginPage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            loginPage.emailField.SendKeys("s@s.com");
            loginPage.passwordField.SendKeys("steven");
            loginPage.SubmitAccount();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
          HomePage homePage = new HomePage(driver);
            homePage.chatsButton.Click();


            ChatsPage chatsPage = new ChatsPage(driver);    
            chatsPage.chatNameInput.Click();
            chatsPage.chatNameInput.SendKeys("automated test Chat");
            
   //currently the driver is not finding the create button. This is odd as the primary change made had nothing to do with the button, and had no previous problem. 
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
