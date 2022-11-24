namespace Cillo05_LabExer
{
    partial class FrmRegistration
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
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMidIn = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.ComboBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(84, 59);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(125, 20);
            this.txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(84, 140);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(125, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(290, 99);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(118, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtMidIn
            // 
            this.txtMidIn.Location = new System.Drawing.Point(473, 96);
            this.txtMidIn.Name = "txtMidIn";
            this.txtMidIn.Size = new System.Drawing.Size(75, 20);
            this.txtMidIn.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(361, 184);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(187, 20);
            this.txtContactNo.TabIndex = 8;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.txtGender.Location = new System.Drawing.Point(290, 140);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(118, 21);
            this.txtGender.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "M.I";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Contact No.";
            // 
            // txtProgram
            // 
            this.txtProgram.FormattingEnabled = true;
            this.txtProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSAPEX",
            "BSJEROME",
            "BSFLUSH"});
            this.txtProgram.Location = new System.Drawing.Point(290, 58);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(118, 21);
            this.txtProgram.TabIndex = 21;
            // 
            // btnRecords
            // 
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Location = new System.Drawing.Point(462, 218);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(86, 23);
            this.btnRecords.TabIndex = 22;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 294);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMidIn);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMidIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtProgram;
        private System.Windows.Forms.Button btnRecords;
    }
}

