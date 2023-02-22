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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        
        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Patient());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Messages";
            //guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new FRM_SUBSCRIBER_LIST());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            if (Pnl02.Visible)
            {
                bunifuTransition1.HideSync(Pnl02, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                if ((SlideBar.Width == 50))
                {
                    //btnslide_Click(sender, e);
                }
                bunifuTransition1.ShowSync(Pnl02, false, BunifuAnimatorNS.Animation.Scale);
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide);
            }
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 50;
                guna2PictureBox_val.Visible = false;
               // btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //menuButton.Text = "";
                    //menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    //menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 265;
                guna2PictureBox_val.Visible = true;
               // btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //menuButton.Text = "   " + menuButton.Tag.ToString();
                    //menuButton.ImageAlign = ContentAlignment.MiddleRight;
                    //menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // CollapseMenu();
            if (panelMenu.Width == 265)
            {
                panelMenu.Width = 50;
                guna2PictureBox_val.Size = new System.Drawing.Size(50, 53);
                //StatusBarItemUser.Visible = false;
                panelMenu.HorizontalScroll.Visible = false;
                bunifuTransition1.HideSync(panelMenu, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.ShowSync(panelMenu, false, BunifuAnimatorNS.Animation.VertSlide);
                Btn01.ImageAlign = ContentAlignment.MiddleLeft;
                Btn02.ImageAlign = ContentAlignment.MiddleLeft;
                Btn04.ImageAlign = ContentAlignment.MiddleLeft;
                Btn05.ImageAlign = ContentAlignment.MiddleLeft;
                Btn09.ImageAlign = ContentAlignment.MiddleLeft;
                PL01.Visible = false;
                PL02.Visible = false;
                PL04.Visible = false;
                PL05.Visible = false;
                PL09.Visible = false;
            }
            else
            {
                panelMenu.Width = 265;
                guna2PictureBox_val.Size = new System.Drawing.Size(265, 97);
               // StatusBarItemUser.Visible = true;
                bunifuTransition1.HideSync(panelMenu, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.ShowSync(panelMenu, false, BunifuAnimatorNS.Animation.VertSlide);
                Btn01.ImageAlign = ContentAlignment.MiddleRight;
                Btn02.ImageAlign = ContentAlignment.MiddleRight;
                Btn04.ImageAlign = ContentAlignment.MiddleRight;
                Btn05.ImageAlign = ContentAlignment.MiddleRight;
                Btn09.ImageAlign = ContentAlignment.MiddleRight;
                PL01.Visible = true;
                PL02.Visible = true;
                PL04.Visible = true;
                PL05.Visible = true;
                PL09.Visible = true;
            }
            Pnl02.Visible = false;
            Pnl04.Visible = false;
            Pnl05.Visible = false;
            Pnl09.Visible = false;
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void Btn04_Click(object sender, EventArgs e)
        {
            label_val.Text = "Messages";
            //guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new FRM_SUBSCRIBER_LIST());
        }
    }
}
