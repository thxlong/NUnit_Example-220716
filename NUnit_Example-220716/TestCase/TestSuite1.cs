using NUnit_Example_220716.Action;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit_Example_220716.TestCase
{
    public class TestSuite1
    {
        ChromeDriver chromeDriver = new ChromeDriver();
        LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://pcs11/TRS/signin");
            chromeDriver.FindElement(By.XPath("//*[@id='details-button']")).Click();
            chromeDriver.FindElement(By.XPath("//*[@id='proceed-link']")).Click();
            Thread.Sleep(5000);
        }

        [Test]
        public void TestCase1()
        {
            string strCopyRight = "login-copy-right";
            loginPage = new LoginPage(chromeDriver);
            loginPage.LoginPageAction("admin", "Test123");
            Thread.Sleep(5000);
            Console.WriteLine("Login successfully");
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(2000);
            chromeDriver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}