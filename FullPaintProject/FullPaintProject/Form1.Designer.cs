
namespace FullPaintProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grosimetext = new System.Windows.Forms.TextBox();
            this.colorsbutton = new System.Windows.Forms.Button();
            this.ShapesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radieraButton = new System.Windows.Forms.RadioButton();
            this.cercplinButton = new System.Windows.Forms.RadioButton();
            this.creionButton = new System.Windows.Forms.RadioButton();
            this.dreptunghiplinButton = new System.Windows.Forms.RadioButton();
            this.linieButton = new System.Windows.Forms.RadioButton();
            this.cercbutton = new System.Windows.Forms.RadioButton();
            this.dreptunghiButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.HelloUserLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.grosimetext);
            this.Menu.Controls.Add(this.colorsbutton);
            this.Menu.Controls.Add(this.ShapesLabel);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.HelpBtn);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tools";
            // 
            // grosimetext
            // 
            this.grosimetext.Location = new System.Drawing.Point(800, 114);
            this.grosimetext.Margin = new System.Windows.Forms.Padding(4);
            this.grosimetext.Name = "grosimetext";
            this.grosimetext.Size = new System.Drawing.Size(55, 22);
            this.grosimetext.TabIndex = 10;
            this.grosimetext.TextChanged += new System.EventHandler(this.grosimetext_TextChanged);
            // 
            // colorsbutton
            // 
            this.colorsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorsbutton.Image = ((System.Drawing.Image)(resources.GetObject("colorsbutton.Image")));
            this.colorsbutton.Location = new System.Drawing.Point(800, 17);
            this.colorsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.colorsbutton.Name = "colorsbutton";
            this.colorsbutton.Size = new System.Drawing.Size(100, 47);
            this.colorsbutton.TabIndex = 1;
            this.colorsbutton.UseVisualStyleBackColor = true;
            this.colorsbutton.Click += new System.EventHandler(this.colorsbutton_Click);
            // 
            // ShapesLabel
            // 
            this.ShapesLabel.AutoSize = true;
            this.ShapesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapesLabel.Location = new System.Drawing.Point(375, 114);
            this.ShapesLabel.Name = "ShapesLabel";
            this.ShapesLabel.Size = new System.Drawing.Size(71, 20);
            this.ShapesLabel.TabIndex = 9;
            this.ShapesLabel.Text = "Shapes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radieraButton);
            this.panel1.Controls.Add(this.cercplinButton);
            this.panel1.Controls.Add(this.creionButton);
            this.panel1.Controls.Add(this.dreptunghiplinButton);
            this.panel1.Controls.Add(this.linieButton);
            this.panel1.Controls.Add(this.cercbutton);
            this.panel1.Controls.Add(this.dreptunghiButton1);
            this.panel1.Location = new System.Drawing.Point(281, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 100);
            this.panel1.TabIndex = 8;
            // 
            // radieraButton
            // 
            this.radieraButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.radieraButton.AutoSize = true;
            this.radieraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radieraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radieraButton.Image = ((System.Drawing.Image)(resources.GetObject("radieraButton.Image")));
            this.radieraButton.Location = new System.Drawing.Point(395, 9);
            this.radieraButton.Margin = new System.Windows.Forms.Padding(4);
            this.radieraButton.Name = "radieraButton";
            this.radieraButton.Size = new System.Drawing.Size(76, 58);
            this.radieraButton.TabIndex = 11;
            this.radieraButton.TabStop = true;
            this.radieraButton.UseVisualStyleBackColor = true;
            // 
            // cercplinButton
            // 
            this.cercplinButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cercplinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cercplinButton.Location = new System.Drawing.Point(143, 42);
            this.cercplinButton.Margin = new System.Windows.Forms.Padding(4);
            this.cercplinButton.Name = "cercplinButton";
            this.cercplinButton.Size = new System.Drawing.Size(132, 30);
            this.cercplinButton.TabIndex = 4;
            this.cercplinButton.TabStop = true;
            this.cercplinButton.Text = "Filled circle ●";
            this.cercplinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cercplinButton.UseVisualStyleBackColor = true;
            // 
            // creionButton
            // 
            this.creionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.creionButton.AutoSize = true;
            this.creionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creionButton.Image = ((System.Drawing.Image)(resources.GetObject("creionButton.Image")));
            this.creionButton.Location = new System.Drawing.Point(309, 9);
            this.creionButton.Margin = new System.Windows.Forms.Padding(4);
            this.creionButton.Name = "creionButton";
            this.creionButton.Size = new System.Drawing.Size(58, 58);
            this.creionButton.TabIndex = 10;
            this.creionButton.TabStop = true;
            this.creionButton.UseVisualStyleBackColor = true;
            // 
            // dreptunghiplinButton
            // 
            this.dreptunghiplinButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.dreptunghiplinButton.AutoSize = true;
            this.dreptunghiplinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dreptunghiplinButton.Location = new System.Drawing.Point(143, 5);
            this.dreptunghiplinButton.Margin = new System.Windows.Forms.Padding(4);
            this.dreptunghiplinButton.Name = "dreptunghiplinButton";
            this.dreptunghiplinButton.Size = new System.Drawing.Size(132, 29);
            this.dreptunghiplinButton.TabIndex = 3;
            this.dreptunghiplinButton.TabStop = true;
            this.dreptunghiplinButton.Text = "Filled rectangle ▬";
            this.dreptunghiplinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dreptunghiplinButton.UseVisualStyleBackColor = true;
            // 
            // linieButton
            // 
            this.linieButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.linieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linieButton.Location = new System.Drawing.Point(5, 66);
            this.linieButton.Margin = new System.Windows.Forms.Padding(4);
            this.linieButton.Name = "linieButton";
            this.linieButton.Size = new System.Drawing.Size(100, 30);
            this.linieButton.TabIndex = 2;
            this.linieButton.TabStop = true;
            this.linieButton.Text = "Line ━";
            this.linieButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linieButton.UseVisualStyleBackColor = true;
            // 
            // cercbutton
            // 
            this.cercbutton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cercbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cercbutton.Location = new System.Drawing.Point(5, 34);
            this.cercbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cercbutton.Name = "cercbutton";
            this.cercbutton.Size = new System.Drawing.Size(100, 30);
            this.cercbutton.TabIndex = 1;
            this.cercbutton.TabStop = true;
            this.cercbutton.Text = "Circle ○";
            this.cercbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cercbutton.UseVisualStyleBackColor = true;
            // 
            // dreptunghiButton1
            // 
            this.dreptunghiButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dreptunghiButton1.AutoSize = true;
            this.dreptunghiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dreptunghiButton1.Location = new System.Drawing.Point(5, 5);
            this.dreptunghiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.dreptunghiButton1.Name = "dreptunghiButton1";
            this.dreptunghiButton1.Size = new System.Drawing.Size(100, 29);
            this.dreptunghiButton1.TabIndex = 0;
            this.dreptunghiButton1.TabStop = true;
            this.dreptunghiButton1.Text = "Rectangle ▭";
            this.dreptunghiButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dreptunghiButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
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
            this.HelpBtn.Location = new System.Drawing.Point(148, 87);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(115, 39);
            this.HelpBtn.TabIndex = 7;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
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
            this.SaveBtn.Size = new System.Drawing.Size(115, 44);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1152, 660);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Menu;
        public System.Windows.Forms.Label HelloUserLabel;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.Button LogoutBtn;
        public System.Windows.Forms.Label LogoutLabel;
        public System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.Button HelpBtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ShapesLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radieraButton;
        public System.Windows.Forms.RadioButton creionButton;
        public System.Windows.Forms.RadioButton cercplinButton;
        public System.Windows.Forms.RadioButton dreptunghiplinButton;
        public System.Windows.Forms.RadioButton linieButton;
        public System.Windows.Forms.RadioButton cercbutton;
        public System.Windows.Forms.RadioButton dreptunghiButton1;
        public System.Windows.Forms.Button colorsbutton;
        public System.Windows.Forms.TextBox grosimetext;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

