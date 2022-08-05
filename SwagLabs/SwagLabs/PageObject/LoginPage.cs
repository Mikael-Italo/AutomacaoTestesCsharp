using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace SwagLabs.PageObject
{
    internal class LoginPage
    {
#region drivers
        private RemoteWebDriver _driver;

        public LoginPage (RemoteWebDriver driver) => _driver = driver;
        #endregion
#region Mapping
        IWebElement inputUsername => _driver.FindElementByName("user-name");
        IWebElement inputPassword => _driver.FindElementByName("password");
        IWebElement btnLogin => _driver.FindElementByName("login-button");
        IWebElement errorsLogin => _driver.FindElementByXPath("//h3[contains(@data-test, 'error')]");
#endregion

#region Action
        public void insertUsername()
        {
            inputUsername.SendKeys(ConfigurationManager.AppSettings["email_standard"]);
        }
        public void clickButtonLogin()
        {
            btnLogin.Click();
        }
#endregion

#region Validation
        public void ValidationPasswordRequired()
        {
            Assert.That(errorsLogin.Text, Is.EqualTo("Epic sadface: Password is required"));
        }
#endregion

    }
}
