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

        public void FillFirstName(string first)
        {
            var firstName = Driver.WebDriver.FindElement(_first_name_field);
            firstName.Clear();
            firstName.SendKeys(first);

        }

        public void FillMiddleName( string middle)
        {
            
            var middleName = Driver.WebDriver.FindElement(_middle_name_field);
            middleName.Clear();
            middleName.SendKeys(middle);
        }

        public void FillLastName( string last)
        {

            var lastName=Driver.WebDriver.FindElement(_last_name_field);
            lastName.Clear();
            lastName.SendKeys(last);
        }

        public void FillEmail(string email)
        {
            var mail=Driver.WebDriver.FindElement(_email_field);
            mail.Clear();
            mail.SendKeys(email);
        }

        public void FillPassword(string password)
        {
            var pass=Driver.WebDriver.FindElement(_password_field);
            pass.Clear();
            pass.SendKeys(password);

        }

        public void FillConfirmPassword(string password)
        {
            
            var pass=Driver.WebDriver.FindElement(_confirm_password_field);
            pass.Clear();
            pass.SendKeys(password);
        }



        public void ClickOnRegister()
        {
            Driver.WebDriver.FindElement(_register_button).Click();
        }

        public void FillInRegisterForm()
        {
            FillFirstName(Faker.Name.First());
            FillMiddleName( Faker.Name.Middle());
            FillLastName( Faker.Name.Last());
            FillEmail(Faker.Name.Last() + "@yahoo.com");
            FillPassword("asdasd");
            FillConfirmPassword("asdasd");
        }
    }
}
