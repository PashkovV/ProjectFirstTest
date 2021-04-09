using System;
using TechTalk.SpecFlow;

namespace ProjectFirst.StepDefinitions
{
    [Binding]
    public class LanguageChangeSteps
    {
        [Given(@"The User on the language change page ""(.*)""")]
        public void GivenTheUserOnTheLanguageChangePage(string p0)
        {
        }
        
        [When(@"The User press language (.*)")]
        public void WhenTheUserPressLanguage(string p0)
        {
        }
        
        [Then(@"The User redirected to the home page ""(.*)""")]
        public void ThenTheUserRedirectedToTheHomePage(string p0)
        {
        }
        
        [Then(@"The User see the button with label (.*)")]
        public void ThenTheUserSeeTheButtonWithLabel(string p0, Table table)
        {
        }
    }
}
