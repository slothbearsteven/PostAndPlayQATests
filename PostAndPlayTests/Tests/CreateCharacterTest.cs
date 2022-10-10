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
    internal class CreateCharacterTest
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            //Takes the driver and assigns it the chrome driver. After it maximizes the window for ease of viewing the test
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CreateCharacter()
        {
            //Login and create a character using the 'happy' path methods
            LoginMethods loginMethods = new LoginMethods();
            CharactersMethods charactersMethods = new CharactersMethods();
            loginMethods.HappyPathLogin(driver);
            charactersMethods.CreateCharacterHappy(driver);

            CharactersPage charactersPage = new CharactersPage(driver);
            //after creating a character, grab the most recent character and assert that the expected and actual names are the same
            IWebElement createdCharacter = charactersPage.GetMostRecentCharacterMade(0);
            string createdCharacterName =createdCharacter.FindElement(By.XPath(".//strong")).Text;
            string createdCharacterDescription = createdCharacter.FindElement(By.XPath(".//div[1]/p")).Text;

            Assert.AreEqual(charactersMethods.characterName, createdCharacterName);
            Assert.AreEqual(charactersMethods.characterDescription, createdCharacterDescription);  
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
