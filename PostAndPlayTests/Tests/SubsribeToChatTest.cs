﻿using PostAndPlayTests.FreqMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class SubsribeToChatTest
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [Test]

        public void SubscribeToChat()
        {
            LoginMethods loginMethods = new LoginMethods();
            ChatsMethods chatsMethods = new ChatsMethods();

            loginMethods.HappyPathLogin(driver);

            //grab ammount subscribed to on the screen currently



        }

        [TearDown]

        public void TearDown()
        {

        }
    }
}
