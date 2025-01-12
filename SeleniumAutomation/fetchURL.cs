using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Beginner
{
    public class fetchURL
    {
        [Test]
        public void fetch() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.12-FetchURL.html");
            driver.Manage().Window.Maximize();

            string title = driver.Url;

            IWebElement x = driver.FindElement(By.Id("urlInput"));
            x.SendKeys(title);
        }
    }
}
