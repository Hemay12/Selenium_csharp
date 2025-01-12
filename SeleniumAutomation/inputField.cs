using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner
{
    public class inputField
    {
        [Test]
        public void inputFieldMethod() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.02-Input.html");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("user-input-name")).SendKeys("Dummy");
            driver.FindElement(By.Id("user-input-age")).SendKeys("32");
            driver.FindElement(By.Id("text-input")).SendKeys("text within double quotes");


        }
    }
}
