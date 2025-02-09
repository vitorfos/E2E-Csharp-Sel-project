using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCoreDemo.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string VerifyTitle()
        {
            return driver.Title;
        }

        public void WaitForPageToLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void ClickLogin()
        {
            IWebElement loginLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("loginLink")));
            loginLink.Click();
        }

        public void Login(string username, string password)
        {
            IWebElement userNameField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));
            userNameField.SendKeys(username);

            IWebElement passwordField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("Password")));
            passwordField.SendKeys(password);

            IWebElement loginButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("loginIn")));
            loginButton.Click();
        }

        public string VerifyLoggedIn()
        {
            IWebElement helloLabel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[@title='Manage']")));
            return helloLabel.Text;
        }

        // Add properties for web elements here, e.g.:
        // public IWebElement SomeElement => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("elementId")));
    }
}