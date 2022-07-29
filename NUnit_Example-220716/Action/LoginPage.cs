using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Example_220716.Action
{

    public class LoginPage : AstractPage
    {
        ChromeDriver driver;
        string inputUserName = "//input[@data-placeholder='Username']";
        //string inputUserName = "//input[contains(@data-placeholder,'Username')]";
        //string inputPassword = "//input[@data-placeholder='Password']";
        string inputPassword = "//input[contains(@data-placeholder,'Password')]";
        string SubmitBtn = "//button[@type=\"submit\"]";
        //string loginBtn = "/html/body/trs-root/trs-signin/div/mat-list/div/form/mat-list-item[3]/div/button";


        public LoginPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void setUserName(String strUserName)
        {
            driver.FindElement(By.XPath(inputUserName)).SendKeys(strUserName);
        }

        public void setPassword(String strPassword)
        {
            driver.FindElement(By.XPath(inputPassword)).SendKeys(strPassword);
        }

        public void performLogin()
        {
            clickToElement(driver, SubmitBtn);
        }

        public void perFormContinue()
        {
            clickToElement(driver, SubmitBtn);
        }


        public void LoginPageAction(string strUserName, string strPassword)
        {
            waitForControlByXPath(driver, strUserName);
            //Fill user name
            this.setUserName(strUserName);
            //Perform continue
            perFormContinue();
            Thread.Sleep(2000);
            //Fill password
            this.setPassword(strPassword);
            //Click Login button
            this.performLogin();
        }


    }
}
