using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AForge.Video.DirectShow;
using AForge.Video;
namespace multimedia
{
    public partial class Form1 : Form
    {
        FilterInfoCollection f;
        VideoCaptureDevice vc;
        Bitmap b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo fi in f)
            {
                comboBox1.Items.Add(fi.Name);
            }
            comboBox1.SelectedIndex = 0;
            vc = new VideoCaptureDevice();

        }

       

        private void Vc_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
           // pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vc.IsRunning == true) vc.Stop();
        }

       

        private void StopVideoBtn_Click(object sender, EventArgs e)
        {
            vc.Stop();
            b = (Bitmap)pictureBox1.Image.Clone();
            Form2 f = new Form2();
            f.GetBitMap(b);
        }

        private void StartVideoBtn_Click(object sender, EventArgs e)
        {
            vc = new VideoCaptureDevice(f[comboBox1.SelectedIndex].MonikerString);
            vc.NewFrame += new NewFrameEventHandler(Vc_NewFrame);
            vc.Start();
        }
    }
}
