using AnySpacesTests.PageObjectElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjects
{
    class SignUpLandingPage
    {
        readonly IWebDriver driver;
        SignUpLandingPageElements signUpLandingPageElement;
        public SignUpLandingPage(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //Click on Create Account button on sign up landing page
        public void ClickOnSignUpWithEmailButton()
        {
            signUpLandingPageElement = new SignUpLandingPageElements(this.driver);
            signUpLandingPageElement.SignUpWithEmailButton.Click();

        }

        //Click on Sign up with Facebook button on sign up landing page
        public void ClickOnSignUpWithFacebookButton()
        {
            signUpLandingPageElement = new SignUpLandingPageElements(this.driver);
            signUpLandingPageElement.SignUpWithFacebookButton.Click();

        }


    }
}
