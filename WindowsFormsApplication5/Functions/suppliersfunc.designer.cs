namespace WindowsFormsApplication5.Functions
{
    partial class suppliersfunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl1;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.homepage = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.region = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.suppliername = new System.Windows.Forms.TextBox();
            this.supplierid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addsupplier = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textbox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(581, 427);
            tabControl1.TabIndex = 102;
            tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.homepage);
            this.tabPage1.Controls.Add(this.lb);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.postalcode);
            this.tabPage1.Controls.Add(this.region);
            this.tabPage1.Controls.Add(this.city);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.fax);
            this.tabPage1.Controls.Add(this.suppliername);
            this.tabPage1.Controls.Add(this.supplierid);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.addsupplier);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add new supplier";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // homepage
            // 
            this.homepage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homepage.Location = new System.Drawing.Point(240, 302);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(100, 24);
            this.homepage.TabIndex = 135;
            this.homepage.TextChanged += new System.EventHandler(this.homepage_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(122, 305);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(74, 17);
            this.lb.TabIndex = 134;
            this.lb.Text = "HomePage";
            this.lb.Click += new System.EventHandler(this.label13_Click);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.phone.Location = new System.Drawing.Point(240, 263);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 24);
            this.phone.TabIndex = 133;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // postalcode
            // 
            this.postalcode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.postalcode.Location = new System.Drawing.Point(240, 233);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(100, 24);
            this.postalcode.TabIndex = 132;
            this.postalcode.TextChanged += new System.EventHandler(this.postalcode_TextChanged);
            // 
            // region
            // 
            this.region.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.region.Location = new System.Drawing.Point(240, 197);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(100, 24);
            this.region.TabIndex = 131;
            this.region.TextChanged += new System.EventHandler(this.region_TextChanged);
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.city.Location = new System.Drawing.Point(240, 164);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 24);
            this.city.TabIndex = 130;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.address.Location = new System.Drawing.Point(240, 134);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 24);
            this.address.TabIndex = 129;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // fax
            // 
            this.fax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fax.Location = new System.Drawing.Point(240, 101);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(100, 24);
            this.fax.TabIndex = 128;
            this.fax.TextChanged += new System.EventHandler(this.fax_TextChanged);
            // 
            // suppliername
            // 
            this.suppliername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.suppliername.Location = new System.Drawing.Point(240, 59);
            this.suppliername.Name = "suppliername";
            this.suppliername.Size = new System.Drawing.Size(100, 24);
            this.suppliername.TabIndex = 127;
            this.suppliername.TextChanged += new System.EventHandler(this.suppliername_TextChanged);
            // 
            // supplierid
            // 
            this.supplierid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.supplierid.Location = new System.Drawing.Point(240, 24);
            this.supplierid.Name = "supplierid";
            this.supplierid.Size = new System.Drawing.Size(100, 24);
            this.supplierid.TabIndex = 126;
            this.supplierid.TextChanged += new System.EventHandler(this.supplierid_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 125;
            this.label12.Text = "PostalCode";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 124;
            this.label10.Text = "Phone";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 123;
            this.label9.Text = "Address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 122;
            this.label8.Text = "City";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "Region";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 120;
            this.label5.Text = "SupplierName";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Fax";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "SupplierID";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // addsupplier
            // 
            this.addsupplier.Location = new System.Drawing.Point(168, 353);
            this.addsupplier.Name = "addsupplier";
            this.addsupplier.Size = new System.Drawing.Size(181, 23);
            this.addsupplier.TabIndex = 114;
            this.addsupplier.Text = "Add ";
            this.addsupplier.UseVisualStyleBackColor = true;
            this.addsupplier.Click += new System.EventHandler(this.addsupplier_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.textbox8);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit supplier";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(538, 99);
            this.dataGridView1.TabIndex = 156;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 17);
            this.label22.TabIndex = 155;
            this.label22.Text = "choose suppliername";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 103;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox15.Location = new System.Drawing.Point(470, 200);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 24);
            this.textBox15.TabIndex = 154;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 153;
            this.label13.Text = "HomePage";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox11.Location = new System.Drawing.Point(129, 202);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 24);
            this.textBox11.TabIndex = 152;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox14.Location = new System.Drawing.Point(470, 170);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 24);
            this.textBox14.TabIndex = 151;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox13.Location = new System.Drawing.Point(470, 133);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 24);
            this.textBox13.TabIndex = 150;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox10.Location = new System.Drawing.Point(129, 163);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 24);
            this.textBox10.TabIndex = 149;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox9.Location = new System.Drawing.Point(129, 133);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 24);
            this.textBox9.TabIndex = 148;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox12.Location = new System.Drawing.Point(470, 93);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 24);
            this.textBox12.TabIndex = 147;
            // 
            // textbox8
            // 
            this.textbox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textbox8.Location = new System.Drawing.Point(129, 97);
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(100, 24);
            this.textbox8.TabIndex = 146;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(389, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 144;
            this.label15.Text = "PostalCode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 143;
            this.label16.Text = "Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 142;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 141;
            this.label18.Text = "City";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(389, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 140;
            this.label19.Text = "Region";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 17);
            this.label20.TabIndex = 139;
            this.label20.Text = "SupplierName";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(389, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 17);
            this.label21.TabIndex = 138;
            this.label21.Text = "Fax";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 136;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(573, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "delete supplier ";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-164, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Quantity Exibits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-164, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 99;
            this.label11.Text = "Supplied Item Name:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-164, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Quantity Research:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-164, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 94;
            this.label7.Text = "Total Quantity:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-164, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 17);
            this.label14.TabIndex = 95;
            this.label14.Text = "Supplier Name:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 17);
            this.label23.TabIndex = 157;
            this.label23.Text = "choose suppliername";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 156;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(574, 150);
            this.dataGridView2.TabIndex = 158;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 159;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // suppliersfunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Name = "suppliersfunc";
            this.Text = "Form1";
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox postalcode;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.TextBox suppliername;
        private System.Windows.Forms.TextBox supplierid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addsupplier;
        private System.Windows.Forms.TextBox homepage;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textbox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}