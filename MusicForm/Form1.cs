using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace MusicForm
{
    public partial class Form1 : Form
    {

        List<Music> Cache = new List<Music>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }

        public void GetData()
        {
            
            var t = Task.Run(() => GetURI(new Uri("https://localhost:5001/api/music/invalid")));
            t.Wait();
            JArray j = JArray.Parse(t.Result);
            Cache = new List<Music>();
            foreach (var elem in j)
            {
                Cache.Add(new Music()
                {
                    Title = (string)elem["title"],
                    Genre = (string)elem["genre"],
                    Price = (decimal)elem["price"],
                    Rating = (string)elem["rating"],
                    ReleaseDate = (DateTime)elem["releaseDate"],
                    isValid = (Boolean)elem["isValid"],
                });
            }
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(j.ToString(), (typeof(DataTable)));
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
