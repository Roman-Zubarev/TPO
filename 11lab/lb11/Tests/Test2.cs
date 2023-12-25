using lb11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lb11.DriverManager.DriverMaganer;
using Assert = NUnit.Framework.Assert;

namespace lb11.Tests
{
    [TestClass]
    public class Test2
    {
        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);

        }

        [Test]
        public void Test()
        {
            _mainPage.Open();

            _mainPage.SelectCarMake();

            _mainPage.SelectCarModel();

            _mainPage.SelectCarYear();

            _mainPage.SelectCarDetail();

            _mainPage.SubmitSearch();

            _mainPage.ClickOnCarDetails();
        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
