using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace Beginner
{
    public class Balloons
    {
        [Test]
        public void balloon() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://softwaretestingpro.github.io/Automation/Beginner/B-1.13-Balloons.html");
            driver.Manage().Window.Maximize();  

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            
            
            IWebElement timer = driver.FindElement(By.Id("timer"));
            string timer_str = timer.Text;
            while (true){

                if (timer_str.Equals("Time: 0")) {
                    break;
                }

                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("balloon")));
                var balloons = driver.FindElements(By.ClassName("balloon"));

                foreach (var balloon in balloons) {
                    if (int.Parse(balloon.Text) % 2 == 0) {
                        balloon.Click();
                         
                    }  
                }
            }
            


        }
    }
}
