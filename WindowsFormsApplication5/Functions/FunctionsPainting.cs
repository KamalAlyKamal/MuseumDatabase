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
    public partial class FunctionsPainting : Form
    {
        controller MuseumController;
        public FunctionsPainting(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void AddPaintingButton_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox1.Text));
            if (textBox1.Text == "" || textBox13.Text == "" || textBox2.Text == "" || textBox16.Text == "" || textBox3.Text == "" || textBox14.Text == "" || textBox4.Text == "" || textBox12.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else if (dt != null)
            {
                MessageBox.Show("Serial Number is already taken!");
            }
            else if (dt == null)
            {
                MuseumController.AddPainting(textBox1.Text, textBox13.Text, textBox2.Text, textBox16.Text, textBox3.Text, dateTimePicker5.Value.ToString("yyyy-MM-dd"), dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox14.Text, textBox4.Text, textBox12.Text, textBox5.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), label35.Text);
                MessageBox.Show("Painting added successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e) //edit search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox6.Text));
            dataGridView1.DataSource = dt1;
            DataTable dt2;
            dt2 = MuseumController.GetPaintingbyserialnumber(textBox6.Text);
            dataGridView2.DataSource = dt2;
            if (dt2 == null)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }
        }

        private void roundButton1_Click(object sender, EventArgs e) //edit
        {
            if (textBox6.Text == "" || textBox7.Text == "" || textBox19.Text == "" || textBox8.Text == "" || textBox18.Text == "" || textBox11.Text == "" || textBox17.Text == "" || textBox10.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else
            {
                MuseumController.EditPainting(textBox6.Text, textBox7.Text, textBox19.Text, textBox8.Text, textBox18.Text, dateTimePicker3.Value.ToString("yyyy-MM-dd"), dateTimePicker6.Value.ToString("yyyy-MM-dd"), textBox11.Text, textBox17.Text, textBox10.Text, textBox15.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Painting updated successfully!");
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox9.Text));
            DataTable dt2;
            dt2 = MuseumController.GetPaintingbyserialnumber(textBox9.Text);
            if (dt1 != null && dt2 != null)
            {
                label48.Text = dt1.Rows[0][0].ToString();
                label50.Text = dt1.Rows[0][1].ToString();
                label49.Text = dt1.Rows[0][2].ToString();
                label51.Text = dt1.Rows[0][4].ToString();
                label52.Text = dt1.Rows[0][5].ToString();
                label42.Text = dt2.Rows[0][1].ToString();
                label43.Text = dt2.Rows[0][2].ToString();
                label45.Text = dt2.Rows[0][3].ToString();
                label44.Text = dt2.Rows[0][4].ToString();
                label46.Text = dt2.Rows[0][5].ToString();
                label47.Text = dt2.Rows[0][6].ToString();
            }
        }

        private void roundButton2_Click(object sender, EventArgs e) //delete
        {
            if (textBox9.Text == "")
            {
                MessageBox.Show("Please Enter serial number!");
            }
            else
            {
                int check = MuseumController.DeletePainting(textBox9.Text);
                if (check != 0)
                    MessageBox.Show("Painting deleted successfully!");
                else
                    MessageBox.Show("No Painting found with this serial number!");
            }
        }
    }
}
