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


namespace FullPaintProject
{
    public partial class Form1 : Form
    {
        int x = -1;
        int y = -1;
        int h, w, xnou, ynou;
        ColorDialog colorDialog = new ColorDialog();
        float grosime = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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
        public Form1()
        {
            InitializeComponent();
           grosimetext.Text= Convert.ToString(5);
          
        }

        #region Logout+Close
        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        #region save, undo, help
        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        // Meniu CUlori
        private void colorsbutton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorsbutton.BackColor = colorDialog.Color;
            p.Color = colorDialog.Color;
        }

        private void grosimetext_TextChanged(object sender, EventArgs e)
        {
            grosime = Convert.ToInt32(grosimetext.Text);
        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            miscare = true;
            p.Width = grosime;
        }
            bool miscare = true;
        
            private void Form1_MouseUp(object sender, MouseEventArgs e)
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

