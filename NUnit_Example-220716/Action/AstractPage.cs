using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Example_220716.Action
{
    public class AstractPage
    {
        public IWebElement element;
        public int timeWait = 30;

        public void clickToElement(IWebDriver driver, string locator)
        {
            element = driver.FindElement(By.XPath(locator));
            element.Click();
        }

        public virtual void sendKeyToElement(IWebDriver driver, string locator, string value)
        {
            element = driver.FindElement(By.XPath(locator));
            element.Clear();
            element.SendKeys(value);
        }

        public void waitForControlByXPath(IWebDriver driver, string locator)
        {
            try
            {
                By by = By.XPath(locator);
                //By by = By.ClassName(locator);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void waitForControlByClass(IWebDriver driver, string locator)
        {
            try
            {
                By by = By.ClassName(locator);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


    }
}
