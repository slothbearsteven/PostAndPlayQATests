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
            driver = new ChromeDriver();

        }

        [Test]
        public void CreateCharacter()
        {
            LoginMethods loginMethods = new LoginMethods();
            CharactersMethods charactersMethods = new CharactersMethods();
            loginMethods.HappyPathLogin(driver);
            charactersMethods.CreateCharacterHappy(driver);

            CharactersPage charactersPage = new CharactersPage(driver);
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
