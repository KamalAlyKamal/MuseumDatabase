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
    public partial class InternalSuppliesDisplay : Form
    {
        controller MuseumController;
        public InternalSuppliesDisplay(controller obj)
        {
            MuseumController = obj;
            InitializeComponent();
            DataTable dt = MuseumController.getsupplieditems();
            if (dt == null)
            {
                MessageBox.Show("internalsupplies table is empty");
            }
            else
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "SuppliedItemName";
                comboBox4.ValueMember = "SuppliedItemName";
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            // DataTable dt = MuseumController.getsupplieditembyname(comboBox4.SelectedValue.ToString());
           //   dataGridView1.DataSource = dt;
           // dataGridView1.Refresh();
        }

        private void InternalSuppliesDisplay_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
