using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_App
{
    public partial class CreateCategory : Form
    {
        CreateBudget createbudget;
        public CreateCategory(CreateBudget form)
        {
            InitializeComponent();
            createbudget = form;
        }
        Bitmap neuesbild;
        private void UserImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.wav; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.wav; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                double x = 0;
                double zielhoehe = 0;
                double zielbreite = 0;
                Bitmap newimage = new Bitmap(open.FileName);
                double newimageheight = Convert.ToDouble(newimage.Height);
                double maxheight = Convert.ToDouble(UserImage.MaximumSize.Height);
                double newimagewidth = Convert.ToDouble(newimage.Width);
                double maxwidth = Convert.ToDouble(UserImage.MaximumSize.Width);
                if (newimage.Height > UserImage.MaximumSize.Height && newimage.Height > newimage.Width)
                {
                    x = newimageheight / maxheight;	                    //= Verhältnis
                    zielhoehe = newimageheight / x;			            //= UserImageMax.height
                    zielbreite = newimagewidth / x;		                //=width proportional zu height
                }
                if (newimage.Width > UserImage.MaximumSize.Width && newimage.Width > newimage.Height)
                {
                    x = newimagewidth / maxwidth;
                    zielbreite = newimagewidth / x;
                    zielhoehe = newimageheight / x;
                }
                if (newimage.Height > UserImage.MaximumSize.Height && newimage.Height == newimage.Width)
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

                neuesbild = scaledimg;
                UserImage.Image = neuesbild;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Category newcat = new Category();
            newcat.CategoryImage = neuesbild;
            newcat.CategoryName = CategoryNameText.Text;
            createbudget.budgetcategories.Add(newcat);
            createbudget.CategoryBox.Items.Add(newcat.ToString());
        }
    }
}
