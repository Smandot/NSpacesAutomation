using AnySpacesTests.PageObjectElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySpacesTests.PageObjectValidator
{
    class HomePageValidator
    {
        readonly IWebDriver driver;
        public HomePageValidator(IWebDriver iDriver)
        {
            this.driver = iDriver;
        }

        public HomePageElements HomePage
        {
            get
            {
                return new HomePageElements(this.driver);
            }
        }
        
    }
}
