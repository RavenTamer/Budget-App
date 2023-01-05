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

namespace Budget_App
{
    public partial class CreateBudget : Form
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
            CategoryBox.Items.Add("+");
        }
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(CategoryBox.SelectedItem) == "+")
            {
                CreateCategory createcategory = new CreateCategory(this);
                createcategory.Show();
            }


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
        }
    }
}
