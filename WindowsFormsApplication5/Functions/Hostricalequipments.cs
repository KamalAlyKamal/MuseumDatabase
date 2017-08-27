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
    public partial class Hostricalequipments : Form
    {
        controller musueemcontroller;
        public Hostricalequipments(controller obj)
        {
            musueemcontroller = obj;
            DataTable dt = musueemcontroller.getallequipments();
            InitializeComponent();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SerialNumber";
            comboBox1.ValueMember = "SerialNumber";
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "SerialNumber";
            comboBox2.ValueMember = "SerialNumber";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 0 || textBox8.Text.Length == 0 || textBox6.Text.Length==0 || textBox5.Text.Length ==0 || textBox4.Text.Length==0 || textBox3.Text.Length ==0 ||textBox2.Text.Length==0 ||textBox1.Text.Length==0)
            {
                MessageBox.Show("error has occured");
            }
                musueemcontroller.addexhibits(textBox5.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox6.Text, textBox1.Text, textBox8.Text, textBox9.Text);

        int check =musueemcontroller.addhistoricalequipment(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (check == 0)
            {
                MessageBox.Show("errror has occured");
            }
            else
                MessageBox.Show("the equipment has been added sucessfully ");
            DataTable dt = musueemcontroller.getallequipments();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SerialNumber";
            comboBox1.ValueMember = "SerialNumber";
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "SerialNumber";
            comboBox2.ValueMember = "SerialNumber";
            comboBox1.Refresh();
            comboBox2.Refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musueemcontroller.getequipwithsn(comboBox1.SelectedValue.ToString());
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox11.Text.Length==0 || textBox10.Text.Length==0|| textBox7.Text.Length==0)
            {

                MessageBox.Show("error has occured");
            }
            else
            {
                musueemcontroller.updateequipment(textBox11.Text, textBox10.Text, textBox7.Text, comboBox1.Text.ToString());
                MessageBox.Show("ana equipment has been edited ");
                DataTable dt = musueemcontroller.getallequipments();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SerialNumber";
                comboBox1.ValueMember = "SerialNumber";
                comboBox1.Refresh();

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = musueemcontroller.getequipwithsn(comboBox1.SelectedValue.ToString());
            dataGridView2.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           int check = musueemcontroller.deleteequipment(comboBox2.SelectedValue.ToString());
            DataTable dt = musueemcontroller.getallequipments();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SerialNumber";
            comboBox1.ValueMember = "SerialNumber";
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "SerialNumber";
            comboBox2.ValueMember = "SerialNumber";
            comboBox1.Refresh();
            comboBox2.Refresh();
        }
    }
}
