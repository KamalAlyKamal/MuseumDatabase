using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Display
{
    public partial class Salesdisplay : Form
    {
        controller MuseumController;
        UserType usertypeform;
        DepartmentManager departmentmanagerform;
        public Salesdisplay(controller obj, UserType usertype1 = UserType.Guest, DepartmentManager depmanager = DepartmentManager.none)
        {  
            usertypeform = usertype1;
            MuseumController = obj;
            departmentmanagerform = depmanager;
            InitializeComponent();
            if (departmentmanagerform != DepartmentManager.Sales)
            {
                DataTable dt = MuseumController.getsalestodisplay();
                if (dt == null)
                {
                    MessageBox.Show("Market is empty");
                }
                else
                {
                    label1.Text = "Item To Buy:";
                    label2.Show();
                    textBox4.Show();
                    button1.Show();
                    comboBox4.DataSource = dt;
                    comboBox4.DisplayMember = "ItemName";
                    comboBox4.ValueMember = "ItemName";
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }
            else if (departmentmanagerform == DepartmentManager.Sales)
            {
                DataTable dt = MuseumController.getallsalesinfo(); 

                if (dt == null)
                {
                    MessageBox.Show("sales table is empty");
                }
                else
                {
                    label1.Text = "Item Name:";
                    label2.Hide();
                    textBox4.Hide();
                    button1.Hide();
                    comboBox4.DataSource = dt;
                    comboBox4.DisplayMember = "ItemName";
                    comboBox4.ValueMember = "ItemName";
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                }
            }
           


        }

        private void Salesdisplay_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = MuseumController.getquantitystock(comboBox4.SelectedValue.ToString());
            int quantitystock = Int32.Parse(dt.Rows[0][0].ToString());
            if (textBox4.Text == "")                   //validation part
            {
                MessageBox.Show("Please, insert the quantity");
                return;
            }
            else if (Int32.Parse(textBox4.Text) <= 0 )
            {
                MessageBox.Show("please enter valid value");
                return;
            }
            else if (quantitystock > Int32.Parse(textBox4.Text))
            {
                int quantityleft = quantitystock - Int32.Parse(textBox4.Text);
                MuseumController.updatesalesafterselling(quantityleft, comboBox4.SelectedValue.ToString());
                MessageBox.Show("item bought successfully");
                dt = MuseumController.getsalestodisplay();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                return;
            }
            else if (quantitystock == 0)
            {
               MessageBox.Show("item is out of stock ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
