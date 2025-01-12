using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner
{
    public class radioButton
    {
        [Test]
        public void radioButtonMethod() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.03-Radio.html");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@value='male']")).Click();

            String successMessage = driver.FindElement(By.Id("successMessage")).Text;

            Assert.AreEqual("You have selected Male.", successMessage);
        }
    }
}
