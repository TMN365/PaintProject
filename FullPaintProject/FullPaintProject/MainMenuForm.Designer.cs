
namespace FullPaintProject
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.picturesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(169, 221);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(163, 28);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New creation";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(424, 419);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(162, 29);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.Location = new System.Drawing.Point(169, 322);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(163, 29);
            this.editDataButton.TabIndex = 4;
            this.editDataButton.Text = "Edit data";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(668, 221);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(349, 227);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // picturesListBox
            // 
            this.picturesListBox.FormattingEnabled = true;
            this.picturesListBox.ItemHeight = 16;
            this.picturesListBox.Location = new System.Drawing.Point(54, 31);
            this.picturesListBox.Name = "picturesListBox";
            this.picturesListBox.Size = new System.Drawing.Size(963, 132);
            this.picturesListBox.TabIndex = 6;
            this.picturesListBox.SelectedIndexChanged += new System.EventHandler(this.picturesListBox_SelectedIndexChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FullPaintProject.Properties.Resources.BackgroundMainMenuForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picturesListBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.newButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox picturesListBox;
    }
}