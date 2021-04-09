using System;
using TechTalk.SpecFlow;
using ProjectFirst.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectFirst.StepDefinitions
{
    [Binding]
    public class MicrosoftBingHomePageCheckSteps
    {
        IWebDriver driver = new ChromeDriver();
        public IWebDriver Driver { get; private set; }
        [When(@"The User on the home page of the site ""(.*)""")]
        public void WhenTheUserOnTheHomePageOfTheSite(string p0)
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.GoTo();
            mainpagesteps.BingLogoDisplayed();
        }
        
        [Then(@"The User should see title with label '(.*)'")]
        public void ThenTheUserShouldSeeTitleWithLabel(string p0)
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.BingLogoDisplayed();
        }
    }
}
