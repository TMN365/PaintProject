using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
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
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        #endregion

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
