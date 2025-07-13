using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAssignment
{
    public class Test
    {
        WebDriver driver;
        [Test]
        public void Test1() {
            
            driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.dummyticket.com/dummy-ticket-for-visa-application/");
            driver.Manage().Window.Maximize();
            By productName = By.Id("product_3186");
            driver.FindElement(productName).Click();
            By firstName = By.Id("travname");
            driver.FindElement(firstName).SendKeys("Nada");
            By lastName = By.Id("travlastname");
            driver.FindElement(lastName).SendKeys("Hossam");

           



            By gender = By.Id("sex_2");
            driver.FindElement(gender).Click();
            By tripType = By.Id("traveltype_1");
            driver.FindElement(tripType).Click();

            By fromCity = By.Id("fromcity");
            driver.FindElement(fromCity).SendKeys("Cairo");
            By tocity = By.Id("tocity");
            driver.FindElement(tocity).SendKeys("Paris");
            driver.FindElement(By.Id("billing_phone")).SendKeys("01111111111");
            driver.FindElement(By.Id("billing_email")).SendKeys("nada.salem@geidea.net");
            driver.FindElement(By.Id("billing_email")).SendKeys("nada.salem@geidea.net");
            driver.FindElement(By.Id("billing_address_1")).SendKeys("6october");
            driver.FindElement(By.Id("billing_city")).SendKeys("elsheikh zayed");
            driver.FindElement(By.Id("billing_postcode")).SendKeys("12345");


            driver.FindElement(By.Id("Field-numberInput")).SendKeys("1234432112344321");
            driver.FindElement(By.Id("Field-expiryInput")).SendKeys("09/26");
            driver.FindElement(By.Id("Field-cvcInput")).SendKeys("678");

            driver.FindElement(By.Id("place_order")).Click();








        }
        [Test]

        public void Testcase2() {


            driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://aa-practice-test-automation.vercel.app/Pages/uploadFile.html");
            driver.Manage().Window.Maximize();

           
            
            driver.FindElement(By.Id("regularFileInput")).SendKeys("\"C:\\Users\\Nada.Salem\\Pictures\\Screenshots\\Screenshot 2023-09-14 162014.png\"");

            driver.FindElement(By.Id("chooseFileBtn")).SendKeys("\"C:\\Users\\Nada.Salem\\Pictures\\Screenshots\\Screenshot 2023-09-14 162014.png\"");




        }

    }
}
