using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Creating_Emails_With_Selenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public readonly string url = "https://login.yahoo.com/";

        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        IWebElement LoginTxt => driver.FindElement(By.Id("login-username"));
        IWebElement SubmitButton => driver.FindElement(By.Id("login-signin"));
        IWebElement InformationHeading => driver.FindElement(By.ClassName("challenge-heading"));

        public void Navigate()
        {
            driver.Navigate(url);
        }
        public void Login(string login)
        {
            driver.Navigate(url);
            LoginTxt.SendText(login);
            SubmitButton.Submit();
        }
        public void ValidateInfoHeading(string text)
        {
            InformationHeading.ValidateText(driver, text);
        }
    }
}
