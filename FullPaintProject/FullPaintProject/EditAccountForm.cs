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
    public partial class EditAccountForm : Form
    {
        string username, password;
        bool check = false;

        public EditAccountForm(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }


        public EditAccountForm()
        {
        }

        public void confirmButton_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Olariu Gabriel\Dropbox\Facultate\AN3\Sem2\II\Proiect\FullPaintProject\FullPaintProject\PaintDataBase.mdf';Integrated Security=True");
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
                setCheckForTests(true);
            }
            else
            {
                MessageBox.Show("The fields are incorrect completed.");
                setCheckForTests(false);
            }
            clearTextbox();
        }

        public void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(username, password);
            mainMenuForm.ShowDialog();
            this.Close();
        }

        public void clearTextbox()
        {
            passTextBox.Text = changeMailTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = oldPasswordTextBox.Text = confPassTextBox.Text = "";
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
