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
    public partial class FunctionsJewelery : Form
    {
        controller MuseumController;
        public FunctionsJewelery(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void AddJeweleryTab_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            //Checks if there is an empty textbox
            if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox9.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please Enter all the data required");
                return;
            }

            //Checks that the SerialNumber is not taken
            DataTable checktable = MuseumController.GetExhibitBySerialNumber(textBox1.Text);
            if(checktable !=null)
            {
                MessageBox.Show("Serial Number is already taken");
                return;
            }

            //Adds the Jewelery
            int check;
            check = MuseumController.AddExhibit(textBox7.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"), textBox9.Text, textBox1.Text, label35.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to add Jewelery");
                return;
            }
            check = MuseumController.AddJewelery(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to add Jewelery");
                return;
            }

            MessageBox.Show("Added Successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checks if it's not empty
            if(textBox5.Text=="")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox5.Text);
            if(dt==null)
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


            dt = MuseumController.GetJeweleryBySerialNumber(textBox5.Text);
            if (dt == null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView2.DataSource = null;
                dataGridView2.Refresh();
                MessageBox.Show("No Jewelery Found With This serial number");
                return;
            }
               
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            //Checks if it's not empty
            if (textBox17.Text == "")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox17.Text);
            if (dt == null)
            {
                MessageBox.Show("No Exhibits Found With This serial number");
                return;
            }

            int check = MuseumController.DeleteJewelery(textBox17.Text);
            if(check==0)
            {
                MessageBox.Show("Failed to delete Jewelery");
                return;
            }

            check = MuseumController.DeleteExhibit(textBox17.Text);
            if (check == 0)
            {
                MessageBox.Show("Failed to delete Jewelery Exhibit");
                return;
            }

            MessageBox.Show("Successfully Deleted");
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "" || textBox16.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Please Enter all the data required");
                return;
            }

            int check = MuseumController.EditExhibit(textBox5.Text ,textBox12.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox16.Text, textBox18.Text, textBox19.Text);
            if(check==0)
            {
                MessageBox.Show("Failed to Edit Jewelery");
                return;
            }

            check = MuseumController.EditJewelery(textBox5.Text, textBox13.Text, textBox14.Text, textBox15.Text);
            if(check==0)
            {
                MessageBox.Show("Failed to Edit Jewelery");
                return;
            }

            MessageBox.Show("Successfully Edit Jewelery");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Checks if it's not empty
            if (textBox17.Text == "")
            {
                MessageBox.Show("Please insert a value");
                return;
            }

            DataTable dt = MuseumController.GetExhibitBySerialNumber(textBox17.Text);
            if (dt == null)
            {
                MessageBox.Show("No Exhibits Found With This serial number");
                return;
            }


            DataTable dt2 = MuseumController.GetJeweleryBySerialNumber(textBox17.Text);
            if (dt2 == null)
            {
                MessageBox.Show("No Jewelery Found With This serial number");
                return;
            }

            label28.Text = dt.Rows[0][0].ToString();
            label27.Text = dt.Rows[0][1].ToString();
            label33.Text = dt.Rows[0][2].ToString();
            label39.Text = dt.Rows[0][6].ToString();

            label29.Text = dt2.Rows[0][1].ToString();
            label30.Text = dt2.Rows[0][2].ToString();
            label34.Text = dt2.Rows[0][3].ToString();


        }
    }
}
