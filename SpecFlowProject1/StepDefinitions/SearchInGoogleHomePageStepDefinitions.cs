using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.BindingSkeletons;

namespace SpecFlowProjectUsingBDD.StepDefinitions
{
    [Binding]
    public class SearchInGoogleHomePageStepDefinitions
    {
        IWebDriver? driver;
        [Given(@"Google Page Open")]
        public void GivenGooglePageOpen()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Given(@"Search Text Box should be present and Enabled in the Google Home Page")]
        public void GivenSearchTextBoxShouldBePresentAndEnabledInTheGoogleHomePage()
        {
            Console.WriteLine(driver.Title);
            Assert.That(driver.FindElement(By.Name("q")).Displayed, Is.True);
            Assert.That(driver.FindElement(By.Name("q")).Enabled, Is.True);
        }

        [When(@"User searches a Course with a keyword (.*) Tutorial")]
        public void WhenUserSearchesACourseWithAKeywordJavaTutorial(string keyWord)
        {
            // create into new page object
            //public IWebElement SearchBox => driver.FindElement(By.Name("q"));
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys(keyWord);
            Thread.Sleep(100);
            searchBox.SendKeys(Keys.Escape);
            Thread.Sleep(100);
        }

        [When(@"Hit enters button")]
        public void WhenHitEntersButton()
        {
            var searchBox = driver.FindElement(By.Name("q"));
            //searchBox.Click();
            //another workaround
            searchBox.SendKeys(Keys.Enter);
        }

        [Then(@"All Courses related to (.*) Tutorial should be displayed")]
        public void ThenAllCoursesRelatedToJavaTutorialShouldBeDisplayed(string keyWord)
        {
            //Validate keyword has been displayed
            Assert.IsTrue(driver.Url.Contains(keyWord));
            driver.Quit();
        }
    }
}
