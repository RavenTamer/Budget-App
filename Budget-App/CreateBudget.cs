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
using System.Xml.Linq;
using System.Xml.Serialization;
using ComponentFactory.Krypton.Toolkit;

namespace Budget_App
{
    public partial class CreateBudget : KryptonForm
    {
        MainForm mainForm;
        public List<Category> budgetcategories = new List<Category>();

        public CreateBudget(MainForm form)
        {
            InitializeComponent();

            XmlSerializer xml = new XmlSerializer(typeof(List<Category>));

            if (File.Exists("Categories.xml"))
            {
                FileStream stream = File.OpenRead("Categories.xml");

                budgetcategories = (List<Category>)xml.Deserialize(stream);
                if (budgetcategories != null)
                {
                    foreach (Category category in budgetcategories)
                        CategoryBox.Items.Add(category);
                }

                stream.Close();
            }

            mainForm = form;

            CurrencyBox.Items.Add("CHF");
            CurrencyBox.Items.Add("€");
            CurrencyBox.Items.Add("£");
            CurrencyBox.Items.Add("$");

            TimeBox.Items.Add("Daily");
            TimeBox.Items.Add("Weekly");
            TimeBox.Items.Add("Monthly");
            TimeBox.Items.Add("Quarterly");
            TimeBox.Items.Add("Semesterly");
            TimeBox.Items.Add("Yearly");
            

        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CreateCategory createcategory = new CreateCategory(this);
            createcategory.Show();
            Hide();
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            Category c = CategoryBox.SelectedItem as Category;

            if (c != null) 
            { 

                if (c.CategoryImage != null)
                    this.CategoryPicture.Image = c.CategoryImage;
                else
                    this.CategoryPicture.Image = this.CategoryPicture.InitialImage;

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CategoryBox.Text != "")
            {
            Budget budget = new Budget();
            budget.Category = CategoryBox.SelectedItem as Category;
            budget.Currency = (string)CurrencyBox.SelectedItem;
            budget.Time = (string)TimeBox.SelectedItem;
            budget.Note = NoteBox.Text;
            budget.MoneyAmount = MoneyAmountNumeric.Value;
            mainForm.budgetList.Add(budget);

            XmlSerializer xml = new XmlSerializer(typeof(List<Budget>));
            FileStream stream = File.Open("Budgets.xml", FileMode.OpenOrCreate);
            xml.Serialize(stream, mainForm.budgetList);
            stream.Close();

            mainForm.Show();
            this.Close();
            }
            else
            {
                MessageBox.Show("Please select a Category!!!");
            }

        }

        private void CreateBudget_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
