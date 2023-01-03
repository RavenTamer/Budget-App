using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Budget_App
{
    public class Category
    {
        string categoryName;
        Bitmap categoryImage;
        byte[] categoryImageData;


        public string CategoryName { get { return categoryName; } set { categoryName = value; } }
        
        [XmlIgnore]
        public Bitmap CategoryImage { get { return categoryImage; } set { categoryImage = value; ConvertBitmapToByteArray(); } }


        public byte[] CategoryImageData { get { return categoryImageData; } set { categoryImageData = value; ConvertByteArrayToBitmap();  } }


        public override string ToString()
        {
            return this.CategoryName;
        }


        private void ConvertBitmapToByteArray()
        {
            if (this.CategoryImage == null)
            {
                this.CategoryImageData = null;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    this.CategoryImage.Save(ms, ImageFormat.Bmp);
                    this.categoryImageData = ms.ToArray();
                }
            }
        }

        private void ConvertByteArrayToBitmap()
        {
            if (this.CategoryImageData == null)
            {
                this.CategoryImage = null;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(this.CategoryImageData))
                {
                    this.CategoryImage = new Bitmap(ms);
                }
            }
        }
    }
}
  