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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Faculta\UTCN\An3Sem2\II\PaintProject22.05\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf;Integrated Security=True";
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
            if (this.textBoxUsername.Text != "" && this.textBoxPassword.Text != "" &&
                this.textBoxEmail.Text != "" && this.textBoxFirstName.Text != "" &&
                this.textBoxLastName.Text != "")
            {
                string selectQuery = "Select * from AccountTable where Username= '" + this.textBoxUsername.Text.Trim()+"' ";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                SqlDataReader sqlDataReader;
                SqlCommand sqlCheckAvailCommand = new SqlCommand(selectQuery, sqlCon);

                string insertQuery = "INSERT into AccountTable(Username,Password,Email,FirstName,LastName) values('"
                            + this.textBoxUsername.Text + "','" + this.textBoxPassword.Text + "','" +
                            this.textBoxEmail.Text + "','" + this.textBoxFirstName.Text
                            + "','" + this.textBoxLastName.Text + "') ;";
 
                SqlCommand sqlInsertCommand = new SqlCommand(insertQuery, sqlCon);

                try
                {
                    sqlCon.Open();
                    sqlDataReader = sqlCheckAvailCommand.ExecuteReader();
                    if (sqlDataReader.Read() == false)
                    {
                        try
                        {
                            sqlDataReader.Close();
                            //sqlCon.Open();
                            sqlDataReader = sqlInsertCommand.ExecuteReader();
                            MessageBox.Show("Inserted !");
                            while (sqlDataReader.Read())
                            {

                            }
                            clearTextBoxes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! " + ex);
                        }
                    }
                    else {
                        
                        MessageBox.Show("Username already exists!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex);
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect information");
            }
            

        }
        void clearTextBoxes()
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

  
    }
}
