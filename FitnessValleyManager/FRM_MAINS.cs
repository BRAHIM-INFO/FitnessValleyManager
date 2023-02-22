using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevComponents.DotNetBar;
using Microsoft.Win32;
using System.Media;
//using PersonnelManagement.Forms;
using System.Data.SqlClient;

namespace FitnessValleyManager
{
    public partial class FRM_MAINS : Form
    {
        //TabItem newtabMnuTreasuryCard;
        //TabItem newtabMnuTreasuryCard01;
        //TabItem newtabMnuTreasuryCard02;
        //TabItem newtabMnuTreasuryCard03;
        //TabItem newtabMnuTreasuryCard04;
        //TabItem newtabMnuTreasuryCard05;
        //TabItem newtabMnuTreasuryCard06;
        //TabItem newtabMnuTreasuryCard07;
        //TabItem newtabMnuTreasuryCard08;
        //TabItem newtabMnuTreasuryCard09;
        //TabItem newtabMnuTreasuryCard10;
        //TabItem newtabMnuTreasuryCard11;
        //TabItem newtabMnuTreasuryCard12;
        //TabItem newtabMnuTreasuryCard13;
        //TabItem newtabMnuTreasuryCard14;
        //public static bool IsClosed = false;
        //SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_PersonnelManagementConnectionString300);

        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public FRM_MAINS()
        {
            InitializeComponent();
        }

        public FRM_MAINS(string StatusBarItemUserNm)
        {
            InitializeComponent();
            //StatusBarItemUser.Text = StatusBarItemUserNm;
            //Da = new SqlDataAdapter("select Priv_Display from TBL_PRIV where Priv_User_ID=" + int.Parse(Properties.Settings.Default.User_ID) + "", con);
            //Da.Fill(Dt);
            //if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
            //    Btn01.Enabled = false;
            //if (Dt.Rows[1][0].ToString() == "False" || Dt.Rows[1][0].ToString() == string.Empty)
            //    button6.Enabled = false;
            //if (Dt.Rows[2][0].ToString() == "False" || Dt.Rows[2][0].ToString() == string.Empty)
            //    button10.Enabled = false;
            //if (Dt.Rows[3][0].ToString() == "False" || Dt.Rows[3][0].ToString() == string.Empty)
            //    button1.Enabled = false;
            //if (Dt.Rows[4][0].ToString() == "False" || Dt.Rows[4][0].ToString() == string.Empty)
            //    button2.Enabled = false;
            //if (Dt.Rows[5][0].ToString() == "False" || Dt.Rows[5][0].ToString() == string.Empty)
            //    button3.Enabled = false;
            //if (Dt.Rows[6][0].ToString() == "False" || Dt.Rows[6][0].ToString() == string.Empty)
            //    button4.Enabled = false;
            //if (Dt.Rows[7][0].ToString() == "False" || Dt.Rows[7][0].ToString() == string.Empty)
            //    BtnAbomentEtude.Enabled = false;
            //if (Dt.Rows[8][0].ToString() == "False" || Dt.Rows[8][0].ToString() == string.Empty)
            //    BtnPaie.Enabled = false;
            //if (Dt.Rows[9][0].ToString() == "False" || Dt.Rows[9][0].ToString() == string.Empty)
            //    BtnRPT01.Enabled = false;
            //if (Dt.Rows[10][0].ToString() == "False" || Dt.Rows[10][0].ToString() == string.Empty)
            //    BtnRPT02.Enabled = false;
            //if (Dt.Rows[11][0].ToString() == "False" || Dt.Rows[11][0].ToString() == string.Empty)
            //    BtnRPT03.Enabled = false;
            //if (Dt.Rows[12][0].ToString() == "False" || Dt.Rows[12][0].ToString() == string.Empty)
            //    BtnRPT04.Enabled = false;
            //if (Dt.Rows[13][0].ToString() == "False" || Dt.Rows[13][0].ToString() == string.Empty)
            //    button5.Enabled = false;
            //if (Dt.Rows[14][0].ToString() == "False" || Dt.Rows[14][0].ToString() == string.Empty)
            //    BtnAddUser.Enabled = false;
            //if (Dt.Rows[15][0].ToString() == "False" || Dt.Rows[15][0].ToString() == string.Empty)
            //    BtnUsersPermissions.Enabled = false;
            //if (Dt.Rows[16][0].ToString() == "False" || Dt.Rows[16][0].ToString() == string.Empty)
            //    BtnRestore.Enabled = false;
            //if (Dt.Rows[17][0].ToString() == "False" || Dt.Rows[17][0].ToString() == string.Empty)
            //    BtnBackup.Enabled = false;
            //if (Dt.Rows[18][0].ToString() == "False" || Dt.Rows[18][0].ToString() == string.Empty)
            //    BtnSetting.Enabled = false;
            //if (Dt.Rows[19][0].ToString() == "False" || Dt.Rows[19][0].ToString() == string.Empty)
            //    BtnDeviceFinger.Enabled = false;
        }

