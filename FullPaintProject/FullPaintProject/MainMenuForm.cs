using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FullPaintProject
{
    public partial class MainMenuForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Alex\Desktop\An3Sem2\II\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf';Integrated Security=True";
        string username;
        string password;
        string path;
        public MainMenuForm(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            this.path = System.Environment.CurrentDirectory; path = Path.GetDirectoryName(path); path = Path.GetDirectoryName(path);
            string[] filePaths = Directory.GetFiles(path, idReturn() + "_*.jpg");
            foreach (String name in filePaths)
            {
                picturesListBox.Items.Add(name);
            }            
        }

        public void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        public void editDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAccountForm editAccountFrom = new EditAccountForm(username, password);
            editAccountFrom.ShowDialog();
            this.Close();

        }

        public void newButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 drawingForm = new Form1(username, password);
            drawingForm.ShowDialog();
            this.Close();
        }


        private string idReturn()
        {
            string id = "";
            string selectQuery = "Select * from AccountTable where Username= '" + username + "' ";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand sqlIdCommand = new SqlCommand(selectQuery, sqlCon);

            SqlDataReader sqlDataReader;
            DataSet dataSet = new DataSet();
            try
            {
                sqlCon.Open();
                sqlDataReader = sqlIdCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    id = sqlDataReader["Id"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Server problem!");
            }
            return id;
        }

        private void picturesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if(picturesListBox.SelectedItem == null)
                {
                    return;
                }
                pictureBox.Image = Image.FromFile(picturesListBox.SelectedItem.ToString());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
