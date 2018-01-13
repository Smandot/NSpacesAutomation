using AnySpacesTests.PageObjectElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjects
{
    class SignUpWithEmailPage
    {
         readonly IWebDriver driver;
        SignUpWithEmailPageElements signUpWithEmailPageElement;
        public SignUpWithEmailPage(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //Enter the data in the sign up form
        public void FillSignUpForm()
        {
            signUpWithEmailPageElement = new SignUpWithEmailPageElements(this.driver);
            signUpWithEmailPageElement.FirstNameTextbox.SendKeys("Shobha");
            signUpWithEmailPageElement.LastNameTextbox.SendKeys("Seth");
            signUpWithEmailPageElement.EmailAddressTextbox.SendKeys("Shobha.Seth24@gmail.com");
            signUpWithEmailPageElement.PasswordTextbox.SendKeys("Welcome@123");

            //SelectElement oSelect = new SelectElement(signUpWithEmailPageElement.CountryCodeDropdown);
            //oSelect.SelectByText("+91");

            signUpWithEmailPageElement.PhoneNumberTextbox.SendKeys("77655");

            signUpWithEmailPageElement.SignUpButton.Click();

        }
    }
}
