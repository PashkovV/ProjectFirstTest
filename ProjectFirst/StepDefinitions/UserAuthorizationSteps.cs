using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectFirst.Steps;
using ProjectFirst.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectFirst.StepDefinitions
{
    [Binding]
    public class UserAuthorizationSteps
    {
        IWebDriver driver = new ChromeDriver();
        public IWebDriver Driver { get; private set; }
        
        [Given(@"The User on the authorize page ""(.*)""")]
        public void GivenTheUserOnTheAuthorizePage(string p0)
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.GoTo();
        }
        
        [Given(@"The User enter correct login")]
        public void GivenTheUserEnterCorrectLogin()
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            var EmailValue = "";
            mainpagesteps.AuthorizationEmailEnter(EmailValue);
        }
        
        [Given(@"The User enter correct password")]
        public void GivenTheUserEnterCorrectPassword()
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            var PasswordValue = "";
            mainpagesteps.AuthorizationPasswordEnter(PasswordValue);
        }
        
        [When(@"The User press the '(.*)' button")]
        public void WhenTheUserPressTheButton(string p0)
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.AuthorizationSignInButton();
        }
        
        [Then(@"The home page opens ""(.*)""")]
        public void ThenTheHomePageOpens(string p0)
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.BingLogoDisplayed();
        }
    }
}
