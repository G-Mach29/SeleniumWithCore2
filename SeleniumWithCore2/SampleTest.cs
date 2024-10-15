using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using System.Threading;

namespace SeleniumWithCore2
{
    [TestFixture] // NUnit attribute to define a test class
    public class SampleTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // Initialize Chrome WebDriver
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenGoogleTest()
        {
            // Navigate to Google
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tamato");
            Thread.Sleep(2000);

            // Assert the title contains "Google"
            // Assert.IsTrue(driver.Title.Contains("Google"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            // Close the browser after each test
            driver.Quit();
        }
    }
}
