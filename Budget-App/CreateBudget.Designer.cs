namespace Budget_App
{
    partial class CreateBudget
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
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.CurrencyBox = new System.Windows.Forms.ComboBox();
            this.MoneyAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CategoryPicture = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyAmountNumeric)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(51, 287);
            this.NoteBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(278, 70);
            this.NoteBox.TabIndex = 1;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(98, 177);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(180, 28);
            this.CategoryBox.TabIndex = 2;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.FormattingEnabled = true;
            this.CurrencyBox.Location = new System.Drawing.Point(138, 215);
            this.CurrencyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(97, 28);
            this.CurrencyBox.TabIndex = 3;
            // 
            // MoneyAmountNumeric
            // 
            this.MoneyAmountNumeric.Location = new System.Drawing.Point(98, 367);
            this.MoneyAmountNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoneyAmountNumeric.Maximum = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.MoneyAmountNumeric.Name = "MoneyAmountNumeric";
            this.MoneyAmountNumeric.Size = new System.Drawing.Size(182, 26);
            this.MoneyAmountNumeric.TabIndex = 4;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.TimeBox);
            this.ControlPanel.Controls.Add(this.CategoryPicture);
            this.ControlPanel.Controls.Add(this.SubmitButton);
            this.ControlPanel.Controls.Add(this.MoneyAmountNumeric);
            this.ControlPanel.Controls.Add(this.NoteBox);
            this.ControlPanel.Controls.Add(this.CurrencyBox);
            this.ControlPanel.Controls.Add(this.CategoryBox);
            this.ControlPanel.Location = new System.Drawing.Point(92, 18);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(376, 459);
            this.ControlPanel.TabIndex = 5;
            // 
            // CategoryPicture
            // 
            this.CategoryPicture.Image = global::Budget_App.Properties.Resources.placeholder_cropped;
            this.CategoryPicture.InitialImage = global::Budget_App.Properties.Resources.placeholder_cropped;
            this.CategoryPicture.Location = new System.Drawing.Point(112, 5);
            this.CategoryPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryPicture.Name = "CategoryPicture";
            this.CategoryPicture.Size = new System.Drawing.Size(150, 154);
            this.CategoryPicture.TabIndex = 6;
            this.CategoryPicture.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(138, 403);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(99, 35);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(127, 251);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 28);
            this.TimeBox.TabIndex = 7;
            // 
            // CreateBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 484);
            this.Controls.Add(this.ControlPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateBudget";
            this.Text = "CreateBudget";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyAmountNumeric)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.ComboBox CurrencyBox;
        private System.Windows.Forms.NumericUpDown MoneyAmountNumeric;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox CategoryPicture;
        public System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.ComboBox TimeBox;
    }
}