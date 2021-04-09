using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProjectFirst
{
    public class WebDriverManager
    {
        public IWebDriver Driver { get; set; }
        public Actions ActionItem { get; set; }
        public WebDriverWait Wait { get; set; }

        public WebDriverManager(IWebDriver driver)
        {
            Driver = driver;
            ActionItem = new Actions(Driver);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
    }
}
