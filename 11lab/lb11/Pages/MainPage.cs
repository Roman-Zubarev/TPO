﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lb11.Loger.Loger;

namespace lb11.Pages
{
    internal class MainPage : PageBase.PageBase
    {

        private readonly string _baseUrl = "https://bamper.by/";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void Open()
        {
            Driver.Navigate().GoToUrl(_baseUrl);
            Info("Main page opened.");
        }

        public void SelectCarMake()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[1]/div[1]/span/span[1]/span/span[1]/span")).Click();

            Driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[54]")).Click();

            Info("Select completed.");

        }
        public void SelectCarModel()
        {
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@id=\"select2-model-container\"]")).Click();
            Driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();
        }
        public void OpenBAZAR()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[1]/nav/div/div[2]/ul[2]/li[3]/a")).Click();
            Info("BAZAR opened.");
        }
        public void SelectCarYear()
        {
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[3]/ul/li[10]/a")).Click();
        }

        public void SelectCarNoDetail()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[6]/span/span[1]/span/span[1]")).Click();
            Driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1628]")).Click();
        }

        public void SelectCarDetail()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[6]/span/span[1]/span/span[1]")).Click();
            Driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();
        }

        public void SubmitSearch()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[1]/aside/aside[1]/form/div/div[30]/div[1]/button")).Click();
        }

        public void ClickOnCarDetails()
        {
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div[2]/div[1]/div[2]/div/div/div[1]/div[1]/div/a/div[1]/div/div[2]")).Click();

        }

    }
}
