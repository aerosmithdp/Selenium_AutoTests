using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.PageObjects
{
    public class Combos
    {
        private IWebDriver _driver;

        public Combos(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
