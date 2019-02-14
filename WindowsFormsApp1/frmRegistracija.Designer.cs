namespace WindowsFormsApp1
{
    partial class frmRegistracija
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrimen = new System.Windows.Forms.TextBox();
            this.txtIdBolnica = new System.Windows.Forms.TextBox();
            this.txtAlergii = new System.Windows.Forms.TextBox();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSbazaDataSet = new WindowsFormsApp1.HMSbazaDataSet();
            this.hMSbazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientTableAdapter = new WindowsFormsApp1.HMSbazaDataSetTableAdapters.PacientTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBolnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(266, 77);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(279, 20);
            this.txtIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(116, 83);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primen (Datum):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alergii:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID na Bolnicata:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(266, 209);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(279, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtPrimen
            // 
            this.txtPrimen.Location = new System.Drawing.Point(266, 285);
            this.txtPrimen.Name = "txtPrimen";
            this.txtPrimen.Size = new System.Drawing.Size(279, 20);
            this.txtPrimen.TabIndex = 8;
            // 
            // txtIdBolnica
            // 
            this.txtIdBolnica.Location = new System.Drawing.Point(266, 401);
            this.txtIdBolnica.Name = "txtIdBolnica";
            this.txtIdBolnica.Size = new System.Drawing.Size(279, 20);
            this.txtIdBolnica.TabIndex = 9;
            // 
            // txtAlergii
            // 
            this.txtAlergii.Location = new System.Drawing.Point(266, 344);
            this.txtAlergii.Name = "txtAlergii";
            this.txtAlergii.Size = new System.Drawing.Size(279, 20);
            this.txtAlergii.TabIndex = 10;
            // 
            // txtPol
            // 
            this.txtPol.Location = new System.Drawing.Point(266, 138);
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(279, 20);
            this.txtPol.TabIndex = 12;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(632, 375);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 46);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(250, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "REGISTRACIJA NA PACIENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.primenDataGridViewTextBoxColumn,
            this.alergiiDataGridViewTextBoxColumn,
            this.idBolnicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(611, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.hMSbazaDataSetBindingSource;
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primenDataGridViewTextBoxColumn
            // 
            this.primenDataGridViewTextBoxColumn.DataPropertyName = "primen";
            this.primenDataGridViewTextBoxColumn.HeaderText = "primen";
            this.primenDataGridViewTextBoxColumn.Name = "primenDataGridViewTextBoxColumn";
            this.primenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alergiiDataGridViewTextBoxColumn
            // 
            this.alergiiDataGridViewTextBoxColumn.DataPropertyName = "alergii";
            this.alergiiDataGridViewTextBoxColumn.HeaderText = "alergii";
            this.alergiiDataGridViewTextBoxColumn.Name = "alergiiDataGridViewTextBoxColumn";
            this.alergiiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idBolnicaDataGridViewTextBoxColumn
            // 
            this.idBolnicaDataGridViewTextBoxColumn.DataPropertyName = "idBolnica";
            this.idBolnicaDataGridViewTextBoxColumn.HeaderText = "idBolnica";
            this.idBolnicaDataGridViewTextBoxColumn.Name = "idBolnicaDataGridViewTextBoxColumn";
            this.idBolnicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.txtAlergii);
            this.Controls.Add(this.txtIdBolnica);
            this.Controls.Add(this.txtPrimen);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Name = "frmRegistracija";
            this.Text = "frmRegistracija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrimen;
        private System.Windows.Forms.TextBox txtIdBolnica;
        private System.Windows.Forms.TextBox txtAlergii;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hMSbazaDataSetBindingSource;
        private HMSbazaDataSet hMSbazaDataSet;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private HMSbazaDataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBolnicaDataGridViewTextBoxColumn;
    }
}