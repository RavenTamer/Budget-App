namespace Budget_App
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CategoryPicture = new System.Windows.Forms.PictureBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.NoteButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(40, 31);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Location = new System.Drawing.Point(0, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(100, 23);
            this.AmountLabel.TabIndex = 0;
            // 
            // CategoryPicture
            // 
            this.CategoryPicture.Location = new System.Drawing.Point(0, 0);
            this.CategoryPicture.Name = "CategoryPicture";
            this.CategoryPicture.Size = new System.Drawing.Size(100, 50);
            this.CategoryPicture.TabIndex = 0;
            this.CategoryPicture.TabStop = false;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.Location = new System.Drawing.Point(0, 0);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(100, 23);
            this.CurrencyLabel.TabIndex = 0;
            // 
            // NoteButton
            // 
            this.NoteButton.Location = new System.Drawing.Point(0, 0);
            this.NoteButton.Name = "NoteButton";
            this.NoteButton.Size = new System.Drawing.Size(75, 23);
            this.NoteButton.TabIndex = 0;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(0, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(100, 23);
            this.TimeLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(303, 341);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Budget-App";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.PictureBox CategoryPicture;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Button NoteButton;
        private System.Windows.Forms.Label TimeLabel;
    }
}

