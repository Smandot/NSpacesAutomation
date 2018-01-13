using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using AnySpacesTests.PageObjects;

namespace AnySpacesTests.UITests
{
    [TestClass]
    public class LaunchSignUpLandingPageTests
    {
       //Global variable
         IWebDriver driver;

        [TestInitialize]
        public void InitializeTest()
        {
            driver = new ChromeDriver();
        }
        
        [TestMethod]
        public void LaunchSignUpLandingPageTest()
        {
            HomePage homePage = new HomePage(this.driver);
            homePage.Navigate();
            homePage.ClickOnSignUpLink();
        }
    }
}
