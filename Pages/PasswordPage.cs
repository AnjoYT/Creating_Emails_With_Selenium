using OpenQA.Selenium;

namespace Creating_Emails_With_Selenium.Pages
{
    public class PasswordPage
    {
        IWebDriver driver;
        public PasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement PasswordText => driver.FindElement(By.Id("login-passwd"));
        IWebElement SubmitButton => driver.FindElement(By.Id("login-signin"));

        public void Login(string password)
        {
            PasswordText.SendText(password);
            SubmitButton.Submit();
        }
    }
}
