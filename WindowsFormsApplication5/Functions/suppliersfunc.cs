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
    public partial class suppliersfunc : Form
    {
        controller musueemcontroller;
   
        public suppliersfunc(controller obj)
        {
            musueemcontroller = obj;
         
            InitializeComponent();
            DataTable dt = musueemcontroller.getallsuppliersnames();
            if (dt == null)
            {
                MessageBox.Show("Suppliers table is empty");
            }
            else
            {


                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SupplierName";
                comboBox1.ValueMember = "SupplierID";
                comboBox2.DataSource =dt;
                comboBox2.DisplayMember = "SupplierName";
                comboBox2.ValueMember = "SupplierID"; 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void addsupplier_Click(object sender, EventArgs e)
        {
            int check=0 ;
            if (supplierid.Text.Length == 0 || suppliername.Text.Length == 0 || fax.Text.Length == 0 || address.Text.Length == 0 || homepage.Text.Length == 0 || city.Text.Length == 0 || region.Text.Length == 0 || postalcode.Text.Length == 0 || phone.Text.Length == 0)
            {

                MessageBox.Show("please fill all the form ");
            }
            else
            {
              
             check =   musueemcontroller.addnewsupplier(supplierid.Text,suppliername.Text,fax.Text,address.Text,city.Text,region.Text,postalcode.Text,phone.Text,homepage.Text);
            }
            if (check > 0)
            {
                MessageBox.Show("the supplier has been added sucessfuly ");

            }
            else
            {
                MessageBox.Show("their is an error happened ");


            }
        }

        private void homepage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void region_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void supplierid_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppliername_TextChanged(object sender, EventArgs e)
        {

        }

        private void postalcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = comboBox1.SelectedValue.ToString();
            DataTable dt =  musueemcontroller.getsupplierbysupplierid(select);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (textbox8.Text.Length == 0 || textBox9.Text.Length == 0 || textBox10.Text.Length == 0 || textBox11.Text.Length == 0 || textBox12.Text.Length == 0 || textBox13.Text.Length == 0 || textBox14.Text.Length == 0 || textBox15.Text.Length == 0)
            {

                MessageBox.Show("please fill all the form ");
            }
            else
            {
                string select = comboBox1.SelectedValue.ToString();


               check = musueemcontroller.editnewsupplier(textbox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,select);
                DataTable dt = musueemcontroller.getallsuppliersnames();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SupplierName";
                comboBox1.ValueMember = "SupplierID";
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "SupplierName";
                comboBox2.ValueMember = "SupplierID";
                dataGridView1.Refresh();
            }
            if (check > 0)
            {
                MessageBox.Show("the supplier has been added sucessfuly ");

            }
            else
            {
                MessageBox.Show("their is an error happened ");


            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = comboBox2.SelectedValue.ToString();
            DataTable dt = musueemcontroller.getsupplierbysupplierid(select);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check;
            if(comboBox2.SelectedValue !=null)
            {
               check= musueemcontroller.deletesupplier(comboBox2.SelectedValue.ToString());
                if(check>0)
                {
                    MessageBox.Show("the supplier has been deleted");
                    DataTable dt = musueemcontroller.getallsuppliersnames();
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "SupplierName";
                    comboBox2.ValueMember = "SupplierID";
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "SupplierName";
                    comboBox1.ValueMember = "SupplierID";
                    dataGridView2.Refresh();
                }
                else
                { MessageBox.Show("an error has occured"); }
            }
        }
    }
}
