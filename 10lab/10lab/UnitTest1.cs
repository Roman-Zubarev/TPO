using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace _10lab
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

            public void SelectCarMake()
            {
                driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[1]/div[1]/span/span[1]/span/span[1]/span")).Click();

                driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[54]")).Click();
            }

            public void SelectCarModel( )
            {
                // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


                driver.FindElement(By.XPath("//*[@id=\"select2-model-container\"]")).Click();

                /*                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                                wait.Until(drv => drv.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")));*/

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();
            }

            public void SelectCarYear()
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.PollingInterval = TimeSpan.FromSeconds(200);
                wait.Until(d => d.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[3]/ul/li[10]/a")));


                driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[3]/ul/li[10]/a")).Click();
            }

            public void SelectCarDetail()
            {
                driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[6]/span/span[1]/span/span[1]")).Click();
                driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1628]")).Click();
            }

            public void SubmitSearch()
            {
                driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[30]/div[1]/button")).Click();
            }

            public void ClickOnCarDetails()
            {
                driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[2]/div[1]/div[2]/div/div/div[1]/div[1]/div/a/div[1]/div/div[2]")).Click();

            }


           
        }

        [TestMethod]
        public void OpenItemTest()
        {
            BamperPage homePage = new BamperPage(driver);
            homePage.GoToHomePage();
            homePage.SelectCarMake();

            Thread.Sleep(2000);

            homePage.SelectCarModel();

            Thread.Sleep(2000);

            homePage.SelectCarYear();

            homePage.SelectCarDetail();

            homePage.SubmitSearch();
            Thread.Sleep(2000);

            homePage.ClickOnCarDetails();

        }
    }
}