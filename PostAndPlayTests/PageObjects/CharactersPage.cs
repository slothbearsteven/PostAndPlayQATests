using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.PageObjects
{
    internal class CharactersPage
    {
        private IWebDriver driver;
        public CharactersPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
           
        }


        public IWebElement createCharacterButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div/button"));

        //Begin Modal content

        public IWebElement characterNameInput => driver.FindElement(By.Id("charactername"));

        public IWebElement characterStatsInput => driver.FindElement(By.Id("characterStats"));

        public IWebElement characterDescriptionInput => driver.FindElement(By.Id("characterDescription"));

        public IWebElement submitCharacterButton => driver.FindElement(By.XPath("//*[@id=\"characterModal\"]/div/div/div[2]/form/div[3]/button"));

        //End Modal Content

        int totalCharacters;

         
        public IWebElement GetMostRecentCharacterMade(int i) { 
        
        

            driver.Navigate().Refresh();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            try
            {

               totalCharacters = driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/*")).Count;

                return driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[" + totalCharacters+ "]"));
            }
            //*[@id="app"]/div/div/div[2]/div[3]/div[2]/button[2]
            catch
            {
                if (i < 5)
                {
                    i++;
                    return GetMostRecentCharacterMade(i);
                }
                else
                {


                    return driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[" + totalCharacters + "]"));
                }
            }

        }




    }
}
