using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    
    public partial class salesfunc : Form
    {
        controller MuseumController;
        public salesfunc(controller obj)
        {
            MuseumController = obj;
            InitializeComponent();
            DataTable dt = MuseumController.getallsalesinfo();
            if (dt == null)
            {
                MessageBox.Show("sales table is empty");
            }
            else
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ItemName";
                comboBox1.ValueMember = "BarCode";
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "ItemName";
                comboBox5.ValueMember = "BarCode";
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ItemName";
                comboBox2.ValueMember = "BarCode";
            }
           dt = MuseumController.getallsuppliersinfo();
            if (dt == null)
            {
                MessageBox.Show("Supplier table is empty");
            }
            else
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "SupplierName";
                comboBox4.ValueMember = "SupplierID";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "SupplierName";
                comboBox3.ValueMember = "SupplierID";
            }
        }
 
      
   

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void additem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            int x = MuseumController.addsalesitem(textBox2.Text, textBox1.Text, textBox7.Text, textBox6.Text, comboBox4.SelectedValue.ToString(), textBox3.Text, textBox4.Text, textBox5.Text, label23.Text);
            if ( x == 0)
            {
                MessageBox.Show("insertion of new item failed");
            }
            else
            {
                MessageBox.Show("inserted item successfully");
                DataTable dt = MuseumController.getallsalesinfo();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ItemName";
                comboBox1.ValueMember = "BarCode";
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "ItemName";
                comboBox5.ValueMember = "BarCode";
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ItemName";
                comboBox2.ValueMember = "BarCode";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            DataTable dt = MuseumController.CalculateProfit(Int32.Parse(comboBox1.SelectedValue.ToString()));
            label22.Text = dt.Rows[0][0].ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox16.Text=="")
            {
                MessageBox.Show("Please Enter the Ratio");
                return;
            }

            int x = MuseumController.UpdateSalesUnitCostandSellingPrice(Int32.Parse(textBox16.Text));

            if (x == 0)
            {
                MessageBox.Show("Failed to Add Taxes");
            }
            else
            {
                MessageBox.Show("Successfully Added Taxes");
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSales_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataTable dt = MuseumController.getallsalesinfobyname(comboBox5.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox10.Text == "" || textBox9.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            int x = MuseumController.updatesalesitem(comboBox5.SelectedValue.ToString(), textBox13.Text, textBox10.Text, textBox9.Text, comboBox3.SelectedValue.ToString(), textBox12.Text, textBox11.Text, textBox8.Text);
            if (x == 0)
            {
                MessageBox.Show("updating  item failed");
            }
            else
            {
                MessageBox.Show("item updated successfully");
                DataTable dt = MuseumController.getallsalesinfobyname(comboBox5.SelectedValue.ToString());
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.getallsalesinfobyname(comboBox2.SelectedValue.ToString());
            label33.Text = dt.Rows[0][1].ToString();
            label37.Text = dt.Rows[0][2].ToString();
            label38.Text = dt.Rows[0][3].ToString();
            label40.Text = dt.Rows[0][4].ToString();
            label35.Text = dt.Rows[0][5].ToString();
            label36.Text = dt.Rows[0][6].ToString();
            label39.Text = dt.Rows[0][7].ToString();

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            int x = MuseumController.deletesalesitem(comboBox2.SelectedValue.ToString());
            if (x == 0)
            {
                MessageBox.Show("deleting  item failed");
            }
            else
            {
                MessageBox.Show("item  deleted successfully");
                DataTable dt = MuseumController.getallsalesinfo(); 
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ItemName";
                comboBox1.ValueMember = "BarCode";
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "ItemName";
                comboBox5.ValueMember = "BarCode";
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ItemName";
                comboBox2.ValueMember = "BarCode";
                label33.Text = "..";
                label37.Text = "..";
                label38.Text = "..";
                label40.Text = "..";
                label35.Text = "..";
                label36.Text = "..";
                label39.Text = "..";
            }

        }
    }
}
