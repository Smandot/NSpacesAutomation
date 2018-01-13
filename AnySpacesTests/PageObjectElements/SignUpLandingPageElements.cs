using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjectElements
{
    class SignUpLandingPageElements
    {
        IWebDriver driver;
        public SignUpLandingPageElements(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //Control element for Sign Up with Facebook
        public IWebElement SignUpWithFacebookButton
        {
            get 
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"signup-modal\"]/div/div/div[2]/div/button"));
            }

        }

        //Control element for Sign Up with Email
        public IWebElement SignUpWithEmailButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"signup-modal\"]/div/div/div[2]/div/a"));
            }

        }
        
        //Control element for close button
        public IWebElement CloseButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"signup-modal\"]/div/div/div[1]/button"));
            }

        }
    }
}
