using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;





namespace multimedia
{
    public partial class Form2 : Form
    {
        int rotate = 0;
        bool CropClick = false;
        Image opicityImg;
        Bitmap cupture;
      
      

        
       static Bitmap pic;
        public void GetBitMap(Bitmap b)
        {
            pic = b;
        }
        string path = string.Empty;
        Bitmap orginal;
       Bitmap red;
       Bitmap blue;
       Bitmap green;
       Bitmap yellow;
       Bitmap magenta;
       Bitmap cyan;
       Bitmap black_white;
       Bitmap gray;
       Bitmap mirror;
        Bitmap Nigatve;


        public Form2()
        {

            InitializeComponent();
            pictureBoxEditor.MouseWheel += PictureBoxEditor_MouseWheel;
            CustomizeDesing();
           
        }

        private void PictureBoxEditor_MouseWheel(object sender, MouseEventArgs e)
        {
          
        }

        private void CustomizeDesing()
        {
            panelEditChooes.Visible = false;
        }
      
       
      
        private void btnTake_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();

         if(f.ShowDialog(this)==DialogResult.OK)
            {
               if(pic!=null)pictureBoxEditor.Image=pic;
              
            }
            progressBar1.Visible = true;
             cupture = (Bitmap)pictureBoxEditor.Image;
            cupture.Save("D:\\m.png");
            
            orginal = new Bitmap("D:\\m.png");
            MyBitmap.GetPath="D:\\m.png";
            mirror = MyBitmap.ConvertToMirror("D:\\m.png");
            orginal = new Bitmap("D:\\m.png");
            opicityImg = orginal;
          procssing();
           ShowButton();


        }

