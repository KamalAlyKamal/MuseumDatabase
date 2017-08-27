using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class FunctionsCEO : Form
    {
        controller MuseumController;
        public FunctionsCEO(controller obj)
        {
            MuseumController = obj;
            InitializeComponent();

            DataTable dt = MuseumController.GetDepartmentByID();
            if (dt == null)
            {
                MessageBox.Show("No Departments Found");
            }
            else
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "DepartmentName";
                comboBox1.ValueMember = "Departmentid";

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "DepartmentName";
                comboBox2.ValueMember = "Departmentid";
            }
        }

        private void FunctionsCEO_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox9.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }

            int x = MuseumController.AddnewDepartment(Int32.Parse(textBox1.Text), textBox9.Text, char.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));

            if (x == 1)
            {
                //Succesffuly Added
                MessageBox.Show("Department Added Successfully");
            }
            else
                MessageBox.Show("Failed to Add Department");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchForEdit_Click(object sender, EventArgs e)
        {

            DataTable dt = MuseumController.GetDepartmentByID(comboBox1.SelectedValue.ToString());
            if (dt == null)
            {
                
                MessageBox.Show("No Department Found with this name");
                return;
            }
            textBox7.Text = dt.Rows[0][2].ToString();
            textBox6.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox10.Text = dt.Rows[0][1].ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox10.Text=="")
            {
                MessageBox.Show("Please Fill All the required Data");
                return;
            }

            int check = MuseumController.EditDepartment(comboBox1.SelectedValue.ToString(), textBox10.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            if (check != 0)
                MessageBox.Show("Sucessfully Edited The Department");
            else
                MessageBox.Show("Failed to Edit The Department");
        }

        private void EditDepartmentTab_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = MuseumController.GetDepartmentByID(comboBox1.SelectedValue.ToString());
            if (dt == null)
            {

                MessageBox.Show("No Department Found with this name");
                return;
            }
            textBox7.Text = dt.Rows[0][2].ToString();
            textBox6.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox10.Text = dt.Rows[0][1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Please Fill All the required Data");
                return;
            }

            int check = MuseumController.DeleteDepartment(comboBox1.SelectedValue.ToString());
            if (check != 0)
                MessageBox.Show("Sucessfully Deleted The Department");
            else
                MessageBox.Show("Failed to Deleted The Department");
        }
    }
}
