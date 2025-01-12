using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner
{
    public class inputValidation
    {
        [Test]
        public void input() {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.06-ValueInput.html");
            driver.Manage().Window.Maximize();

            var Str = driver.FindElement(By.Id("inputField1")).GetAttribute("value");

            driver.FindElement(By.Id("inputField2")).SendKeys(Str);

            String successMessage = "Success: The values match!";

            Assert.AreEqual(successMessage, driver.FindElement(By.Id("message")).Text);
        }
    }
}
