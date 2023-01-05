using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Budget_App
{
    public partial class MainForm : Form
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
                if (budgetList != null)
                {
                    int x = 12;
                    int y = 3;
                    int count = 0;

                    foreach (Budget budget in budgetList)
                    {
                        if (budget != null)
                        {
                            // 
                            // BudgetBox
                            // 
                            GroupBox BudgetBox = new GroupBox();
                            BudgetBox.Controls.Add(TimeLabel);
                            BudgetBox.Controls.Add(this.NoteButton);
                            BudgetBox.Controls.Add(this.CurrencyLabel);
                            BudgetBox.Controls.Add(this.AmountLabel);
                            BudgetBox.Controls.Add(this.CategoryPicture);
                            BudgetBox.Location = new System.Drawing.Point(y, x);
                            BudgetBox.Name = "BudgetBox"+count;
                            BudgetBox.Size = new System.Drawing.Size(331, 79);
                            BudgetBox.TabIndex = 0;
                            BudgetBox.TabStop = false;
                            BudgetBox.Text = "Category";
                            // 
                            // AmountLabel
                            // 
                            this.AmountLabel.AutoSize = true;
                            this.AmountLabel.Location = new System.Drawing.Point(y+71, x+14);
                            this.AmountLabel.Name = "AmountLabel" + count;
                            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
                            this.AmountLabel.TabIndex = 1;
                            this.AmountLabel.Text = Convert.ToString(budget.MoneyAmount);
                            // 
                            // CategoryPicture
                            // 
                            if (budget.Category.CategoryImage != null)
                            {
                                this.CategoryPicture.Image = budget.Category.CategoryImage;
                            }
                            else
                            {
                                this.CategoryPicture.Image = Properties.Resources.placeholder_cropped;
                            }
                            this.CategoryPicture.Location = new System.Drawing.Point(y+3, x+11);
                            this.CategoryPicture.Name = "CategoryPicture" + count;
                            this.CategoryPicture.Size = new System.Drawing.Size(50, 50);
                            this.CategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            this.CategoryPicture.TabIndex = 0;
                            this.CategoryPicture.TabStop = false;
                            // 
                            // CurrencyLabel
                            // 
                            this.CurrencyLabel.AutoSize = true;
                            this.CurrencyLabel.Location = new System.Drawing.Point(y+132, x+14);
                            this.CurrencyLabel.Name = "CurrencyLabel" + count;
                            this.CurrencyLabel.Size = new System.Drawing.Size(72, 20);
                            this.CurrencyLabel.TabIndex = 2;
                            this.CurrencyLabel.Text = budget.Currency;
                            // 
                            // NoteButton
                            // 
                            this.NoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            this.NoteButton.Location = new System.Drawing.Point(y+285, x+11);
                            this.NoteButton.Name = "NoteButton" + count;
                            this.NoteButton.Size = new System.Drawing.Size(37, 37);
                            this.NoteButton.TabIndex = 3;
                            this.NoteButton.Text = "≡";
                            this.NoteButton.UseVisualStyleBackColor = true;
                            // 
                            // TimeLabel
                            // 
                            TimeLabel.AutoSize = true;
                            TimeLabel.Location = new System.Drawing.Point(x+71, y+41);
                            TimeLabel.Name = "TimeLabel" + count;
                            TimeLabel.Size = new System.Drawing.Size(43, 20);
                            TimeLabel.TabIndex = 4;
                            TimeLabel.Text = budget.Time;
                            
                            x += 10;
                            count++;
                        }
                        
                    }
                }

                stream.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateBudget budget = new CreateBudget(this);
            budget.Show();
        }
    }
}
