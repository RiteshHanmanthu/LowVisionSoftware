namespace LowVisionSoftware
{
    partial class Donation
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.DonorGridView = new System.Windows.Forms.DataGridView();
            this.donorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDonorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.___Ritesh_Blind_LowVisionDBDataSet = new LowVisionSoftware.@__Ritesh_Blind_LowVisionDBDataSet();
            this.newDonorTableAdapter = new LowVisionSoftware.@__Ritesh_Blind_LowVisionDBDataSetTableAdapters.NewDonorTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DonorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDonorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___Ritesh_Blind_LowVisionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(473, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(388, 353);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email ID: ";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // DonorGridView
            // 
            this.DonorGridView.AllowUserToAddRows = false;
            this.DonorGridView.AllowUserToDeleteRows = false;
            this.DonorGridView.AllowUserToResizeColumns = false;
            this.DonorGridView.AllowUserToResizeRows = false;
            this.DonorGridView.AutoGenerateColumns = false;
            this.DonorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.donationAmtDataGridViewTextBoxColumn});
            this.DonorGridView.DataSource = this.newDonorBindingSource;
            this.DonorGridView.Location = new System.Drawing.Point(391, 12);
            this.DonorGridView.Name = "DonorGridView";
            this.DonorGridView.Size = new System.Drawing.Size(444, 313);
            this.DonorGridView.TabIndex = 2;
            this.DonorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonorGridView_CellContentClick);
            // 
            // donorNameDataGridViewTextBoxColumn
            // 
            this.donorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.HeaderText = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.Name = "donorNameDataGridViewTextBoxColumn";
            this.donorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // donationAmtDataGridViewTextBoxColumn
            // 
            this.donationAmtDataGridViewTextBoxColumn.DataPropertyName = "DonationAmt";
            this.donationAmtDataGridViewTextBoxColumn.HeaderText = "DonationAmt";
            this.donationAmtDataGridViewTextBoxColumn.Name = "donationAmtDataGridViewTextBoxColumn";
            // 
            // newDonorBindingSource
            // 
            this.newDonorBindingSource.DataMember = "NewDonor";
            this.newDonorBindingSource.DataSource = this.___Ritesh_Blind_LowVisionDBDataSet;
            // 
            // ___Ritesh_Blind_LowVisionDBDataSet
            // 
            this.___Ritesh_Blind_LowVisionDBDataSet.DataSetName = "__Ritesh_Blind_LowVisionDBDataSet";
            this.___Ritesh_Blind_LowVisionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newDonorTableAdapter
            // 
            this.newDonorTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LowVisionSoftware.Properties.Resources.thumbsUp_NoBG;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LowVisionSoftware.Properties.Resources.DSC_3034;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 121);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter EXACTLY THE SAME \r\nEmail you have used to donate.\r\n\r\nThank you for m" +
    "aking a difference in our society!.";
            // 
            // Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DonorGridView);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Donation";
            this.Text = "Donation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDonorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___Ritesh_Blind_LowVisionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView DonorGridView;
        private __Ritesh_Blind_LowVisionDBDataSet ___Ritesh_Blind_LowVisionDBDataSet;
        private System.Windows.Forms.BindingSource newDonorBindingSource;
        private __Ritesh_Blind_LowVisionDBDataSetTableAdapters.NewDonorTableAdapter newDonorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

