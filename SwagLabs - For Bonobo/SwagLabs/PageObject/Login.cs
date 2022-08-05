using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SwagLabs.PageObject
{
    internal class Login
    {
        //Mapeamento de elementos, so escoler o que usar

        [FindsBy(How = How.Name, Using= "user-name")]
        public IWebElement inputUsername { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement inputPassword { get; set; }

        [FindsBy(How = How.Name, Using = "login-button")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(@data-test, 'error')]")]
        public IWebElement errorsLogin { get; set; }
    }
}
