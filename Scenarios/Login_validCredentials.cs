namespace TestAutomationFrameWork_Assignment.Scenarios
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    public class Login_validCredentials
    {
        public Login_validCredentials()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }


        //To check the login screen using valid datas.
        [Test]
        public void Login_ValidData()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Valid.Password);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.SuccessfulLoginText, Actions.getText().TrimEnd());
            Thread.Sleep(3000);
            Actions.LogOutFromScreen();
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.SuccessfulLogOutText, Actions.getLogOutText().TrimEnd());
        }

        

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}