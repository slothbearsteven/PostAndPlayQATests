using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.PageObjects
{
    internal class NavBar
    {
        private IWebDriver driver;
        public NavBar(IWebDriver webDriver)
        {
            this.driver = webDriver;
           

        }

        public IWebElement chatsButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[2]/a/button"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='nav']/div/a"));
        public IWebElement charactersButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[1]/a/button"));
        public IWebElement diceButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[2]/div/div/button"));
        public IWebElement logoutButton => driver.FindElement(By.XPath("//*[@id='nav']/div/div[1]/div/div/button"));
    }
}
