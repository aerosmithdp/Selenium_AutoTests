using OpenQA.Selenium;

namespace SeleniumTests.PageObjects
{
    public class TopCards
    {
        private IWebDriver _driver;

        public TopCards(IWebDriver driver)
        {
            _driver = driver;
        }

        private By _pastWeekButton = By.LinkText("Past Week");

        public TopCards ClickPastWeek()
        {
            _driver.FindElement(_pastWeekButton).Click();
            return this;
        }

    }
}
