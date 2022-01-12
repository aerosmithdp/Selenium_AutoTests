using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTests
{
    public class BaseTest : IDisposable
    {
        private IWebDriver _driver;

        public IWebDriver StartDriverOnPage(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            return _driver;
        }
        public void Dispose()
        {
            _driver.Quit();
        }

    }
}
