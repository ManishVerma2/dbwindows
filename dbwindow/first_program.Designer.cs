namespace dbwindow
{
    partial class first_program
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgtbl = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.classid = new System.Windows.Forms.ComboBox();
            this.choosegn = new System.Windows.Forms.GroupBox();
            this.other = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.bpl = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddcls = new System.Windows.Forms.TextBox();
            this.dataGridclass = new System.Windows.Forms.DataGridView();
            this.clssave = new System.Windows.Forms.Button();
            this.clsupdate = new System.Windows.Forms.Button();
            this.clsdelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtbl)).BeginInit();
            this.choosegn.SuspendLayout();
            this.bpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridclass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtbl
            // 
            this.dgtbl.AllowUserToAddRows = false;
            this.dgtbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtbl.Location = new System.Drawing.Point(12, 265);
            this.dgtbl.Name = "dgtbl";
            this.dgtbl.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtbl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgtbl.RowTemplate.Height = 30;
            this.dgtbl.Size = new System.Drawing.Size(776, 201);
            this.dgtbl.TabIndex = 0;
            this.dgtbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtbl_CellClick);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(183, 472);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 39);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(288, 472);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 39);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(393, 472);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 39);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(498, 472);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(99, 39);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Father Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mother Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of BIrth : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class Id : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Student is BPL :";
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.Location = new System.Drawing.Point(193, 4);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(274, 23);
            this.txtsname.TabIndex = 12;
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(193, 33);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(274, 23);
            this.txtfname.TabIndex = 13;
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(193, 62);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(274, 23);
            this.txtmname.TabIndex = 14;
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd/mm/yyyy";
            this.dob.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(192, 91);
            this.dob.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(274, 23);
            this.dob.TabIndex = 15;
            this.dob.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // classid
            // 
            this.classid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classid.FormattingEnabled = true;
            this.classid.Location = new System.Drawing.Point(192, 120);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(274, 24);
            this.classid.TabIndex = 16;
            this.classid.SelectedIndexChanged += new System.EventHandler(this.classid_SelectedIndexChanged);
            // 
            // choosegn
            // 
            this.choosegn.Controls.Add(this.other);
            this.choosegn.Controls.Add(this.female);
            this.choosegn.Controls.Add(this.male);
            this.choosegn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosegn.Location = new System.Drawing.Point(192, 150);
            this.choosegn.Name = "choosegn";
            this.choosegn.Size = new System.Drawing.Size(274, 46);
            this.choosegn.TabIndex = 17;
            this.choosegn.TabStop = false;
            this.choosegn.Text = "Gender";
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(179, 19);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(67, 20);
            this.other.TabIndex = 2;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            this.other.CheckedChanged += new System.EventHandler(this.Chk);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(81, 19);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(77, 20);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.Chk);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(6, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 20);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.Chk);
            // 
            // bpl
            // 
            this.bpl.Controls.Add(this.checkBox2);
            this.bpl.Controls.Add(this.checkBox1);
            this.bpl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpl.Location = new System.Drawing.Point(193, 202);
            this.bpl.Name = "bpl";
            this.bpl.Size = new System.Drawing.Size(274, 46);
            this.bpl.TabIndex = 18;
            this.bpl.TabStop = false;
            this.bpl.Text = "BPL";
            this.bpl.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(80, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.BPLChk);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.BPLChk);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Add Class ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtaddcls
            // 
            this.txtaddcls.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddcls.Location = new System.Drawing.Point(489, 36);
            this.txtaddcls.Name = "txtaddcls";
            this.txtaddcls.Size = new System.Drawing.Size(204, 23);
            this.txtaddcls.TabIndex = 20;
            // 
            // dataGridclass
            // 
            this.dataGridclass.AllowUserToAddRows = false;
            this.dataGridclass.AllowUserToDeleteRows = false;
            this.dataGridclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridclass.Location = new System.Drawing.Point(489, 81);
            this.dataGridclass.Name = "dataGridclass";
            this.dataGridclass.ReadOnly = true;
            this.dataGridclass.Size = new System.Drawing.Size(299, 63);
            this.dataGridclass.TabIndex = 21;
            this.dataGridclass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridclass_CellContentClick);
            // 
            // clssave
            // 
            this.clssave.Location = new System.Drawing.Point(540, 163);
            this.clssave.Name = "clssave";
            this.clssave.Size = new System.Drawing.Size(47, 25);
            this.clssave.TabIndex = 22;
            this.clssave.Text = "Save";
            this.clssave.UseVisualStyleBackColor = true;
            this.clssave.Click += new System.EventHandler(this.clssave_Click);
            // 
            // clsupdate
            // 
            this.clsupdate.Location = new System.Drawing.Point(593, 163);
            this.clsupdate.Name = "clsupdate";
            this.clsupdate.Size = new System.Drawing.Size(47, 25);
            this.clsupdate.TabIndex = 23;
            this.clsupdate.Text = "Update";
            this.clsupdate.UseVisualStyleBackColor = true;
            this.clsupdate.Click += new System.EventHandler(this.clsupdate_Click);
            // 
            // clsdelete
            // 
            this.clsdelete.Location = new System.Drawing.Point(646, 163);
            this.clsdelete.Name = "clsdelete";
            this.clsdelete.Size = new System.Drawing.Size(47, 25);
            this.clsdelete.TabIndex = 24;
            this.clsdelete.Text = "Delete";
            this.clsdelete.UseVisualStyleBackColor = true;
            this.clsdelete.Click += new System.EventHandler(this.clsdelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(726, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "0";
            // 
            // first_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clsdelete);
            this.Controls.Add(this.clsupdate);
            this.Controls.Add(this.clssave);
            this.Controls.Add(this.dataGridclass);
            this.Controls.Add(this.txtaddcls);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bpl);
            this.Controls.Add(this.choosegn);
            this.Controls.Add(this.classid);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgtbl);
            this.Name = "first_program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "first_program";
            this.Load += new System.EventHandler(this.first_program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtbl)).EndInit();
            this.choosegn.ResumeLayout(false);
            this.choosegn.PerformLayout();
            this.bpl.ResumeLayout(false);
            this.bpl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtbl;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox classid;
        private System.Windows.Forms.GroupBox choosegn;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.GroupBox bpl;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaddcls;
        private System.Windows.Forms.DataGridView dataGridclass;
        private System.Windows.Forms.Button clssave;
        private System.Windows.Forms.Button clsupdate;
        private System.Windows.Forms.Button clsdelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}