using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Display
{
    public partial class Suppliers : Form
    {
        controller musuem;
        public Suppliers(controller obj)
        {
            InitializeComponent();
            musuem = obj;
            comboBox1.DataSource = musuem.getallsuppliersnames();
            comboBox1.DisplayMember = "SupplierID";
            comboBox1.ValueMember = "SupplierID";
            dataGridView1.DataSource = musuem.getallsuppliersnames();
    
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         dataGridView1.DataSource=   musuem.getsupplierbysupplierid(comboBox1.SelectedValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
         dataGridView1.DataSource=   musuem.getsupplierbysuppliername(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musuem.getallsuppliersnames();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
