using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace Beginner
{
    public class rightClick
    {
        [Test]
        public void rightClickMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.09-DoubleClick.html");
            driver.Manage().Window.Maximize();

            Actions ac = new Actions(driver);

            IWebElement x = driver.FindElement(By.Id("clickButton"));
            ac.ContextClick(x).Perform();


        }
    }
}
