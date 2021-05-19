using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace multimedia
{
    
    public partial class copedForm : Form
    {
     static Image image;
        public static Image Image
        {
            set { image = value; }
            get { return image; }
        }
        public copedForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = pictureBox1.Name;
            saveFileDialog1.Filter = saveFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog1.FileName, format);
                this.Close();
            }
        }

        private void copedForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
        }
    }
}
