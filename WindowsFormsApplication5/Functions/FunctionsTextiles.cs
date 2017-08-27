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
    //111128 00018
    public partial class FunctionsTextiles : Form
    {
        controller MuseumController;
        public FunctionsTextiles(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void AddTextiltesTab_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e) //add
        {
            DataTable dt = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox1.Text));
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox9.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else if (dt!=null)
            {
                MessageBox.Show("Serial Number is already taken!");
            }
            else if (dt==null)
            {
                int check = MuseumController.AddTextiles(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, textBox7.Text, textBox9.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"), textBox8.Text, textBox6.Text, label35.Text);
                if (check != 0)
                    MessageBox.Show("Textile added successfully!");
                else
                    MessageBox.Show("Failed to Add Textile");

            }
        }

        private void button1_Click(object sender, EventArgs e) //edit search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox5.Text));
            dataGridView1.DataSource = dt1;
            DataTable dt2;
            dt2 = MuseumController.GetTextilesbyserialnumber(textBox5.Text);
            dataGridView2.DataSource = dt2;
            if (dt2 == null)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }
        }

        private void roundButton2_Click(object sender, EventArgs e) //edit
        {
            if (textBox5.Text == "" || textBox15.Text == "" || textBox14.Text == "" || textBox16.Text == "" || textBox13.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else
            {
                int check = MuseumController.EditTextiles(textBox5.Text, textBox15.Text, textBox14.Text, textBox16.Text, textBox11.Text, textBox13.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox12.Text, textBox10.Text);
                if (check != 0)
                    MessageBox.Show("Textile updated successfully!");
                else
                    MessageBox.Show("Failed to edit Textile");
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox17.Text));
            DataTable dt2;
            dt2 = MuseumController.GetTextilesbyserialnumber(textBox17.Text);
            if (dt1 != null && dt2 != null)
            {
                label28.Text = dt1.Rows[0][0].ToString();
                label27.Text = dt1.Rows[0][1].ToString();
                label33.Text = dt1.Rows[0][2].ToString();
                label32.Text = dt1.Rows[0][4].ToString();
                label31.Text = dt1.Rows[0][5].ToString();
                label34.Text = dt2.Rows[0][0].ToString();
                label29.Text = dt2.Rows[0][1].ToString();
                label30.Text = dt2.Rows[0][2].ToString();
            }
        }

        private void roundButton3_Click(object sender, EventArgs e) //delete
        {
            if (textBox17.Text == "")
            {
                MessageBox.Show("Please Enter serial number!");
            }
            else
            {
               int check =  MuseumController.DeleteTextiles(textBox17.Text);
                if (check != 0)
                    MessageBox.Show("Textile deleted successfully!");
                else
                    MessageBox.Show("Failed to delete Textile");
            }
        }
    }
}
