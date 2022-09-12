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

            string characterName = "Selenius Automa";
            string characterDescription = "This is an automatically created character";
            string characterStats = "";

            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            homePage.charactersButton.Click();

            CharactersPage charactersPage = new CharactersPage(driver);
            charactersPage.createCharacterButton.Click();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            charactersPage.characterNameInput.SendKeys(characterName);
            charactersPage.characterDescriptionInput.Click();
          charactersPage.characterDescriptionInput.SendKeys(characterDescription);
            charactersPage.characterStatsInput.Click();
            charactersPage.characterStatsInput.SendKeys(characterStats);
          

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            charactersPage.submitCharacterButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            driver.Navigate().Refresh();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            IWebElement createdCharacter = charactersPage.GetMostRecentCharacterMade(0);
            string createdCharacterName =createdCharacter.FindElement(By.XPath(".//strong")).Text;
            string createdCharacterDescription = createdCharacter.FindElement(By.XPath(".//div[1]/p")).Text;

            Assert.AreEqual(characterName, createdCharacterName);
            Assert.AreEqual(characterDescription, createdCharacterDescription);  
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
