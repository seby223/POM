using OpenQA.Selenium;
using System.Linq;
using POM.Helpers;
//using Faker;

namespace POM.Pages
{
    public class RegisterPage
    {
        #region Selectors
        private readonly By _first_name_field = By.CssSelector("#firstname");
        private readonly By _middle_name_field = By.CssSelector("#middlename");
        private readonly By _last_name_field = By.CssSelector("#lastname");
        private readonly By _email_field = By.CssSelector("#email_address");
        private readonly By _password_field = By.CssSelector("#password");
        private readonly By _confirm_password_field = By.CssSelector("#confirmation");
        private readonly By _register_button = By.CssSelector(".buttons-set .button");
        #endregion

        public void FillNames(string first, string middle, string last)
        {
            Driver.WebDriver.FindElement(_first_name_field).SendKeys(first);
            Driver.WebDriver.FindElement(_middle_name_field).SendKeys(middle);
            Driver.WebDriver.FindElement(_last_name_field).SendKeys(last);
        }

        public void FillEmail(string email)
        {
            Driver.WebDriver.FindElement(_email_field).SendKeys(email);
        }

        public void FillPassword(string password)
        {
            Driver.WebDriver.FindElement(_password_field).SendKeys(password);
            Driver.WebDriver.FindElement(_confirm_password_field).SendKeys(password);
        }

        public void ClickOnRegister()
        {
            Driver.WebDriver.FindElement(_register_button).Click();
        }

        public void FillInRegisterForm()
        {
            FillNames(Faker.Name.First(), Faker.Name.Middle(), Faker.Name.Last());
            FillEmail(Faker.Name.Last() + "@yahoo.com");
            FillPassword("asdasd");
        }
    }
}
