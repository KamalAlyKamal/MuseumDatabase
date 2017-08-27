using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Functions
{
    public partial class Form1 : Form
    {
        controller musuem;
        public Form1(controller obj)
        {
         
            
            InitializeComponent();
            musuem = obj;
            comboBox1.DataSource = musuem.selecttopromote();
            comboBox1.DisplayMember = "SSN";
            comboBox1.ValueMember = "SSN";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musuem.promotone(comboBox1.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musuem.promotwo(comboBox1.SelectedValue.ToString());
        }
    }
}
