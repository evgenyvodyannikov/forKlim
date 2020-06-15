using System;
using System.Windows.Forms;

namespace Строки_15._06_Клим__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string result = "";
            string s = textBox1.Text;
            //while (s.IndexOf('.') >= 0)
            //{
            //    result += s.Insert(s.IndexOf('.'), "..");
            //    result.Remove(result.IndexOf('.') + 2, result.Length - result.IndexOf('.') - 2);
            //    s = s.Remove(0, s.IndexOf('.') + 1);
            //}
            s = s.Replace(".", "...");
            textBox1.Text = s;
        }
    }
}
