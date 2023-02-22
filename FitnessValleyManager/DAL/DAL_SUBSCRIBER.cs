using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using FitnessValleyManager.ENTITIES;
using System.IO;
using System.Drawing.Imaging;

namespace FitnessValleyManager.DAL
{
    public class DAL_SUBSCRIBER
    {
        IFirebaseClient client;
        IFirebaseConfig con = new FirebaseConfig
        {
            AuthSecret = "OiU15ePqRhbCfb05N0QVKKoaTKDBLqRMqrCH5Qg2",
            BasePath = "https://dbfitnessvalley-default-rtdb.firebaseio.com/"
        };

        public DAL_SUBSCRIBER()
        {
            client = new FirebaseClient(con);
        }

        public string ConvertImage(Bitmap tempBitmap)
        {
            MemoryStream objStream = new MemoryStream();
            tempBitmap.Save(objStream, ImageFormat.Jpeg);
            return Convert.ToBase64String(objStream.ToArray());
        }

        //Add new Subscriber In database
        public async Task<int> AddSubscriber(int ID_SUB ,string RegisteCivile_SUB,string IDCard_SUB,string Nom_SUB,string DateNaiss_SUB,string LieuNaiss_SUB,string DateInscrip_SUB,string Sexe_SUB ,string Phone_SUB ,string Adresse_SUB,
            string Email_SUB, string Nationalite_SUB, Bitmap QrCode_SUB, Bitmap Image_SUB)
        {
            int Reponce = 0;
            var dt = new CLS_SUBSCRIBER
            {
                ID_SUB = ID_SUB,
                RegisteCivile_SUB = RegisteCivile_SUB,
                IDCard_SUB = IDCard_SUB,
                Nom_SUB = Nom_SUB,
                DateNaiss_SUB = DateNaiss_SUB,
                LieuNaiss_SUB = LieuNaiss_SUB,
                DateInscrip_SUB = DateInscrip_SUB,
                Sexe_SUB = Sexe_SUB,
                Phone_SUB = Phone_SUB,
                Adresse_SUB = Adresse_SUB,
                Email_SUB = Email_SUB,
                Nationalite_SUB = Nationalite_SUB,
                QrCode_SUB = ConvertImage(QrCode_SUB),
                Image_SUB = ConvertImage(Image_SUB)
            };

          var Resp =  await client.PushAsync("TBL_SUBSCRIBER", dt); 
            if(Resp.StatusCode.ToString() == "OK")
            {
                Reponce = 1;
            }
            else
            {
                Reponce = 0;
            }
            return Reponce;
        }

        //Update  Subscriber In database
        public async void UpdateSubscriber(string Keys, int ID_SUB, string RegisteCivile_SUB, string IDCard_SUB, string Nom_SUB, string DateNaiss_SUB, string LieuNaiss_SUB, string DateInscrip_SUB, string Sexe_SUB, string Phone_SUB, string Adresse_SUB, string Email_SUB, string Nationalite_SUB, Bitmap QrCode_SUB, Bitmap Image_SUB)
        {
            var dt = new CLS_SUBSCRIBER
            {
                ID_SUB = ID_SUB,
                RegisteCivile_SUB = RegisteCivile_SUB,
                IDCard_SUB = IDCard_SUB,
                Nom_SUB = Nom_SUB,
                DateNaiss_SUB = DateNaiss_SUB,
                LieuNaiss_SUB = LieuNaiss_SUB,
                DateInscrip_SUB = DateInscrip_SUB,
                Sexe_SUB = Sexe_SUB,
                Phone_SUB = Phone_SUB,
                Adresse_SUB = Adresse_SUB,
                Email_SUB = Email_SUB,
                Nationalite_SUB = Nationalite_SUB,
                QrCode_SUB = ConvertImage(QrCode_SUB),
                Image_SUB = ConvertImage(Image_SUB)
            };

            await client.UpdateAsync("TBL_SUBSCRIBER/" + Keys, dt);
        }

        //Delete  Subscriber In database
        public async void DeleteSubscriber(string Keys)
        {
            await client.DeleteAsync("TBL_SUBSCRIBER/" + Keys);
        }

