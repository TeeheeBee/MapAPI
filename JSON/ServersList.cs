using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace JSON
{
    public class ServerComm
    {
        private readonly string _path = $"d:\\Apps\\JSON\\JSON\\Servers.json";
        List<Order> a;
        public ServersList ReadJSON()
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                //richTextBoxReadJson.Text = jsonFromFile;
                var serversFromJson = JsonConvert.DeserializeObject<ServersList>(jsonFromFile);
                return serversFromJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int GetServerNo (int serverLoad, int rowNumber, int columnNumber)
        {
            int serverNo = 0;
            if (serverLoad > 0)
                serverNo = 1 + ((rowNumber + columnNumber) % serverLoad);
            return serverNo;
        }

        public string GetHttpsLink (int id, string link, int serverNo, int z, int x, int y, string appID, string appCode)
        {
            string finalLink = string.Format(link, z, x, y, appID, appCode, serverNo);
            return finalLink;
        }

        public Bitmap DownloadTile(string finalLink)
        {
            Bitmap tile = null;
            WebClient client = new WebClient();
            try
            {
                Stream stream = client.OpenRead(finalLink);
                tile = new Bitmap(stream);
                stream.Flush();
                stream.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            client.Dispose();
            if (tile == null)
            {
                MessageBox.Show("Tile nije dohvaćen");
            }
            return tile;
        }

        public ServersList GetServersList()
        {
            var serversList = new ServersList
            {
                Servers = new List<Server>
                {
                    new Server
                    {
                        Id = 0,
                        Name = "Wiki Media",
                        Type = -1,
                        Link = "https://maps.wikimedia.org/osm-intl/{0}/{1}/{2}.png",
                        ServerLoad = 0,
                        AppID = "",
                        AppCode = "",
                        HitsStartDate = DateTime.Now,
                        Hits = 0,
                        DateToResetHits = DateTime.Now.AddMonths(1)
                    },
                    new Server
                    {
                        Id = 1,
                        Name = "Here Satellite",
                        Type = 25000,
                        Link = "https://{5}.aerial.maps.api.here.com/maptile/2.1/maptile/newest/satellite.day/{0}/{1}/{2}/256/png8?app_id={3}&app_code={4}",
                        ServerLoad = 4,
                        AppID = "F9VSVW1GjhHP7TUVMcqf",
                        AppCode = "CI1lzWESsMs7w6RYwKEPFQ",
                        HitsStartDate = DateTime.Now,
                        Hits = 1,
                        DateToResetHits = DateTime.Now.AddMonths(1)
                    },
                }
            };
            return serversList;
        }
    }
    public class ServersList
    {
        public List<Server> Servers { get; set; }
    }

    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Link { get; set; }
        public int ServerLoad { get; set; }
        public string AppID { get; set; }
        public string AppCode { get; set; }
        public DateTime HitsStartDate { get; set; }
        public int Hits { get; set; }
        public DateTime DateToResetHits { get; set; }
    }





}
