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
    public partial class RegisterForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Olariu Gabriel\Dropbox\Facultate\AN3\Sem2\II\Proiect\FullPaintProject\FullPaintProject\Database1.mdf';Integrated Security=True";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
                textBoxUsername.Text = "";
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
                textBoxPassword.Text = "";
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "E-mail adress")
                textBoxEmail.Text = "";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // aici verificam datele daca sunt valide si deschidem form pentru codul primit prin mail
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                //AICI TREBUIE SA NE PUNEM UN IF CARE SA NE VERIFICE DACA USERNAME-UL SI/SAU EMAIL-UL EXISTA DEJA IN BAZA DE DATE
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", textBoxUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", textBoxPassword.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration is successful");
                clearTextBoxs();
            }

        }
        void clearTextBoxs()
        {
            textBoxPassword.Text = textBoxUsername.Text = textBoxFirstName.Text = textBoxLastName.Text = textBoxEmail.Text = "";
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "First Name")
                textBoxFirstName.Text = "";
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Last Name")
                textBoxLastName.Text = "";
        }
    }
}