        private void btnslide_Click(object sender, EventArgs e)
        { 
            if (SlideBar.Width == 265)
            {
                SlideBar.Width = 50;
                //PicLogo.Size = new System.Drawing.Size(50, 146);
                StatusBarItemUser.Visible = false;
                SlideBar.HorizontalScroll.Visible = false;
                bunifuTransition1.HideSync(SlideBar, false, BunifuAnimatorNS.Animation.Particles);
                bunifuTransition1.ShowSync(SlideBar, false, BunifuAnimatorNS.Animation.VertSlide);
                Btn01.ImageAlign = ContentAlignment.MiddleLeft;
                Btn02.ImageAlign = ContentAlignment.MiddleLeft;
                Btn04.ImageAlign = ContentAlignment.MiddleLeft;
                Btn05.ImageAlign = ContentAlignment.MiddleLeft;
                Btn09.ImageAlign = ContentAlignment.MiddleLeft;
                Btn10.ImageAlign = ContentAlignment.MiddleLeft;
                PL01.Visible = false;
                PL02.Visible = false;
                PL04.Visible = false;
                PL05.Visible = false;
                PL09.Visible = false;
                PL10.Visible = false;
            }
            else
            {
                SlideBar.Width = 265;
                // PicLogo.Size = new System.Drawing.Size(265, 146);
                StatusBarItemUser.Visible = true;
                bunifuTransition1.HideSync(SlideBar, false, BunifuAnimatorNS.Animation.Particles);
                bunifuTransition1.ShowSync(SlideBar, false, BunifuAnimatorNS.Animation.VertSlide);
                Btn01.ImageAlign = ContentAlignment.MiddleRight;
                Btn02.ImageAlign = ContentAlignment.MiddleRight;
                Btn04.ImageAlign = ContentAlignment.MiddleRight;
                Btn05.ImageAlign = ContentAlignment.MiddleRight;
                Btn09.ImageAlign = ContentAlignment.MiddleRight;
                Btn10.ImageAlign = ContentAlignment.MiddleRight;
                PL01.Visible = true;
                PL02.Visible = true;
                PL04.Visible = true;
                PL05.Visible = true;
                PL09.Visible = true;
                PL10.Visible = true;
            }
            Pnl02.Visible = false;
            Pnl04.Visible = false;
            Pnl05.Visible = false;
            Pnl09.Visible = false;
            Pnl10.Visible = false;
        }

