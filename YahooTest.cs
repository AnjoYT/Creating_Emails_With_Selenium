using Creating_Emails_With_Selenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Creating_Emails_With_Selenium
{
    public class YahooTest : IDisposable
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public YahooTest()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        public void Dispose()
        {
            driver.Dispose();
        }
        [Fact]
        public void SendCorrectLogin()
        {
            LoginPage loginPage = new LoginPage(driver, wait);
            loginPage.Login("seleniumtest338@yahoo.com");
            string passwordHeading = "Wprowadź hasło";
            loginPage.ValidateInfoHeading(passwordHeading);
        }

        [Fact]
        public void SendCorrectPassword()
        {
            IWebDriver driver = new ChromeDriver();
        }
    }
}
