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
    public partial class fossilfunc : Form
    {
        controller MuseumController;
        public fossilfunc(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Checks if there is an empty textbox
            if (textBox7.Text == "" || textBox4.Text == "" || textBox2.Text == "" || textBox1.Text == "" || textBox5.Text == "" || textBox11.Text == "" || textBox9.Text == "" || textBox3.Text == ""  || textBox6.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Please Enter all the data required");
                return;
            }

            //Checks that the SerialNumber is not taken
            DataTable checktable = MuseumController.GetExhibitBySerialNumber(textBox5.Text);
            if (checktable != null)
            {
                MessageBox.Show("Serial Number is already taken");
                return;
            }

            //Adds the Jewelery
            int check;
            check = MuseumController.AddExhibit(textBox11.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), textBox9.Text, textBox5.Text, label33.Text, textBox6.Text, textBox3.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to add fossil");
                return;
            }
            check = MuseumController.addfossils(textBox5.Text, textBox7.Text, textBox4.Text, textBox2.Text, textBox1.Text, textBox20.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to add fossil");
                return;
            }

            MessageBox.Show("Added Successfully");
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Checks if it's not empty
            if (textBox12.Text == "")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox12.Text);
            if (dt == null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView2.DataSource = null;
                dataGridView2.Refresh();
                MessageBox.Show("No Exhibits Found With This serial number");
                return;
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            dt = MuseumController.getfossilsbyserialnumber(textBox12.Text);
            if (dt == null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView2.DataSource = null;
                dataGridView2.Refresh();
                MessageBox.Show("No fossil Found With This serial number");
                return;
            }

            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "" || textBox14.Text == "" || textBox17.Text == "" || textBox16.Text == "" || textBox15.Text == "" || textBox21.Text == "" || textBox13.Text == "" || textBox10.Text=="" || textBox8.Text == "" || textBox18.Text=="")
            {
                MessageBox.Show("Please Enter all the data required");
                return;
            }

            int check = MuseumController.EditExhibit(textBox12.Text, textBox13.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox10.Text, textBox18.Text, textBox8.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to Edit fossil");
                return;
            }

            check = MuseumController.updatefossils(textBox12.Text, textBox14.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox21.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to Edit fossil");
                return;
            }

            MessageBox.Show("Successfully Edit fossil");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox19.Text);
            if (dt == null)
            {
                MessageBox.Show("No Exhibits Found With This serial number");
                return;
            }

            int check = MuseumController.deletefossils(textBox19.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to delete Jewelery");
                return;
            }

            check = MuseumController.DeleteExhibit(textBox19.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to delete Jewelery Exhibit");
                return;
            }

            MessageBox.Show("Successfully Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox19.Text);
            if (dt == null)
            {
                MessageBox.Show("No Exhibits Found With This serial number");
                return;
            }


            DataTable dt2 = MuseumController.getfossilsbyserialnumber(textBox19.Text);
            if (dt2 == null)
            {
                MessageBox.Show("No fossil Found With This serial number");
                return;
            }

            label38.Text = dt.Rows[0][0].ToString();
            label39.Text = dt.Rows[0][1].ToString();
            label40.Text = dt.Rows[0][2].ToString();
            label43.Text = dt.Rows[0][4].ToString();

            label35.Text = dt2.Rows[0][0].ToString();
            label36.Text = dt2.Rows[0][1].ToString();
            label37.Text = dt2.Rows[0][2].ToString();
            label42.Text = dt2.Rows[0][3].ToString();
            label27.Text = dt2.Rows[0][4].ToString();


        }
    }
}
