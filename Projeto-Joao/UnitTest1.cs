

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Projeto_Joao
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://hom.eadtech.net/App/Student/User/Account/Login");

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}