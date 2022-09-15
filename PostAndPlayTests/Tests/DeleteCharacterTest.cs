using PostAndPlayTests.FreqMethods;
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

            int originalCharacterCount;
            int updatedCharacterCount;
            
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
