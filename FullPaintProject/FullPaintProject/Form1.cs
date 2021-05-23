using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;

namespace FullPaintProject
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Faculta\UTCN\An3Sem2\II\PaintProject22.05\PaintProject\FullPaintProject\FullPaintProject\PaintDataBase.mdf;Integrated Security=True";
        string username, password;
        string id;
        int x = -1;
        int y = -1;
        int h, w, xnou, ynou;
        ColorDialog colorDialog = new ColorDialog();
        float grosime = 0;

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grafica = CreateGraphics();
            if (creionButton.Checked && miscare && x != -1 && y != -1)
            {

                grafica.DrawLine(p, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }
            if (radieraButton.Checked && miscare && x != -1 && y != -1)
            {
                Pen objMyPen = new Pen(Color.White);
                objMyPen.Width = grosime;
                objMyPen.DashStyle = DashStyle.Solid;
                grafica.DrawLine(objMyPen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        Pen p = new Pen(Color.Black);
        public Form1(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            grosimetext.Text= Convert.ToString(5);
            HelloUserLabel.Text = "Hello, " + username;


        }

        #region Logout+Close
        public void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        public void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(username,password);
            mainMenuForm.ShowDialog();
            this.Close();

        }
        #endregion

        #region save, undo, help
        public void SaveBtn_Click(object sender, EventArgs e)
        {
            string selectQuery = "Select * from AccountTable where Username= '" + username + "' AND Password = '"+password+"' ";
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
                    this.id = sqlDataReader["Id"].ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error! " + e);
            }
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 144, 0, 0, new Size(this.Width+215, this.Height-11));
            string fileName = "\\" + id + "_" + Guid.NewGuid() + ".jpg";
            string path = System.Environment.CurrentDirectory;      path = Path.GetDirectoryName(path);     path = Path.GetDirectoryName(path);
            //MessageBox.Show(path);
            bitmap.Save(path + fileName);
            MessageBox.Show("Image saved.");
        }


        public void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to https://www.camera_priza.ro");
        }
        #endregion

        // Meniu CUlori
        public void colorsbutton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorsbutton.BackColor = colorDialog.Color;
            p.Color = colorDialog.Color;
        }

        public void grosimetext_TextChanged(object sender, EventArgs e)
        {
            grosime = Convert.ToInt32(grosimetext.Text);
        }

     

        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            miscare = true;
            p.Width = grosime;
        }
            bool miscare = true;
        
         public void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            miscare = false;
            xnou = e.X;
            ynou = e.Y;
            h = e.X - x;
            w = e.Y - y;
            Graphics g = CreateGraphics();


            Rectangle r = new Rectangle(x, y, h, w);

            if (dreptunghiButton1.Checked)
            {
                g.DrawRectangle(p, r);
            }
            if (cercbutton.Checked)
            {
                g.DrawEllipse(p, r);
            }
            if (linieButton.Checked)
            {

                Point P1 = new Point(x, y);
                Point P2 = new Point(xnou, ynou);
                g.DrawLine(p, P1, P2);
            }
            if (dreptunghiplinButton.Checked)
            {

                g.FillRectangle(new SolidBrush(colorDialog.Color), r);
            }

            if (cercplinButton.Checked)
            {
                g.FillEllipse(new SolidBrush(colorDialog.Color), r);
            }
        }

       
       
    }


}

