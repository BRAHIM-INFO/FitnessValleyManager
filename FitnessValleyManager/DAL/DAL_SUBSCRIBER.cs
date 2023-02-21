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

namespace FitnessValleyManager.DLL
{
    public class DAL_SUBSCRIBER
    {
        IFirebaseClient client;
        IFirebaseConfig con = new FirebaseConfig
        {
            AuthSecret = "Q1qazBxZzUhEHq850QKKUrYPqlskwunw6zgpP5JC",
            BasePath = "https://db-masionspa-f178e-default-rtdb.firebaseio.com/"
        };

        public BLL_CLIENTS()
        {
            client = new FirebaseClient(con);
        }

        //Add new Client In database
        public async void AddClient(int ID, string NOM, string SEXE, string PHONE, string ADRESSE, string LOCATION, double CACHBACK)
        {
            var dt = new CLS_CLIENTS
            {
                ID = ID,
                NOM = NOM,
                ADRESSE = ADRESSE,
                PHONE = PHONE,
                SEXE = SEXE,
                CACHBACK = CACHBACK,
                LOCATION = LOCATION
            };

            await client.PushTaskAsync("Tbl_Client", dt);
        }

        //Update  Client In database
        public async void UpdateClient(string Keys, int ID, string NOM, string SEXE, string PHONE, string ADRESSE, string LOCATION, double CACHBACK)
        {
            var dt = new CLS_CLIENTS
            {
                ID = ID,
                NOM = NOM,
                ADRESSE = ADRESSE,
                PHONE = PHONE,
                SEXE = SEXE,
                CACHBACK = CACHBACK,
                LOCATION = LOCATION
            };

            await client.UpdateTaskAsync("Tbl_Client/" + Keys, dt);
        }

        //Delete  Client In database
        public async void DeleteClient(string Keys)
        {
            await client.DeleteTaskAsync("Tbl_Client/" + Keys);
        }

        //Incrementer ID of Client
        public async Task<int> IncrementID()
        {
            var Res = await client.GetTaskAsync("Tbl_Client");
            Dictionary<string, CLS_CLIENTS> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_CLIENTS>>(Res.Body.ToString());

            int maxim = 0;
            List<int> listID = new List<int>();
            foreach (var item in data)
            {
                listID.Add(item.Value.ID);
            }
            maxim = listID.Max();
            return maxim;
        }

        //GetAll Client
        public async Task<DataTable> GetAllClients()
        {
            DataTable dataTableClient = new DataTable();
            dataTableClient.Columns.Add("الكاي", typeof(string));
            dataTableClient.Columns.Add("الكود", typeof(string));
            dataTableClient.Columns.Add("الاسم", typeof(string));
            dataTableClient.Columns.Add("الهاتف", typeof(string));
            dataTableClient.Columns.Add("النوع", typeof(string));
            dataTableClient.Columns.Add("العنوان", typeof(string));
            dataTableClient.Columns.Add("كاشباك", typeof(string));
            dataTableClient.Columns.Add("المنطقة", typeof(string));


            var Res = await client.GetTaskAsync("Tbl_Client");
            Dictionary<string, CLS_CLIENTS> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_CLIENTS>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.NOM.ToString() != "DEFAULT")
                {
                    dataTableClient.Rows.Add(new object[] { line.Key.ToString(), line.Value.ID.ToString(), line.Value.NOM.ToString(), line.Value.PHONE.ToString(),
                                                line.Value.SEXE.ToString(), line.Value.ADRESSE.ToString(), line.Value.CACHBACK.ToString(),line.Value.LOCATION.ToString()});
                }
            }
            return dataTableClient;
        }

        public async void GetNameClient(string NOM, string PHONE)
        {
            var Res = await client.GetTaskAsync("Tbl_Services");
            Dictionary<string, CLS_SERVICES> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_SERVICES>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.Name_Client.ToString() == NOM & line.Value.Phone_Client.ToString() == PHONE)
                {
                    var dt = new CLS_SERVICES();
                    dt.ID_Serv = line.Value.ID_Serv;
                    dt.NumFact = line.Value.NumFact;
                    dt.Date_Serv = line.Value.Date_Serv;
                    dt.Name_Client = NOM;
                    dt.Phone_Client = PHONE;
                    dt.Sex_Client = line.Value.Sex_Client;
                    dt.Adresse_Client = line.Value.Adresse_Client;
                    dt.Name_Driver = line.Value.Name_Driver;
                    dt.Name_Employer = line.Value.Name_Employer;
                    dt.Name_Spicialiste = line.Value.Name_Spicialiste;
                    dt.Takyim_Serv = line.Value.Takyim_Serv;
                    dt.NewOld_Client = line.Value.NewOld_Client;
                    dt.HowFindUs = line.Value.HowFindUs;
                    dt.PACK = line.Value.PACK;
                    dt.SERVICE = line.Value.SERVICE;
                    dt.PRICE = line.Value.PRICE;
                    dt.Qte_Serv = line.Value.Qte_Serv;
                    dt.txtReducServ = line.Value.txtReducServ;
                    dt.CACHBACK = line.Value.CACHBACK;
                    dt.Mont_Serv = line.Value.Mont_Serv;
                    dt.txtMontant = line.Value.txtMontant;
                    dt.txtReducTtl = line.Value.txtReducTtl;
                    dt.TTLCachBack = line.Value.TTLCachBack;
                    dt.txtVat = line.Value.txtVat;
                    dt.Paeiment = line.Value.Paeiment;
                    dt.TTL_Amount = line.Value.TTL_Amount;
                    dt.IfUpdate = line.Value.IfUpdate;
                    dt.IfDelate = line.Value.IfDelate;
                    var Resx = await client.UpdateTaskAsync("Tbl_Services/" + line.Key, dt);
                }

            }

        }

        //Check If Exist Phone Number  Client In database
        public async Task<bool> IfExistPhone(string PHONE)
        {
            bool ExistPhone = false;
            var Res = await client.GetTaskAsync("Tbl_Client");
            Dictionary<string, CLS_CLIENTS> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_CLIENTS>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.PHONE.ToString() == PHONE)
                {
                    ExistPhone = true;
                }
            }
            return ExistPhone;
        }

        //Check If Exist Phone Number  Client In database
        public async Task<bool> IfExistPhoneAfterUpdate(int ID, string PHONE)
        {
            bool ExistPhone = false;
            var Res = await client.GetTaskAsync("Tbl_Client");
            Dictionary<string, CLS_CLIENTS> data = JsonConvert.DeserializeObject<Dictionary<string, CLS_CLIENTS>>(Res.Body.ToString());
            foreach (var line in data)
            {
                if (line.Value.ID == ID & line.Value.PHONE.ToString() == PHONE)
                {
                    ExistPhone = true;
                }
            }
            return ExistPhone;
        }
    }
}
