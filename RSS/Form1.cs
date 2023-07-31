using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string haber (string link)
        {
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
            return link;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            haber("https://www.hurriyet.com.tr/rss/anasayfa");
        }
    }
}
