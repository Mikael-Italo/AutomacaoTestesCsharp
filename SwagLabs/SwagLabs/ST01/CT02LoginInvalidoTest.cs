using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using SwagLabs.PageObject;
using SwagLabs;
using System.Configuration;

namespace ST01Login
{
    [TestFixture]
    public class CT02LoginInvalidoTest
    {
        private RemoteWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = Utils.getBrowserLocal(driver, ConfigurationManager.AppSettings["browser"]); //Rodar local
            //driver = Utils.getBrowserRemote(driver); //Rodar remote com GRID (Firefox)
            //driver = Utils.getBrowserMobile(driver); //Rodar mobile

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CT02LoginInvalido()
        {
            LoginPage lg = new LoginPage(driver);

            lg.insertUsername("testeteste");
            lg.insertPassword("teste123");
            lg.clickButtonLogin();
            lg.validationLoginInvalid();

        }



    }
}
