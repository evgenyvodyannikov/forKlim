using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Строки_15._06_Клим__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string result = null;
            bool zapyataya = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                { result += s[i].ToString(); }
                if (s[i] == ',')
                { if (i != 0 && zapyataya == false)
                    { result += s[i].ToString(); zapyataya = true; } 
                }
            }
            decimal res = decimal.Parse(result);
            textBox1.Text = res.ToString();
        }
    }
}
