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
    public partial class Exhibits : Form
    {
        controller MuseumController;
        UserType usertypeform;
        DepartmentManager departmentmanagerform;

        public Exhibits(controller Obj, UserType usertype1 = UserType.Guest, DepartmentManager departmentmanager1 = DepartmentManager.none)
        {
            InitializeComponent();

            //////////////Initializing the values///////////////
            MuseumController = Obj;
            this.usertypeform = usertype1;
            this.departmentmanagerform = departmentmanager1;

            ////////////Activating or deactivating buttons/////////
            if (usertypeform==UserType.Guest)
            {
                MenuItemMuseumStatistics.Visible = false;
                internalSuppliesToolStripMenuItem.Visible = false;
            }
            ///////////Showing initial datatable for display//////////
            DataTable dt;
            dt= MuseumController.GetPaintings();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            dt = MuseumController.GetSculptures();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();

            dt = MuseumController.GetHistoricalDocuments();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();

            dt = MuseumController.DisplayEquipments();
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();

            dt = MuseumController.DisplayFossils();
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();

            dt = MuseumController.DisplayJewelery();
            dataGridView6.DataSource = dt;
            dataGridView6.Refresh();

            dt = MuseumController.DisplayWeapons();
            dataGridView7.DataSource = dt;
            dataGridView7.Refresh();

            dt = MuseumController.DisplayTextiles();
            dataGridView8.DataSource = dt;
            dataGridView8.Refresh();

            dt = MuseumController.DisplayInstruments();
            dataGridView9.DataSource = dt;
            dataGridView9.Refresh();

            dt = MuseumController.DisplayResearch();
            dataGridView10.DataSource = dt;
            dataGridView10.Refresh();

            //////////////Shows the combo boxes/////////////// 
            //Painting
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("7");      //7 is the painting departmentID
            if (dt == null)
            {
                MessageBox.Show("Painting Exhibit table is empty");
            }
            else
            {
                PaintingName.DataSource = dt;
                PaintingName.DisplayMember = "ExhibitName";
                PaintingName.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctPainterNames();
            if(dt==null)
            {
                MessageBox.Show("Paintings table is empty");
            }
            else
            {
                PainterName.DataSource = dt;
                PainterName.ValueMember = "PainterName";
            }
            //combobox 3
            dt = MuseumController.GetDistinctPaintSchools();
            if (dt == null)
            {
                MessageBox.Show("Paintings table is empty");
            }
            else
            {
                PaintingSchool.DataSource = dt;
                PaintingSchool.ValueMember = "School";
            }

            //Sculptures
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("9");      
            if (dt == null)
            {
                MessageBox.Show("Sculpture Exhibit table is empty");
            }
            else
            {
                SculptureName.DataSource = dt;
                SculptureName.DisplayMember = "ExhibitName";
                SculptureName.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctSculptureCultures();
            if (dt == null)
            {
                MessageBox.Show("Scupture table is empty");
            }
            else
            {
                CultureName.DataSource = dt;
                CultureName.ValueMember = "Culture";
            }

            //Historical Equipments
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("8");
            if (dt == null)
            {
                MessageBox.Show("Historical Equipment Exhibit table is empty");
            }
            else
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ExhibitName";
                comboBox2.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctEquipmentCultures();
            if (dt == null)
            {
                MessageBox.Show("Historical Documents table is empty");
            }
            else
            {
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "Culture";
            }

            //Historical Documents
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("1");
            if (dt == null)
            {
                MessageBox.Show("Historical Documents Exhibit table is empty");
            }
            else
            {
                HistoricalDocumentName.DataSource = dt;
                HistoricalDocumentName.DisplayMember = "ExhibitName";
                HistoricalDocumentName.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctHistoricalDocumentDates();
            if (dt == null)
            {
                MessageBox.Show("Historical Documents table is empty");
            }
            else
            {
                HistoricalDocumentDate.DataSource = dt;
                HistoricalDocumentDate.ValueMember = "Date";
            }

            //Historical Fossils
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("6");
            if (dt == null)
            {
                MessageBox.Show("Historical Fossils Exhibit table is empty");
            }
            else
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "ExhibitName";
                comboBox4.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctFossilsPeriod();
            if (dt == null)
            {
                MessageBox.Show("Historical Fossils table is empty");
            }
            else
            {
                comboBox3.DataSource = dt;
                comboBox3.ValueMember = "Period";
            }

            //Jewelery
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("5");
            if (dt == null)
            {
                MessageBox.Show("Jewelery Exhibit table is empty");
            }
            else
            {
                comboBox6.DataSource = dt;
                comboBox6.DisplayMember = "ExhibitName";
                comboBox6.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctJeweleryTypes();
            if (dt == null)
            {
                MessageBox.Show("Jewelery table is empty");
            }
            else
            {
                comboBox5.DataSource = dt;
                comboBox5.ValueMember = "Type";
            }

            //Weapon
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("4");
            if (dt == null)
            {
                MessageBox.Show("Weapons Exhibit table is empty");
            }
            else
            {
                comboBox8.DataSource = dt;
                comboBox8.DisplayMember = "ExhibitName";
                comboBox8.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctWeaponsOrigin();
            if (dt == null)
            {
                MessageBox.Show("Weapons table is empty");
            }
            else
            {
                comboBox7.DataSource = dt;
                comboBox7.ValueMember = "Origin";
            }

            //Textiles
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("3");
            if (dt == null)
            {
                MessageBox.Show("Textiles Exhibit table is empty");
            }
            else
            {
                comboBox10.DataSource = dt;
                comboBox10.DisplayMember = "ExhibitName";
                comboBox10.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctTextilesCulture();
            if (dt == null)
            {
                MessageBox.Show("Textiles table is empty");
            }
            else
            {
                comboBox9.DataSource = dt;
                comboBox9.ValueMember = "Culture";
            }

            //Instrument
            //combobox 1
            dt = MuseumController.GetExhibitByDepartmentID("2");
            if (dt == null)
            {
                MessageBox.Show("Instruments Exhibit table is empty");
            }
            else
            {
                comboBox12.DataSource = dt;
                comboBox12.DisplayMember = "ExhibitName";
                comboBox12.ValueMember = "SerialNumber";
            }
            //combobox 2
            dt = MuseumController.GetDistinctInstrumentsCulture();
            if (dt == null)
            {
                MessageBox.Show("Instruments table is empty");
            }
            else
            {
                comboBox11.DataSource = dt;
                comboBox11.ValueMember = "Culture";
            }

            //Research
            //combobox 1
            dt = MuseumController.GetDistinctResearchType();
            if (dt == null)
            {
                MessageBox.Show("Research Exhibit table is empty");
            }
            else
            {
                comboBox14.DataSource = dt;
                comboBox14.ValueMember = "Type";
            }
            //combobox 2
            dt = MuseumController.GetDistinctResearchTopic();
            if (dt == null)
            {
                MessageBox.Show("Research table is empty");
            }
            else
            {
                comboBox13.DataSource = dt;
                comboBox13.ValueMember = "Topic";
            }

        }

        private void Exhibits_Load(object sender, EventArgs e)
        {

        }

        private void Exhibits_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void PaintingsPage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemMuseumStatistics_Click(object sender, EventArgs e)
        {
            new Display.ExhibitMuseumStatistics(MuseumController).Show();
        }

        private void StatisticsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaintingName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PainterName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaintingSchool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchByNamePaintings_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayPaintingExhibitBySerialNumber(PaintingName.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void SearchPaintings_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayExhibitsByPainterNameSchool(PainterName.Text, PaintingSchool.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void SculptureName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchByNameSculptures_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplaySculptureExhibitBySerialNumber(SculptureName.SelectedValue.ToString());
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void SculptorName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CultureName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchSculptures_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayExhibitBySculptureCulture(CultureName.SelectedValue.ToString());
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoricalDocumentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchByNameHistoricalDocuments_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayDocumentsBySerialNumber(HistoricalDocumentName.SelectedValue.ToString());
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void HistoricalDocumentDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchHistoricalDocuments_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayDocumentsByDate(HistoricalDocumentName.SelectedValue.ToString());
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaintingsPage_Click_1(object sender, EventArgs e)
        {
           
        }

        private void SculpturesPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = MuseumController.GetPaintings();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = MuseumController.GetSculptures();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void HistoricalDocumentsTab_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HistoricalEquipmentPage_Click(object sender, EventArgs e)
        {

        }

        private void HistoricalFossilsPage_Click(object sender, EventArgs e)
        {

        }

        private void JeweleryTab_Click(object sender, EventArgs e)
        {

        }

        private void WeaponAndAmmunitionTab_Click(object sender, EventArgs e)
        {

        }

        private void TextilesTab_Click(object sender, EventArgs e)
        {

        }

        private void OldMusicalInstrumentsTab_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayEquipmentsBySerialNumber(comboBox2.SelectedValue.ToString());
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayEquipmentsByCulture(comboBox1.SelectedValue.ToString());
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayEquipments();
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.GetHistoricalDocuments();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayFossilsBySerialNumber(comboBox4.SelectedValue.ToString());
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayFossilsByPeriod(comboBox3.SelectedValue.ToString());
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayFossils();
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayJeweleryBySerialNumber(comboBox6.SelectedValue.ToString());
            dataGridView6.DataSource = dt;
            dataGridView6.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayJeweleryByPeriod(comboBox5.SelectedValue.ToString());
            dataGridView6.DataSource = dt;
            dataGridView6.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayJewelery();
            dataGridView6.DataSource = dt;
            dataGridView6.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayWeaponBySerialNumber(comboBox8.SelectedValue.ToString());
            dataGridView7.DataSource = dt;
            dataGridView7.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayWeaponByOrigin(comboBox7.SelectedValue.ToString());
            dataGridView7.DataSource = dt;
            dataGridView7.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayWeapons();
            dataGridView7.DataSource = dt;
            dataGridView7.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayTextilesBySerialNumber(comboBox10.SelectedValue.ToString());
            dataGridView8.DataSource = dt;
            dataGridView8.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayTextilesByOrigin(comboBox9.SelectedValue.ToString());
            dataGridView8.DataSource = dt;
            dataGridView8.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayTextiles();
            dataGridView8.DataSource = dt;
            dataGridView8.Refresh();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayInstrumentsBySerialNumber(comboBox12.SelectedValue.ToString());
            dataGridView9.DataSource = dt;
            dataGridView9.Refresh();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayInstrumentsByCulture(comboBox11.SelectedValue.ToString());
            dataGridView9.DataSource = dt;
            dataGridView9.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayInstruments();
            dataGridView9.DataSource = dt;
            dataGridView9.Refresh();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayResearchByType(comboBox14.SelectedValue.ToString());
            dataGridView10.DataSource = dt;
            dataGridView10.Refresh();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayResearchByTopic(comboBox13.SelectedValue.ToString());
            dataGridView10.DataSource = dt;
            dataGridView10.Refresh();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DataTable dt = MuseumController.DisplayResearch();
            dataGridView10.DataSource = dt;
            dataGridView10.Refresh();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Display.Salesdisplay(MuseumController, usertypeform, departmentmanagerform).Show(this);
            this.Hide();
        }

        private void internalSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Display.InternalSuppliesDisplay(MuseumController).Show();
        }
    }
}
