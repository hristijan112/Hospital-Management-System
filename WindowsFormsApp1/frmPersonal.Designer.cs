namespace WindowsFormsApp1
{
    partial class frmPersonal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSbazaDataSet = new WindowsFormsApp1.HMSbazaDataSet();
            this.hMSbazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new WindowsFormsApp1.HMSbazaDataSetTableAdapters.PersonalTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumNaPriklucuvanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sertifikatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jaziciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBolnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.brTelefonDataGridViewTextBoxColumn,
            this.datumNaPriklucuvanjeDataGridViewTextBoxColumn,
            this.obrazovanieDataGridViewTextBoxColumn,
            this.sertifikatDataGridViewTextBoxColumn,
            this.jaziciDataGridViewTextBoxColumn,
            this.idBolnicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 291);
            this.dataGridView1.TabIndex = 0;
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
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.hMSbazaDataSetBindingSource;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
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
            // 
            // brTelefonDataGridViewTextBoxColumn
            // 
            this.brTelefonDataGridViewTextBoxColumn.DataPropertyName = "brTelefon";
            this.brTelefonDataGridViewTextBoxColumn.HeaderText = "brTelefon";
            this.brTelefonDataGridViewTextBoxColumn.Name = "brTelefonDataGridViewTextBoxColumn";
            // 
            // datumNaPriklucuvanjeDataGridViewTextBoxColumn
            // 
            this.datumNaPriklucuvanjeDataGridViewTextBoxColumn.DataPropertyName = "datumNaPriklucuvanje";
            this.datumNaPriklucuvanjeDataGridViewTextBoxColumn.HeaderText = "datumNaPriklucuvanje";
            this.datumNaPriklucuvanjeDataGridViewTextBoxColumn.Name = "datumNaPriklucuvanjeDataGridViewTextBoxColumn";
            // 
            // obrazovanieDataGridViewTextBoxColumn
            // 
            this.obrazovanieDataGridViewTextBoxColumn.DataPropertyName = "obrazovanie";
            this.obrazovanieDataGridViewTextBoxColumn.HeaderText = "obrazovanie";
            this.obrazovanieDataGridViewTextBoxColumn.Name = "obrazovanieDataGridViewTextBoxColumn";
            // 
            // sertifikatDataGridViewTextBoxColumn
            // 
            this.sertifikatDataGridViewTextBoxColumn.DataPropertyName = "sertifikat";
            this.sertifikatDataGridViewTextBoxColumn.HeaderText = "sertifikat";
            this.sertifikatDataGridViewTextBoxColumn.Name = "sertifikatDataGridViewTextBoxColumn";
            // 
            // jaziciDataGridViewTextBoxColumn
            // 
            this.jaziciDataGridViewTextBoxColumn.DataPropertyName = "jazici";
            this.jaziciDataGridViewTextBoxColumn.HeaderText = "jazici";
            this.jaziciDataGridViewTextBoxColumn.Name = "jaziciDataGridViewTextBoxColumn";
            // 
            // idBolnicaDataGridViewTextBoxColumn
            // 
            this.idBolnicaDataGridViewTextBoxColumn.DataPropertyName = "idBolnica";
            this.idBolnicaDataGridViewTextBoxColumn.HeaderText = "idBolnica";
            this.idBolnicaDataGridViewTextBoxColumn.Name = "idBolnicaDataGridViewTextBoxColumn";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(344, 377);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 46);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "ZACUVAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPersonal";
            this.Text = "frmPersonal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSbazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hMSbazaDataSetBindingSource;
        private HMSbazaDataSet hMSbazaDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private HMSbazaDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumNaPriklucuvanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sertifikatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jaziciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBolnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodaj;
    }
}