using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Budget_App
{

    public partial class MainForm : KryptonForm
    {
        public List<Budget> budgetList = new List<Budget>();

        public MainForm()
        {
            InitializeComponent();
            
            XmlSerializer xml = new XmlSerializer(typeof(List<Budget>));

            if (File.Exists("Budgets.xml"))
            {
                FileStream stream = File.OpenRead("Budgets.xml");
                budgetList = (List<Budget>)xml.Deserialize(stream);
                stream.Close();
            }
            DrawBudgetList();
        }
        private void DeleteButton_RemoveBudget(object sender, EventArgs e)
        {
            Button budgetdelete = (Button)sender;
            budgetList.RemoveAt((int)budgetdelete.Tag);
            XmlSerializer xml = new XmlSerializer(typeof(List<Budget>));
            TextWriter writer = File.CreateText("Budgets.xml");
            xml.Serialize(writer, budgetList);
            writer.Close();
            DrawBudgetList();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateBudget budget = new CreateBudget(this);
            budget.Show();
            Hide();
        }
        private void NoteButton_Click(object sender, EventArgs e)
        {
            Button note = (Button)sender;
            Budget budget = budgetList[Convert.ToInt32(note.Tag)];
            string noteText = budget.ToString();
            MessageBox.Show(noteText);
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            DrawBudgetList();
        }
        public void DrawBudgetList()
        {
            int count = 0;
            BudgetPanel.Controls.Clear();
            if(budgetList.Count != 0) {
                foreach (Budget budget in budgetList)
                {
                    if (budget != null)
                    {
                        // 
                        // BudgetBox
                        // 
                        BudgetBox = new GroupBox();
                        BudgetBox.Name = "BudgetBox";
                        BudgetBox.Size = new System.Drawing.Size(270, 79);
                        BudgetBox.TabIndex = 0;
                        BudgetBox.TabStop = false;
                        BudgetBox.Text = budget.Category.CategoryName;
                        BudgetPanel.Controls.Add(BudgetBox);
                        // 
                        // AmountLabel
                        // 
                        AmountLabel = new Label();
                        AmountLabel.AutoSize = true;
                        AmountLabel.Location = new System.Drawing.Point(70, 30);
                        AmountLabel.Name = "AmountLabel";
                        AmountLabel.Size = new System.Drawing.Size(65, 20);
                        AmountLabel.TabIndex = 1;
                        AmountLabel.Text = Convert.ToString(budget.MoneyAmount);
                        BudgetBox.Controls.Add(AmountLabel);
                        // 
                        // CategoryPicture
                        //
                        CategoryPicture = new PictureBox();
                        CategoryPicture.Size = new System.Drawing.Size(50, 50); 
                        CategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        CategoryPicture.Tag = count;
                        CategoryPicture.Location = new System.Drawing.Point(5, 20);

                     
                        if (budget.Category.CategoryImage != null)
                        {
                            if((int)CategoryPicture.Tag == count) 
                            {
                                double x;
                                double zielhoehe = 0;
                                double zielbreite = 0;
                                Bitmap newimage = new Bitmap(budget.Category.CategoryImage);
                                double newimageheight = Convert.ToDouble(newimage.Height);
                                double newimagewidth = Convert.ToDouble(newimage.Width);
                                double maxheight = Convert.ToDouble(CategoryPicture.Size.Height);
                                double maxwidth = Convert.ToDouble(CategoryPicture.Size.Width);

                                if (newimageheight > 50 || newimagewidth > 50)
                                {


                                    if (newimage.Height > CategoryPicture.Size.Height && newimage.Height > newimage.Width)
                                    {
                                        x = newimageheight / maxheight;                     //= Verhältnis
                                        zielhoehe = newimageheight / x;                     //= UserImageMax.height
                                        zielbreite = newimagewidth / x;                     //= width proportional zu height
                                    }
                                    if (newimage.Width > CategoryPicture.Size.Width && newimage.Width > newimage.Height)
                                    {
                                        x = newimagewidth / maxwidth;
                                        zielbreite = newimagewidth / x;
                                        zielhoehe = newimageheight / x;
                                    }
                                    if (newimage.Height > CategoryPicture.Size.Height && newimage.Height == newimage.Width)
                                    {
                                        x = newimageheight / maxheight;
                                        zielhoehe = newimageheight / x;
                                        zielbreite = newimagewidth / x;
                                    }

                                    Bitmap scaledimg = new Bitmap((int)(zielbreite), (int)(zielhoehe));


                                    using (Graphics gNew = Graphics.FromImage(scaledimg))
                                    {
                                        gNew.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                        gNew.DrawImage(newimage, new Rectangle(0, 0, (int)(zielbreite), (int)(zielhoehe)));
                                    }

                                    CategoryPicture.Image = scaledimg;
                                }
                            }
                        }
                        else
                        {
                            CategoryPicture.Image = Properties.Resources.placeholder_cropped;
                        }
                        CategoryPicture.Name = "CategoryPicture";
                        CategoryPicture.TabIndex = 0;
                        CategoryPicture.TabStop = false;
                        BudgetBox.Controls.Add(CategoryPicture);
                        // 
                        // CurrencyLabel
                        // 
                        CurrencyLabel = new Label();
                        CurrencyLabel.AutoSize = true;
                        CurrencyLabel.Location = new System.Drawing.Point(120, 30);
                        CurrencyLabel.Name = "CurrencyLabel";
                        CurrencyLabel.Size = new System.Drawing.Size(72, 20);
                        CurrencyLabel.TabIndex = 2;
                        CurrencyLabel.Text = budget.Currency;
                        BudgetBox.Controls.Add(CurrencyLabel);
                        // 
                        // NoteButton
                        // 
                        NoteButton = new Button();
                        NoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        NoteButton.Location = new System.Drawing.Point(200, 25);
                        NoteButton.Name = "NoteButton";
                        NoteButton.Size = new System.Drawing.Size(37, 37);
                        NoteButton.TabIndex = 3;
                        NoteButton.Text = "≡";
                        NoteButton.Tag = count;
                        NoteButton.UseVisualStyleBackColor = true;
                        BudgetBox.Controls.Add(NoteButton);
                        NoteButton.Click += NoteButton_Click;
                        // 
                        // TimeLabel
                        // 
                        TimeLabel = new Label();
                        TimeLabel.AutoSize = true;
                        TimeLabel.Name = "TimeLabel";
                        TimeLabel.Size = new System.Drawing.Size(43, 20);
                        TimeLabel.Location = new System.Drawing.Point(99, 55);
                        TimeLabel.TabIndex = 4;
                        TimeLabel.Text = budget.Time;
                        BudgetBox.Controls.Add(TimeLabel);
                        // 
                        // DeleteButton
                        // 
                        DeleteButton = new Button();
                        DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        DeleteButton.Location = new System.Drawing.Point(70, 50);
                        DeleteButton.Name = "DeleteButton";
                        DeleteButton.Size = new System.Drawing.Size(20, 20);
                        DeleteButton.TabIndex = 3;
                        DeleteButton.Text = "-";
                        DeleteButton.UseVisualStyleBackColor = true;
                        this.Controls.Add(DeleteButton);
                        BudgetBox.Controls.Add(DeleteButton);
                        DeleteButton.Click += DeleteButton_RemoveBudget;
                        DeleteButton.Tag = (int)count;
                        count++;
                    }
                }
            }               
            else
            {
                //
                // EmptyLabel
                //
                EmptyLabel = new Label();
                EmptyLabel.AutoSize = true;
                EmptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                EmptyLabel.Name = "EmptyLabel";
                EmptyLabel.Text = "There are no Budgets. \nClick the '+' Button to create a new Budget";
                BudgetPanel.Controls.Add(EmptyLabel);
            }
        }
    }
}

