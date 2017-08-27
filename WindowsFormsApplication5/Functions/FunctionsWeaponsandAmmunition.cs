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
    // 111129 00019
    public partial class FunctionsWeaponsandAmmunition : Form
    {
        controller MuseumController;
        public FunctionsWeaponsandAmmunition(controller obj)
        {
            InitializeComponent();
            MuseumController = obj;
        }

        private void FunctionsWeaponsandAmmunition_Load(object sender, EventArgs e)
        {

        }

        private void AddWeaponandAmmunition_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox1.Text));
            if (textBox1.Text == "" || textBox6.Text == "" || textBox2.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox3.Text == "" || textBox9.Text == "" || textBox4.Text == "" || textBox10.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else if (dt != null)
            {
                MessageBox.Show("Serial Number is already taken!");
            }
            else if (dt == null)
            {
                int check = MuseumController.AddWeaponsandAmmunition(textBox1.Text, textBox6.Text, textBox2.Text, textBox7.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox8.Text, textBox3.Text, textBox9.Text, textBox4.Text, textBox10.Text, textBox5.Text, label1.Text);
                if (check != 0)
                    MessageBox.Show("Weapon and Ammunition added successfully!");
                else
                    MessageBox.Show("Failed to add Weapon");
            }
        }

        private void Search_Click(object sender, EventArgs e) //edit search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox19.Text));
            dataGridView1.DataSource = dt1;
            DataTable dt2;
            dt2 = MuseumController.GetWeaponandAmmunitionbyserialnumber(textBox19.Text);
            dataGridView2.DataSource = dt2;
            if (dt2==null)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }
        }

        private void UpdateWeaponandAmmunition_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == "" || textBox31.Text == "" || textBox13.Text == "" || textBox17.Text == "" || textBox12.Text == "" || textBox16.Text == "" || textBox11.Text == "" || textBox15.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Please Enter all values!");
            }
            else
            {
                int check = MuseumController.EditWeaponandAmmunition(textBox19.Text, textBox18.Text, textBox31.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), textBox13.Text, textBox17.Text, textBox12.Text, textBox16.Text, textBox11.Text, textBox15.Text, textBox20.Text, label14.Text);
                if (check != 0)
                    MessageBox.Show("Weapon and Ammunition updated successfully!");
                else
                    MessageBox.Show("Failed to Edit Weapon");
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete search
        {
            DataTable dt1;
            dt1 = MuseumController.GetExhibitsbySerialNumber(Int32.Parse(textBox27.Text));
            DataTable dt2;
            dt2 = MuseumController.GetWeaponandAmmunitionbyserialnumber(textBox27.Text);
            if (dt1 != null && dt2 != null)
            {
                label28.Text = dt1.Rows[0][0].ToString();
                label29.Text = dt1.Rows[0][1].ToString();
                label30.Text = dt1.Rows[0][2].ToString();
                label31.Text = dt1.Rows[0][4].ToString();
                label32.Text = dt1.Rows[0][5].ToString();
                label34.Text = dt2.Rows[0][0].ToString();
                label33.Text = dt2.Rows[0][1].ToString();
                label35.Text = dt2.Rows[0][2].ToString();
                label36.Text = dt2.Rows[0][3].ToString();
                label37.Text = dt2.Rows[0][4].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) //delete
        {
            if (textBox27.Text == "")
            {
                MessageBox.Show("Please Enter serial number!");
            }
            else
            {
                int check = MuseumController.DeleteWeaponandAmmunition(textBox27.Text);
                if (check != 0)
                    MessageBox.Show("Weapon and Ammunition deleted successfully!");
                else
                    MessageBox.Show("Failed to delete Weapon");
            }
            
        }
    }
}
