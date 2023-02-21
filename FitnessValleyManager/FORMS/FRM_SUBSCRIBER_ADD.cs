using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;

namespace FitnessValleyManager
{
    public partial class FRM_SUBSCRIBER_ADD : Form
    {
        public static PictureBox Pic_PROF = new PictureBox();
        string PathImage = "";
        public static int NumIdProf = 0;
        public static int NumIdProfPoste = 0;
        bool OnModify = false;
        string Sex = "أنثى";
        Siticone.UI.WinForms.SiticoneRoundedButton Btn_Default = new Siticone.UI.WinForms.SiticoneRoundedButton();
        //Classes.CLS_USERS cls_users = new Classes.CLS_USERS();
        public FRM_SUBSCRIBER_ADD()
        {
            InitializeComponent();
           // cls_users.LoadPermission(2, Btn_Default, Btn_Default, Btn_Default, Btn_Default);
        }

        //public void Alert(string msg, FRM_ALERT.enmType type)
        //{
        //    FRM_ALERT frm = new FRM_ALERT();
        //    frm.showAlert(msg, type);
        //}

        public void EmptyData()
        {
        //    txtIdProf.Text = string.Empty;
        //    txtPrenomProf.Text = string.Empty;
        //    txtLieuNaissProf.Text = string.Empty;
        //    txtAdresseProf.Text = string.Empty;
        //    txtDiplomeProf.Text = string.Empty;
        //    txtEtaCivile.Text = string.Empty;
        //    txtNoteProf.Text = string.Empty;
        //    txtTel01Prof.Text = string.Empty;
        //    txtTel02Prof.Text = string.Empty;
        //    txtEmailProf.Text = string.Empty;
        //    txtPosteProf.Text = string.Empty;
        //    TxtSalaire.Text = string.Empty;
        //    ImgAbonnee.Image = Properties.Resources.icons8_school_director_48;
        //    //imgageFinger.Image = Properties.Resources.icons8_fingerprint_64;
        //    imgageQRCode.Image = Properties.Resources.cf258720ded328c92d5a821c78b5a052;
        }

        public void EnableAll(bool Values)
        {
            txtDateNaissProf.Enabled = Values;
            txtDateNaissInscr.Enabled = Values;
            txtIdProf.Enabled = Values;
            txtPrenomProf.Enabled = Values;
            txtLieuNaissProf.Enabled = Values;
            txtAdresseProf.Enabled = Values; 
            txtTel01Prof.Enabled = Values;
            txtTel02Prof.Enabled = Values;
            txtEmailProf.Enabled = Values; 
            BtnCodeBarre.Enabled = Values;
            //BtnFinger.Enabled = Values;
            BtnWebCam.Enabled = Values;
            BtnParcour.Enabled = Values;
        }

        SqlConnection con;
        SqlCommand cmd;

        public async Task LOADING_DATA(DataGridView Dgs)
        {
            cmd = new SqlCommand();
            try
            {
                //con = new SqlConnection(Properties.Settings.Default.DB_PersonnelManagementConnectionString300);
                //Dgs.DataSource = null;
                //con.Open();
                //cmd.Connection = con;
                //cmd.CommandText = @"SELECT ID_EMP, NOM_EMP, DATENAISS_EMP, LIEUNAISS_EMP, ADRESSE_EMP, SEX_EMP, DATEINSCR_EMP, DIPLOME_EMP, NOM_POSTE, SALAIRE_EMP, ETAT_SOC_EMP, TEL01_EMP, TEL02_EMP, EMAIL_EMP, Notes_EMP," +
                //         "IMAGE_EMP, QR_CODE_EMP, FINGER_EMP FROM TBL_EMPS";
                //await cmd.ExecuteNonQueryAsync();
                //con.Close();
                //using (SqlDataAdapter Dta = new SqlDataAdapter(cmd))
                //{
                //    DataTable dt = new DataTable();
                //    Dta.Fill(dt);
                //    Dgs.DataSource = dt;
                //}
            }
            catch (Exception ex)
            {

            }

        }

