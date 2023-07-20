namespace dbwindow
{
    partial class tblfeereceipt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtreceiptby = new System.Windows.Forms.TextBox();
            this.cobostudentid = new System.Windows.Forms.ComboBox();
            this.receiptdate = new System.Windows.Forms.DateTimePicker();
            this.reesave = new System.Windows.Forms.Button();
            this.reeupdate = new System.Windows.Forms.Button();
            this.reedelete = new System.Windows.Forms.Button();
            this.reereset = new System.Windows.Forms.Button();
            this.dataGridree = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridree)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Id : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receipt Date : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Receipt By : ";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(289, 118);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(217, 20);
            this.txtamount.TabIndex = 7;
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(289, 151);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(217, 20);
            this.txtpayment.TabIndex = 8;
            // 
            // txtreceiptby
            // 
            this.txtreceiptby.Location = new System.Drawing.Point(289, 185);
            this.txtreceiptby.Name = "txtreceiptby";
            this.txtreceiptby.Size = new System.Drawing.Size(217, 20);
            this.txtreceiptby.TabIndex = 9;
            // 
            // cobostudentid
            // 
            this.cobostudentid.FormattingEnabled = true;
            this.cobostudentid.Location = new System.Drawing.Point(289, 55);
            this.cobostudentid.Name = "cobostudentid";
            this.cobostudentid.Size = new System.Drawing.Size(217, 21);
            this.cobostudentid.TabIndex = 10;
            this.cobostudentid.SelectedIndexChanged += new System.EventHandler(this.cobostudentid_SelectedIndexChanged);
            // 
            // receiptdate
            // 
            this.receiptdate.CustomFormat = "dd/mm/yyyy";
            this.receiptdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiptdate.Location = new System.Drawing.Point(289, 86);
            this.receiptdate.Name = "receiptdate";
            this.receiptdate.Size = new System.Drawing.Size(217, 20);
            this.receiptdate.TabIndex = 11;
            this.receiptdate.Value = new System.DateTime(2023, 4, 26, 10, 49, 28, 0);
            // 
            // reesave
            // 
            this.reesave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reesave.Location = new System.Drawing.Point(204, 366);
            this.reesave.Name = "reesave";
            this.reesave.Size = new System.Drawing.Size(79, 34);
            this.reesave.TabIndex = 12;
            this.reesave.Text = "Save";
            this.reesave.UseVisualStyleBackColor = true;
            this.reesave.Click += new System.EventHandler(this.reesave_Click);
            // 
            // reeupdate
            // 
            this.reeupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reeupdate.Location = new System.Drawing.Point(289, 366);
            this.reeupdate.Name = "reeupdate";
            this.reeupdate.Size = new System.Drawing.Size(79, 34);
            this.reeupdate.TabIndex = 13;
            this.reeupdate.Text = "Update";
            this.reeupdate.UseVisualStyleBackColor = true;
            this.reeupdate.Click += new System.EventHandler(this.reeupdate_Click);
            // 
            // reedelete
            // 
            this.reedelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reedelete.Location = new System.Drawing.Point(374, 366);
            this.reedelete.Name = "reedelete";
            this.reedelete.Size = new System.Drawing.Size(79, 34);
            this.reedelete.TabIndex = 14;
            this.reedelete.Text = "Delete";
            this.reedelete.UseVisualStyleBackColor = true;
            this.reedelete.Click += new System.EventHandler(this.reedelete_Click);
            // 
            // reereset
            // 
            this.reereset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reereset.Location = new System.Drawing.Point(459, 366);
            this.reereset.Name = "reereset";
            this.reereset.Size = new System.Drawing.Size(79, 34);
            this.reereset.TabIndex = 15;
            this.reereset.Text = "Reset";
            this.reereset.UseVisualStyleBackColor = true;
            this.reereset.Click += new System.EventHandler(this.reereset_Click);
            // 
            // dataGridree
            // 
            this.dataGridree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridree.Location = new System.Drawing.Point(66, 226);
            this.dataGridree.Name = "dataGridree";
            this.dataGridree.Size = new System.Drawing.Size(673, 121);
            this.dataGridree.TabIndex = 16;
            this.dataGridree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridree_CellClick);
            // 
            // tblfeereceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridree);
            this.Controls.Add(this.reereset);
            this.Controls.Add(this.reedelete);
            this.Controls.Add(this.reeupdate);
            this.Controls.Add(this.reesave);
            this.Controls.Add(this.receiptdate);
            this.Controls.Add(this.cobostudentid);
            this.Controls.Add(this.txtreceiptby);
            this.Controls.Add(this.txtpayment);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "tblfeereceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tblfeereceipt";
            this.Load += new System.EventHandler(this.tblfeereceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.TextBox txtreceiptby;
        private System.Windows.Forms.ComboBox cobostudentid;
        private System.Windows.Forms.DateTimePicker receiptdate;
        private System.Windows.Forms.Button reesave;
        private System.Windows.Forms.Button reeupdate;
        private System.Windows.Forms.Button reedelete;
        private System.Windows.Forms.Button reereset;
        private System.Windows.Forms.DataGridView dataGridree;
    }
}