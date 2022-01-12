using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;

        private By _navBarCards = By.Id("navbar-cards");
        private By _topCards = By.XPath("//span[contains(.,'Top Cards')]");
        private By _saltiestCards = By.XPath("//span[contains(.,'Saltiest Cards')]");
        private By _combos = By.XPath("//span[contains(.,'Combos')]");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public HomePage ClickCards()
        {
            _driver.FindElement(_navBarCards).Click();
            return this;
        }

        public TopCards ClickTopCards()
        {
            _driver.FindElement(_topCards).Click();
            return new TopCards(_driver);
        }

        public SaltiesCards ClickSaltiesCards()
        {
            _driver.FindElement(_saltiestCards).Click();
            return new SaltiesCards(_driver);
        }

        public Combos ClickCombos()
        {
            _driver.FindElement(_combos).Click();
            return new Combos(_driver);
        }
    }
}
