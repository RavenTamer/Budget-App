namespace Budget_App
{
    partial class CreateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategory));
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.CategoryNameText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UserImage
            // 
            this.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
            this.UserImage.Location = new System.Drawing.Point(38, 12);
            this.UserImage.MaximumSize = new System.Drawing.Size(100, 100);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(100, 100);
            this.UserImage.TabIndex = 1;
            this.UserImage.TabStop = false;
            this.UserImage.Click += new System.EventHandler(this.UserImage_Click);
            // 
            // CategoryNameText
            // 
            this.CategoryNameText.Location = new System.Drawing.Point(12, 127);
            this.CategoryNameText.Name = "CategoryNameText";
            this.CategoryNameText.Size = new System.Drawing.Size(153, 20);
            this.CategoryNameText.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(50, 163);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 198);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CategoryNameText);
            this.Controls.Add(this.UserImage);
            this.Name = "CreateCategory";
            this.Text = "CreateCategory";
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.TextBox CategoryNameText;
        private System.Windows.Forms.Button AddButton;
    }
}