        public void FRM_EMP_ADD_Load(object sender, EventArgs e)
        {
            //int CountEMP = tBL_EMPSTableAdapter.GetData().Count;
            //if (CountEMP >= 5)
            //{
            //var frm = new Forms.FRM_EVALUATION();
            //frm.ShowDialog();
            //this.Enabled = false;
            //// }
        }
        private void CmdNew_Click(object sender, EventArgs e)
        {
            //int CountEMP = tBL_EMPSTableAdapter.GetData().Count;
            //if (CountEMP >= 5)
            //{
            //    var frm = new Forms.FRM_EVALUATION();
            //    frm.ShowDialog();
            //    this.Enabled = false;
            //}
            EmptyData();
            EnableAll(true);
            //if (tBL_EMPSTableAdapter1.ScalarQueryMAX() != null)
            //{
            //    txtIdProf.Text = ((int)tBL_EMPSTableAdapter1.ScalarQueryMAX() + 1).ToString();
            //}
            //else
            //{
            //    txtIdProf.Text = "1";
            //}
            CmdNew.Enabled = false;
            CmdSave.Enabled = true;
            CmdDelete.Enabled = false;
            CmdModify.Enabled = false;
            BtnWebCam.Enabled = true;
            BtnParcour.Enabled = true;
            BtnCodeBarre.Enabled = true;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //int CountEMP = tBL_EMPSTableAdapter.GetData().Count;
            //if (CountEMP >= 5)
            //{
            //    var frm = new Forms.FRM_EVALUATION();
            //    frm.ShowDialog();
            //    this.Enabled = false;
            //}
            //if (string.IsNullOrEmpty(txtPrenomProf.Text) | string.IsNullOrEmpty(txtPosteProf.Text) | string.IsNullOrEmpty(TxtSalaire.Text))
            //{
            //    this.Alert("رجاء أدخل جميع البيانات", FRM_ALERT.enmType.Error);
            //    return;
            //}

            ////انشاء الباركود تلقائيا اذا لم يتم انشاءه من قبل
            //Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //imgageQRCode.Image = qrcode.Draw(txtIdProf.Text, 50);


            ////تهيئة الملف لادراج الصور في  قاعدة البيانات
            //imgageFinger.Image = Properties.Resources.icons8_fingerprint_64;
            //MemoryStream msAbon = new MemoryStream();
            //imgageFinger.Image.Save(msAbon, ImageFormat.Jpeg);
            //byte[] byteimageFinger = msAbon.ToArray();


            //MemoryStream msAbon01 = new MemoryStream();
            //ImgAbonnee.Image.Save(msAbon01, ImageFormat.Jpeg);
            //byte[] byteimageAbon = msAbon01.ToArray();


            //MemoryStream msAbon02 = new MemoryStream();
            //imgageQRCode.Image.Save(msAbon02, ImageFormat.Jpeg);
            //byte[] byteimageCode = msAbon02.ToArray();

            //if (OnModify == false)
            //{
            //    this.tBL_EMPSTableAdapter1.InsertQuery(txtPrenomProf.Text, txtDateNaissProf.Value,
            //    txtLieuNaissProf.Text, txtAdresseProf.Text, Sex, txtDateNaissInscr.Value, txtDiplomeProf.Text, txtPosteProf.Text, TxtSalaire.Text,
            //    txtEtaCivile.Text, txtTel01Prof.Text, txtTel02Prof.Text, txtEmailProf.Text, txtNoteProf.Text, byteimageAbon, byteimageCode, byteimageFinger);

            //    this.Alert("تم إنشاء موظف (ة) بنجاح", FRM_ALERT.enmType.Success);

            //}
            //else
            //{
            //    this.tBL_EMPSTableAdapter1.UpdateQuery(txtPrenomProf.Text, txtDateNaissProf.Value,
            //  txtLieuNaissProf.Text, txtAdresseProf.Text, Sex, txtDateNaissInscr.Value, txtDiplomeProf.Text, txtPosteProf.Text, TxtSalaire.Text,
            //  txtEtaCivile.Text, txtTel01Prof.Text, txtTel02Prof.Text, txtEmailProf.Text, txtNoteProf.Text, byteimageAbon, byteimageCode, byteimageFinger, int.Parse(txtIdProf.Text));
            //    this.Alert("تم تعديل موظف (ة) بنجاح", FRM_ALERT.enmType.Success);
            //}


            ////اعدادات الازرار 
            //EmptyData();
            //EnableAll(false);
            //CmdNew.Enabled = true;
            //CmdSave.Enabled = false;
            //CmdDelete.Enabled = false;
            //CmdModify.Enabled = false;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtIdProf.Text))
            //{
            //    if (MessageBox.Show("هل تريد حذف ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    {
            //        this.tBL_EMPSTableAdapter1.DeleteQuery(int.Parse(txtIdProf.Text));
            //        this.Alert("تم الحذف بنجاح", FRM_ALERT.enmType.Success);

            //        CmdNew.Enabled = true;
            //        CmdModify.Enabled = false;
            //        CmdSave.Enabled = false;
            //        CmdDelete.Enabled = false;
            //        EmptyData();

            //    }
            //}
            //else
            //{
            //    this.Alert("رجاء أدخل جميع البيانات", FRM_ALERT.enmType.Error);
            //    return;
            //}
        }

