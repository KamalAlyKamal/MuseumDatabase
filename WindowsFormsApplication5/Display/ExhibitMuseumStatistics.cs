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
    public partial class ExhibitMuseumStatistics : Form
    {
        controller MuseumController;
        public ExhibitMuseumStatistics(controller obj)
        {
            MuseumController = obj;
            InitializeComponent();
            
            DataTable dt = MuseumController.CountWorkers();
            EmployeesCount.Text = dt.Rows[0][0].ToString();

            dt = MuseumController.CountExhibits();
            ExhibitsCount.Text = dt.Rows[0][0].ToString();

            dt = MuseumController.EmployeesAverageSalary();
            EmployeesAvgSalary.Text = dt.Rows[0][0].ToString();

        }

        private void ExhibitMuseumStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
