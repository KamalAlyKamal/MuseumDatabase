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
    public partial class workers : Form
    {
        controller musuem;
        string username;
        public workers(controller obj,string uname )
        {
            musuem = obj;
           username=uname;
            InitializeComponent();
            DataTable dt = musuem.selectallemployees();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "SSN ";
            comboBox3.ValueMember = "SSN";
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
             dt = musuem.getworkersofmanager(username);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SSN";
            comboBox1.ValueMember = "SSN";
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "SSN";
            comboBox2.ValueMember = "SSN";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 0;
            if( textBox2.Text.Length ==0 || textBox3.Text.Length ==0 )
            {
                MessageBox.Show("please fill all the form ");
            }
            else
            {
                check = musuem.addworker(comboBox3.SelectedValue.ToString(), textBox2.Text, textBox3.Text,username);
                DataTable dt = musuem.getworkersofmanager(username);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember ="SSN";
                comboBox1.ValueMember ="SSN";
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "SSN";
                comboBox2.ValueMember = "SSN";


                if (check >0)
                {
                    MessageBox.Show("the worker has beed added ");
                }
                else
                {
                    MessageBox.Show("there is an error ");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt =musuem.getworkerbyssn(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = musuem.getworkerbyssn(comboBox1.SelectedValue.ToString());
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int check = musuem.deletefromworkers(comboBox2.SelectedValue.ToString());
            DataTable dt = musuem.getworkersofmanager(username);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "SSN";
            comboBox2.ValueMember = "SSN";
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SSN";
            comboBox1.ValueMember = "SSN";
            
            if(check>0)
            {
                MessageBox.Show("the worker has been deleted ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (textBox7.Text.Length == 0 || textBox6.Text.Length == 0 )
            {
                MessageBox.Show("please fill all the form ");
            }
            else
            { 
              
                check = musuem.updateworkerbyssn(textBox7.Text, textBox6.Text,comboBox1.SelectedValue.ToString());
                DataTable dt = musuem.getworkersofmanager(username);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "SSN";
                comboBox2.ValueMember = "SSN";
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SSN";
                comboBox1.ValueMember = "SSN";
                dataGridView1.Refresh();
                if (check > 0)
                {
                    textBox6.Clear();
                    textBox7.Clear();
                    MessageBox.Show("the worker has beed updated ");
                }
                else
                {
                    MessageBox.Show("there is an error ");
                }
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
