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
        IWebElement logoPageInitial => _driver.FindElementByCssSelector(".app_logo");
        #endregion


        #region Password is required
        //Action
        public void insertUsername(String username)
        {
            inputUsername.SendKeys(username);
        }
        public void clickButtonLogin()
        {
            btnLogin.Click();
        }
        
        // Validation
        public void validationPasswordRequired()
        {
            Assert.That(errorsLogin.Text, Is.EqualTo("Epic sadface: Password is required"));
        }
        #endregion

#region Login Invalid
        //Action
        public void insertPassword(String password)
        {
            inputPassword.SendKeys(password);
        }

        //Validation
        public void validationLoginInvalid()
        {
            Assert.That(errorsLogin.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }
#endregion
#region Login Sucess
        //Validation
        public void validationLoginSucess()
        {
            Assert.True(logoPageInitial.Enabled);
        }
#endregion
    }
}
