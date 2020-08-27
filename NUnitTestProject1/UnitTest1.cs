using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            #region Brouser Capabilities - dont use
            //DesiredCapabilities capabilities = new DesiredCapabilities();
            #endregion

            #region Brouser Options - dont use
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("start-fullscreen");
            //driver = new ChromeDriver(options);
            # endregion

            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://www.google.com";
     
            //driver.FindElement(By.ClassName("hOoLGe")).Click();
            //driver.FindElement(By.Id("K90")).Click();
            //driver.FindElement(By.Id(""));
           

            var webelement = driver.FindElement(By.Name("q"));
            webelement.SendKeys("webdriver");
            driver.FindElement(By.Id("gsr")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - Поиск в Google"));
            Assert.Pass();
        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}