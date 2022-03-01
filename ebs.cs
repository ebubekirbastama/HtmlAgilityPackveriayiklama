using System;
using System.Linq;
using System.Windows.Forms;

namespace EBS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(richTextBox1.Text);
            var df = html.DocumentNode.SelectNodes("//fatura//fatno").ToArray()[0].InnerText;
        }

    }
}
