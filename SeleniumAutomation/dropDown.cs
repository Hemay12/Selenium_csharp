using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Beginner
{
    public class dropDown
    {
        [Test]
        public void drop() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.08-DropDown.html");
            driver.Manage().Window.Maximize();

            IWebElement dropdownElement = driver.FindElement(By.Id("dropdown1"));
            SelectElement dropdown1 = new SelectElement(dropdownElement);
            dropdown1.SelectByValue("2");

            IWebElement dropdownElement2 = driver.FindElement(By.Id("dropdown2"));
            SelectElement dropdown2 = new SelectElement(dropdownElement2);
            dropdown2.SelectByValue("2");
            dropdown2.SelectByValue("4");

            IWebElement dropdownElement3 = driver.FindElement(By.Id("dropdown3"));
            SelectElement dropdown3 = new SelectElement(dropdownElement3);
            dropdown3.SelectByIndex(3);
        }
    }
}