        private void PanelSlideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChooes_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                progressBar1.Visible = true;
                path = openFileDialog1.FileName;
                orginal = new Bitmap(path);
                MyBitmap.GetPath = path;
                opicityImg = orginal;
                mirror = MyBitmap.ConvertToMirror(path);
                procssing();
                ShowButton();
               


            }
        }
        public void ShowButton()
        {
            panel2.Visible = true;
            ConvertToBlueBtn.Visible = true;
            ConvertToCyanBtn.Visible = true;
            ConvertToGreenBtn.Visible = true;
            ConvertToMagentaBtn.Visible = true;
            ConvertToNegativeBtn.Visible = true;
            ConvertToRedBtn.Visible = true;
            ConvertToWhiteBlackBtn.Visible = true;
            ConvertToYallowBtn.Visible = true;
            RestBtn.Visible = true;
            ConvertToGrayBtn.Visible = true;
            MirrorBtn.Visible = true;
            panelMenuTools.Visible=true;
          
        }
        public void Pro()
        {
            progressBar1.Value += 25;
            if (progressBar1.Value == progressBar1.MaxValue)
            {
               
                progressBar1.Visible = false;
                pictureBoxEditor.Image = orginal;
               

            }
        }
        public void procssing()
        {
            progressBar1.Value = 0;
            Task t1 = new Task(delegate () { red = MyBitmap.ConvertTo("red");Pro(); });
            Task t2 = new Task(delegate () { green = MyBitmap.ConvertTo("Green"); Pro(); });
            Task t3 = new Task(delegate () { blue = MyBitmap.ConvertTo("blue");Pro(); });
            Task t4 = new Task(delegate () { cyan = MyBitmap.ConvertTo("cyan"); Pro(); });
            Task t5 = new Task(delegate () { yellow = MyBitmap.ConvertTo("yellow"); Pro(); });
            Task t6 = new Task(delegate () { magenta = MyBitmap.ConvertTo("magenta"); Pro(); });
            Task t7 = new Task(delegate () { black_white = MyBitmap.ConvertTo("blackWhite"); Pro(); });
            Task t8 = new Task(delegate () { gray = MyBitmap.ConvertTo("gray"); Pro(); });
            Task t9 = new Task(delegate () { Nigatve = MyBitmap.ConvertTo("nigatve");Pro(); });
           
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
           
            

            //  blue = MyBitmap.ConvertTo("blue");


        } 
        
                   
      
        private void panelMenuTools_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panleTools_Paint(object sender, PaintEventArgs e)
        {

        }   
             

        private void ConverColorBtn_Click(object sender, EventArgs e)
        {
            if (panelColorMenu.Visible) panelColorMenu.Visible = false;
            else { panelColorMenu.Visible = true; }
        }

        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            if (panleTools.Visible) panleTools.Visible = false;
            else
            {
                panleTools.Visible = true;
            }
        }

        private void ConvertToCyanBtn_Click_1(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = cyan;
        }

        private void ConvertToRedBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = red;
            opicityImg = red;
        }

        private void ConvertToGreenBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = green;
            opicityImg = green;
        }

        private void ConvertToBlueBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = blue;
            opicityImg = blue;
        }

        private void ConvertToWhiteBlackBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = black_white;
            opicityImg = black_white;
        }

        private void ConvertToNegativeBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = Nigatve;
            opicityImg = Nigatve;
        }

        private void ConvertToMagentaBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = magenta;
            opicityImg = magenta;
        }

        private void ConvertToYallowBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = yellow;
            opicityImg = yellow;
        }

        private void ConvertToGrayBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = gray;
            opicityImg = gray;
        }

        private void MirrorBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = mirror;
          
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = orginal;
            opicityImg = orginal;
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
           float x = (float)trackBar1.Value / 10;
            if (pictureBoxEditor.Image != null)
            {
                if (trackBar1.Value > 0)
                {
                    pictureBoxEditor.Image = MyBitmap.ChangeOpacity(opicityImg, x);
                    
                }
            }
            
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void scaleTrackBar_Scroll(object sender, EventArgs e)
        {
            if (scaleTrackBar.Value == 49)
            { pictureBoxEditor.SizeMode = PictureBoxSizeMode.StretchImage; pictureBoxEditor.Image = opicityImg; }
            else
            {
                pictureBoxEditor.SizeMode = PictureBoxSizeMode.CenterImage;
                Bitmap scale = new Bitmap(opicityImg, scaleTrackBar.Value, scaleTrackBar.Value);
                Graphics g = Graphics.FromImage(scale);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                pictureBoxEditor.Image = scale;
            }
        }

      

       
        //Cut pic var
        Rectangle rectangle;
        Point point1;//نقطة البداية
        Point point2;//نقطة النهاية
        bool isMouseDown = false;
        private void pictureBoxEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (CropClick == true ||copyClick==true)
            {
                isMouseDown = true;
                point1 = e.Location;
            }
        }

        private void pictureBoxEditor_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                point2 = e.Location;
                isMouseDown = false;
                
               if(rectangle!=null &&pictureBoxEditor.Image!=null &&CropClick==true)
                {
                    Bitmap b = new Bitmap(pictureBoxEditor.Image, pictureBoxEditor.Width, pictureBoxEditor.Height);
                    Bitmap cropimg = new Bitmap(rectangle.Width, rectangle.Height);
                    Graphics g = Graphics.FromImage(cropimg);
                   
                    g.DrawImage(b, 0, 0, rectangle, GraphicsUnit.Pixel);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    pictureBoxEditor.Image = cropimg;
                    CropClick = false;
                }
               if(rectangle != null && pictureBoxEditor.Image != null && copyClick == true)
                {
                    Bitmap b = new Bitmap(pictureBoxEditor.Image, pictureBoxEditor.Width, pictureBoxEditor.Height);
                    Bitmap cropimg = new Bitmap(rectangle.Width, rectangle.Height);
                    Graphics g = Graphics.FromImage(cropimg);

                    g.DrawImage(b, 0, 0, rectangle, GraphicsUnit.Pixel);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    copedForm cf = new copedForm();
                    copedForm.Image = cropimg;
                    cf.Show();
                    copyClick = false;
                }
                point1 = new Point(-1, -1);
                point2=new Point(-1, -1);
            }


          
        }
      /*  private bool ClearRect()
        {

        }*/
        private void pictureBoxEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                point2 = e.Location;
                Refresh();
            }
        }

        private void pictureBoxEditor_Paint(object sender, PaintEventArgs e)
        {
            if(rectangle!=null)
            {
                e.Graphics.DrawRectangle(Pens.Gray, GetRect());
            }
        }
        private Rectangle GetRect()
        {
            rectangle = new Rectangle();
            rectangle.X = Math.Min(point1.X,point2.X);//مناخد الاحداثيات الاقل كنقطة بداية
            rectangle.Y = Math.Min(point1.Y, point2.Y);// == ===  == ===     ===  ===
            rectangle.Width = Math.Abs(point1.X - point2.X);//===  ==== ==== === === == 
            rectangle.Height = Math.Abs(point1.Y - point2.Y);//= = = = = = = = = = = 
            return rectangle;
        }            
               

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (OpcityPanel.Visible == false) OpcityPanel.Visible = true;
            else
            {
                OpcityPanel.Visible = false;
            }
        }

        private void ScalePictureBox_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.SizeMode = PictureBoxSizeMode.CenterImage;
            if (scalePanel.Visible == false) scalePanel.Visible = true;
            else
            {
                scalePanel.Visible = false;
            }
        }

        private void RotatePictureBox_Click(object sender, EventArgs e)
        {
            rotate -= 40;
            pictureBoxEditor.Image = MyBitmap.Rotate(rotate, opicityImg);
        }

       

        private void RotateLPictrueBox_Click(object sender, EventArgs e)
        {
            rotate += 40;
            pictureBoxEditor.Image = MyBitmap.Rotate(rotate, opicityImg);
        }

        private void CropPictureBox_Click_1(object sender, EventArgs e)
        {
            CropClick = true;
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
          
        }

      
        private void WriteChoeesBtn_Click(object sender, EventArgs e)
        {
            if (WritePanel.Visible == true) WritePanel.Visible = false;
            else { WritePanel.Visible = true; }

        }
        //write text
        
        private void WriteTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            pictureBoxEditor.Image = MyImage.Write(opicityImg, WriteTextBox.Text);
            WMovetrackBar.Maximum = opicityImg.Width-1;
            HMovetrackBar.Maximum = opicityImg.Height - 1;
        }
        //move text
        private void WMovetrackBar_Scroll(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = MyImage.Write(opicityImg, WriteTextBox.Text, WMovetrackBar.Value, HMovetrackBar.Value);
        }

        private void HMovetrackBar_Scroll(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = MyImage.Write(opicityImg, WriteTextBox.Text, WMovetrackBar.Value, HMovetrackBar.Value);

        }
        //copy image
        //var 
        bool copyClick = false;
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            copyClick = true;
        }

        private void Flipbtn_Click(object sender, EventArgs e)
        {
            pictureBoxEditor.Image = MyBitmap.Flip(opicityImg);
        }

        private void FaceImageBtn_Click(object sender, EventArgs e)
        {
            FaceDec faceDec = new FaceDec(false);
            faceDec.ShowDialog();
           

          



        }

        private void FaceDetectionBtn_Click(object sender, EventArgs e)
        {
            if (FaceDetectionPanel.Visible == true) FaceDetectionPanel.Visible = false;
            else
            {
                FaceDetectionPanel.Visible = true;
            }
        }

        private void pictureBoxEditor_Click(object sender, EventArgs e)
        {

        }

        private void panelEditChooes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WritePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitter5_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void WriteTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panelColorMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Toolslbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void scalePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void OpcityPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEmpty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpcitytoolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void splitter6_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FaceDetectionVideoBtn_Click(object sender, EventArgs e)
        {
            FaceDec faceDec = new FaceDec(true);
            faceDec.ShowDialog();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FaceDetectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (panelEditChooes.Visible)
            {
                panelEditChooes.Visible = false;
            }
            else { panelEditChooes.Visible = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                copedForm cf = new copedForm();
                Image image = Image.FromFile(openFileDialog1.FileName);
                copedForm.Image = image;
                cf.Show();
            }
        }
        //اظهار و اخفاء لوحة تغير نوع الصورة
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (ConvertPanel.Visible == true) ConvertPanel.Visible = false;
            else
            {
                ConvertPanel.Visible = true;
            }
        }
       
             

        private void ZoomBtn_Click(object sender, EventArgs e)
        {
            ZoomForm zf = new ZoomForm();
            zf.ShowDialog();
                zf.Image = pictureBoxEditor.Image;
               
            
           
        }
    } 
  
  }
