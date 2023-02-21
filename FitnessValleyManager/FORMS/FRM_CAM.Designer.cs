namespace FitnessValleyManager
{
    partial class FRM_CAM
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new Siticone.UI.WinForms.SiticoneButton();
            this.Label13 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnPhoto = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.Btn_Save = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bntStart = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.bntStop = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(109)))), ((int)(((byte)(253)))));
            this.Panel1.Controls.Add(this.BtnExit);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(528, 41);
            this.Panel1.TabIndex = 64;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.Parent = this.BtnExit;
            this.BtnExit.CustomImages.Parent = this.BtnExit;
            this.BtnExit.FillColor = System.Drawing.Color.Transparent;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.HoveredState.Parent = this.BtnExit;
            this.BtnExit.Image = global::FitnessValleyManager.Properties.Resources.icons8_close_window_48;
            this.BtnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnExit.Location = new System.Drawing.Point(10, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(33, 30);
            this.BtnExit.TabIndex = 46;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(327, 7);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(157, 28);
            this.Label13.TabIndex = 45;
            this.Label13.Text = "اخذ صورة من الكام";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = global::FitnessValleyManager.Properties.Resources.system_tools;
            this.PictureBox2.Location = new System.Drawing.Point(490, 7);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(29, 31);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 42;
            this.PictureBox2.TabStop = false;
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.CheckedState.Parent = this.BtnPhoto;
            this.BtnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPhoto.CustomImages.Parent = this.BtnPhoto;
            this.BtnPhoto.Enabled = false;
            this.BtnPhoto.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPhoto.ForeColor = System.Drawing.Color.White;
            this.BtnPhoto.HoveredState.Parent = this.BtnPhoto;
            this.BtnPhoto.Location = new System.Drawing.Point(388, 288);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.ShadowDecoration.Parent = this.BtnPhoto;
            this.BtnPhoto.Size = new System.Drawing.Size(128, 32);
            this.BtnPhoto.TabIndex = 167;
            this.BtnPhoto.Text = "إظافة الى الملف";
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AccessibleDescription = "bntCapture";
            this.Btn_Save.CheckedState.Parent = this.Btn_Save;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.CustomImages.Parent = this.Btn_Save;
            this.Btn_Save.Enabled = false;
            this.Btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(89)))));
            this.Btn_Save.Font = new System.Drawing.Font("JF Flat", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.HoveredState.Parent = this.Btn_Save;
            this.Btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Save.ImageSize = new System.Drawing.Size(16, 16);
            this.Btn_Save.Location = new System.Drawing.Point(276, 290);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(109, 30);
            this.Btn_Save.TabIndex = 169;
            this.Btn_Save.Text = "التقط صورة";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(161)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(194, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 171;
            this.label1.Text = "الكاميرا";
            // 
            // bntStart
            // 
            this.bntStart.CheckedState.Parent = this.bntStart;
            this.bntStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntStart.CustomImages.Parent = this.bntStart;
            this.bntStart.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold);
            this.bntStart.ForeColor = System.Drawing.Color.White;
            this.bntStart.HoveredState.Parent = this.bntStart;
            this.bntStart.Image = global::FitnessValleyManager.Properties.Resources.icons8_play_30_1_;
            this.bntStart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bntStart.Location = new System.Drawing.Point(35, 288);
            this.bntStart.Name = "bntStart";
            this.bntStart.ShadowDecoration.Parent = this.bntStart;
            this.bntStart.Size = new System.Drawing.Size(106, 32);
            this.bntStart.TabIndex = 170;
            this.bntStart.Text = "تشغيل";
            this.bntStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // bntStop
            // 
            this.bntStop.CheckedState.Parent = this.bntStop;
            this.bntStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntStop.CustomImages.Parent = this.bntStop;
            this.bntStop.Enabled = false;
            this.bntStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.bntStop.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold);
            this.bntStop.ForeColor = System.Drawing.Color.White;
            this.bntStop.HoveredState.Parent = this.bntStop;
            this.bntStop.Image = global::FitnessValleyManager.Properties.Resources.icons8_pause_30;
            this.bntStop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bntStop.Location = new System.Drawing.Point(144, 288);
            this.bntStop.Name = "bntStop";
            this.bntStop.ShadowDecoration.Parent = this.bntStop;
            this.bntStop.Size = new System.Drawing.Size(109, 32);
            this.bntStop.TabIndex = 168;
            this.bntStop.Text = "توقيف";
            this.bntStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bntStop.Click += new System.EventHandler(this.bntStop_Click);
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture.Image = global::FitnessValleyManager.Properties.Resources._001;
            this.imgCapture.Location = new System.Drawing.Point(276, 70);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(240, 212);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 129;
            this.imgCapture.TabStop = false;
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.Image = global::FitnessValleyManager.Properties.Resources._002;
            this.imgVideo.Location = new System.Drawing.Point(12, 70);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(241, 212);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 128;
            this.imgVideo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(161)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(460, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 172;
            this.label2.Text = "الصورة";
            // 
            // FRM_CAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntStart);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.imgCapture);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CAM";
            this.Load += new System.EventHandler(this.FRM_CAM_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.PictureBox imgVideo;
        private Siticone.UI.WinForms.SiticoneRoundedButton BtnPhoto;
        private Siticone.UI.WinForms.SiticoneButton BtnExit;
        private Siticone.UI.WinForms.SiticoneRoundedButton bntStop;
        private Siticone.UI.WinForms.SiticoneRoundedButton Btn_Save;
        private Siticone.UI.WinForms.SiticoneRoundedButton bntStart;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
    }
}