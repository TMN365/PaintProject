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
    public class EditAccountFormTests
    {
        [TestMethod()]
        public void clearTextboxTest()
        {
            bool result = false;
            EditAccountForm editAccountForm = new EditAccountForm("1","1");
            editAccountForm.passTextBox.Text = "text";
            editAccountForm.changeMailTextBox.Text = "text";
            editAccountForm.firstNameTextBox.Text = "text";
            editAccountForm.lastNameTextBox.Text = "text";
            editAccountForm.oldPasswordTextBox.Text = "text";
            editAccountForm.confPassTextBox.Text = "2";
            editAccountForm.clearTextbox();
            if (editAccountForm.passTextBox.Text == "" &&
                editAccountForm.changeMailTextBox.Text == "" &&
                editAccountForm.firstNameTextBox.Text == "" &&
                editAccountForm.lastNameTextBox.Text == "" &&
                editAccountForm.oldPasswordTextBox.Text == "" &&
                editAccountForm.confPassTextBox.Text == "") result = true;
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void confirmButton_ClickTrueTest()
        {
            EditAccountForm editAccountForm = new EditAccountForm("A", "A");
            editAccountForm.setCheckForTests(false);
            editAccountForm.passTextBox.Text = "C";
            editAccountForm.changeMailTextBox.Text = "1";
            editAccountForm.firstNameTextBox.Text = "1";
            editAccountForm.lastNameTextBox.Text = "1";
            editAccountForm.oldPasswordTextBox.Text = "A";
            editAccountForm.confPassTextBox.Text = "C";
            editAccountForm.confirmButton_Click(new object(), new EventArgs());
            Assert.IsTrue(editAccountForm.getCheckForTests());

            // AICI RESETEZ PENTRU RULAREA DIN NOU A TESTELOR
            editAccountForm = new EditAccountForm("A", "C");
            editAccountForm.setCheckForTests(false);
            editAccountForm.passTextBox.Text = "A";
            editAccountForm.changeMailTextBox.Text = "1";
            editAccountForm.firstNameTextBox.Text = "1";
            editAccountForm.lastNameTextBox.Text = "1";
            editAccountForm.oldPasswordTextBox.Text = "C";
            editAccountForm.confPassTextBox.Text = "A";
            editAccountForm.confirmButton_Click(new object(), new EventArgs());
        }
        [TestMethod()]
        public void confirmButton_ClickFalseTest()
        {
            EditAccountForm editAccountForm = new EditAccountForm("C", "C");
            editAccountForm.setCheckForTests(false);
            editAccountForm.passTextBox.Text = "2";
            editAccountForm.changeMailTextBox.Text = "1";
            editAccountForm.firstNameTextBox.Text = "1";
            editAccountForm.lastNameTextBox.Text = "1";
            editAccountForm.oldPasswordTextBox.Text = "parola";
            editAccountForm.confPassTextBox.Text = "2";
            editAccountForm.confirmButton_Click(new object(), new EventArgs());
            Assert.IsTrue(!editAccountForm.getCheckForTests());
        }
    }
}