using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;

namespace multimedia
{
    public partial class FaceDec : Form
    {
        bool isVideo;
       

        FilterInfoCollection filter;
        VideoCaptureDevice device;
        public FaceDec(bool x)
        {
            isVideo = x;
            InitializeComponent();
        }

        private void FaceDec_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                comboBox2.Items.Add(device.Name);
            comboBox2.SelectedIndex = 0;
            device = new VideoCaptureDevice();
        }

        private void DedectBtn_Click(object sender, EventArgs e)
        {
            if (isVideo)
            {
                device = new VideoCaptureDevice(filter[comboBox2.SelectedIndex].MonikerString);
                device.NewFrame += Device_NewFrame;
                device.Start();
            }
            else
            { 
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(image, 1.2, 1);
                    foreach (Rectangle rectangle in rectangles)
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        Pen pen = new Pen(Color.Green, 1);
                        g.DrawRectangle(pen, rectangle);
                    }
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
          Bitmap bitmap=(Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap);
            Rectangle []rectangles = cascadeClassifier.DetectMultiScale(image,1.2,1);
            foreach( Rectangle rectangle in rectangles )
            {
                Graphics g = Graphics.FromImage(bitmap);
                Pen pen = new Pen(Color.Green, 1);
                g.DrawRectangle(pen, rectangle);
            }
            pictureBox1.Image = bitmap;
        }

        private void FaceDec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning) device.Stop();
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
    }
}
