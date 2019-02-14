namespace WindowsFormsApp1
{
    partial class frmOperacii
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
            this.txtIdPacient = new System.Windows.Forms.TextBox();
            this.txtIdDoktor = new System.Windows.Forms.TextBox();
            this.txtTipOperacija = new System.Windows.Forms.TextBox();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSbazaDataSet = new WindowsFormsApp1.HMSbazaDataSet();
            this.hMSbazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operaciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operaciiTableAdapter = new WindowsFormsApp1.HMSbazaDataSetTableAdapters.OperaciiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipNaOperacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaciiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(177, 76);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(72, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "ID na Pacient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID na Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip na Operacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum i Vreme";
            // 
            // txtIdPacient
            // 
            this.txtIdPacient.Location = new System.Drawing.Point(338, 73);
            this.txtIdPacient.Name = "txtIdPacient";
            this.txtIdPacient.Size = new System.Drawing.Size(279, 20);
            this.txtIdPacient.TabIndex = 6;
            // 
            // txtIdDoktor
            // 
            this.txtIdDoktor.Location = new System.Drawing.Point(338, 137);
            this.txtIdDoktor.Name = "txtIdDoktor";
            this.txtIdDoktor.Size = new System.Drawing.Size(279, 20);
            this.txtIdDoktor.TabIndex = 7;
            // 
            // txtTipOperacija
            // 
            this.txtTipOperacija.Location = new System.Drawing.Point(338, 207);
            this.txtTipOperacija.Name = "txtTipOperacija";
            this.txtTipOperacija.Size = new System.Drawing.Size(279, 20);
            this.txtTipOperacija.TabIndex = 8;
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(338, 277);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(279, 20);
            this.txtVreme.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(422, 333);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idPacientDataGridViewTextBoxColumn,
            this.idPersonalDataGridViewTextBoxColumn,
            this.tipNaOperacijaDataGridViewTextBoxColumn,
            this.vremeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operaciiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
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
            // operaciiBindingSource
            // 
            this.operaciiBindingSource.DataMember = "Operacii";
            this.operaciiBindingSource.DataSource = this.hMSbazaDataSetBindingSource;
            // 
            // operaciiTableAdapter
            // 
            this.operaciiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "idPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "idPacient";
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipNaOperacijaDataGridViewTextBoxColumn
            // 
            this.tipNaOperacijaDataGridViewTextBoxColumn.DataPropertyName = "tipNaOperacija";
            this.tipNaOperacijaDataGridViewTextBoxColumn.HeaderText = "tipNaOperacija";
            this.tipNaOperacijaDataGridViewTextBoxColumn.Name = "tipNaOperacijaDataGridViewTextBoxColumn";
            this.tipNaOperacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vremeDataGridViewTextBoxColumn
            // 
            this.vremeDataGridViewTextBoxColumn.DataPropertyName = "vreme";
            this.vremeDataGridViewTextBoxColumn.HeaderText = "vreme";
            this.vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
            this.vremeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmOperacii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.txtTipOperacija);
            this.Controls.Add(this.txtIdDoktor);
            this.Controls.Add(this.txtIdPacient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIme);
            this.Name = "frmOperacii";
            this.Text = "frmOperacii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOperacii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaciiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPacient;
        private System.Windows.Forms.TextBox txtIdDoktor;
        private System.Windows.Forms.TextBox txtTipOperacija;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hMSbazaDataSetBindingSource;
        private HMSbazaDataSet hMSbazaDataSet;
        private System.Windows.Forms.BindingSource operaciiBindingSource;
        private HMSbazaDataSetTableAdapters.OperaciiTableAdapter operaciiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipNaOperacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
    }
}