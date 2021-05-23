using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FullPaintProject
{
    public partial class EditAccountFrom : Form
    {
        string username, password;

        public EditAccountFrom(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Faculta\UTCN\An3Sem2\II\PaintProject22.05\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf;Integrated Security=True");
            if (passTextBox.Text == confPassTextBox.Text && passTextBox.Text != "" && changeMailTextBox.Text != "" && lastNameTextBox.Text != "" &&
                firstNameTextBox.Text != "" && oldPasswordTextBox.Text != "" && oldPasswordTextBox.Text == password)
            {
                myCon.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTable SET Username=@Username,  Password=@Password, Email=@Email, FirstName=@FirstName, LastName=@LastName WHERE Password = '" + oldPasswordTextBox.Text + "' AND Username = '" + username + "'", myCon);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", passTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", changeMailTextBox.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The account is updated.");
                myCon.Close();

            }
            else
            {
                MessageBox.Show("The fields are incorrect completed.");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(username, password);
            mainMenuForm.ShowDialog();
            this.Close();
        }

        private void clearTextbox()
        {
            passTextBox.Text = changeMailTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = oldPasswordTextBox.Text = confPassTextBox.Text = "";
        }
       

    }
}
