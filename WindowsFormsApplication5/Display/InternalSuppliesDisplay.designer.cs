namespace WindowsFormsApplication5.Display
{
    partial class InternalSuppliesDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.internalsupplyname = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(753, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(462, 374);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // internalsupplyname
            // 
            this.internalsupplyname.AutoSize = true;
            this.internalsupplyname.Location = new System.Drawing.Point(39, 376);
            this.internalsupplyname.Name = "internalsupplyname";
            this.internalsupplyname.Size = new System.Drawing.Size(171, 17);
            this.internalsupplyname.TabIndex = 3;
            this.internalsupplyname.Text = "Internal Supply Item Name";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(233, 374);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(149, 24);
            this.comboBox4.TabIndex = 104;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // InternalSuppliesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 447);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.internalsupplyname);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InternalSuppliesDisplay";
            this.Text = "InternalSuppliesDisplay";
            this.Load += new System.EventHandler(this.InternalSuppliesDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label internalsupplyname;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}