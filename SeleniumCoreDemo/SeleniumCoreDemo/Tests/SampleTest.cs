using System;
using SeleniumCoreDemo.Pages;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCoreDemo.Tests
{
    public class SampleTest
    {
        private IWebDriver driver;
        public HomePage homePage;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            try
            {
                Console.WriteLine("Setting up ChromeDriver...");
                driver = new ChromeDriver();
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                Console.WriteLine("ChromeDriver initialized.");

                homePage = new HomePage(driver);
                Console.WriteLine("Navigating to URL...");
                homePage.NavigateTo("http://eaapp.somee.com/");
                Console.WriteLine("Navigated to URL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to initialize ChromeDriver: {ex.Message}");
                throw;
            }
        }

        [Test]
        public void TestHomePage()
        {
            try
            {
                wait.Until(d => d.Title.Contains("Home - Execute Automation Employee App"));
                
                Console.WriteLine("Page title verified.");
                Assert.AreEqual("Home - Execute Automation Employee App", homePage.VerifyTitle());

                Console.WriteLine("Login");
                homePage.ClickLogin();
                homePage.Login("admin", "password");
                
                Console.WriteLine("Admin logged in verified.");
                Assert.AreEqual("Hello admin!", homePage.VerifyLoggedIn());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                throw;
            }
        }

        [TearDown]
        public void Teardown()
        {
            try
            {
                Console.WriteLine("Test completed. Waiting for 5 seconds before closing the browser.");
                Thread.Sleep(5000); // Wait for 5 seconds before closing the browser
                driver.Quit();
                Console.WriteLine("ChromeDriver closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to close ChromeDriver: {ex.Message}");
            }
        }
    }
}