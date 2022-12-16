using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App
{
    public class Category
    {
        string categoryname;
        Bitmap categoryimage;

        public string CategoryName { get { return categoryname; } set { categoryname = value; } }
        public Bitmap CategoryImage { get { return categoryimage; } set { categoryimage = value; } }
        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
  