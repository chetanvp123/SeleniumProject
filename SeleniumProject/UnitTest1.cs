using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumProject
{
    public class Tests
    {
       public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.co.in/");
            
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("q")).SendKeys("Tata cha");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("q")).Clear();
        }
        [Test]
        public void Test2()
        {
            driver.FindElement(By.Name("q")).SendKeys("Scania");
            System.Threading.Thread.Sleep(3000);
        }
        [OneTimeTearDown]
        public void close()
        {
            driver.Close();

        }

    }
}