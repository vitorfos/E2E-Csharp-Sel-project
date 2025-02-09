using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreDemo.Drivers
{
    public class WebDriverManager
    {
        private IWebDriver _driver;

        public IWebDriver InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            //options.AddArgument("--headless");
            _driver = new ChromeDriver(options);
            return _driver;
        }

        public void QuitDriver()
        {
            _driver.Quit();
        }
    }
}