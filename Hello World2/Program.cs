using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.bing.com/");
            driver.Manage().Window.Maximize();

            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
            searchInput.SendKeys("Hello World");
            //searchInput.SendKeys(Keys.Enter);
            //.Click();

            IWebElement buttonSearch = driver.FindElement(By.Id("sb_form_go"));

            buttonSearch.Click();
            driver.Close();
        }

      
    }
}
