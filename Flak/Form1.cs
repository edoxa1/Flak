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

namespace Flak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string[] space;
        string text;

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(s, Encoding.Default);
                text = sr.ReadToEnd();
                space = text.Split(' ');
                richTextBox1.Text = text;
                label1.Text = $"Количество слов: {space.Length}";
                sr.Close();
            }
        }
    }
}