        //public void Alert(string msg, FRM_ALERT.enmType type)
        //{
        //    FRM_ALERT frm = new FRM_ALERT();
        //    frm.showAlert(msg, type);
        //}

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
                    btnslide_Click(sender, e);
                }
                bunifuTransition1.ShowSync(Pnl02, false, BunifuAnimatorNS.Animation.Scale);
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide);
            }
        }

        private void Btn04_Click(object sender, EventArgs e)
        {
            if (Pnl04.Visible)
            {
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                if ((SlideBar.Width == 50))
                {
                    btnslide_Click(sender, e);
                }

                bunifuTransition1.HideSync(Pnl02, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.ShowSync(Pnl04, false, BunifuAnimatorNS.Animation.Scale);
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide);
            }
        }

        private void Btn05_Click(object sender, EventArgs e)
        {
            if (Pnl05.Visible)
            {
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                if ((SlideBar.Width == 50))
                {
                    btnslide_Click(sender, e);
                }

                bunifuTransition1.HideSync(Pnl02, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.ShowSync(Pnl05, false, BunifuAnimatorNS.Animation.Scale);
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide);
            }
        }

        private void Btn09_Click(object sender, EventArgs e)
        {
            if (Pnl09.Visible)
            {
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                if ((SlideBar.Width == 50))
                {
                    btnslide_Click(sender, e);
                }

                bunifuTransition1.HideSync(Pnl02, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.ShowSync(Pnl09, false, BunifuAnimatorNS.Animation.Scale);
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {

        }



        private void FRM_MAINS_Load(object sender, EventArgs e)
        {
            //guna2ShadowForm1.SetShadowForm(this);
            ////label_val.Text = "Dashboard Overview";
            ////guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            //container(new Dashboard());

            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard))
            //    {
            //        newtabMnuTreasuryCard = TabControlHome.CreateTab("الرئيسية");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_DOASHBORD() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard;
            //    }


            //    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //    string day = dt.DayOfWeek.ToString();
            //    switch (day)
            //    {
            //        case "Saturday": { day = "السبت"; } break;
            //        case "Sunday": { day = "الاحد"; } break;
            //        case "Monday": { day = "الاثنين"; } break;
            //        case "Tuesday": { day = "الثلاثاء"; } break;
            //        case "Wednesday": { day = "الاربعاء"; } break;
            //        case "Thursday": { day = "الخميس"; } break;
            //        case "Friday": { day = "الجمعة"; } break;
            //    }

            //    StatusBarItemDate.Text = day + " " + DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-SA"));
            //    StatusBarItemTimes.Text = DateTime.Now.ToLongTimeString();
            //    this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //    this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;


            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), FRM_ALERT.enmType.Error);
            //}
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        
        private void button1_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard05))
        //        {
        //            newtabMnuTreasuryCard05 = TabControlHome.CreateTab("العطل المرضية للموظفين");
        //            TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard05.AttachedControl;
        //            panel.Controls.Add(new Forms.FRM_MALADIE_EMP() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
        //            TabControlHome.SelectedTab = newtabMnuTreasuryCard05;
        //        }
        //        else
        //        {
        //            TabControlHome.SelectedTab = newtabMnuTreasuryCard05;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
        //    }
        }

        private void BtnAbomentEtude_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard03))
            //    {
            //        newtabMnuTreasuryCard03 = TabControlHome.CreateTab("دفع المرتبات الموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard03.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_EMP_SALAIRE() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard03;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard03;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        //private void BtnAdmin_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.BtnAdmin.ImageSize = new System.Drawing.Size(32, 32);
        //}

        //private void BtnAdmin_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BtnAdmin.ImageSize = new System.Drawing.Size(25, 25);
        //}

        //private void BtnSet_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.BtnSet.ImageSize = new System.Drawing.Size(32, 32);
        //}

        //private void BtnSet_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BtnSet.ImageSize = new System.Drawing.Size(25, 25);
        //}

        //private void CmdClose_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.CmdClose.ImageSize = new System.Drawing.Size(32, 32);
        //}

        //private void CmdClose_MouseLeave(object sender, EventArgs e)
        //{
        //    this.CmdClose.ImageSize = new System.Drawing.Size(25, 25);
        //}

        private void FRM_MAINS_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Alert("شكرا لكم مع برنامج بيوتيفول بيست", Forms.FRM_ALERT.enmType.Info);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            //label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new FRM_SUBSCRIBER_LIST());

            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard02))
            //    {
            //        newtabMnuTreasuryCard02 = TabControlHome.CreateTab("غيابات الموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard02.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_ABS_EMP() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard02;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard02;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            // }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard04))
            //    {
            //        newtabMnuTreasuryCard04 = TabControlHome.CreateTab("قائمة الغيابات والاجازات للموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard04.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_LISTE_ABS_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard04;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard04;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard06))
            //    {
            //        newtabMnuTreasuryCard06 = TabControlHome.CreateTab("الاجازات للموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard06.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_CONGER_EMP() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard06;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard06;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        //private void TabControlHome_TabItemClose(object sender, TabStripActionEventArgs e)
        //{
        //    //if (this.TabControlHome.SelectedTab.Text.ToString() == "قائمة الغيابات والاجازات للموظفين")
        //    //{
        //    //    IsClosed = true;
        //    //}
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard07))
            //    {
            //        newtabMnuTreasuryCard07 = TabControlHome.CreateTab("قائمة كل الموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard07.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_LISTE_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard07;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard07;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_SETTING();
            //frm.ShowDialog();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard08))
            //    {
            //        newtabMnuTreasuryCard08 = TabControlHome.CreateTab("إظافة مستخدم جديد");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard08.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_USERS_ADDS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard08;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard08;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnUsersPermissions_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard09))
            //    {
            //        newtabMnuTreasuryCard09 = TabControlHome.CreateTab("صلاحيات المستخدمين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard09.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_USERS_PERMISSIONS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard09;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard09;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_BACKUP_DATA();
            //frm.ShowDialog();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_RESTORE_DATA();
            //frm.ShowDialog();
        }

        private void BtnApropos_Click(object sender, EventArgs e)
        {
            //var frm = new Master();
            //frm.ShowDialog();
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            //label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new FRM_SUBSCRIBER_LIST());

            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard))
            //    {
            //        newtabMnuTreasuryCard = TabControlHome.CreateTab("الرئيسية");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_DOASHBORD() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_SETTING();
            //frm.ShowDialog();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_ABOUT_DEVELOPER();
            //frm.ShowDialog();
        }

        private void BtnPaie_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard10))
            //    {
            //        newtabMnuTreasuryCard10 = TabControlHome.CreateTab("سجل رواتب الموظفين");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard10.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_LISTE_SALAIRE_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard10;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard10;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnRPT01_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard11))
            //    {
            //        newtabMnuTreasuryCard11 = TabControlHome.CreateTab("تقرير الغيابات ");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard11.AttachedControl;
            //        panel.Controls.Add(new Forms.RPT_ABS_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard11;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard11;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnRPT02_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard12))
            //    {
            //        newtabMnuTreasuryCard12 = TabControlHome.CreateTab("تقرير الاجازات");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard12.AttachedControl;
            //        panel.Controls.Add(new Forms.RPT_CONGER_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard12;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard12;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnRPT03_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard13))
            //    {
            //        newtabMnuTreasuryCard13 = TabControlHome.CreateTab("تقرير العطل المرضية");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard13.AttachedControl;
            //        panel.Controls.Add(new Forms.RPT_MALADIES_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard13;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard13;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnRPT04_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard14))
            //    {
            //        newtabMnuTreasuryCard14 = TabControlHome.CreateTab("تقرير مهمات العمل");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard14.AttachedControl;
            //        panel.Controls.Add(new Forms.RPT_MISSIONS_EMPS() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard14;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard14;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }

        private void BtnApropo_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_ABOUT_DEVELOPER();
            //frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Pnl10.Visible)
            {
                bunifuTransition1.HideSync(Pnl10, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                if ((SlideBar.Width == 50))
                {
                    btnslide_Click(sender, e);
                }

                bunifuTransition1.HideSync(Pnl02, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl04, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl05, false, BunifuAnimatorNS.Animation.VertSlide);
                bunifuTransition1.HideSync(Pnl09, false, BunifuAnimatorNS.Animation.VertSlide); 
                bunifuTransition1.ShowSync(Pnl10, false, BunifuAnimatorNS.Animation.Scale);
            }
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            //label_val.Text = "Dashboard Overview";
            //guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new FRM_SUBSCRIBER_ADD());

            //try
            //{
            //    if (!TabControlHome.Tabs.Contains(newtabMnuTreasuryCard01))
            //    {
            //        newtabMnuTreasuryCard01 = TabControlHome.CreateTab("إظافة موظف جديد");
            //        TabControlPanel panel = (TabControlPanel)newtabMnuTreasuryCard01.AttachedControl;
            //        panel.Controls.Add(new Forms.FRM_EMP_ADD() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None });
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard01;
            //    }
            //    else
            //    {
            //        TabControlHome.SelectedTab = newtabMnuTreasuryCard01;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.Alert(ex.Message.ToString(), Forms.FRM_ALERT.enmType.Error);
            //}
        }
    }
}
