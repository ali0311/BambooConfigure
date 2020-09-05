using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BambooTestClass
{
    [TestClass]
    public class BambooTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.in/");
            driver.Close();

        }
    }
}
