using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class DeleteCharacterTest
    {
        IWebDriver driver;
        [SetUp] 
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [Test]

        public void DeleteCharacter() 
        {
            CharactersMethods charactersMethods = new CharactersMethods();

            charactersMethods.CreateCharacterHappy(driver);
            CharactersPage charactersPage = new CharactersPage(driver);

            int originalCharacterCount = driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/*")).Count;


            IWebElement deleteCharacterButton =charactersPage.GetMostRecentCharacterMade(0).FindElement(By.XPath(".//div[2]/button[2]"));
            deleteCharacterButton.Click();

            charactersPage.alert.Accept();

            driver.Navigate().Refresh();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            int updatedCharacterCount = driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/*")).Count;

            Assert.AreNotEqual(updatedCharacterCount, originalCharacterCount);
            
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
