using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullPaintProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullPaintProject.Tests
{
    [TestClass()]
    public class LoginFormTests
    {
        [TestMethod()]
        public void loginButton_ClickTrueTest()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.setCheckForTests(false);
            loginForm.textBoxUsername.Text = "D";
            loginForm.textBoxPassword.Text = "D";
            loginForm.loginButton_Click(new object(), new EventArgs());
            Assert.IsTrue(loginForm.getCheckForTests());
        }
        [TestMethod()]
        public void loginButton_ClickFalseTest()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.setCheckForTests(false);
            loginForm.textBoxUsername.Text = "1";
            loginForm.textBoxPassword.Text = "22143";
            loginForm.loginButton_Click(new object(), new EventArgs());
            Assert.IsTrue(!loginForm.getCheckForTests());
        }

        [TestMethod()]
        public void usernameTextBox_ClickTest()
        {
            bool result = false;
            LoginForm loginForm = new LoginForm();
            loginForm.usernameTextBox_Click(new object(), new EventArgs());
            if (loginForm.textBoxUsername.Text == "") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void passwordTextBox_ClickTest()
        {
            bool result = false;
            LoginForm loginForm = new LoginForm();
            loginForm.passwordTextBox_Click(new object(), new EventArgs());
            if (loginForm.textBoxPassword.Text == "") result = true;
            Assert.IsTrue(result);
        }
    }
}