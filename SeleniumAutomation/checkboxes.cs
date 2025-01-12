using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner
{
    public class checkboxes
    {

        [Test]
        public void checkbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.05-Checkboxes.html");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@value='music']")).Click();

            List<IWebElement> list = driver.FindElements(By.Name("hobbies")).ToList();
            list[2].Click();

            String successMessage = "You have selected \"Music\" and the 3rd option.";

            Assert.AreEqual(successMessage, driver.FindElement(By.Id("successMessage")).Text);
        }
    }
}
