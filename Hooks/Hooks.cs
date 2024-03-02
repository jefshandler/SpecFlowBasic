using TechTalk.SpecFlow;

namespace SpecFlowBasic.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun]
        public static void BeforeTest() => Console.WriteLine("This line is executed from before Test");
        


        [BeforeScenario("mytag")]
        public void BeforeScenarioWithTag() => Console.WriteLine("This line is executed from before Test");
        

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario() => Console.WriteLine("This line is executed from before Test");
        

        [AfterScenario]
        public void AfterScenario() => Console.WriteLine("This line is executed from after Test");

    }
}