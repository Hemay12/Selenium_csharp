using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner
{
    public class radioList
    {
        [Test]
        public void radio() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.07-RadioList.html");
            driver.Manage().Window.Maximize();

            List<IWebElement> list = driver.FindElements(By.ClassName("form-check")).ToList();
            foreach (IWebElement element in list) {
                string str = element.FindElement(By.ClassName("form-check-label")).Text;
                if (str.Equals("India") ){
                    element.FindElement(By.ClassName("form-check-input")).Click();
                }
            }
        }
    }
}
