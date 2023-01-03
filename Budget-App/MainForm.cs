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

namespace Budget_App
{
    public partial class MainForm : Form
    {
        public List<Budget> budgetList = new List<Budget>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateBudget budget = new CreateBudget(this);
            budget.Show();
        }
    }
}
