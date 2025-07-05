using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.Support.UI;

namespace AutomationAssignment
{
    public class Tests
    {
        WebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://example.com/");
            driver.Manage().Window.Maximize();
            string URL = driver.Url;
            Console.WriteLine("Page URL: " + URL);
            string title = driver.Title;
            Console.WriteLine("Page Title: " + title);
            string HtmlSourceCode = driver.PageSource;
            Console.WriteLine("Html source code: " +HtmlSourceCode);

            string currentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine($"Unique ID of current browser window: {currentWindowHandle}");

            driver.Navigate().GoToUrl("https://www.selenium.dev.");

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();



            var windowSize = driver.Manage().Window.Size;
            Console.WriteLine("Window width: " + windowSize.Width + ", Window height: " + windowSize.Height);
            var windowPosition = driver.Manage().Window.Position;
            Console.WriteLine("Window X: " + windowPosition.X + ", Window Y: " + windowPosition.Y);

            
            int width = 1024;
            int height = 768;

            Size newSize = new Size(width, height);
            driver.Manage().Window.Size = newSize;

            int X = 200;
            int Y = 150;
            Point newPosition = new Point(X, Y);
            driver.Manage().Window.Position = newPosition;


            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            driver.Close();

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://example.com/");
            driver.Quit();





       
        
        
        }

        [Test]
        public void TestCase2()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/r.php?entry_point=login");
            driver.Manage().Window.Maximize();

            By firstNameField = By.Name("firstname");
            driver.FindElement(firstNameField).SendKeys("Nada");

            By lastNameField = By.Name("lastname");
            driver.FindElement(lastNameField).SendKeys("Hossam");

            By day = By.Id("day");
            driver.FindElement(day).SendKeys("25");
            By month = By.Id("month");
            driver.FindElement(month).SendKeys("May"); 
            By year = By.Id("year");
            driver.FindElement(year).SendKeys("1993");

            
            By femaleRadio = By.XPath("//input[@type='radio' and @value='1']");
            driver.FindElement(femaleRadio).Click();

            By email = By.CssSelector("input.inputtext[name='reg_email__']");
            driver.FindElement(email).SendKeys("nadatest@example.com");

           By password = By.Id("password_step_input");
            driver.FindElement(password).SendKeys("TestPass123!");
        }
    }

    
    }


    