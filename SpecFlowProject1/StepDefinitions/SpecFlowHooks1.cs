using TechTalk.SpecFlow;

namespace SpecFlowProjectUsingBDD.StepDefinitions
{
    [Binding]
    public sealed class SpecFlowHooks1
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("In Method Before Test Run");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("In Method After Test Run");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("In Method Before Feature");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("In Method After Feature");
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
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