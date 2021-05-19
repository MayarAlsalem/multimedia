using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace multimedia
{

    public partial class ZoomForm : Form
    {
        bool cheekZoom = false;
        static Image img;
        public Image Image
        {
            set { img = value; }
            get { return img; }
        }
        public ZoomForm()
        {
            InitializeComponent();

        }

        private void ZoomForm_Load(object sender, EventArgs e)
        {
            if (img != null)
                pictureBoxEditor.Image = img;
        }

      

        private void ZoomBtn_Click(object sender, EventArgs e)
        {

            if (cheekZoom == true) cheekZoom = false;
            else { cheekZoom = true; }
            
        }
        protected override void OnMouseWheel(MouseEventArgs ea)
        {
            if (cheekZoom == true)
            {
                //  flag = 1;
                // Override OnMouseWheel event, for zooming in/out with the scroll wheel
                if (pictureBoxEditor.Image != null)
                {
                    // If the mouse wheel is moved forward (Zoom in)
                    if (ea.Delta > 0)
                    {
                        // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                        if ((pictureBoxEditor.Width < (15 * this.Width)) && (pictureBoxEditor.Height < (15 * this.Height)))
                        {
                            // Change the size of the picturebox, multiply it by the ZOOMFACTOR
                            pictureBoxEditor.Width = (int)(pictureBoxEditor.Width * 1.25);
                            pictureBoxEditor.Height = (int)(pictureBoxEditor.Height * 1.25);

                            // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                            pictureBoxEditor.Top = (int)(ea.Y - 1.25 * (ea.Y - pictureBoxEditor.Top));
                            pictureBoxEditor.Left = (int)(ea.X - 1.25 * (ea.X - pictureBoxEditor.Left));
                        }
                    }
                    else
                    {
                        // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                        if ((pictureBoxEditor.Width > (15)) && (pictureBoxEditor.Height > (15)))
                        {
                            // Change the size of the picturebox, divide it by the ZOOMFACTOR
                            pictureBoxEditor.Width = (int)(pictureBoxEditor.Width / 1.25);
                            pictureBoxEditor.Height = (int)(pictureBoxEditor.Height / 1.25);

                            // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                            pictureBoxEditor.Top = (int)(ea.Y - 0.80 * (ea.Y - pictureBoxEditor.Top));
                            pictureBoxEditor.Left = (int)(ea.X - 0.80 * (ea.X - pictureBoxEditor.Left));
                        }
                    }
                }
            }
        }
    }
}
        
