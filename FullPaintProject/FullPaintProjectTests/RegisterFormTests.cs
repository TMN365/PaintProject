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
    public class RegisterFormTests
    {
        int iteratie =4;
        [TestMethod()]
        public void clearTextBoxesTest()
        {
            bool result = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.textBoxPassword.Text = registerForm.textBoxUsername.Text = registerForm.textBoxFirstName.Text = registerForm.textBoxLastName.Text = registerForm.textBoxEmail.Text = "test";
            registerForm.clearTextBoxes();
            if (registerForm.textBoxPassword.Text == "" &&
                registerForm.textBoxUsername.Text == "" &&
                registerForm.textBoxFirstName.Text == "" &&
                registerForm.textBoxLastName.Text == "" &&
                registerForm.textBoxEmail.Text == "") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void usernameTextBox_ClickTest()
        {
            bool result = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.usernameTextBox_Click(new object(), new EventArgs());
            if (registerForm.textBoxUsername.Text == "") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void passwordTextBox_ClickTest()
        {
            bool result = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.passwordTextBox_Click(new object(), new EventArgs());
            if (registerForm.textBoxPassword.Text == "") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void confirmButton_ClickIncorrectTest()
        {
            bool result = false;
            string checkString;
            RegisterForm registerForm = new RegisterForm();
            registerForm.textBoxPassword.Text = registerForm.textBoxUsername.Text = registerForm.textBoxFirstName.Text = registerForm.textBoxLastName.Text = registerForm.textBoxEmail.Text = "";
            registerForm.confirmButton_Click(new object(), new EventArgs());

            if (registerForm.getCheckForTests() == "Incorrect information") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void confirmButton_ClickExistsTest()
        {
            bool result = false;
            string checkString;
            RegisterForm registerForm = new RegisterForm();
            registerForm.textBoxPassword.Text = registerForm.textBoxUsername.Text = registerForm.textBoxFirstName.Text = registerForm.textBoxLastName.Text = registerForm.textBoxEmail.Text = "A";
            registerForm.confirmButton_Click(new object(), new EventArgs());

            if (registerForm.getCheckForTests() == "Username already exists!") result = true;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void confirmButton_ClickTest()
        {
            bool result = false;
            string checkString;
            RegisterForm registerForm = new RegisterForm();
            registerForm.textBoxPassword.Text = registerForm.textBoxUsername.Text = registerForm.textBoxFirstName.Text = registerForm.textBoxLastName.Text = registerForm.textBoxEmail.Text = "test"+ iteratie.ToString();
            iteratie++;
            registerForm.confirmButton_Click(new object(), new EventArgs());

            if (registerForm.getCheckForTests() == "inserted") result = true;
            Assert.IsTrue(result);
        }
    }
}