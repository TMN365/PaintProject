
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
            this.ShapesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.HelloUserLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dreptunghiButton1 = new System.Windows.Forms.RadioButton();
            this.cercbutton = new System.Windows.Forms.RadioButton();
            this.linieButton = new System.Windows.Forms.RadioButton();
            this.dreptunghiplinButton = new System.Windows.Forms.RadioButton();
            this.cercplinButton = new System.Windows.Forms.RadioButton();
            this.creionButton = new System.Windows.Forms.RadioButton();
            this.radieraButton = new System.Windows.Forms.RadioButton();
            this.colors_button = new System.Windows.Forms.Button();
            this.selectwidth_textBox = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu.Controls.Add(this.selectwidth_textBox);
            this.Menu.Controls.Add(this.colors_button);
            this.Menu.Controls.Add(this.radieraButton);
            this.Menu.Controls.Add(this.creionButton);
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
            this.Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(863, 115);
            this.Menu.TabIndex = 0;
            // 
            // ShapesLabel
            // 
            this.ShapesLabel.AutoSize = true;
            this.ShapesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapesLabel.Location = new System.Drawing.Point(260, 95);
            this.ShapesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShapesLabel.Name = "ShapesLabel";
            this.ShapesLabel.Size = new System.Drawing.Size(62, 17);
            this.ShapesLabel.TabIndex = 9;
            this.ShapesLabel.Text = "Shapes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cercplinButton);
            this.panel1.Controls.Add(this.dreptunghiplinButton);
            this.panel1.Controls.Add(this.linieButton);
            this.panel1.Controls.Add(this.cercbutton);
            this.panel1.Controls.Add(this.dreptunghiButton1);
            this.panel1.Location = new System.Drawing.Point(211, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 81);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
          
            // 
            // HelpBtn
            // 
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelpBtn.Location = new System.Drawing.Point(111, 71);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(86, 32);
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
            this.UndoBtn.Location = new System.Drawing.Point(111, 36);
            this.UndoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(86, 38);
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
            this.HelloUserLabel.Location = new System.Drawing.Point(2, 93);
            this.HelloUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HelloUserLabel.Name = "HelloUserLabel";
            this.HelloUserLabel.Size = new System.Drawing.Size(96, 17);
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
            this.CloseBtn.Location = new System.Drawing.Point(792, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(71, 27);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.Location = new System.Drawing.Point(762, 93);
            this.LogoutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(77, 23);
            this.LogoutLabel.TabIndex = 4;
            this.LogoutLabel.Text = "Logout";
         
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(766, 31);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(60, 59);
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
            this.SaveBtn.Location = new System.Drawing.Point(111, 2);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(86, 36);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dreptunghiButton1
            // 
            this.dreptunghiButton1.AutoSize = true;
            this.dreptunghiButton1.Location = new System.Drawing.Point(4, 4);
            this.dreptunghiButton1.Name = "dreptunghiButton1";
            this.dreptunghiButton1.Size = new System.Drawing.Size(75, 17);
            this.dreptunghiButton1.TabIndex = 0;
            this.dreptunghiButton1.TabStop = true;
            this.dreptunghiButton1.Text = "dreptunghi";
            this.dreptunghiButton1.UseVisualStyleBackColor = true;
            // 
            // cercbutton
            // 
            this.cercbutton.AutoSize = true;
            this.cercbutton.Location = new System.Drawing.Point(4, 28);
            this.cercbutton.Name = "cercbutton";
            this.cercbutton.Size = new System.Drawing.Size(46, 17);
            this.cercbutton.TabIndex = 1;
            this.cercbutton.TabStop = true;
            this.cercbutton.Text = "cerc";
            this.cercbutton.UseVisualStyleBackColor = true;
            // 
            // linieButton
            // 
            this.linieButton.AutoSize = true;
            this.linieButton.Location = new System.Drawing.Point(4, 52);
            this.linieButton.Name = "linieButton";
            this.linieButton.Size = new System.Drawing.Size(43, 17);
            this.linieButton.TabIndex = 2;
            this.linieButton.TabStop = true;
            this.linieButton.Text = "linie";
            this.linieButton.UseVisualStyleBackColor = true;
            // 
            // dreptunghiplinButton
            // 
            this.dreptunghiplinButton.AutoSize = true;
            this.dreptunghiplinButton.Location = new System.Drawing.Point(117, 20);
            this.dreptunghiplinButton.Name = "dreptunghiplinButton";
            this.dreptunghiplinButton.Size = new System.Drawing.Size(91, 17);
            this.dreptunghiplinButton.TabIndex = 3;
            this.dreptunghiplinButton.TabStop = true;
            this.dreptunghiplinButton.Text = "dreptunghiplin";
            this.dreptunghiplinButton.UseVisualStyleBackColor = true;
            // 
            // cercplinButton
            // 
            this.cercplinButton.AutoSize = true;
            this.cercplinButton.Location = new System.Drawing.Point(117, 43);
            this.cercplinButton.Name = "cercplinButton";
            this.cercplinButton.Size = new System.Drawing.Size(62, 17);
            this.cercplinButton.TabIndex = 4;
            this.cercplinButton.TabStop = true;
            this.cercplinButton.Text = "cercplin";
            this.cercplinButton.UseVisualStyleBackColor = true;
            // 
            // creionButton
            // 
            this.creionButton.AutoSize = true;
            this.creionButton.Location = new System.Drawing.Point(484, 29);
            this.creionButton.Name = "creionButton";
            this.creionButton.Size = new System.Drawing.Size(54, 17);
            this.creionButton.TabIndex = 10;
            this.creionButton.TabStop = true;
            this.creionButton.Text = "creion";
            this.creionButton.UseVisualStyleBackColor = true;
            // 
            // radieraButton
            // 
            this.radieraButton.AutoSize = true;
            this.radieraButton.Location = new System.Drawing.Point(484, 57);
            this.radieraButton.Name = "radieraButton";
            this.radieraButton.Size = new System.Drawing.Size(57, 17);
            this.radieraButton.TabIndex = 11;
            this.radieraButton.TabStop = true;
            this.radieraButton.Text = "radiera";
            this.radieraButton.UseVisualStyleBackColor = true;
            // 
            // colors_button
            // 
            this.colors_button.Location = new System.Drawing.Point(601, 26);
            this.colors_button.Name = "colors_button";
            this.colors_button.Size = new System.Drawing.Size(75, 23);
            this.colors_button.TabIndex = 12;
            this.colors_button.Text = "culori";
            this.colors_button.UseVisualStyleBackColor = true;
            // 
            // selectwidth_textBox
            // 
            this.selectwidth_textBox.Location = new System.Drawing.Point(589, 75);
            this.selectwidth_textBox.Name = "selectwidth_textBox";
            this.selectwidth_textBox.Size = new System.Drawing.Size(100, 20);
            this.selectwidth_textBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 386);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radieraButton;
        private System.Windows.Forms.RadioButton creionButton;
        private System.Windows.Forms.RadioButton cercplinButton;
        private System.Windows.Forms.RadioButton dreptunghiplinButton;
        private System.Windows.Forms.RadioButton linieButton;
        private System.Windows.Forms.RadioButton cercbutton;
        private System.Windows.Forms.RadioButton dreptunghiButton1;
        private System.Windows.Forms.TextBox selectwidth_textBox;
        private System.Windows.Forms.Button colors_button;
    }
}

