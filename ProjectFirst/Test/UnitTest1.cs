using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectFirst.Pages;
using ProjectFirst.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectFirst.Test
{
    [TestClass]
    public class UnitTest1

    {
        IWebDriver driver = new ChromeDriver();
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
            var SearchValue = "star wars episode vi";
            mainpagesteps.SearchFormTest(SearchValue);
            mainpagesteps.GoTo();
            mainpagesteps.LanguageLocalization();
            driver.Close();

        }
        [TestMethod]
        public void TCID2()
        {
            MainPageSteps mainpagesteps = new MainPageSteps(driver);
            mainpagesteps.GoTo();
            var SearchValue = "star wars episode vi";
            mainpagesteps.SearchFormTest(SearchValue);
            driver.Close();
        }
        
    }

}
