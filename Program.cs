using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com");
            
            driver.Manage().Window.Maximize();
            Thread.Sleep(8000);
        }
    }
}