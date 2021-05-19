namespace multimedia
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartVideoBtn = new System.Windows.Forms.Button();
            this.StopVideoBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.StartVideoBtn);
            this.panel1.Controls.Add(this.StopVideoBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 100);
            this.panel1.TabIndex = 0;
            // 
            // StartVideoBtn
            // 
            this.StartVideoBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartVideoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.StartVideoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.StartVideoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartVideoBtn.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartVideoBtn.ForeColor = System.Drawing.Color.White;
            this.StartVideoBtn.Location = new System.Drawing.Point(20, 25);
            this.StartVideoBtn.Name = "StartVideoBtn";
            this.StartVideoBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.StartVideoBtn.Size = new System.Drawing.Size(167, 51);
            this.StartVideoBtn.TabIndex = 11;
            this.StartVideoBtn.Text = "&Start";
            this.StartVideoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartVideoBtn.UseVisualStyleBackColor = true;
            this.StartVideoBtn.Click += new System.EventHandler(this.StartVideoBtn_Click);
            // 
            // StopVideoBtn
            // 
            this.StopVideoBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StopVideoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StopVideoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.StopVideoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.StopVideoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopVideoBtn.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopVideoBtn.ForeColor = System.Drawing.Color.White;
            this.StopVideoBtn.Location = new System.Drawing.Point(213, 25);
            this.StopVideoBtn.Name = "StopVideoBtn";
            this.StopVideoBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.StopVideoBtn.Size = new System.Drawing.Size(167, 51);
            this.StopVideoBtn.TabIndex = 10;
            this.StopVideoBtn.Text = "&Stop";
            this.StopVideoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopVideoBtn.UseVisualStyleBackColor = true;
            this.StopVideoBtn.Click += new System.EventHandler(this.StopVideoBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(979, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 470);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button StartVideoBtn;
        public System.Windows.Forms.Button StopVideoBtn;
    }
}

