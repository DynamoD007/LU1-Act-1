using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LU1_Act_1
{
    public partial class Form2 : Form
    {
        public string label1;
        public Form2()
        {
            InitializeComponent();
            
        }

        public string _textBox1
        {
            get { return textBox1.Text; }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form1 frm = new Form1();
            frm._textBox = _textBox1;
            frm.Show();
            this.Hide();
        }

    }
}
