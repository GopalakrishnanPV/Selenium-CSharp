namespace SpecFlowDemo.StepDefinitions
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		//int firstNumber, secondNumber, actualResult;

		public ScenarioContext _scenarioContext;

		public CalculatorStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given("the first number is (.*)")]
		public void GivenTheFirstNumberIs(int number)
		{
			//firstNumber = number;
		}

		[Given("the second number is (.*)")]
		public void GivenTheSecondNumberIs(int number)
		{
			//secondNumber = number;
		}

		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			//actualResult = firstNumber + secondNumber;
		}

		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(int expectedResult)
		{
			//actualResult.Should().Be(expectedResult);
			_scenarioContext.Get<int>("result").Should().Be(expectedResult);
		}
	}
}