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
    // 111127 00017
    public partial class FunctionsOldMusicalInstruments : Form
    {
        controller MuseumController;
        public FunctionsOldMusicalInstruments(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }


        private void DeleteMusicalInstrumentTab_Click(object sender, EventArgs e)
        {

        }

        private void FunctionsOldMusicalInstruments_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e) //add
        {
            DataTable dt = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox1.Text));
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox9.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else if (dt != null)
            {
                MessageBox.Show("Serial Number is already taken!");
            }
            else if (dt == null)
            {
                int check = MuseumController.AddMusicalInstrument(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, textBox7.Text, textBox9.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"), textBox8.Text, textBox6.Text, label35.Text);
                if (check != 0)
                    MessageBox.Show("Old Musical Instrument added successfully!");
                else
                    MessageBox.Show("Failed to add Musical Instrument");
            }
        }

        private void button1_Click(object sender, EventArgs e) //edit search
        {
             DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox5.Text));
            dataGridView1.DataSource = dt1;
            DataTable dt2;
            dt2 = MuseumController.GetMusicalInstrumentsbyserialnumber(textBox5.Text);
            dataGridView2.DataSource = dt2;
            if (dt2 == null)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }
        }

        private void roundButton2_Click(object sender, EventArgs e) //edit
        {
            if (textBox5.Text == "" || textBox15.Text == "" || textBox14.Text == "" || textBox16.Text == "" || textBox13.Text == ""|| textBox11.Text == "" || textBox12.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else
            {
                int check = MuseumController.EditMusicalInstrument(textBox5.Text, textBox15.Text, textBox14.Text, textBox16.Text, textBox13.Text, textBox11.Text, textBox12.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox10.Text);
                if (check != 0)
                    MessageBox.Show("Old Musical Instrument updated successfully!");
                else
                    MessageBox.Show("Failed to edit Musical Instrument");
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete search
        {
            DataTable dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox17.Text));
            DataTable dt2 = MuseumController.GetMusicalInstrumentsbyserialnumber(textBox17.Text);
            if (dt1 != null && dt2 != null)
            {
                label28.Text = dt1.Rows[0][0].ToString();
                label27.Text = dt1.Rows[0][1].ToString();
                label33.Text = dt1.Rows[0][2].ToString();
                label32.Text = dt1.Rows[0][4].ToString();
                label31.Text = dt1.Rows[0][5].ToString();
                label29.Text = dt2.Rows[0][0].ToString();
                label30.Text = dt2.Rows[0][1].ToString();
                label34.Text = dt2.Rows[0][2].ToString();
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
                int check = MuseumController.DeleteMusicalInstrument(textBox17.Text);
                if (check != 0)
                    MessageBox.Show("Old Musical Instrument deleted successfully!");
                else
                    MessageBox.Show("Failed to delete");
            }
        }
    }
}
