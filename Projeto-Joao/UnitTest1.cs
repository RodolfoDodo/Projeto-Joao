

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
        public void TestComSucesso()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://hom.eadtech.net/App/Student/User/Account/Login");

            Thread.Sleep(5000);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("TesteSucesso.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Test]
        public void Sucesso()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://hom.eadtech.net/App/Student/User/Account/Login");

            Thread.Sleep(5000);
            //driver.FindElement(By.Id("#frmLoginSubmit")).Click();

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Teste.png", ScreenshotImageFormat.Png);
            driver.Quit();

        }
    }
}