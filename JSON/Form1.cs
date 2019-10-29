using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSON
{
    public partial class Form1 : Form
    {
        //private readonly string _path = $"d:\\Apps\\JSON\\JSON\\Customer.json";
        private readonly string _path = $"d:\\Apps\\JSON\\JSON\\Servers.json";
        public Form1()
        {
            InitializeComponent();
            //ServersList serversList = serverComm.ReadJSON();
            //servers = serversList.Servers;
            //cBserverList.Items.Clear();
            //foreach (var i in servers)
            //{
            //    cBserverList.Items.Add(Convert.ToString(i.Name));
            //}
        }
        List<Server> servers;
        ServerComm serverComm = new ServerComm();
        ServersList serversList = new ServersList();
        private void buttonReadJson_Click(object sender, EventArgs e)
        {
            ReadServersList();
            //ServersList serversList = serverComm.ReadJSON();
            //serversList = serverComm.ReadJSON();
            //servers = serversList.Servers;
            //cBserverList.Items.Clear();
            //foreach(var i in servers)
            //{
            //    cBserverList.Items.Add(Convert.ToString(i.Name)); 
            //}
        }
        private void buttonWriteJson_Click(object sender, EventArgs e)
        {
            try
            {
                Server s = GetServerFromInput();
                servers.RemoveAt(s.Id);
                servers.Insert(s.Id, s);
                WriteServersList(serversList);
                ReadServersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnWriteNewFromThis_Click(object sender, EventArgs e)
        {
            try
            {
                Server s = GetServerFromInput();
                s.Id = servers.Count();
                servers.Add(s);
                WriteServersList(serversList);
                ReadServersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnWriteNewFromBlank_Click(object sender, EventArgs e)
        {
            EmptyInputForm();
            Server s = new Server();
            s.Id = servers.Count();
            s.Link = "";
            s.Name = "";
            s.ServerLoad = 0;
            s.AppID = "";
            s.AppCode = "";
            s.HitsStartDate = DateTime.Now;
            s.DateToResetHits = DateTime.Now;
            s.Hits = 0;
            s.Type = 0;
            servers.Add(s);
            WriteServersList(serversList);
            ReadServersList();
        }
        Server GetServerFromInput()
        {
            Server s = new Server();
            s.Link = tBformatLink.Text;
            //s.Id = Convert.ToInt32(lblid.Text);
            s.Name = tBName.Text;
            s.ServerLoad = Convert.ToInt32(tBServerLoad.Text);
            s.AppID = tBAppID.Text;
            s.AppCode = tBAppCode.Text;
            s.HitsStartDate = Convert.ToDateTime(tBHitsStartDate.Text);
            s.DateToResetHits = Convert.ToDateTime(tBDateToResetHits.Text);
            s.Hits = Convert.ToInt32(tBHits.Text);
            s.Type = Convert.ToInt32(tBType.Text);
            return s;
        }

        void EmptyInputForm()
        {
            tBformatLink.Text = "";
            FinalLink = "";
            lblFinalLink.Text = "";
            lblid.Text = "";
            tBName.Text = "";
            tBServerLoad.Text = "";
            tBAppID.Text = "";
            tBAppCode.Text = "";
            tBHitsStartDate.Text = "";
            tBDateToResetHits.Text = "";
            tBHits.Text = "";
            tBType.Text = "";
        }

        void ReadServersList()
        {
            serversList = serverComm.ReadJSON();
            servers = serversList.Servers;
            cBserverList.Items.Clear();
            foreach (var i in servers)
            {
                cBserverList.Items.Add(Convert.ToString(i.Name));
            }
        }
        void WriteServersList(ServersList serversList)
        {
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(serversList, Formatting.Indented);
                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Bitmap Tile;
        string FinalLink;
        Server s = new Server();
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cBserverList.SelectedIndex;
            s = servers[index];
            int serverNo = serverComm.GetServerNo(servers[index].ServerLoad, 0, 0);
            tBformatLink.Text      = s.Link;
            FinalLink              = serverComm.GetHttpsLink(s.Id, s.Link, serverNo, 14, 8922, 5847, s.AppID, s.AppCode);
            lblFinalLink.Text      = FinalLink;
            lblid.Text             = Convert.ToString(s.Id);
            tBName.Text            = Convert.ToString(s.Name);
            tBServerLoad.Text      = Convert.ToString(s.ServerLoad);
            tBAppID.Text           = Convert.ToString(s.AppID);
            tBAppCode.Text         = Convert.ToString(s.AppCode);
            tBHitsStartDate.Text   = Convert.ToString(s.HitsStartDate);
            tBDateToResetHits.Text = Convert.ToString(s.DateToResetHits);
            tBHits.Text            = Convert.ToString(s.Hits);
            tBType.Text            = Convert.ToString(s.Type);
        }

        private void BtnTestTileLoad_Click(object sender, EventArgs e)
        {
            Tile = serverComm.DownloadTile(FinalLink);
            if (Tile != null)
            {
                pictureBox1.Image = Tile;
                s.Hits++;
            }
        }

        private void BtnDeleteServer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Server s = GetServerFromInput();
                    servers.RemoveAt(s.Id);
                    WriteServersList(serversList);
                    ReadServersList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Spas u zadnji čas");
            }
        }
    }
}



