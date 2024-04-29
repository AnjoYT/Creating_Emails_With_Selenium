using OpenQA.Selenium;

namespace Creating_Emails_With_Selenium
{
    public static class CustomMethods
    {
        public static void SendText(this IWebElement locator, string text)
        {
            locator.SendKeys(text);
        }
        public static void Submit(this IWebElement locator)
        {
            locator.Submit();
        }
        public static void Navigate(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static void ValidateText(this IWebElement locator, IWebDriver driver, string text)
        {
            //Assert.False(locator.Text.Contains(text), locator.Text);
        }
    }
}
