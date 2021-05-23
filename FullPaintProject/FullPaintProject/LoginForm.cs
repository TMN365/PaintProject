using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullPaintProject
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Faculta\UTCN\An3Sem2\II\PaintProject22.05\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf;Integrated Security=True";
        public LoginForm()
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from AccountTable where Username = '" + textBoxUsername.Text + "' and password='" + textBoxPassword.Text + "'", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MainMenuForm mainMenuForm = new MainMenuForm(textBoxUsername.Text, textBoxPassword.Text);
                    mainMenuForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username and the password are incorrect.");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
