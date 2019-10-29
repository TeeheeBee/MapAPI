using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace JSON
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        public static IEnumerable<TResult> ReadJson<TResult>(Stream stream)
        {
            var serializer = new JsonSerializer();

            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    yield return serializer.Deserialize<TResult>(jsonReader);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string jsonStr = "{\"myProperty\": \"foo\"}{\"myProperty\": \"bar\"}{\"myProperty\": \"baz\"}";

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
            {
                IEnumerable<MyClass> result = ReadJson<MyClass>(stream);

                foreach (var item in result)
                {
                    Console.WriteLine(item.MyProperty);
                }
            }
        }
    }



    public class MyClass
    {
        public string MyProperty { get; set; }
    }
}
