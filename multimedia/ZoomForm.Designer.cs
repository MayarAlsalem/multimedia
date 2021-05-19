namespace multimedia
{
    partial class ZoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxEditor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZoomBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxEditor
            // 
            this.pictureBoxEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEditor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEditor.Name = "pictureBoxEditor";
            this.pictureBoxEditor.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditor.TabIndex = 7;
            this.pictureBoxEditor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.ZoomBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // ZoomBtn
            // 
            this.ZoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ZoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.ZoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.ZoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomBtn.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomBtn.ForeColor = System.Drawing.Color.White;
            this.ZoomBtn.Location = new System.Drawing.Point(20, 25);
            this.ZoomBtn.Name = "ZoomBtn";
            this.ZoomBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ZoomBtn.Size = new System.Drawing.Size(167, 51);
            this.ZoomBtn.TabIndex = 11;
            this.ZoomBtn.Text = "&Zoom";
            this.ZoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZoomBtn.UseVisualStyleBackColor = true;
            this.ZoomBtn.Click += new System.EventHandler(this.ZoomBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBoxEditor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ZoomForm";
            this.Text = "ZoomForm";
            this.Load += new System.EventHandler(this.ZoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button ZoomBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}