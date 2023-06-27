using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class FacebookHomePageLoginStepDefinitions
    {
        IWebDriver? driver;
        [Given(@"User Navigates to the Facebook Home Page")]
        public void GivenUserNavigatesToTheFacebookHomePage()
        {
            //Console.WriteLine("Given Sample");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.facebook.com");
        }

        [When(@"User enters (.*) as UserName and (.*) as Password")]
        public void WhenUserEntersTestAsUserNameAndPasdAsPassword(string p0, string p1)
        {
            //Console.WriteLine("When Sample");
            driver.FindElement(By.Name("email")).SendKeys(p0);
            driver.FindElement(By.Name("pass")).SendKeys(p1);
        }

        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            //Console.WriteLine("When/Amd Sample");
            driver.FindElement(By.Name("login")).Click();
        }

        [Then(@"Login should be unsuccessful")]
        public void ThenLoginShouldBeUnsuccessful()
        {
            Console.WriteLine(driver.Title);
            String expectedTitle = "Log into Facebook";
            Assert.AreEqual(expectedTitle, driver.Title);
            driver.Quit();
            //The email or mobile number you entered isn’t connected to an account. Find your account and log in.
        }
    }
}
