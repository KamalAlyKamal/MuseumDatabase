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
    public partial class sculptfunc : Form
    {
        controller musueem;
        public sculptfunc(controller obj)
        {
            musueem = obj;
            InitializeComponent();
            comboBox1.DataSource = musueem.getallsclupt();
            comboBox1.DisplayMember = "SerialNumber";
            comboBox1.ValueMember = "SerialNumber";
            comboBox2.DataSource = musueem.getallsclupt();
            comboBox2.DisplayMember = "SerialNumber";
            comboBox2.ValueMember = "SerialNumber";

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Photo.Text.Length==0||EstimatedValue.Text.Length==0|| textBox1.Text.Length == 0 ||Discription.Text.Length==0|| textBox2.Text.Length == 0 || textBox4.Text.Length == 0||textBox5.Text.Length==0||textBox7.Text.Length==0|| textBox8.Text.Length==0)
            {
                MessageBox.Show("please fill all the form");
            }
            else
            {
                musueem.AddExhibit(textBox4.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), EstimatedValue.Text, textBox1.Text, "9", Discription.Text, Photo.Text);
                int check = musueem.addsculpt(textBox1.Text, textBox4.Text, textBox7.Text, textBox2.Text, textBox5.Text, textBox8.Text);
                if (check == 0)
                {
                    MessageBox.Show("error has occured");
                }
                else
                {
                    MessageBox.Show("the sculpture has been added sucessfully");
                    comboBox1.DataSource = musueem.getallsclupt();
                    comboBox1.DisplayMember = "SerialNumber";
                    comboBox1.ValueMember = "SerialNumber";
                    dataGridView1.DataSource = musueem.getallscluptwithsn(comboBox1.SelectedValue.ToString());
                    comboBox2.DataSource = musueem.getallsclupt();
                    comboBox2.DisplayMember = "SerialNumber";
                    comboBox2.ValueMember = "SerialNumber";
                    dataGridView2.DataSource = musueem.getallscluptwithsn(comboBox2.SelectedValue.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musueem.getallscluptwithsn(comboBox1.SelectedValue.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Length == 0 || textBox6.Text.Length == 0 || textBox11.Text.Length == 0 || textBox9.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("please fill all the form");
            }
            else
            {
                musueem.EditExhibit(comboBox1.SelectedValue.ToString(), textBox10.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox14.Text, textBox13.Text, textBox12.Text);
                int check = musueem.editsclupt(comboBox1.SelectedValue.ToString(), textBox10.Text, textBox6.Text, textBox11.Text, textBox9.Text, textBox3.Text);
                if (check == 0)
                {
                    MessageBox.Show("error has occured");
                }
                else
                {
                    MessageBox.Show("the sculpture has been Edited sucessfully");
                    comboBox1.DataSource = musueem.getallsclupt();
                    comboBox1.DisplayMember = "SerialNumber";
                    comboBox1.ValueMember = "SerialNumber";
                    dataGridView1.DataSource = musueem.getallscluptwithsn(comboBox1.SelectedValue.ToString());
                    comboBox2.DataSource = musueem.getallsclupt();
                    comboBox2.DisplayMember = "SerialNumber";
                    comboBox2.ValueMember = "SerialNumber";
                    dataGridView2.DataSource = musueem.getallscluptwithsn(comboBox2.SelectedValue.ToString());
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = musueem.getallscluptwithsn(comboBox2.SelectedValue.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = musueem.deletsclupt(comboBox2.SelectedValue.ToString());
           
            if (check == 0)
            {
                MessageBox.Show("error has occured");
            }
            else
            {
                musueem.DeleteExhibit(comboBox2.SelectedValue.ToString());
                MessageBox.Show("the sculpture has been Edited sucessfully");
                comboBox1.DataSource = musueem.getallsclupt();
                comboBox1.DisplayMember = "SerialNumber";
                comboBox1.ValueMember = "SerialNumber";
                dataGridView1.DataSource = musueem.getallscluptwithsn(comboBox1.SelectedValue.ToString());
                comboBox2.DataSource = musueem.getallsclupt();
                comboBox2.DisplayMember = "SerialNumber";
                comboBox2.ValueMember = "SerialNumber";
                dataGridView2.DataSource = musueem.getallscluptwithsn(comboBox2.SelectedValue.ToString());
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
    }

