using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Beginner;

public class Click
{
    [Test]
    public void click() 
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.01-Click.html");

        driver.Manage().Window.Maximize();

        driver.FindElement(By.Id("clickButton")).Click();
        String successMessage = driver.FindElement(By.Id("successMessage")).Text;

        Assert.AreEqual("Success! You clicked the button.", successMessage);

    }
}
