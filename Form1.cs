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
    public partial class Form1 : Form
    {
        public string label;

        public Form1()
        {
            InitializeComponent();
            label1.Text = label;
            label1.Visible = true;
            
        }

        public string _textBox
        {
            set { label1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            this.Hide();
            form2.Show();           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
