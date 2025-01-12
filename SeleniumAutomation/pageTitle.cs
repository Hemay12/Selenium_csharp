using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace SeleniumAutomation
{
    public class pageTitle
    {
        [Test]
        public void title()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.11-PageTitle.html");
            driver.Manage().Window.Maximize();

            string title = driver.Title;

            IWebElement x = driver.FindElement(By.Id("titleInput"));
            x.SendKeys(title);

            
        }

    }
}
