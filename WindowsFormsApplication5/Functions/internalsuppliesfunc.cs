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

    public partial class internalsuppliesfunc : Form
    {
        controller MuseumController;
        public internalsuppliesfunc(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
            DataTable dt = MuseumController.getallsuppliersinfo();
            if (dt == null)
            {
                MessageBox.Show("Suppliers table is empty");
            }
            else
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SupplierName";
                comboBox1.ValueMember = "SupplierID";
                comboBox6.DataSource = dt;
                comboBox6.DisplayMember = "SupplierName";
                comboBox6.ValueMember = "SupplierID";
            }
            dt = MuseumController.getallinternalsupplyitems();
            if (dt == null)
            {
                MessageBox.Show("Internalsupplies table is empty");
            }
            else
            {
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SuppliedItemName";
                comboBox5.ValueMember = "SuppliedItemName";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "SuppliedItemName";
                comboBox3.ValueMember = "SuppliedItemName";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (textBox11.Text == "" || textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            if (Int32.Parse(textBox11.Text) < (Int32.Parse(textBox1.Text)) + (Int32.Parse(textBox3.Text)))
            {
                MessageBox.Show("total quantity cant be less the the sum of quantity exhibits and quantity research");
                return;
            }
            int x = MuseumController.AddNewInternalSupplies(Int32.Parse(textBox11.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox1.Text), textBox2.Text, Int32.Parse(comboBox1.SelectedValue.ToString()), 10);
            if (x == 1)
            {
                //Succesffuly Added
                MessageBox.Show("Internal Supply Added Successfully");
                DataTable dt = MuseumController.getallinternalsupplyitems();
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SuppliedItemName";
                comboBox5.ValueMember = "SuppliedItemName";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "SuppliedItemName";
                comboBox3.ValueMember = "SuppliedItemName";
            }
            else
                MessageBox.Show("Failed to Add Internal Supply");

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox10.Text == "" || textBox7.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            if (Int32.Parse(textBox10.Text) < (Int32.Parse(textBox9.Text)) + (Int32.Parse(textBox7.Text)))
            {
                MessageBox.Show("total quantity cant be less the the sum of quantity exhibits and quantity research");
                return;
            }

            int x = MuseumController.updateinternalsuppliesitem(comboBox5.SelectedValue.ToString(), textBox10.Text, textBox9.Text, textBox7.Text, comboBox6.SelectedValue.ToString());
            if (x == 0)
            {
                MessageBox.Show("updating item failed");
            }
            else
            {
                MessageBox.Show("item updated successfully");
                DataTable dt = MuseumController.getallinternalsupplyinfobyname(comboBox5.SelectedValue.ToString());
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.getallinternalsupplyinfobyname(comboBox5.SelectedValue.ToString());
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.getallinternalsupplyinfobyname(comboBox3.SelectedValue.ToString());
            label17.Text = dt.Rows[0][0].ToString();
            label18.Text = dt.Rows[0][1].ToString();
            label19.Text = dt.Rows[0][2].ToString();
            label3.Text = dt.Rows[0][4].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = MuseumController.deleteinternalsuppliesitem(comboBox3.SelectedValue.ToString());
            if (x == 0)
            {
                MessageBox.Show("deleting  item failed");
            }
            else
            {
                MessageBox.Show("item  deleted successfully");
                DataTable dt = MuseumController.getallinternalsupplyitems();
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SuppliedItemName";
                comboBox5.ValueMember = "SuppliedItemName";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "SuppliedItemName";
                comboBox3.ValueMember = "SuppliedItemName";
                label17.Text = "";
                label18.Text = "";
                label19.Text = "";
                label3.Text = "";
            }
        }
    }
}
