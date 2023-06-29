using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.BindingSkeletons;

namespace SpecFlowProjectUsingBDD
{
    [Binding]
    public class SearchInGoogleHomePage : SeleniumTestBase
    {
        //IWebDriver? driver;
        GooglePage? googlePage;
        [OneTimeSetUp]
        public void SetupOnce()
        {
            googlePage = new GooglePage(driver);
        }

        [Given(@"Google Page Open")]
        public void GivenGooglePageOpen()
        {
            //googlePage = new GooglePage(driver);
            googlePage.GoToPage();
        }

        [Given(@"Search Text Box should be present and Enabled in the Google Home Page")]
        public void GivenSearchTextBoxShouldBePresentAndEnabledInTheGoogleHomePage()
        {
            //Console.WriteLine(driver.Title);
            //Assert.That(driver.FindElement(By.Name("q")).Displayed, Is.True);
            //Assert.That(driver.FindElement(By.Name("q")).Enabled, Is.True);
            Assert.That(googlePage.isSearchBoxDisplayed(), Is.True);
            Assert.That(googlePage.isSearchBoxEnabled(), Is.True);
        }

        [When(@"User searches a Course with a keyword (.*) Tutorial")]
        public void WhenUserSearchesACourseWithAKeywordJavaTutorial(string keyWord)
        {
            googlePage.SearchFor(keyWord);
        }

        [When(@"Hit enters button")]
        public void WhenHitEntersButton()
        {
            //var searchBox = driver.FindElement(By.Name("q"));
            ////searchBox.Click();
            ////another workaround
            //searchBox.SendKeys(Keys.Enter);
            googlePage.EnterLoginButton();
        }

        [Then(@"All Courses related to (.*) Tutorial should be displayed")]
        public void ThenAllCoursesRelatedToJavaTutorialShouldBeDisplayed(string keyWord)
        {
            //Validate keyword has been displayed
            //Assert.IsTrue(driver.Url.Contains(keyWord));
            googlePage.IsOnResultsPage(keyWord);
            driver.Quit();
        }
    }
}
