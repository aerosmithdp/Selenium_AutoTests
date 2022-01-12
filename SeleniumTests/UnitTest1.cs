using OpenQA.Selenium;
using System;
using Xunit;
using SeleniumTests.PageObjects;

namespace SeleniumTests
{
    public class UnitTest1 : BaseTest
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = StartDriverOnPage("https://edhrec.com");
            HomePage homePage = new HomePage(driver);
            homePage.ClickCards()
                    .ClickTopCards()
                    .ClickPastWeek();
        }

        [Fact]
        public void Test2()
        {
            IWebDriver driver = StartDriverOnPage("https://edhrec.com");
            HomePage homePage = new HomePage(driver);
            homePage.ClickCards()
                    .ClickSaltiesCards();
        }

        [Fact]
        public void Test3()
        {
            IWebDriver driver = StartDriverOnPage("https://edhrec.com");
            HomePage homePage = new HomePage(driver);
            homePage.ClickCards()
                    .ClickCombos();
        }
    }
}
