using FitnessValleyManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessValleyManager
{
    public partial class FRM_CAM : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        WebCam webcam;

        public FRM_CAM()
        {
            InitializeComponent();
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
            Btn_Save.Enabled = true;
            bntStop.Enabled = true;
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
            BtnPhoto.Enabled = true;
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            //Helper.SaveImageCapture(imgCapture.Image); 
            FRM_SUBSCRIBER_ADD.Pic_PROF.Image = imgCapture.Image;
            webcam.Stop();
            this.Hide();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FRM_CAM_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
