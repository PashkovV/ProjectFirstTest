using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectFirst.Pages;


namespace ProjectFirst.Test
{
    [TestClass]
    public class BaseTest : MainPage
    
    {
        public BaseTest(IWebDriver driver) : base(driver) 
        { 
        }
    }
}
