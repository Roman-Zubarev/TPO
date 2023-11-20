using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;

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


        /*        [TestMethod]
                public void ICanWin()
                {
                    WebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://pastebin.com");
                    driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");

                    driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
                    driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();

                    driver.FindElement(By.Id("postform-name")).SendKeys("helloweb");
                    driver.FindElement(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button")).Click();

                    //driver.Quit();
                }

                [TestMethod]
                public void BringItOn()
                {
                    WebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://pastebin.com");
                    driver.FindElement(By.Id("postform-text")).SendKeys("git config --global user.name  \"New Sheriff in Town\"" + "\ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") " + "\ngit push origin master --force");


                    driver.FindElement(By.Id("select2-postform-format-container")).Click();
                    driver.FindElement(By.XPath("//li[text()='Bash']")).Click();

                    driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
                    driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();

                    driver.FindElement(By.Id("postform-name")).SendKeys("how to gain dominance among developers");
                    driver.FindElement(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button")).Click();

        *//*            WebElement syntax = (WebElement)driver.FindElement(By.XPath("//a[text()='Bash']"));
                    WebElement gitCodeFirstLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/ol/li[1]/div"));
                    WebElement gitCodeSecondLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/ol/li[2]/div"));
                    WebElement gitCodeThirdLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/ol/li[3]/div"));

                    Assert.AreEqual("Bash", syntax.Text);
                    Assert.IsTrue(gitCodeFirstLine.Text.StartsWith("git config"));
                    Assert.IsTrue(gitCodeSecondLine.Text.StartsWith("git reset"));
                    Assert.IsTrue(gitCodeThirdLine.Text.StartsWith("git push"));
        *//*

                    //driver.Quit();
                }

                [TestMethod]
                public void HurtMePlenty()
                {
                    WebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://cloud.google.com/");
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                    driver.FindElement(By.XPath("//*[@id=\"kO001e\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/input")).Click();

                    driver.FindElement(By.XPath("//*[@id=\"kO001e\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/input")).SendKeys("Google Cloud Platform Pricing Calculator");
                    driver.FindElement(By.XPath("//*[@id=\"kO001e\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/input")).SendKeys(Keys.Enter);

                    driver.FindElement(By.XPath("//*[@id=\"___gcse_0\"]/div/div/div/div[5]/div[2]/div/div/div[1]/div[1]/div[1]/div[1]/div/a")).Click();


                    //  driver.FindElement(By.XPath("//*[@id=\"mainForm\"]/div[2]/div/md-card/md-card-content/div/div[1]/form/div[1]/div[1]/md-input-container")).SendKeys("4");
                    //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    *//*            IWebDriver el = (IWebDriver)driver.FindElement(By.XPath("//*[@id=\"select_value_label_94\"]"));

                                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                                wait.Until()*//*
                    driver.FindElement(By.XPath("//*[@id=\"mainForm\"]/div[2]/div/md-card/md-card-content/div/div[1]/form/div[1]")).Click();

                    driver.FindElement(By.XPath("/html/body/md-content/md-card/div/md-card-content[1]/div[2]/div/md-card/md-card-content/div/div[1]/form/div[1]/div[1]/md-input-container/input")).SendKeys("4");


                    //driver.Quit();
                }*/
    }
}
