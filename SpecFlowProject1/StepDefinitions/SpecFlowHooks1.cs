using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUsingBDD.StepDefinitions
{
    [Binding]
    public sealed class SpecFlowHooks1
    {
        private static ExtentReports? extent;
        private static ExtentTest? featureName;
        private static ExtentTest? scenarioName;


        private readonly IObjectContainer objectContainer;
        private ChromeDriver webdriver;

        public SpecFlowHooks1(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\Adrian Rojas\\Desktop\\Adrian\\Projects\\C#\\BDD\\SpecFlowProject1\\Reports\\index.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            Console.WriteLine("In Method Before Test Run");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
            Console.WriteLine("In Method After Test Run");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("In Method Before Feature");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("In Method After Feature");
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            this.webdriver = new ChromeDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(webdriver);
        }
        public static void BeforeScenario()
        {
            scenarioName = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("In Method Before Scenario");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("In Method After Scenario");
        }

        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("In Method Before Step");
        }

        [AfterStep]
        public static void AfterStep()
        {
            //var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //if (ScenarioContext.Current.TestError == null)
            //{
            //    if (stepType == "Given")
            //        scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            //    else if (stepType == "When")
            //        scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
            //    else if (stepType == "Then")
            //        scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            //    else if (stepType == "And")
            //        scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            //}
            //else if (ScenarioContext.Current.TestError != null)
            //{
            //    if (stepType == "Given")
            //        scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            //    if (stepType == "When")
            //        scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            //    if (stepType == "Then")
            //        scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            //    if (stepType == "And")
            //        scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);

            //}
            Console.WriteLine("In Method After Step");
        }

        [BeforeScenarioBlock]
        public static void BeforeScenarioBlock()
        {
            Console.WriteLine("In Method Before Scenario Block");
        }

        [AfterScenarioBlock]
        public static void AfterScenarioBlock()
        {
            Console.WriteLine("In Method After Scenario Block");
        }
    }
}