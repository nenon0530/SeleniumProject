using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace NewSeleniumProject
{
    [TestFixture]
    public class NewSeleniumProject
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;


        [SetUp]
        public void SetupTest()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            // driver = new EdgeDriver();
            //driver = new InternetExplorerDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1000);


            baseURL = "http://xxxxxx/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        [Test]
        public void SeleniumTutorial01()
        {
            //テストコード貼り付けSTART
            driver.Navigate().GoToUrl("http://xxxxx");
            driver.FindElement(By.Id("UserId")).Clear();
            driver.FindElement(By.Id("UserId")).SendKeys("admin");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("admin");
            driver.FindElement(By.CssSelector("button.l_button.c_button")).Click();
            driver.FindElement(By.XPath("//div[@id='param']/div[2]/div[2]/div/div[2]/div/button")).Click();
            new SelectElement(driver.FindElement(By.Name("CHNCD_LIST"))).SelectByText("02shoplist");
            //driver.FindElement(By.CssSelector("option[value=\"02\"]")).Click();
            //sleep 3 seconds
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='output']/button")).Click();
            //sleep 3 seconds
            Thread.Sleep(3000);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
//テストコード貼り付けEND