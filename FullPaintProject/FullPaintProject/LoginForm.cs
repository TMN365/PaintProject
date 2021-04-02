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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Faculta\UTCN\An3Sem2\II\ProiectPaint02.04\PaintProject\FullPaintProject\FullPaintProject\Database1.mdf;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
                usernameTextBox.Text = "";
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
                passwordTextBox.Text = "";
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
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetPasswordFromUsername"/*Queryul meu*/, sqlConnection);

                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim()); // Ia valoarea din text box si o baga in query
                    sqlCommand.ExecuteNonQuery();
                }// aici am facut un query

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read()) // de-an pulea readerul
                    {
                        while (reader.Read())
                        {
                            string findCours = reader["Username"].ToString();
                            /*
                             * si salvez mail + password
                             * Creare obiect cu toate campurile
                             */

                        }
                    }
                    /*else//Nu mai stiu ce era aici
                    {
                        List<Note> note = new List<Note>();
                        int controlNumber = this.loggedStudent.CurentYear * 10 + this.loggedStudent.CurentSemester;
                        if (controlNumber >= 11)
                            note.AddRange(getY1S1Notes());
                        if (controlNumber >= 12)
                            note.AddRange(getY1S2Notes());
                        if (controlNumber >= 21)
                            note.AddRange(getY2S1Notes());
                        if (controlNumber >= 22)
                            note.AddRange(getY2S2Notes());
                        if (controlNumber >= 31)
                            note.AddRange(getY3S1Notes());
                        if (controlNumber >= 32)
                            note.AddRange(getY3S2Notes());
                        if (controlNumber >= 41)
                            note.AddRange(getY4S1Notes());
                        if (controlNumber >= 42)
                            note.AddRange(getY4S2Notes());
                        for (int i = 0; i <= note.Count - 1; i++)
                            note.ElementAt(i).setNote(-1);
                        this.LoggedStudent.Notes = note;
                    }
                    */
                }
            }
        }
    }
}
