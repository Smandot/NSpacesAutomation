using AnySpacesTests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AnySpacesTests.UITests
{
    [TestClass]
    public class SignUpTests
    {
        IWebDriver driver;
        HomePage homePage;

        [TestInitialize]
        public void InitializeTest()
        {
            driver = new ChromeDriver();
        }
        
        [TestMethod]
        public void SignUpWithEmailTest()
        {
            //  Launching home page
            homePage = new HomePage(this.driver);
            homePage.Navigate();
            homePage.ClickOnSignUpLink();

           /* WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromMinutes(1));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                Console.WriteLine(Web.FindElement(By.XPath("//*[@id=\"signup-modal\"]/div/div/div[2]/div/a")));
                return true;
            });
            wait.Until(waitForElement);
            */
            Thread.Sleep(10000);
            SignUpLandingPage signUpLandingPage = new SignUpLandingPage(this.driver);
            signUpLandingPage.ClickOnSignUpWithEmailButton();

            Thread.Sleep(10000);
            SignUpWithEmailPage signUpWithEmailPage = new SignUpWithEmailPage(this.driver);
            signUpWithEmailPage.FillSignUpForm();

            
        }
    }
}
