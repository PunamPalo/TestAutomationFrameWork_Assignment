using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomationFrameWork_Assignment.Scenarios
{
    public class Login_InvalidCredentials
    {
        public Login_InvalidCredentials()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        // To check Login screen using empty username
        [Test]
        public void LoginInValidData_UsingEmptyUserName()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.EmptyUserName,
                Config.Credentials.Valid.Password);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        // To check Login screen using wrong username
        [Test]
        public void LoginInValidData_UsingWrongUserName()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.OtherthangivenValue,
                Config.Credentials.Valid.Password);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        // To check Login screen using empty password
        [Test]
        public void LoginInValidData_UsingEmptyPassword()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(
                Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.EmptyPassword);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage_Password, Actions.getText());
        }

        // To check Login screen using wrong password
        [Test]
        public void LoginInValidData_UsingWrongPassword()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(
                Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.OtherthangivenValue);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage_Password, Actions.getText());
        }

        // To check Login screen using empty username and empty password
        [Test]
        public void LoginInValidData_UsingEmptytValues()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.EmptyUserName,
                Config.Credentials.Invalid.Password.EmptyPassword);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
