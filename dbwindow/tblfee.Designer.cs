namespace dbwindow
{
    partial class tblfee
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
            this.txthead = new System.Windows.Forms.TextBox();
            this.txtcharges = new System.Windows.Forms.TextBox();
            this.coboclsid = new System.Windows.Forms.ComboBox();
            this.feesave = new System.Windows.Forms.Button();
            this.feeupdate = new System.Windows.Forms.Button();
            this.feedelete = new System.Windows.Forms.Button();
            this.feereset = new System.Windows.Forms.Button();
            this.dataGridfee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Charges : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ClassID : ";
            // 
            // txthead
            // 
            this.txthead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthead.Location = new System.Drawing.Point(334, 33);
            this.txthead.Name = "txthead";
            this.txthead.Size = new System.Drawing.Size(212, 22);
            this.txthead.TabIndex = 3;
            // 
            // txtcharges
            // 
            this.txtcharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcharges.Location = new System.Drawing.Point(334, 75);
            this.txtcharges.Name = "txtcharges";
            this.txtcharges.Size = new System.Drawing.Size(212, 22);
            this.txtcharges.TabIndex = 4;
            // 
            // coboclsid
            // 
            this.coboclsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coboclsid.FormattingEnabled = true;
            this.coboclsid.Location = new System.Drawing.Point(334, 112);
            this.coboclsid.Name = "coboclsid";
            this.coboclsid.Size = new System.Drawing.Size(212, 24);
            this.coboclsid.TabIndex = 5;
            this.coboclsid.SelectedIndexChanged += new System.EventHandler(this.coboclsid_SelectedIndexChanged);
            // 
            // feesave
            // 
            this.feesave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesave.Location = new System.Drawing.Point(230, 171);
            this.feesave.Name = "feesave";
            this.feesave.Size = new System.Drawing.Size(75, 27);
            this.feesave.TabIndex = 6;
            this.feesave.Text = "Save";
            this.feesave.UseVisualStyleBackColor = true;
            this.feesave.Click += new System.EventHandler(this.feesave_Click);
            // 
            // feeupdate
            // 
            this.feeupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeupdate.Location = new System.Drawing.Point(311, 171);
            this.feeupdate.Name = "feeupdate";
            this.feeupdate.Size = new System.Drawing.Size(75, 27);
            this.feeupdate.TabIndex = 7;
            this.feeupdate.Text = "Update";
            this.feeupdate.UseVisualStyleBackColor = true;
            this.feeupdate.Click += new System.EventHandler(this.feeupdate_Click);
            // 
            // feedelete
            // 
            this.feedelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedelete.Location = new System.Drawing.Point(392, 171);
            this.feedelete.Name = "feedelete";
            this.feedelete.Size = new System.Drawing.Size(75, 27);
            this.feedelete.TabIndex = 8;
            this.feedelete.Text = "Delete";
            this.feedelete.UseVisualStyleBackColor = true;
            this.feedelete.Click += new System.EventHandler(this.feedelete_Click);
            // 
            // feereset
            // 
            this.feereset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feereset.Location = new System.Drawing.Point(473, 171);
            this.feereset.Name = "feereset";
            this.feereset.Size = new System.Drawing.Size(75, 27);
            this.feereset.TabIndex = 9;
            this.feereset.Text = "Reset";
            this.feereset.UseVisualStyleBackColor = true;
            this.feereset.Click += new System.EventHandler(this.feereset_Click);
            // 
            // dataGridfee
            // 
            this.dataGridfee.AllowUserToAddRows = false;
            this.dataGridfee.AllowUserToDeleteRows = false;
            this.dataGridfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridfee.Location = new System.Drawing.Point(124, 230);
            this.dataGridfee.Name = "dataGridfee";
            this.dataGridfee.ReadOnly = true;
            this.dataGridfee.Size = new System.Drawing.Size(533, 106);
            this.dataGridfee.TabIndex = 10;
            this.dataGridfee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridfee_CellClick);
            // 
            // tblfee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridfee);
            this.Controls.Add(this.feereset);
            this.Controls.Add(this.feedelete);
            this.Controls.Add(this.feeupdate);
            this.Controls.Add(this.feesave);
            this.Controls.Add(this.coboclsid);
            this.Controls.Add(this.txtcharges);
            this.Controls.Add(this.txthead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tblfee";
            this.Text = "tblfee";
            this.Load += new System.EventHandler(this.tblfee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthead;
        private System.Windows.Forms.TextBox txtcharges;
        private System.Windows.Forms.ComboBox coboclsid;
        private System.Windows.Forms.Button feesave;
        private System.Windows.Forms.Button feeupdate;
        private System.Windows.Forms.Button feedelete;
        private System.Windows.Forms.Button feereset;
        private System.Windows.Forms.DataGridView dataGridfee;
    }
}