using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Insert(textBox1.Text);
           
        }

        public void Insert(string nom)
        {

            List<string> listzz = new List<string>();

            listzz.Add(nom);

            foreach (string ver in listzz)
            {
                dataGridView1.Rows.Add(ver);
            }

            textBox1.Text = "";
        }
    }
}
