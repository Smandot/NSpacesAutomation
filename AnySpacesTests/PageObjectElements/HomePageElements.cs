using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjectElements
{
    public class HomePageElements
    {
        readonly IWebDriver driver;
        public HomePageElements(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        //Control element for Sign Up link on home page
        public IWebElement SignUpLink
        {
            get 
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"navbar-content\"]/ul/li[1]/a"));
            }

        }

        //Control element for Login link on home page
        public IWebElement LoginLink
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id=\"navbar-content\"]/ul/li[2]/a"));
            }

        }
        
        
    }
}
