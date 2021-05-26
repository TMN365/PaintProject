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
        string checkString;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Alex\Desktop\An3Sem2\II\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf';Integrated Security=True";
        public RegisterForm()
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


        public void confirmButton_Click(object sender, EventArgs e)
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
                            setCheckForTests("inserted");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! " + ex);
                            setCheckForTests("error reader");
                        }
                    }
                    else {
                        
                        MessageBox.Show("Username already exists!");
                        setCheckForTests("Username already exists!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex);
                    setCheckForTests("error2");
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect information");
                setCheckForTests("Incorrect information");
            }
            

        }
        public void clearTextBoxes()
        {
            textBoxPassword.Text = textBoxUsername.Text = textBoxFirstName.Text = textBoxLastName.Text = textBoxEmail.Text = "";
        }


        public void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
        public string getCheckForTests()
        {
            return checkString;
        }
        public void setCheckForTests(string variable)
        {
            checkString = variable;
        }


    }
}
