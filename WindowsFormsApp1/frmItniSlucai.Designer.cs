namespace WindowsFormsApp1
{
    partial class frmItniSlucai
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
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.txtOperacionaSala = new System.Windows.Forms.TextBox();
            this.txtTipOperacija = new System.Windows.Forms.TextBox();
            this.txtDatumVreme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSbazaDataSet = new WindowsFormsApp1.HMSbazaDataSet();
            this.hMSbazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itniSlucaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itniSlucaiTableAdapter = new WindowsFormsApp1.HMSbazaDataSetTableAdapters.ItniSlucaiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionaSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itniSlucaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(127, 52);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(77, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "ID na Personal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operaciona Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip na operacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum i Vreme";
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(269, 49);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(279, 20);
            this.txtIdPersonal.TabIndex = 6;
            // 
            // txtOperacionaSala
            // 
            this.txtOperacionaSala.Location = new System.Drawing.Point(269, 131);
            this.txtOperacionaSala.Name = "txtOperacionaSala";
            this.txtOperacionaSala.Size = new System.Drawing.Size(279, 20);
            this.txtOperacionaSala.TabIndex = 7;
            // 
            // txtTipOperacija
            // 
            this.txtTipOperacija.Location = new System.Drawing.Point(269, 209);
            this.txtTipOperacija.Name = "txtTipOperacija";
            this.txtTipOperacija.Size = new System.Drawing.Size(279, 20);
            this.txtTipOperacija.TabIndex = 8;
            // 
            // txtDatumVreme
            // 
            this.txtDatumVreme.Location = new System.Drawing.Point(269, 278);
            this.txtDatumVreme.Name = "txtDatumVreme";
            this.txtDatumVreme.Size = new System.Drawing.Size(279, 20);
            this.txtDatumVreme.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(341, 317);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 46);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idPersonalDataGridViewTextBoxColumn,
            this.operacionaSalaDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.vremeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itniSlucaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 479);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // hMSbazaDataSet
            // 
            this.hMSbazaDataSet.DataSetName = "HMSbazaDataSet";
            this.hMSbazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hMSbazaDataSetBindingSource
            // 
            this.hMSbazaDataSetBindingSource.DataSource = this.hMSbazaDataSet;
            this.hMSbazaDataSetBindingSource.Position = 0;
            // 
            // itniSlucaiBindingSource
            // 
            this.itniSlucaiBindingSource.DataMember = "ItniSlucai";
            this.itniSlucaiBindingSource.DataSource = this.hMSbazaDataSetBindingSource;
            // 
            // itniSlucaiTableAdapter
            // 
            this.itniSlucaiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operacionaSalaDataGridViewTextBoxColumn
            // 
            this.operacionaSalaDataGridViewTextBoxColumn.DataPropertyName = "operacionaSala";
            this.operacionaSalaDataGridViewTextBoxColumn.HeaderText = "operacionaSala";
            this.operacionaSalaDataGridViewTextBoxColumn.Name = "operacionaSalaDataGridViewTextBoxColumn";
            this.operacionaSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vremeDataGridViewTextBoxColumn
            // 
            this.vremeDataGridViewTextBoxColumn.DataPropertyName = "vreme";
            this.vremeDataGridViewTextBoxColumn.HeaderText = "vreme";
            this.vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
            this.vremeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmItniSlucai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtDatumVreme);
            this.Controls.Add(this.txtTipOperacija);
            this.Controls.Add(this.txtOperacionaSala);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIme);
            this.Name = "frmItniSlucai";
            this.Text = "frmItniSlucai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItniSlucai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itniSlucaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPersonal;
        private System.Windows.Forms.TextBox txtOperacionaSala;
        private System.Windows.Forms.TextBox txtTipOperacija;
        private System.Windows.Forms.TextBox txtDatumVreme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hMSbazaDataSetBindingSource;
        private HMSbazaDataSet hMSbazaDataSet;
        private System.Windows.Forms.BindingSource itniSlucaiBindingSource;
        private HMSbazaDataSetTableAdapters.ItniSlucaiTableAdapter itniSlucaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionaSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
    }
}