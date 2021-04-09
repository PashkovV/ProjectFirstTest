using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using System.Drawing;

namespace ProjectFirst.Pages
{
    public class MainPage : WebDriverManager
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement BingLogo => Driver.FindElement(BingLogoLocator);
        public By BingLogoLocator => By.Id("bLogo");
        public IWebElement ImagesButton => Driver.FindElement(By.Id("images"));
        public IWebElement VideosButton => Driver.FindElement(By.Id("video"));
        public IWebElement Dots => Driver.FindElement(By.Id("dots_overflow_menu_container"));
        public IWebElement DotsMaps => Driver.FindElement(By.Id("local"));
        public IWebElement DotsNews => Driver.FindElement(By.Id("news"));
        public IWebElement DotsMSN => Driver.FindElement(By.Id("msn"));
        public IWebElement DotsOffice => Driver.FindElement(By.Id("office"));
        public IWebElement DotsOfficeOutlook => Driver.FindElement(By.Id("outlook"));
        public IWebElement DotsOfficeWord => Driver.FindElement(By.Id("word"));
        public IWebElement DotsOfficeExcel => Driver.FindElement(By.Id("excel"));
        public IWebElement DotsOfficepowerpoint => Driver.FindElement(By.Id("powerpoint"));
        public IWebElement DotsOfficeOnenote => Driver.FindElement(By.Id("onenote"));
        public IWebElement DotsOfficeoSway => Driver.FindElement(By.Id("sway"));
        public IWebElement DotsOfficeoutOnedrive => Driver.FindElement(By.Id("onedrive"));
        public IWebElement DotsOfficeCalendar => Driver.FindElement(By.Id("calendar"));
        public IWebElement DotsOfficePeople => Driver.FindElement(By.Id("people"));
        public IWebElement UserProfileSignIn => Driver.FindElement(By.Id("id_s"));
        public IWebElement SignInEmail => Driver.FindElement(By.Id("i0116"));
        public IWebElement SignInNextButton => Driver.FindElement(By.Id("idSIButton9"));
        public IWebElement SignInPassword => Driver.FindElement(By.Id("i0118"));
        public IWebElement SignInSignInButton => Driver.FindElement(By.Id("idSIButton9"));
        public IWebElement UserProfileName => Driver.FindElement(By.Id("id_n"));
        public IWebElement UserProfilePicture => Driver.FindElement(By.Id("id_a"));
        public IWebElement UserProfileSignedInPicture => Driver.FindElement(By.Id("id_p"));
        public IWebElement UserAccount => Driver.FindElement(By.Id("id_d"));
        public IWebElement UserAccountDropdown => Driver.FindElement(By.Id("id_sc"));
        public IWebElement UserAccountDropdownSettings => Driver.FindElement(By.XPath("//*[@id='hbsettings']"));
        public IWebElement UserAccountDropdownSettingsLanguage => Driver.FindElement(By.XPath("//*[@id='hbsettree']/a[1]"));
        public IWebElement UserAccountDropdownSettingsCountry => Driver.FindElement(By.XPath("//*[@id='hbsettree']/a[2]"));
        public IWebElement UserAccountDropdownSettingsLocation => Driver.FindElement(By.XPath("//*[@id='hbsettree']/a[3]"));
        public IWebElement UserAccountDropdownSettingsVoiceSearch => Driver.FindElement(By.XPath("//*[@id='hbsettree']/a[4]"));
        public IWebElement UserAccountDropdownSettingsMore => Driver.FindElement(By.XPath("//*[@id='hbsettree']/a[5]"));
        public IWebElement UserAccountDropdownSafeSearch => Driver.FindElement(By.XPath("//*[@id='HBContent']/a[1]"));
        public IWebElement UserAccountDropdownSearchHistory => Driver.FindElement(By.XPath("//*[@id='HBContent']/a[2]"));
        public IWebElement UserAccountDropdownPrivacy => Driver.FindElement(By.XPath("//*[@id='HBContent']/a[3]"));
        public IWebElement UserAccountDropdownFeedback => Driver.FindElement(By.XPath("//*[@id='HBContent']/a[4]"));
        public IWebElement UserAccountDropdownCustomizeHomepage => Driver.FindElement(By.Id("qs_hp_expando"));
        public IWebElement UserAccountDropdownCustomizeHomepageShowMenuBar => Driver.FindElement(By.Id("qs_menu_ctrl"));
        public IWebElement UserAccountDropdownCustomizeHomepageShowHomepageImage => Driver.FindElement(By.Id("qs_iotd_ctrl"));
        public IWebElement LanguageEnglish => Driver.FindElement(By.XPath("//*[@id='language-section-content']/div[1]/div/div[2]/div/div[3]/div/div[1]/ul/li[4]/a"));
        public IWebElement LanguageUkrainian => Driver.FindElement(By.XPath("//*[@id='language-section-content']/div[1]/div/div[2]/div/div[3]/div/div[3]/ul/li[27]/a"));
        public IWebElement SearchForm => Driver.FindElement(By.Id("sb_form"));
        public IWebElement SearchFormString => Driver.FindElement(By.Id("sb_form_q"));
        public IWebElement SearchFormVoice => Driver.FindElement(By.XPath("//*[@id='sb_form']/div[1]"));
        public IWebElement SearchFormImage => Driver.FindElement(By.XPath("//*[@id='sb_form']/div[2]"));
        public IWebElement SearchFormWeb => Driver.FindElement(By.XPath("//*[@id='sb_form']/label[1]"));
        public IWebElement SearchSuggestionsDropdown => Driver.FindElement(By.Id("sw_as"));
        public IWebElement CountList => Driver.FindElement(By.XPath("//*[@class='b_title']"));
        public IList<IWebElement> NumberOfElementsSearchDropdown => Driver.FindElements(By.XPath("//*[@class='sa_drw']//*[@class='sa_sg']"));
        public IList<IWebElement> NumberOfElements => Driver.FindElements(By.XPath("//*[@class='b_title']"));
        public IWebElement InfoIcon => Driver.FindElement(By.XPath("//*[@id='vs_cont']/div[1]/div/div[2]/div[1]"));
        public IWebElement LeftNavigation => Driver.FindElement(By.Id("leftNav"));
        public IWebElement RightNavigation => Driver.FindElement(By.Id("rightNav"));
        public IWebElement InfoText => Driver.FindElement(By.XPath("//*[@id='vs_cont']/div[1]/div/div[1]/a"));
        public IWebElement PrivacyAndCookie => Driver.FindElement(By.XPath("//*[@id='privacy']"));
        public IWebElement Legal => Driver.FindElement(By.XPath("//*[@id='legal']"));
        public IWebElement Advertise => Driver.FindElement(By.XPath("//*[@id='footer']/div/ul/li[3]/a"));
        public IWebElement AboutOurAds => Driver.FindElement(By.XPath("//*[@id='footer']/div/ul/li[4]/a"));
        public IWebElement Help => Driver.FindElement(By.XPath("//*[@id='help']"));
        public IWebElement Feedback => Driver.FindElement(By.XPath("//*[@id='sb_feedback']"));
        public IWebElement EuropeanDataProtection => Driver.FindElement(By.XPath("//*[@id='sb_dataeu']"));
    }
}
