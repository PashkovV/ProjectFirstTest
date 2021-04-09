using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectFirst.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ProjectFirst.Steps;

namespace ProjectFirst.Test
{
    [TestClass]
    public class UnitTest2
    {
        IWebDriver driver = new FirefoxDriver();
        public IWebDriver Driver { get; private set; }
        [TestMethod]
        public void TCID1()
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.GoTo();
            mainpagesteps.BingLogoDisplayed();
            mainpagesteps.Images();
            mainpagesteps.Videos();
            mainpagesteps.DotsTest();
            mainpagesteps.UserProfileTest();
            mainpagesteps.SearchFormVisibilityTest();
            mainpagesteps.InfoSectionTest();
            //var SearchValue = "star wars episode vi";
            //mainpagesteps.SearchFormTest(SearchValue);
            mainpagesteps.GoTo();
            //mainpagesteps.LanguageLocalization();
            driver.Close();
        }
    }
}
