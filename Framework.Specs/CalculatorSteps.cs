using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Framework.Specs
{
    [Binding]
    public class CalculatorSteps : Steps
    {
        IBaseContext _context;

        public CalculatorSteps(IBaseContext context)
        {
            _context = context;
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int first)
        {
            _context.FirstNumber = first;
        }

        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int last)
        {
            _context.LastNumber = last;
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.Equal(p0, _context.FirstNumber + _context.LastNumber);
        }

        [Given(@"I have added two numbers")]
        public void GivenIHaveAddedTwoNumbers()
        {
            Given(@"I have entered 50 into the calculator");
            And(@"I have also entered 70 into the calculator");
            When(@"I press add");
        }

    }
}
