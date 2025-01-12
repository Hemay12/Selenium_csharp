using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Beginner
{
    public class doubleClick
    {
        [Test]
        public void doubleClickMethod() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.10-RightClick.html");
            driver.Manage().Window.Maximize();

            Actions ac = new Actions(driver);

            IWebElement x = driver.FindElement(By.Id("clickButton"));
            ac.DoubleClick(x).Perform();


        }
    }
}
