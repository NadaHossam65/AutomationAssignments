using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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


        [Test]

        public void Testcase3()
        {


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            driver.Manage().Window.Maximize();


            // Locate the "Add Element" button
            // This button can be located by its tag name 'button'
            // or by its text content, or if it had an ID/Class
            IWebElement addButton = null;
            try
            {
                addButton = driver.FindElement(By.XPath("//button[text()='Add Element']"));
                TestContext.WriteLine("Successfully located the 'Add Element' button.");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("The 'Add Element' button was not found on the page.");
            }

            // 1. Print its Tag Name
            string tagName = addButton.TagName;
            TestContext.WriteLine($"Tag Name: {tagName}");

            // 2. Print its Attributes (like class or id)
            string idAttribute = addButton.GetAttribute("id");
            string classAttribute = addButton.GetAttribute("class");

            TestContext.WriteLine($"ID Attribute: {(string.IsNullOrEmpty(idAttribute) ? "N/A (No ID)" : idAttribute)}");
            TestContext.WriteLine($"Class Attribute: {(string.IsNullOrEmpty(classAttribute) ? "N/A (No Class)" : classAttribute)}");

            // You can also get other attributes if you know they exist, e.g.:
            // string typeAttribute = addButton.GetAttribute("type");
            // TestContext.WriteLine($"Type Attribute: {(string.IsNullOrEmpty(typeAttribute) ? "N/A (No Type)" : typeAttribute)}");

            // 3. Print its Location and Size on screen
            Point location = addButton.Location;
            Size size = addButton.Size;

            TestContext.WriteLine($"Location on Screen (X, Y): ({location.X}, {location.Y})");
            TestContext.WriteLine($"Size (Width x Height): {size.Width}x{size.Height}");

            // 4. Check if it is enabled or not
            bool isEnabled = addButton.Enabled;
            TestContext.WriteLine($"Is Enabled: {isEnabled}");

            // Basic Assertion to ensure the test passes if the button is found and enabled
            Assert.IsTrue(isEnabled, "The 'Add Element' button is not enabled.");
            Assert.AreEqual("Add Element", addButton.Text, "Button text does not match 'Add Element'.");

            driver.Quit();

        }
        [Test]

        public void Testcase4() {



            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://aa-practice-test-automation.vercel.app/Pages/checkbox_Radio.html");
            driver.Manage().Window.Maximize();

            var checkBox1 = driver.FindElement(By.Id("Ahly"));
            bool isOption2Selected = checkBox1.Selected;

            TestContext.WriteLine($"'Option 2' Checkbox Status: Selected = {isOption2Selected}");

            driver.Quit();

        }

    }
}
