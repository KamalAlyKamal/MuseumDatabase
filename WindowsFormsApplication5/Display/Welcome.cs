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
    

    public enum UserType
    {
        Worker = 1,
        WorkerManager = 2,
        DepartmentManager = 3,
        CEO = 4,
        Guest = 5
    };

    public enum DepartmentManager
    {
        none                    =0,
        historicaldocuments     =1,
        musicalinstruments      =2,
        textiles                =3,
        weaponandammunition     =4,
        jewelery                =5,
        Historicalfossils       =6,
        Paintings               =7,
        HistoricalEquipment     =8,
        Sculptures              =9,
        InternalSupplies        =10,
        Sales                   =11,
        Research                =12
    };

    public partial class Welcome : Form
    {
        controller MuseumController = new controller();

        public Welcome()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            UserType usertype1 = (UserType)MuseumController.CheckLoginPassword(username, password);

            if ((int)usertype1 > 0)
            {
                DepartmentManager departmentmanager1 = DepartmentManager.none;
                if ((int)usertype1==3)
                {
                    departmentmanager1 = (DepartmentManager)MuseumController.GetDepartmentManagetID(username);
                }
                     
                new Profile(MuseumController,usertype1, departmentmanager1, username).Show(this);

                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
            }
            else
            {
                //Login Unsuccessful
                MessageBox.Show("Wrong username or password");
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        private void GuestLogIn_Click(object sender, EventArgs e)
        {
            UserType usertype1 = UserType.Guest;
            new Exhibits(MuseumController,usertype1).Show(this);
            this.Hide();

            textBox1.Clear();
            textBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Copyrights.Location = new Point(Copyrights.Location.X + 5, Copyrights.Location.Y);
            if (Copyrights.Location.X > this.Width)
            {
                Copyrights.Location = new Point(0 - Copyrights.Width, Copyrights.Location.Y);
            }
        }

        private void Copyrights_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
