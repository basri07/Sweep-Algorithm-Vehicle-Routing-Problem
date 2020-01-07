namespace GA_ARP_3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this._GA_ARP_3DataSet4 = new GA_ARP_3._GA_ARP_3DataSet4();
            this.müsterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müsterilerTableAdapter = new GA_ARP_3._GA_ARP_3DataSet4TableAdapters.MüsterilerTableAdapter();
            this.müsterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._GA_ARP_3DataSet8 = new GA_ARP_3._GA_ARP_3DataSet8();
            this.AracGridWiew = new System.Windows.Forms.DataGridView();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müsterilerTableAdapter1 = new GA_ARP_3._GA_ARP_3DataSet8TableAdapters.MüsterilerTableAdapter();
            this.müsterilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._GA_ARP_3DataSet10 = new GA_ARP_3._GA_ARP_3DataSet10();
            this.müsterilerTableAdapter2 = new GA_ARP_3._GA_ARP_3DataSet10TableAdapters.MüsterilerTableAdapter();
            this.MusteriGridWiew = new MetroFramework.Controls.MetroGrid();
            this._GA_ARP_3DataSet2 = new GA_ARP_3._GA_ARP_3DataSet2();
            this.müsterilerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.müsterilerTableAdapter3 = new GA_ARP_3._GA_ARP_3DataSet2TableAdapters.MüsterilerTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidildimiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _GA_ARP_3DataSet4
            // 
            this._GA_ARP_3DataSet4.DataSetName = "_GA_ARP_3DataSet4";
            this._GA_ARP_3DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsterilerBindingSource
            // 
            this.müsterilerBindingSource.DataMember = "Müsteriler";
            this.müsterilerBindingSource.DataSource = this._GA_ARP_3DataSet4;
            // 
            // müsterilerTableAdapter
            // 
            this.müsterilerTableAdapter.ClearBeforeFill = true;
            // 
            // müsterilerBindingSource1
            // 
            this.müsterilerBindingSource1.DataMember = "Müsteriler";
            this.müsterilerBindingSource1.DataSource = this._GA_ARP_3DataSet8;
            // 
            // _GA_ARP_3DataSet8
            // 
            this._GA_ARP_3DataSet8.DataSetName = "_GA_ARP_3DataSet8";
            this._GA_ARP_3DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AracGridWiew
            // 
            this.AracGridWiew.AutoGenerateColumns = false;
            this.AracGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AracGridWiew.DataSource = this.aracBindingSource;
            this.AracGridWiew.Location = new System.Drawing.Point(74, 129);
            this.AracGridWiew.Name = "AracGridWiew";
            this.AracGridWiew.Size = new System.Drawing.Size(394, 150);
            this.AracGridWiew.TabIndex = 2;
            this.AracGridWiew.Visible = false;
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataMember = "Arac";
            // 
            // müsterilerTableAdapter1
            // 
            this.müsterilerTableAdapter1.ClearBeforeFill = true;
            // 
            // müsterilerBindingSource2
            // 
            this.müsterilerBindingSource2.DataMember = "Müsteriler";
            this.müsterilerBindingSource2.DataSource = this._GA_ARP_3DataSet10;
            // 
            // _GA_ARP_3DataSet10
            // 
            this._GA_ARP_3DataSet10.DataSetName = "_GA_ARP_3DataSet10";
            this._GA_ARP_3DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsterilerTableAdapter2
            // 
            this.müsterilerTableAdapter2.ClearBeforeFill = true;
            // 
            // MusteriGridWiew
            // 
            this.MusteriGridWiew.AllowUserToResizeRows = false;
            this.MusteriGridWiew.AutoGenerateColumns = false;
            this.MusteriGridWiew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MusteriGridWiew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusteriGridWiew.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MusteriGridWiew.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusteriGridWiew.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MusteriGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriGridWiew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.talepDataGridViewTextBoxColumn,
            this.acılarDataGridViewTextBoxColumn,
            this.gidildimiDataGridViewCheckBoxColumn});
            this.MusteriGridWiew.DataSource = this.müsterilerBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusteriGridWiew.DefaultCellStyle = dataGridViewCellStyle2;
            this.MusteriGridWiew.EnableHeadersVisualStyles = false;
            this.MusteriGridWiew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MusteriGridWiew.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MusteriGridWiew.Location = new System.Drawing.Point(3, 45);
            this.MusteriGridWiew.Name = "MusteriGridWiew";
            this.MusteriGridWiew.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusteriGridWiew.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MusteriGridWiew.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MusteriGridWiew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriGridWiew.Size = new System.Drawing.Size(599, 406);
            this.MusteriGridWiew.TabIndex = 3;
            // 
            // _GA_ARP_3DataSet2
            // 
            this._GA_ARP_3DataSet2.DataSetName = "_GA_ARP_3DataSet2";
            this._GA_ARP_3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsterilerBindingSource3
            // 
            this.müsterilerBindingSource3.DataMember = "Müsteriler";
            this.müsterilerBindingSource3.DataSource = this._GA_ARP_3DataSet2;
            // 
            // müsterilerTableAdapter3
            // 
            this.müsterilerTableAdapter3.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // talepDataGridViewTextBoxColumn
            // 
            this.talepDataGridViewTextBoxColumn.DataPropertyName = "Talep";
            this.talepDataGridViewTextBoxColumn.HeaderText = "Talep";
            this.talepDataGridViewTextBoxColumn.Name = "talepDataGridViewTextBoxColumn";
            // 
            // acılarDataGridViewTextBoxColumn
            // 
            this.acılarDataGridViewTextBoxColumn.DataPropertyName = "Acılar";
            this.acılarDataGridViewTextBoxColumn.HeaderText = "Acılar";
            this.acılarDataGridViewTextBoxColumn.Name = "acılarDataGridViewTextBoxColumn";
            // 
            // gidildimiDataGridViewCheckBoxColumn
            // 
            this.gidildimiDataGridViewCheckBoxColumn.DataPropertyName = "Gidildimi";
            this.gidildimiDataGridViewCheckBoxColumn.HeaderText = "Gidildimi";
            this.gidildimiDataGridViewCheckBoxColumn.Name = "gidildimiDataGridViewCheckBoxColumn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(623, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(7652, 459);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 463);
            this.Controls.Add(this.MusteriGridWiew);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AracGridWiew);
            this.Name = "Form1";
            this.Text = "ÇÖZÜM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private _GA_ARP_3DataSet4 _GA_ARP_3DataSet4;
        private System.Windows.Forms.BindingSource müsterilerBindingSource;
        private _GA_ARP_3DataSet4TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter;
        private System.Windows.Forms.DataGridView AracGridWiew;

        private System.Windows.Forms.BindingSource aracBindingSource;

        private _GA_ARP_3DataSet8 _GA_ARP_3DataSet8;
        private System.Windows.Forms.BindingSource müsterilerBindingSource1;
        private _GA_ARP_3DataSet8TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter1;
        private _GA_ARP_3DataSet10 _GA_ARP_3DataSet10;
        private System.Windows.Forms.BindingSource müsterilerBindingSource2;
        private _GA_ARP_3DataSet10TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter2;
        private MetroFramework.Controls.MetroGrid MusteriGridWiew;
        private _GA_ARP_3DataSet2 _GA_ARP_3DataSet2;
        private System.Windows.Forms.BindingSource müsterilerBindingSource3;
        private _GA_ARP_3DataSet2TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acılarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gidildimiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}