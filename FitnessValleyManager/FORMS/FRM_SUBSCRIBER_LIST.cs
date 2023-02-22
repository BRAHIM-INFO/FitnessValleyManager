using FitnessValleyManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessValleyManager
{
    public partial class FRM_SUBSCRIBER_LIST : Form
    {
        DAL_SUBSCRIBER DAL_SUBSCRIBER = new DAL_SUBSCRIBER();
        public FRM_SUBSCRIBER_LIST()
        {
            InitializeComponent();
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private async void Messages_Load(object sender, EventArgs e)
        {
           DataTable dataTable = await DAL_SUBSCRIBER.GetAllSubscribers();

            DG_Subscribers.Rows.Add(dataTable.Rows.Count);
            for(int i=0; i < dataTable.Rows.Count;i++)
            { 
                DG_Subscribers.Rows[i].Cells[1].Value = Image.FromFile("photos\\1.png");
                DG_Subscribers.Rows[i].Cells[2].Value = dataTable.Rows[i][2].ToString();
                DG_Subscribers.Rows[i].Cells[3].Value = dataTable.Rows[i][3].ToString();
                DG_Subscribers.Rows[i].Cells[4].Value = dataTable.Rows[i][5].ToString();
                DG_Subscribers.Rows[i].Cells[5].Value = dataTable.Rows[i][6].ToString();
                DG_Subscribers.Rows[i].Cells[6].Value = dataTable.Rows[i][4].ToString();
                DG_Subscribers.Rows[i].Cells[7].Value = dataTable.Rows[i][8].ToString();
                DG_Subscribers.Rows[i].Cells[8].Value = dataTable.Rows[i][10].ToString();
                DG_Subscribers.Rows[i].Cells[9].Value  =  dataTable.Rows[i][11].ToString();
                DG_Subscribers.Rows[i].Cells[10].Value = dataTable.Rows[i][7].ToString();
                DG_Subscribers.Rows[i].Cells[11].Value = dataTable.Rows[i][12].ToString();
                DG_Subscribers.Rows[i].Cells[12].Value = dataTable.Rows[i][13].ToString();
            }
           

            //guna2DataGridView1.Rows[1].Cells[1].Value = Image.FromFile("photos\\5.png");
            //guna2DataGridView1.Rows[1].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[1].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[1].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[1].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[1].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[1].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[2].Cells[1].Value = Image.FromFile("photos\\3.png");
            //guna2DataGridView1.Rows[2].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[2].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[2].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[2].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[2].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[2].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[3].Cells[1].Value = Image.FromFile("photos\\4.png");
            //guna2DataGridView1.Rows[3].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[3].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[3].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[3].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[3].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[3].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[4].Cells[1].Value = Image.FromFile("photos\\5.png");
            //guna2DataGridView1.Rows[4].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[4].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[4].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[4].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[4].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[4].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[5].Cells[1].Value = Image.FromFile("photos\\6.png");
            //guna2DataGridView1.Rows[5].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[5].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[5].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[5].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[5].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[5].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[6].Cells[1].Value = Image.FromFile("photos\\5.png");
            //guna2DataGridView1.Rows[6].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[6].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[6].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[6].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[6].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[6].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[7].Cells[1].Value = Image.FromFile("photos\\1.png");
            //guna2DataGridView1.Rows[7].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[7].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[7].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[7].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[7].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[7].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[8].Cells[1].Value = Image.FromFile("photos\\1.png");
            //guna2DataGridView1.Rows[8].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[8].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[8].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[8].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[8].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[8].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[9].Cells[1].Value = Image.FromFile("photos\\1.png");
            //guna2DataGridView1.Rows[9].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[9].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[9].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[9].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[9].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[9].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[10].Cells[1].Value = Image.FromFile("photos\\1.png");
            //guna2DataGridView1.Rows[10].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[10].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[10].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[10].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[10].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[10].Cells[7].Value = "Jan 21,2020";

            //guna2DataGridView1.Rows[11].Cells[1].Value = Image.FromFile("photos\\1.png");
            //guna2DataGridView1.Rows[11].Cells[2].Value = "Dian Cooper";
            //guna2DataGridView1.Rows[11].Cells[3].Value = "(239)555-2020";
            //guna2DataGridView1.Rows[11].Cells[4].Value = "Cilacap";
            //guna2DataGridView1.Rows[11].Cells[5].Value = "Jan 21,2020 -13:30";
            //guna2DataGridView1.Rows[11].Cells[6].Value = "Jan 21,2020";
            //guna2DataGridView1.Rows[11].Cells[7].Value = "Jan 21,2020";

            lblCountSub.Text = DG_Subscribers.Rows.Count.ToString();
        }

        private  void DG_Subscribers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(DG_Subscribers.Rows.Count > 1)
            {
                txtLieuNaiss_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[9].Value.ToString();
                txtAdresse_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[10].Value.ToString();
                txtEmail_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[11].Value.ToString();
                txtNationalite_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[12].Value.ToString();
            } 
        }

        private void DG_Subscribers_SelectionChanged(object sender, EventArgs e)
        {
            //if (DG_Subscribers.Rows.Count > 0)
            //{
            //    txtLieuNaiss_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[9].Value.ToString();
            //    txtAdresse_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[10].Value.ToString();
            //    txtEmail_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[11].Value.ToString();
            //    txtNationalite_SUB.Text = DG_Subscribers.Rows[DG_Subscribers.CurrentRow.Index].Cells[12].Value.ToString();
            //}
        }
    }
}
