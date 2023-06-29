using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectUsingBDD.Pages
{
    [Binding]
    class GoogleHomePage
    {
        private IWebDriver driver;

        public GoogleHomePage(IWebDriver _driver)
        {
            driver = _driver;
        }
        [OneTimeSetUp]
        public void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        //public IWebElement SearchBox => driver.FindElement(By.CssSelector("input[title*=\"Search\"]"));
        public IWebElement SearchBox => driver.FindElement(By.Name("q"));
        //or the same below approach get property

        //public IWebElement SearchBox
        //{
        //    get
        //    {
        //        return driver.FindElement(By.CssSelector("input[value*='Buscar con Google']"));

        //    }
        //}

        //public IWebElement SearchButton => driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b"));
        // getting two elements
        //public IWebElement SearchButton => driver.FindElement(By.Name("btnK"));
        public IWebElement SearchButton => driver.FindElement(By.CssSelector("div[class='FPdoLc lJ9FBc'] input[name='btnK']"));
        
        private string url = "http://www.google.com";

        public void GoToPage()
        {
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            //Maximize current window
            driver.Manage().Window.Maximize();
        }

        public bool IsOnResultsPage(string keyWord)
        {
            return driver.Url.Contains(keyWord);
        }

        public void SearchFor(string search)
        {
            SearchBox.SendKeys(search);
            Thread.Sleep(100);
            SearchBox.SendKeys(Keys.Escape);
            Thread.Sleep(100);
        }

        public void EnterLoginButton()
        {
            SearchButton.Click();
            //SearchBox.SendKeys(Keys.Enter);
        }

        public bool isSearchBoxDisplayed()
        {
            return SearchBox.Displayed;
        }

        public bool isSearchBoxEnabled()
        {
            return SearchBox.Enabled;
        }
    }
}
