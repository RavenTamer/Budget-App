using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Budget_App
{
    public partial class CreateBudget : Form
    {
        public List<Category> budgetcategories = new List<Category>();
        public CreateBudget()
        {
            InitializeComponent();
            if (budgetcategories != null)
            {
                foreach(Category category in budgetcategories)
                CategoryBox.Items.Add(category.ToString());
            }
            CategoryBox.Items.Add("+");
        }
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(CategoryBox.SelectedItem) == "+")
            {
                CreateCategory createcategory = new CreateCategory(this);
                createcategory.Show();
            }
        }
            
    }
}
