namespace WindowsFormsApplication5
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.GuestLogIn = new System.Windows.Forms.Button();
            this.Copyrights = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.SystemColors.Control;
            this.LogIn.Location = new System.Drawing.Point(255, 317);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 32);
            this.LogIn.TabIndex = 5;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // GuestLogIn
            // 
            this.GuestLogIn.Location = new System.Drawing.Point(222, 355);
            this.GuestLogIn.Name = "GuestLogIn";
            this.GuestLogIn.Size = new System.Drawing.Size(143, 34);
            this.GuestLogIn.TabIndex = 6;
            this.GuestLogIn.Text = "Log In As a Guest";
            this.GuestLogIn.UseVisualStyleBackColor = true;
            this.GuestLogIn.Click += new System.EventHandler(this.GuestLogIn_Click);
            // 
            // Copyrights
            // 
            this.Copyrights.AutoSize = true;
            this.Copyrights.BackColor = System.Drawing.Color.Transparent;
            this.Copyrights.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyrights.ForeColor = System.Drawing.Color.White;
            this.Copyrights.Location = new System.Drawing.Point(12, 403);
            this.Copyrights.Name = "Copyrights";
            this.Copyrights.Size = new System.Drawing.Size(480, 22);
            this.Copyrights.TabIndex = 7;
            this.Copyrights.Text = "Ahmed M.Ismail, Kamal Aly, Ahmed Soliman, Ahmed Osman";
            this.Copyrights.Click += new System.EventHandler(this.Copyrights_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 434);
            this.Controls.Add(this.Copyrights);
            this.Controls.Add(this.GuestLogIn);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button GuestLogIn;
        private System.Windows.Forms.Label Copyrights;
        private System.Windows.Forms.Timer timer1;
    }
}

