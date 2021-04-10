
namespace practice_paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.HelloUserLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShapesLabel = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu.Controls.Add(this.ShapesLabel);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.HelpBtn);
            this.Menu.Controls.Add(this.UndoBtn);
            this.Menu.Controls.Add(this.HelloUserLabel);
            this.Menu.Controls.Add(this.CloseBtn);
            this.Menu.Controls.Add(this.LogoutLabel);
            this.Menu.Controls.Add(this.LogoutBtn);
            this.Menu.Controls.Add(this.SaveBtn);
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1151, 142);
            this.Menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelpBtn.Location = new System.Drawing.Point(148, 87);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(114, 40);
            this.HelpBtn.TabIndex = 7;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.FlatAppearance.BorderSize = 0;
            this.UndoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.UndoBtn.Image = ((System.Drawing.Image)(resources.GetObject("UndoBtn.Image")));
            this.UndoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UndoBtn.Location = new System.Drawing.Point(148, 44);
            this.UndoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(114, 47);
            this.UndoBtn.TabIndex = 6;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // HelloUserLabel
            // 
            this.HelloUserLabel.AutoSize = true;
            this.HelloUserLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.HelloUserLabel.Location = new System.Drawing.Point(3, 114);
            this.HelloUserLabel.Name = "HelloUserLabel";
            this.HelloUserLabel.Size = new System.Drawing.Size(125, 21);
            this.HelloUserLabel.TabIndex = 1;
            this.HelloUserLabel.Text = "Hello, username";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CloseBtn.FlatAppearance.BorderSize = 4;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.Location = new System.Drawing.Point(1056, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(95, 33);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.Location = new System.Drawing.Point(1016, 114);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(97, 29);
            this.LogoutLabel.TabIndex = 4;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(1021, 38);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 73);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.Location = new System.Drawing.Point(148, 2);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(114, 44);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(281, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // ShapesLabel
            // 
            this.ShapesLabel.AutoSize = true;
            this.ShapesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapesLabel.Location = new System.Drawing.Point(347, 117);
            this.ShapesLabel.Name = "ShapesLabel";
            this.ShapesLabel.Size = new System.Drawing.Size(71, 20);
            this.ShapesLabel.TabIndex = 9;
            this.ShapesLabel.Text = "Shapes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 475);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label HelloUserLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ShapesLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

