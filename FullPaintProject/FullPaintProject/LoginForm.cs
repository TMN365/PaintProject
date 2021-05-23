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
        bool check = false;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Olariu Gabriel\Dropbox\Facultate\AN3\Sem2\II\Proiect\FullPaintProject\FullPaintProject\PaintDataBase.mdf';Integrated Security=True";
        public LoginForm()
        {
            
            InitializeComponent();
        }
        public void usernameTextBox_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
                textBoxUsername.Text = "";
        }

        public void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
                textBoxPassword.Text = "";
        }

        public void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        public void loginButton_Click(object sender, EventArgs e)
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
                    setCheckForTests(true);
                }
                else
                {
                    MessageBox.Show("The username and/or the password are incorrect.");
                    setCheckForTests(false);
                }
            }
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool getCheckForTests()
        {
            return check;
        }
        public void setCheckForTests(bool variable)
        {
            check = variable;
        }
    }
}
