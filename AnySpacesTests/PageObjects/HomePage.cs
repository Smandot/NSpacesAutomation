using AnySpacesTests.PageObjectElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjects
{
    class HomePage
    {
        readonly IWebDriver driver;
        HomePageElements homePageElement;

        public HomePage(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //To navigate to the website URL
        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://webqa.tcspaces.in/");

        }

        //Click on Sign up link on home page
        public void ClickOnSignUpLink()
        {
            homePageElement = new HomePageElements(this.driver);
            homePageElement.SignUpLink.Click();

            


        }

    }
}
