namespace SpecFlowDemo.StepDefinitions
{
	[Binding]
	public sealed class ScientificCalculatorStepDefinitions
	{
		public ScenarioContext _scenarioContext;

		public ScientificCalculatorStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given("the first number in scientific calculator is (.*)")]
		public void GivenTheFirstNumberIs(int number)
		{
			_scenarioContext["firstNumber"] = number;
		}

		[Given("the second number in scientific calculator is (.*)")]
		public void GivenTheSecondNumberIs(int number)
		{
			_scenarioContext["secondNumber"] = number;
		}

		[When("the two numbers are added in scientific calculator")]
		public void WhenTheTwoNumbersAreAdded()
		{
			_scenarioContext["result"] = _scenarioContext.Get<int>("firstNumber") + _scenarioContext.Get<int>("secondNumber");
		}

		[Then("the result in scientific calculator should be (.*)")]
		public void ThenTheResultShouldBe(int expectedResult)
		{
			_scenarioContext.Get<int>("result").Should().Be(expectedResult);
		}
	}
}