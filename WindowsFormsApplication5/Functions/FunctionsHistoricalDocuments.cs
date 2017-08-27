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
    public partial class FunctionsHistoricalDocuments : Form
    {
        controller MuseumController;
        public FunctionsHistoricalDocuments(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void FunctionsHistoricalDocuments_Load(object sender, EventArgs e)
        {

        }

        private void AddDocumentTab_Click(object sender, EventArgs e)
        {

        }

        private void AddDocumentButton_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox1.Text));
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else if (dt!=null)
            {
                MessageBox.Show("Serial Number is already taken!");
            }
            else if (dt==null)
            {
                MuseumController.AddHistoricalDocuments(Int32.Parse(textBox1.Text), dateTimePicker3.Value.ToString("yyyy-MM-dd"), textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Int32.Parse(textBox4.Text), textBox5.Text, textBox2.Text, Int32.Parse(label28.Text));
                MessageBox.Show("Historical Document added successfully!");
            }
        }

        private void EditDocumentTab_Click(object sender, EventArgs e)
        {

        }

        private void EditDocumentButton_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox9.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else
            {
                int check = MuseumController.EditHistoricalDocuments(textBox10.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), textBox9.Text, textBox7.Text, textBox8.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"), textBox6.Text, label29.Text);
                if (check != 0)
                    MessageBox.Show("Historical Document updated successfully!");
                else
                    MessageBox.Show("Failed to Edit Document");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //edit search button
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox10.Text));
            dataGridView1.DataSource = dt1;
            DataTable dt2;
            dt2 = MuseumController.GetHistoricalDocumentsbySerialNumber(Int32.Parse(textBox10.Text));
            dataGridView2.DataSource = dt2;
            if (dt2 == null)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete search button
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox11.Text));
            DataTable dt2;
            dt2 = MuseumController.GetHistoricalDocumentsbySerialNumber(Int32.Parse(textBox11.Text));
            if (dt1!=null && dt2!=null)
            {
                label22.Text = dt1.Rows[0][0].ToString();
                label23.Text = dt1.Rows[0][1].ToString();
                label24.Text = dt1.Rows[0][2].ToString();
                label25.Text = dt1.Rows[0][4].ToString();
                label26.Text = dt1.Rows[0][5].ToString();
                label21.Text = dt2.Rows[0][0].ToString();
            }
        }

        private void roundButton1_Click(object sender, EventArgs e) //delete button
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("Please Enter serial number!");
            }
            else
            {
                int check = MuseumController.DeleteHistoricalDocuments(textBox11.Text);
                if (check != 0)
                    MessageBox.Show("Historical Document deleted successfully!");
                else
                    MessageBox.Show("Failed to delete");
            }
        }
    }
}
