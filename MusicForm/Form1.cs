using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MusicForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public async void GetData()
        {
            string baseUrl = "https://localhost:5001/api/music/valid";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String json = await content.ReadAsStringAsync();
                            JArray j = JArray.Parse(json);
                            List<Music> elements = new List<Music>();
                            foreach (var elem in j)
                            {

                                elements.Add(new Music()
                                {
                                    Title = (string)elem["title"],
                                    Genre = (string)elem["genre"],
                                    Price = (decimal)elem["price"],
                                    Rating = (string)elem["rating"],
                                    ReleaseDate = (DateTime)elem["datetime"],
                                    isValid = (Boolean)elem["isValid"],
                                });


                            }
                            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(j.ToString(), (typeof(DataTable)));
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
