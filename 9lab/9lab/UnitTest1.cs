using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace _9lab
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BamperTest()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bamper.by/");
            driver.FindElement(By.XPath("//*[@id=\"select2-marka-container\"]")).Click();
            driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[54]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"select2-model-container\"]")).Click();
            driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[3]/ul/li[10]")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[6]/span/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1628]")).Click();


            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[30]/div[1]/button")).Click();

            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[2]/div[1]/div[2]/div/div/div[1]/div[2]/div/h5")).Click();

        }
    }
}