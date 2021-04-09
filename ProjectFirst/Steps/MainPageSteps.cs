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
using ProjectFirst.Pages;
namespace ProjectFirst.Steps
{
    class MainPageSteps : BaseSteps
    {
        public MainPageSteps(IWebDriver driver) : base(driver)
        {
        }
        public void BingLogoDisplayed()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(BingLogoLocator));
            Assert.IsTrue(BingLogo.Displayed);
        }
        public void Images()
        {
            Assert.AreEqual("Изображения", ImagesButton.Text);
        }
        public void Videos()
        {
            Assert.AreEqual("Видео", VideosButton.Text);
        }
        public void DotsTest()
        {
            Assert.IsTrue(Dots.Displayed);
            //ActionItem.MoveToElement(Dots);
            //ActionItem.Click(DotsMaps);
            //GoTo();
        }
        public void UserProfileTest()
        {
            Assert.AreEqual("Войти", UserProfileSignIn.Text);
            Assert.IsTrue(UserProfilePicture.Displayed);
            Assert.IsTrue(UserAccountDropdown.Displayed);
        }
        public void SearchFormVisibilityTest()
        {
            Assert.IsTrue(SearchForm.Displayed);
            Assert.IsTrue(SearchFormString.Displayed);
            Assert.IsTrue(SearchFormVoice.Displayed);
            Assert.IsTrue(SearchFormImage.Displayed);
            Assert.IsTrue(SearchFormWeb.Displayed);
        }
        public void SearchFormTest(string SearchValue)
        {
            SearchFormString.SendKeys(SearchValue);
            Thread.Sleep(2000);
            Assert.AreEqual(8, NumberOfElementsSearchDropdown.Count);
            SearchFormWeb.Click();
            Thread.Sleep(2000);
            Assert.AreEqual(9, 10, NumberOfElements.Count);
        }
        public void PrivacyAndCookie()
        {
            Driver.FindElement(By.XPath("//*[@id='privacy']")).Click();
            Assert.AreEqual("Заявление о конфиденциальности корпорации Майкрософт", Driver.FindElement(By.XPath("//*[@class='page-header']/div/div/div/div/div/h1")).Text);
        }
        public void InfoSectionTest()
        {
            Assert.AreEqual("© Brad McGinley Photography/Getty Images", InfoText.Text);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Black grouse male, Kuusamo, Finland", InfoText.Text);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Étretat, Normandy, France", InfoText.Text);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Parthenon temple, Acropolis of Athens, Greece", InfoText.Text);
            Thread.Sleep(1000);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Saut de Brot stone bridge, Areuse Gorge, Switzerland", InfoText.Text);
            Thread.Sleep(1000);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Ostereierbaum (Easter egg tree) in Saalfeld, Germany", InfoText.Text);
            Thread.Sleep(1000);
            LeftNavigation.Click();
            ActionItem.MoveToElement(InfoIcon).Perform();
            Thread.Sleep(1000);
            Assert.AreEqual("Lighthouse at Cape Aniva, Sakhalin, Russia", InfoText.Text);
        }
        public void LanguageLocalization()
        {
            UserAccountDropdown.Click();
            Thread.Sleep(1000);
            UserAccountDropdownSettings.Click();
            Thread.Sleep(1000);
            UserAccountDropdownSettingsLanguage.Click();
            Thread.Sleep(2000);
            LanguageEnglish.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Images", ImagesButton.Text);
            Assert.AreEqual("Videos", VideosButton.Text);
            ActionItem.MoveToElement(Dots);
            Thread.Sleep(1000);
            Assert.AreEqual("Maps", DotsMaps.Text);
            Assert.AreEqual("News", DotsNews.Text);
            Assert.AreEqual("Sign in", UserProfileSignIn.Text);
            UserAccountDropdown.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Settings", Driver.FindElement(By.XPath("//*[@id='hbsettings']/div/div[2]")).Text);
            Assert.AreEqual("SafeSearch", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[1]/div/div[2]")).Text);
            Assert.AreEqual("Search history", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[2]/div/div[2]")).Text);
            Assert.AreEqual("Privacy", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[3]/div/div[2]")).Text);
            Assert.AreEqual("Feedback", Driver.FindElement(By.XPath("//*[@id='hb_feedback']/div/div[2]")).Text);
            Assert.AreEqual("Customize your homepage", Driver.FindElement(By.XPath("//*[@id='qs_hp_expando']/div/div[2]")).Text);
            Assert.AreEqual("Show menu bar", Driver.FindElement(By.XPath("//*[@id='qs_menu_ctrl']/div/div[2]")).Text);
            Assert.AreEqual("Show homepage image", Driver.FindElement(By.XPath("//*[@id='qs_iotd_ctrl']/div/div[2]")).Text);
            UserAccountDropdownSettings.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Language\r\nEnglish", UserAccountDropdownSettingsLanguage.Text);
            Assert.AreEqual("Country/Region\r\nUkraine (Украина)", UserAccountDropdownSettingsCountry.Text);
            Assert.AreEqual("Location", UserAccountDropdownSettingsLocation.Text);
            Assert.AreEqual("Voice search", UserAccountDropdownSettingsVoiceSearch.Text);
            Assert.AreEqual("More", UserAccountDropdownSettingsMore.Text);
            UserAccountDropdownSettingsLanguage.Click();
            Thread.Sleep(2000);
            LanguageUkrainian.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Зображення", ImagesButton.Text);
            Assert.AreEqual("Відео", VideosButton.Text);
            ActionItem.MoveToElement(Dots);
            Thread.Sleep(1000);
            Assert.AreEqual("Карти", DotsMaps.Text);
            Assert.AreEqual("Новини", DotsNews.Text);
            Assert.AreEqual("Вхід", UserProfileSignIn.Text);
            UserAccountDropdown.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Параметри", Driver.FindElement(By.XPath("//*[@id='hbsettings']/div/div[2]")).Text);
            Assert.AreEqual("Безпечний пошук", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[1]/div/div[2]")).Text);
            Assert.AreEqual("Історія пошуків", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[2]/div/div[2]")).Text);
            Assert.AreEqual("Конфіденційність", Driver.FindElement(By.XPath("//*[@id='HBContent']/a[3]/div/div[2]")).Text);
            Assert.AreEqual("Відгук", Driver.FindElement(By.XPath("//*[@id='hb_feedback']/div/div[2]")).Text);
            Assert.AreEqual("Настройки головної сторінки", Driver.FindElement(By.XPath("//*[@id='qs_hp_expando']/div/div[2]")).Text);
            Assert.AreEqual("Показати рядок меню", Driver.FindElement(By.XPath("//*[@id='qs_menu_ctrl']/div/div[2]")).Text);
            Assert.AreEqual("Показати зображення головної сторінки", Driver.FindElement(By.XPath("//*[@id='qs_iotd_ctrl']/div/div[2]")).Text);
            UserAccountDropdownSettings.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Мова\r\nукраїнська", UserAccountDropdownSettingsLanguage.Text);
            Assert.AreEqual("Країна або регіон\r\nУкраїна (Украина)", UserAccountDropdownSettingsCountry.Text);
            Assert.AreEqual("Розташування", UserAccountDropdownSettingsLocation.Text);
            Assert.AreEqual("Голосовий пошук", UserAccountDropdownSettingsVoiceSearch.Text);
            Assert.AreEqual("Інші", UserAccountDropdownSettingsMore.Text);
        }
        public void AuthorizationEmailEnter(string EmailValue)
        {
            UserProfileSignIn.Click();
            Thread.Sleep(2000);
            SignInEmail.SendKeys(EmailValue);
            SignInNextButton.Click();
            Thread.Sleep(2000);
        }
        public void AuthorizationPasswordEnter(string PasswordValue) 
        {
            SignInPassword.SendKeys(PasswordValue);
        }
        public void AuthorizationSignInButton() 
        {
            SignInSignInButton.Click();
            Thread.Sleep(2000);
        }
    }
}
