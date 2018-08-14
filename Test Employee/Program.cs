using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open chrome browser
            IWebDriver driver = new ChromeDriver(@"C:\Users\SONY\Downloads\chromedriver_win32");

            //Go to the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
        }
    }
}
