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
    public partial class Researchffunc : Form
    {
        controller MuseumController;
        public Researchffunc(controller obj)
        {
            MuseumController = obj;
            InitializeComponent();
            comboBox2.Enabled = false;
            comboBox5.Enabled = false;
            DataTable dt = MuseumController.DisplayResearch();
            if (dt == null)
            {
                MessageBox.Show("research table is empty");
            }
            else
            {
                
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "Type";
                comboBox4.ValueMember = "Type";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Type";
                comboBox3.ValueMember = "Type";

            }

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox4.Text == "" || textBox2.Text == "" || textBox1.Text == ""  || textBox10.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            int x = MuseumController.addresearch(textBox4.Text, textBox2.Text, textBox7.Text, dateTimePicker2.Value.ToString("yyyy-mm-dd"), dateTimePicker1.Value.ToString("yyyy-mm-dd"), textBox1.Text, textBox10.Text, label25.Text);
            if (x == 1)
            {
                //Succesffuly Added
                MessageBox.Show("research Added Successfully");
                DataTable dt = MuseumController.DisplayResearch();
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "Type";
                comboBox4.ValueMember = "Type";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Type";
                comboBox3.ValueMember = "Type";
            }
            else
                MessageBox.Show("Failed to Add research");

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            DataTable dt = MuseumController.DisplayResearchByType(comboBox3.SelectedValue.ToString());
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Topic";
            comboBox3.ValueMember = "Topic";

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;
            DataTable dt = MuseumController.DisplayResearchByType(comboBox4.SelectedValue.ToString());
            comboBox5.DataSource = dt;
            comboBox5.DisplayMember = "Topic";
            comboBox5.ValueMember = "Topic";
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.Enabled==false)
            {
                MessageBox.Show("Please, choose type and topic");
                return;
            }
            DataTable dt = MuseumController.getresearchbytypeandtopic(comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox3.Text == "" || textBox9.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            if (comboBox2.Enabled==false)
            {
                MessageBox.Show("Please, choose type and topic");
                return;
            }
            int x = MuseumController.updateresearch(comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), textBox8.Text, dateTimePicker3.Value.ToString("yyyy-mm-dd"), textBox3.Text, textBox9.Text);
            if (x == 0)
            {
                MessageBox.Show("updating  research failed");
            }
            else
            {
                MessageBox.Show("item updated successfully");
                DataTable dt = MuseumController.getallsalesinfobyname(comboBox5.SelectedValue.ToString());
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                comboBox2.Enabled = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox5.Enabled == false)
            {
                MessageBox.Show("Please, choose type and topic");
                return;
            }
            DataTable dt = MuseumController.getresearchbytypeandtopic(comboBox4.SelectedValue.ToString(), comboBox5.SelectedValue.ToString());

            label20.Text = dt.Rows[0][2].ToString();
            label21.Text = dt.Rows[0][5].ToString();
            label23.Text = dt.Rows[0][6].ToString();
            label27.Text = dt.Rows[0][3].ToString();
            label22.Text = dt.Rows[0][4].ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = MuseumController.deleteresearch(comboBox5.SelectedValue.ToString(), comboBox4.SelectedValue.ToString());
            if (x == 0)
            {
                MessageBox.Show("deleting  research failed");
            }
            else
            {
                MessageBox.Show("research  deleted successfully");
                DataTable dt = MuseumController.DisplayResearch();
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "Type";
                comboBox4.ValueMember = "Type";
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Type";
                comboBox3.ValueMember = "Type";
                label20.Text = "";
                label21.Text = "";
                label23.Text = "";
                label27.Text = "";
                label22.Text = "";
            }
        }
        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
