using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Data;
using OpenQA.Selenium.DevTools.V117.IndexedDB;

namespace _10lab2
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
        }
        public class BamperPage
        {

            private readonly IWebDriver driver;

            public BamperPage(IWebDriver driver)
            {
                this.driver = driver;
            }
            [TestInitialize]
            public void GoToHomePage()
            {
                driver.Navigate().GoToUrl("https://bamper.by/");
            }

            public void GoToPageBazar()
            {
                driver.FindElement(By.XPath("/html/body/div[3]/div[1]/nav/div/div[2]/ul[2]/li[3]/a")).Click();
            }

            public void SearchDetail(string s)
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[1]/form/div/input")).SendKeys(s);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[1]/form/div/input")).SendKeys(Keys.Enter);

          //      driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[1]/div[3]/a/p")).Click();


            }

            public void OpenFirstDetail()
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[6]/div[1]/div[2]/div/div[1]/div/h4/a")).Click();
            }

            public void OpenDealerNumber()
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[1]/div[3]/div[2]/div[10]/div[3]/div[1]/div[2]/p")).Click();
            }
        }

        [TestMethod]
        public void AddItemToBasketTest()
        {
            BamperPage homePage = new BamperPage(driver);
            homePage.GoToHomePage();
            homePage.GoToPageBazar();
            homePage.SearchDetail("аккумулятор");
            homePage.OpenFirstDetail();
    //        homePage.OpenDealerNumber();

        }
    }
}