        //Incrementer ID of Subscriber
        public async Task<int> IncrementID()
        {
            var Res = await client.GetAsync("TBL_SUBSCRIBER");
            Dictionary<string, CLS_SUBSCRIBER> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_SUBSCRIBER>>(Res.Body.ToString());

            int maxim = 0;
            List<int> listID = new List<int>();
            foreach (var item in data)
            {
                listID.Add(item.Value.ID_SUB);
            }
            maxim = listID.Max() + 1;
            return maxim;
        }

        //GetAll Subscriber
        public async Task<DataTable> GetAllSubscribers()
        {
            DataTable dataTableSubscriber = new DataTable();
            dataTableSubscriber.Columns.Add("A", typeof(string));
            dataTableSubscriber.Columns.Add("B", typeof(string));
            dataTableSubscriber.Columns.Add("C", typeof(string));
            dataTableSubscriber.Columns.Add("D", typeof(string));
            dataTableSubscriber.Columns.Add("E", typeof(string));
            dataTableSubscriber.Columns.Add("F", typeof(string));
            dataTableSubscriber.Columns.Add("G", typeof(string));
            dataTableSubscriber.Columns.Add("H", typeof(string));
            dataTableSubscriber.Columns.Add("I", typeof(string));
            dataTableSubscriber.Columns.Add("J", typeof(string));
            dataTableSubscriber.Columns.Add("K", typeof(string));
            dataTableSubscriber.Columns.Add("L", typeof(string));
            dataTableSubscriber.Columns.Add("M", typeof(string));
            dataTableSubscriber.Columns.Add("N", typeof(string));
            dataTableSubscriber.Columns.Add("ImgQrcode", typeof(string)); 


            var Res = await client.GetAsync("TBL_SUBSCRIBER");
            Dictionary<string, CLS_SUBSCRIBER> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_SUBSCRIBER>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.Nom_SUB.ToString() != "DEFAULT")
                {
                    dataTableSubscriber.Rows.Add(new object[] { line.Key.ToString(), line.Value.IDCard_SUB.ToString() /*stringToImage(line.Value.Image_SUB)*/, line.Value.IDCard_SUB.ToString(), line.Value.ID_SUB.ToString(), line.Value.RegisteCivile_SUB.ToString(), line.Value.Nom_SUB.ToString(),
                    line.Value.DateNaiss_SUB.ToString(), line.Value.LieuNaiss_SUB.ToString(), line.Value.DateInscrip_SUB.ToString(), line.Value.Sexe_SUB.ToString(), line.Value.Phone_SUB.ToString(), line.Value.Adresse_SUB.ToString(), line.Value.Email_SUB.ToString(), line.Value.Nationalite_SUB.ToString(),line.Value.IDCard_SUB.ToString() /*stringToImage(line.Value.QrCode_SUB)*/ });
                }
            }
            return dataTableSubscriber;
        }

        //Get image from database
        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);

            // Don't need to use the constructor that takes the starting offset and length
            // as we're using the whole byte array.
            MemoryStream ms = new MemoryStream(imageBytes); 
            Image image = Image.FromStream(ms, true, true); 
            return image;
        }

        //GetAll Subscriber QrCode
        public async Task<Image> GetQrCodeSubscriber(int ID_SUB)
        { 
            Image Qrcode = FitnessValleyManager.Properties.Resources.cf258720ded328c92d5a821c78b5a052;
            var Res = await client.GetAsync("TBL_SUBSCRIBER");
            Dictionary<string, CLS_SUBSCRIBER> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_SUBSCRIBER>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.ID_SUB == ID_SUB)
                {
                    Qrcode = stringToImage(line.Value.QrCode_SUB);
                }
            }
            return Qrcode;
        }

        //GetAll Subscriber Image
        public async Task<Image> GetImageSubscriber(int ID_SUB)
        {
            Image ImgSub = FitnessValleyManager.Properties.Resources.icons8_school_director_48;
            var Res = await client.GetAsync("TBL_SUBSCRIBER");
            Dictionary<string, CLS_SUBSCRIBER> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_SUBSCRIBER>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.ID_SUB == ID_SUB)
                {
                    ImgSub = stringToImage(line.Value.Image_SUB);
                }
            }
            return ImgSub;
        }

    }
}
