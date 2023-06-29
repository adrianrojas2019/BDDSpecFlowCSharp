//using AventStack.ExtentReports.Gherkin.Model;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using TechTalk.SpecFlow;
//using TechTalk.SpecFlow.BindingSkeletons;
//using SpecFlowProjectUsingBDD.Pages;

//namespace SpecFlowProjectUsingBDD.StepDefinitions
//{
//    [Binding]
//    public class SearchInGoogleHomePagePOM
//    {
//        //IWebDriver? driver;

//        private GoogleHomePage googlePage;

//        public SearchInGoogleHomePagePOM(IWebDriver driver)
//        {
//            googlePage = new GoogleHomePage(driver);
//        }

//        [Given(@"Google Page Open")]
//        public void GivenGooglePageOpen()
//        {
//            //driver = new ChromeDriver();
//            //driver.Manage().Window.Maximize();
//            //driver.Navigate().GoToUrl("http://www.google.com");
//            googlePage.GoToPage();
//        }

//        [Given(@"Search Text Box should be present and Enabled in the Google Home Page")]
//        public void GivenSearchTextBoxShouldBePresentAndEnabledInTheGoogleHomePage()
//        {
//            //Console.WriteLine(driver.Title);
//            //Assert.That(driver.FindElement(By.Name("q")).Displayed, Is.True);
//            //Assert.That(driver.FindElement(By.Name("q")).Enabled, Is.True);
//            Assert.That(googlePage.isSearchBoxDisplayed(), Is.True);
//            Assert.That(googlePage.isSearchBoxEnabled(), Is.True);
//        }

//        [When(@"User searches a Course with a keyword (.*) Tutorial")]
//        public void WhenUserSearchesACourseWithAKeywordJavaTutorial(string keyWord)
//        {
//            // create into new page object
//            //public IWebElement SearchBox => driver.FindElement(By.Name("q"));
//            //var searchBox = driver.FindElement(By.Name("q"));
//            //searchBox.SendKeys(keyWord);
//            //Thread.Sleep(100);
//            //searchBox.SendKeys(Keys.Escape);
//            //Thread.Sleep(100);
//            googlePage.SearchFor(keyWord);
//        }

//        [When(@"Hit enters button")]
//        public void WhenHitEntersButton()
//        {
//            //var searchBox = driver.FindElement(By.Name("q"));
//            ////searchBox.Click();
//            ////another workaround
//            //searchBox.SendKeys(Keys.Enter);
//            googlePage.EnterLoginButton();
//        }

//        [Then(@"All Courses related to (.*) Tutorial should be displayed")]
//        public void ThenAllCoursesRelatedToJavaTutorialShouldBeDisplayed(string keyWord)
//        {
//            ////Validate keyword has been displayed
//            //Assert.IsTrue(driver.Url.Contains(keyWord));
//            //driver.Quit();
//            googlePage.IsOnResultsPage(keyWord);
//        }
//    }
//}