        private void CmdModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdProf.Text))
            {
                OnModify = true;
                EnableAll(true);
                CmdNew.Enabled = false;
                CmdSave.Enabled = true;
                CmdDelete.Enabled = true;
                CmdModify.Enabled = false;
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            //Forms.FRM_EMP_SEARCH frm = new FRM_EMP_SEARCH("FRM_EMP_ADD");
            //frm.ShowDialog();
            //txtIdProf.Text = NumIdProf.ToString();
            //Get_Search();
            //EnableAll(false);
            //CmdSave.Enabled = false;
            //CmdSearch.Enabled = true;
            //CmdDelete.Enabled = true;
            //CmdModify.Enabled = true;
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            OnModify = false;
            CmdSave.Enabled = false;
            CmdNew.Enabled = true;
            CmdDelete.Enabled = false;
            CmdModify.Enabled = false;
            EmptyData();
            EnableAll(false);
        }

        public void Get_Search()
        {
            //DataTable Dts = this.tBL_EMPSTableAdapter1.GetDataByID_EMP(int.Parse(txtIdProf.Text));
            //for (int i = 0; i < Dts.Rows.Count; i++)
            //{
            //    txtIdProf.Text = Dts.Rows[i][0].ToString();
            //    txtPrenomProf.Text = Dts.Rows[i][1].ToString();
            //    txtDateNaissProf.Value = DateTime.Parse(Dts.Rows[i][2].ToString());
            //    txtLieuNaissProf.Text = Dts.Rows[i][3].ToString();
            //    txtAdresseProf.Text = Dts.Rows[i][4].ToString();
            //    txtDateNaissInscr.Value = DateTime.Parse(Dts.Rows[i][6].ToString());
            //    txtDiplomeProf.Text = Dts.Rows[i][7].ToString();
            //    txtPosteProf.Text = Dts.Rows[i][8].ToString();
            //    TxtSalaire.Text = Dts.Rows[i][9].ToString();
            //    txtEtaCivile.Text = Dts.Rows[i][10].ToString();
            //    txtTel01Prof.Text = Dts.Rows[i][11].ToString();
            //    txtTel02Prof.Text = Dts.Rows[i][12].ToString();
            //    txtEmailProf.Text = Dts.Rows[i][13].ToString();
            //    txtNoteProf.Text = Dts.Rows[i][14].ToString();

            //    byte[] imageAbon = (byte[])this.tBL_EMPSTableAdapter1.GetDataByID_EMP(int.Parse(txtIdProf.Text)).Rows[0][15];
            //    ImgAbonnee.Image = byteArrayToImage(imageAbon);

            //    byte[] imageAbon1 = (byte[])this.tBL_EMPSTableAdapter1.GetDataByID_EMP(int.Parse(txtIdProf.Text)).Rows[0][16];
            //    imgageQRCode.Image = byteArrayToImage(imageAbon1);

            //    byte[] imageAbon2 = (byte[])this.tBL_EMPSTableAdapter1.GetDataByID_EMP(int.Parse(txtIdProf.Text)).Rows[0][17];
            //    imgageFinger.Image = byteArrayToImage(imageAbon2);

            //    EnableAll(false);
            //}
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void BtnFinger_Click(object sender, EventArgs e)
        {
            //var frm = new Forms.FRM_SCAN_FINGER();
            //frm.ShowDialog();
        }

        private void BtnParcour_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            Ofd.Filter = "Files Images|*.JPG; *.PNG; *.GIF; *.BMP";
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                ImgAbonnee.Image = Image.FromFile(Ofd.FileName);
                PathImage = Ofd.FileName.ToString();
            }
        }

        private void BtnWebCam_Click(object sender, EventArgs e)
        {
            var frm = new FRM_CAM();
            frm.ShowDialog();
            ImgAbonnee.Image = Pic_PROF.Image;
        }

        private void BtnCodeBarre_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgageQRCode.Image = qrcode.Draw(txtIdProf.Text, 50);
        }

        private void TxtSalaire_Leave(object sender, EventArgs e)
        {
            try
            {
                //Double value = double.Parse(TxtSalaire.Text);
                //TxtSalaire.Text = value.ToString("N");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void txtPrenomProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLieuNaissProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAdresseProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDiplomeProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPosteProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtSalaire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTel01Prof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTel02Prof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEmailProf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGListProfs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGListProfs_SelectionChanged(object sender, EventArgs e)
        {

        }


    }
}
