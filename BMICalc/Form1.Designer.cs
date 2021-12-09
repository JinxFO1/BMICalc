namespace BMICalc
{
    partial class Form1
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
            this.BmiCalc = new System.Windows.Forms.Button();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.ReturnTxt = new System.Windows.Forms.TextBox();
            this.HistoryRTB = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Login = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BmiCalc
            // 
            this.BmiCalc.Location = new System.Drawing.Point(245, 20);
            this.BmiCalc.Name = "BmiCalc";
            this.BmiCalc.Size = new System.Drawing.Size(125, 93);
            this.BmiCalc.TabIndex = 0;
            this.BmiCalc.Text = "BMI Calc\r\n";
            this.BmiCalc.UseVisualStyleBackColor = true;
            this.BmiCalc.Click += new System.EventHandler(this.BmiCalc_Click);
            // 
            // WeightTxt
            // 
            this.WeightTxt.Location = new System.Drawing.Point(83, 21);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(100, 20);
            this.WeightTxt.TabIndex = 1;
            // 
            // HeightTxt
            // 
            this.HeightTxt.Location = new System.Drawing.Point(83, 60);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(100, 20);
            this.HeightTxt.TabIndex = 2;
            // 
            // ReturnTxt
            // 
            this.ReturnTxt.Location = new System.Drawing.Point(502, 6);
            this.ReturnTxt.Multiline = true;
            this.ReturnTxt.Name = "ReturnTxt";
            this.ReturnTxt.Size = new System.Drawing.Size(220, 128);
            this.ReturnTxt.TabIndex = 3;
            // 
            // HistoryRTB
            // 
            this.HistoryRTB.Location = new System.Drawing.Point(28, 170);
            this.HistoryRTB.Name = "HistoryRTB";
            this.HistoryRTB.Size = new System.Drawing.Size(436, 215);
            this.HistoryRTB.TabIndex = 4;
            this.HistoryRTB.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(502, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 215);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Location = new System.Drawing.Point(-1, -1);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1102, 439);
            this.tabcontrol1.TabIndex = 6;
            this.tabcontrol1.SelectedIndexChanged += new System.EventHandler(this.tabcontrol1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.Login);
            this.tabPage1.Controls.Add(this.Gender);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.DoB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(344, 142);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(216, 50);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Gender
            // 
            this.Gender.AllowDrop = true;
            this.Gender.BackColor = System.Drawing.SystemColors.Window;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other",
            "Prefer not to say"});
            this.Gender.Location = new System.Drawing.Point(77, 297);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // DoB
            // 
            this.DoB.Location = new System.Drawing.Point(77, 94);
            this.DoB.Name = "DoB";
            this.DoB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "D.O.B";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(77, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BmiCalc);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.WeightTxt);
            this.tabPage2.Controls.Add(this.HistoryRTB);
            this.tabPage2.Controls.Add(this.HeightTxt);
            this.tabPage2.Controls.Add(this.ReturnTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.tabcontrol1);
            //this.Name = "Form1";
            this.Text = "   Calc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BmiCalc;
        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.TextBox ReturnTxt;
        private System.Windows.Forms.RichTextBox HistoryRTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar DoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Login;
    }
}

