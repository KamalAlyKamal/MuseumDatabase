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
    public partial class Profile : Form
    {
        UserType usertypeform;
        DepartmentManager departmentmanagerform;
        controller MuseumController;
        string username;
        DataTable info;
        UserType usertype1;
        //osman 
        public Profile(controller Obj,UserType usertype1, DepartmentManager departmentmanager1 = DepartmentManager.none,string uname =null)
        {
            InitializeComponent();
            this.usertype1 = usertype1;
            this.usertypeform = usertype1;

            this.departmentmanagerform = departmentmanager1;
            MuseumController = Obj;
            username = uname;

            info = MuseumController.getinfo(username);
            textBox1.Text = info.Rows[0][0].ToString();
            textBox2.Text = info.Rows[0][1].ToString();
            textBox3.Text = info.Rows[0][2].ToString();
            textBox4.Text = info.Rows[0][3].ToString();
            textBox5.Text = info.Rows[0][4].ToString();
            textBox6.Text = info.Rows[0][5].ToString();
            textBox9.Text = info.Rows[0][8].ToString();
            textBox10.Text = info.Rows[0][9].ToString();
            textBox11.Text = info.Rows[0][10].ToString();
            textBox12.Text = info.Rows[0][11].ToString();
            textBox8.Text = info.Rows[0][17].ToString();
            textBox16.Text = info.Rows[0][13].ToString();
            textBox7.Text = info.Rows[0][7].ToString();
            textBox14.Text = info.Rows[0][15].ToString();
            dateTimePicker1.Value = DateTime.Parse(info.Rows[0][7].ToString());
            dateTimePicker2.Value = DateTime.Parse(info.Rows[0][14].ToString());
            if(usertype1 ==UserType.Worker)
            {
                DataTable addinfo = MuseumController.getworkerbyssn(username);
                textBox13.Text = addinfo.Rows[0][1].ToString();
                textBox15.Text = addinfo.Rows[0][2].ToString();
                textBox17.Text = addinfo.Rows[0][3].ToString();
            }
            else if(usertype1==UserType.WorkerManager)
            {
                DataTable addinfo = MuseumController.getworkermanagerinfo(username);
                label16.Text = "JobTitle";
                label17.Hide();
                label18.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Text = addinfo.Rows[0][1].ToString();

            }
            else if(usertype1==UserType.DepartmentManager)
            {
               
                label16.Text = "Department ID";
                label17.Hide();
                label18.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Text = MuseumController.GetDepartmentManagetID(username).ToString();

            }
            else if ( usertype1==UserType.CEO)
            {
                label17.Hide();
                label18.Hide();
                label16.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Hide();
            }



        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }



        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Exhibits_Click(object sender, EventArgs e)
        {
            new Exhibits(MuseumController, usertypeform, departmentmanagerform).Show(this);

            this.Hide();   
        }

        private void Functionalities_Click(object sender, EventArgs e)
        {
            if(usertypeform == UserType.CEO)
            {
                new FunctionsCEO(MuseumController).Show();
                new Functions.Form1(MuseumController).Show();
            }
            if(usertypeform==UserType.WorkerManager)
            {
                new Functions.workers(MuseumController,username).Show();
            }

            if(usertypeform == UserType.DepartmentManager)
            {
                if (departmentmanagerform == DepartmentManager.Historicalfossils)
                {
                    new Functions.fossilfunc(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.Research)
                {
                    new Functions.Researchffunc(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.Paintings)
                {
                    new Functions.FunctionsPainting(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.textiles)
                {
                    new Functions.FunctionsTextiles(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.musicalinstruments)
                {
                    new Functions.FunctionsOldMusicalInstruments(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.weaponandammunition)
                {
                    new Functions.FunctionsWeaponsandAmmunition(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.historicaldocuments)
                {
                    new Functions.FunctionsHistoricalDocuments(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.Sales)
                {
                    new salesfunc(MuseumController).Show();
                    new Functions.suppliersfunc(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.InternalSupplies)
                {
                    new internalsuppliesfunc(MuseumController).Show();
                }
                if (departmentmanagerform == DepartmentManager.jewelery)
                {
                    new Functions.FunctionsJewelery(MuseumController).Show();
                }
                if(departmentmanagerform == DepartmentManager.HistoricalEquipment)
                {
                    new Functions.Hostricalequipments(MuseumController).Show();
                }
                if (departmentmanagerform==DepartmentManager.Sculptures)
                {
                    new Functions.sculptfunc(MuseumController).Show();
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            pass.Visible = true;
            Save.Visible = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;
            textBox11.ReadOnly = false;
            textBox12.ReadOnly = false;
            textBox14.ReadOnly = false;
            textBox16.ReadOnly = false;
          






        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || textBox9.Text.Length == 0 || textBox10.Text.Length == 0 || textBox11.Text.Length == 0 || textBox12.Text.Length == 0 || textBox14.Text.Length == 0)
            {
                MessageBox.Show("please fill all the form");
                return;
            }
            else
            {
                int check = MuseumController.updateemployee(username, textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox14.Text);
                if (check == 0)
                {
                    MessageBox.Show("error occured");
                }
                else
                {
                    MessageBox.Show("your information has been updated carfeully ");
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;
                    textBox11.ReadOnly = true;
                    textBox12.ReadOnly = true;
                    textBox14.ReadOnly = true;
                    textBox16.ReadOnly = true;
                    pass.Visible = false;
                    panel1.Visible = false;
                    Save.Visible = false;

                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass.Visible = false;
            panel1.Visible = false;
            Save.Visible = false;
            textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;
                    textBox11.ReadOnly = true;
                    textBox12.ReadOnly = true;
                    textBox14.ReadOnly = true;
                    textBox16.ReadOnly = true;
            info = MuseumController.getinfo(username);
            textBox1.Text = info.Rows[0][0].ToString();
            textBox2.Text = info.Rows[0][1].ToString();
            textBox3.Text = info.Rows[0][2].ToString();
            textBox4.Text = info.Rows[0][3].ToString();
            textBox5.Text = info.Rows[0][4].ToString();
            textBox6.Text = info.Rows[0][5].ToString();
            textBox9.Text = info.Rows[0][8].ToString();
            textBox10.Text = info.Rows[0][9].ToString();
            textBox11.Text = info.Rows[0][10].ToString();
            textBox12.Text = info.Rows[0][11].ToString();
            textBox8.Text = info.Rows[0][17].ToString();
            textBox16.Text = info.Rows[0][13].ToString();
            textBox7.Text = info.Rows[0][7].ToString();
            textBox14.Text = info.Rows[0][15].ToString();
            dateTimePicker1.Value = DateTime.Parse(info.Rows[0][7].ToString());
            dateTimePicker2.Value = DateTime.Parse(info.Rows[0][14].ToString());
            if (usertype1 == UserType.Worker)
            {
                DataTable addinfo = MuseumController.getworkerbyssn(username);
                textBox13.Text = addinfo.Rows[0][1].ToString();
                textBox15.Text = addinfo.Rows[0][2].ToString();
                textBox17.Text = addinfo.Rows[0][3].ToString();
            }
            else if (usertype1 == UserType.WorkerManager)
            {
                DataTable addinfo = MuseumController.getworkermanagerinfo(username);
                label16.Text = "JobTitle";
                label17.Hide();
                label18.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Text = addinfo.Rows[0][1].ToString();

            }
            else if (usertype1 == UserType.DepartmentManager)
            {

                label16.Text = "Department ID";
                label17.Hide();
                label18.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Text = MuseumController.GetDepartmentManagetID(username).ToString();

            }
            else if (usertype1 == UserType.CEO)
            {
                label17.Hide();
                label18.Hide();
                label16.Hide();
                textBox15.Hide();
                textBox17.Hide();
                textBox13.Hide();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
       bool check =MuseumController.checkpassword(textBox18.Text,username);
            if(check==false)
            {
                textBox18.Text = "";
                textBox19.Text = "";
                MessageBox.Show("wrong password");

            }
            else
            {
             int t =   MuseumController.changepassword(textBox19.Text, username);
                if (t != 0)
                {
                    MessageBox.Show("password has been changed correctly");
                    panel1.Visible = false;
                }
                else
                    MessageBox.Show("error occured");



            }


        }

        private void pass_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
