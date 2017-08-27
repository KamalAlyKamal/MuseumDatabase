namespace WindowsFormsApplication5.Display
{
    partial class ExhibitMuseumStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeesCount = new System.Windows.Forms.TextBox();
            this.ExhibitsCount = new System.Windows.Forms.TextBox();
            this.EmployeesAvgSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exhibits Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employees Average Salary";
            // 
            // EmployeesCount
            // 
            this.EmployeesCount.BackColor = System.Drawing.Color.Gainsboro;
            this.EmployeesCount.Location = new System.Drawing.Point(284, 117);
            this.EmployeesCount.Name = "EmployeesCount";
            this.EmployeesCount.ReadOnly = true;
            this.EmployeesCount.Size = new System.Drawing.Size(100, 22);
            this.EmployeesCount.TabIndex = 3;
            // 
            // ExhibitsCount
            // 
            this.ExhibitsCount.BackColor = System.Drawing.Color.Gainsboro;
            this.ExhibitsCount.Location = new System.Drawing.Point(284, 190);
            this.ExhibitsCount.Name = "ExhibitsCount";
            this.ExhibitsCount.ReadOnly = true;
            this.ExhibitsCount.Size = new System.Drawing.Size(100, 22);
            this.ExhibitsCount.TabIndex = 4;
            // 
            // EmployeesAvgSalary
            // 
            this.EmployeesAvgSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.EmployeesAvgSalary.Location = new System.Drawing.Point(284, 278);
            this.EmployeesAvgSalary.Name = "EmployeesAvgSalary";
            this.EmployeesAvgSalary.ReadOnly = true;
            this.EmployeesAvgSalary.Size = new System.Drawing.Size(100, 22);
            this.EmployeesAvgSalary.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(78, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Museum Statistics";
            // 
            // ExhibitMuseumStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(578, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeesAvgSalary);
            this.Controls.Add(this.ExhibitsCount);
            this.Controls.Add(this.EmployeesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExhibitMuseumStatistics";
            this.Text = "ExhibitMuseumStatistics";
            this.Load += new System.EventHandler(this.ExhibitMuseumStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeesCount;
        private System.Windows.Forms.TextBox ExhibitsCount;
        private System.Windows.Forms.TextBox EmployeesAvgSalary;
        private System.Windows.Forms.Label label4;
    }
}