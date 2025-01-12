using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace Beginner
{
    public class color
    {
        [Test]
        public void GetColor()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.04-Color.html");

            driver.Manage().Window.Maximize();

            IWebElement button = driver.FindElement(By.CssSelector("#colorButton"));
            string orginal_color = button.GetCssValue("background-color");
            string hex = utils.RgbaToHex(orginal_color);

            driver.FindElement(By.Id("user-input1")).SendKeys(hex);

            Actions ac = new Actions(driver);

            ac.MoveToElement(button).Perform();
            Thread.Sleep(100);
            string hover_color = button.GetCssValue("background-color");
            string hex1 = utils.RgbaToHex(hover_color);
            driver.FindElement(By.Id("user-input2")).SendKeys(hex1);

            ac.ClickAndHold(button).Perform();
            Thread.Sleep(1000);
            string hold_color = button.GetCssValue("background-color");
            //ac.Release().Perform();
            string hex2 = utils.RgbaToHex(hold_color);
            driver.FindElement(By.Id("user-input3")).SendKeys(hex2);
        }

    }
}


