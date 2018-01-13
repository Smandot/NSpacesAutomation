using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjectElements
{
    class SignUpWithEmailPageElements
    {
          IWebDriver driver;
          public SignUpWithEmailPageElements(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //Control element for First Name textbox
        public IWebElement FirstNameTextbox
        {
            get 
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[1]/div/input"));
            }

        }

        //Control element for Last Name textbox
        public IWebElement LastNameTextbox
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[2]/div/input"));
            }

        }

        //Control element for Email address field
        public IWebElement EmailAddressTextbox
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[3]/div/input"));
            }

        }

        //Control element for Password field
        public IWebElement PasswordTextbox
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[4]/div/input"));
            }

        }

        //Control element for Show / hide button
        public IWebElement ShowHideButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[5]/a"));
            }

        }

        //Control element for Country code dropdown
        public IWebElement CountryCodeDropdown
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"countryDDBtn\"]"));
            }

        }

        //Control element for Phone number field
        public IWebElement PhoneNumberTextbox
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[6]/div/div/input"));
            }

        }

        //Control element for Promotions  toggle button
        public IWebElement PromotionToggleButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/div[7]/app-toggle-button/div/label"));
            }

        }

        //Control element for Sign up button
        public IWebElement SignUpButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[2]/form/button"));
            }

        }

        //Control element for Log in on Sign up with email form
        public IWebElement LoginButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"email-signup-modal\"]/div/div/div[3]/a"));
            }

        }
    }
}
