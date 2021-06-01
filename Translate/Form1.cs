using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Translate
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> translateText;
        private string lang = "en-ru";
        private string text;

        public Form1()
        {
            InitializeComponent();
            
            switchLanguage.SelectedIndex = 0;
            saveFileDialog1.Filter = "Normal text file|*.txt|Xml file|*.xml|Json file|*.json|All types|*.*";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lang == "en-ru") lang = "ru-en";
            else lang = "en-ru";
            string text = textField1.Text;
            textField1.Text = textField2.Text;
            textField2.Text = text;
        }
        private string getContent(string text)
        {
            string url = string.Format("https://fasttranslator.herokuapp.com/api/v1/text/to/text?source={0}&lang={1}", text, lang);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            JObject json1 = JObject.Parse(output.ToString());
            Console.WriteLine();
            return (string)json1.GetValue("data");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textField1.Text != "") textField2.Text = getContent(textField1.Text);
        }
        
        public void WriteToJson(string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                if (lang == "en-ru") text = "{'en': '" + textField1.Text + "', 'ru': '" + textField2.Text + "' }";
                else text = "{'en': '" + textField2.Text + "', 'ru': '" + textField1.Text + "' }";
                JObject json = JObject.Parse(text);
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, json);
                MessageBox.Show("Файл сохранен");
            }
        }
        
        public void WriteToXml(string filename)
        {
            if (lang == "en-ru")
            {
                translateText = new Dictionary<string, string>
                {
                    {"ru", textField2.Text},
                    {"en", textField1.Text}
                };
            }
            else
            {
                translateText = new Dictionary<string, string>
                {
                    {"ru", textField1.Text},
                    {"en", textField2.Text}
                };
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Xml[]),
                                 new XmlRootAttribute() { ElementName = "translate" });
            TextWriter writer = File.CreateText(filename);
            serializer.Serialize(writer,
              translateText.Select(kv => new Xml() { lang = kv.Key, text = kv.Value }).ToArray());
            writer.Close();
            MessageBox.Show("Файл сохранен");
        }
        public void WriteToFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.EndsWith(".xml")) WriteToXml(saveFileDialog1.FileName);
                else if (saveFileDialog1.FileName.EndsWith(".json")) WriteToJson(saveFileDialog1.FileName);
                else
                {
                    string filename = saveFileDialog1.FileName;
                    text = textField1.Text + "\n\n" + textField2.Text;
                    File.WriteAllText(filename, text);
                    MessageBox.Show("Файл сохранен");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }


    }
}
public class Xml
{
    [XmlAttribute]
    public string lang;
    [XmlAttribute]
    public string text;
}