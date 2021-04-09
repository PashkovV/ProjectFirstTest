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

namespace ProjectFirst
{
    class BaseSteps : MainPage
    {
        public BaseSteps(IWebDriver driver) : base(driver)
        {
        }
        public void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.bing.com/");
            Driver.Manage().Window.Size = new Size(1920, 1080);
            Thread.Sleep(3000);
        }
    }
}
