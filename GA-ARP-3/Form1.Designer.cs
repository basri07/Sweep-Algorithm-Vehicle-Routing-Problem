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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this._GA_ARP_3DataSet4 = new GA_ARP_3._GA_ARP_3DataSet4();
            this.müsterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müsterilerTableAdapter = new GA_ARP_3._GA_ARP_3DataSet4TableAdapters.MüsterilerTableAdapter();
            this.müsterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._GA_ARP_3DataSet8 = new GA_ARP_3._GA_ARP_3DataSet8();
            this.AracGridWiew = new System.Windows.Forms.DataGridView();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müsterilerTableAdapter1 = new GA_ARP_3._GA_ARP_3DataSet8TableAdapters.MüsterilerTableAdapter();
            this.MusteriGridWiew = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsterilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._GA_ARP_3DataSet10 = new GA_ARP_3._GA_ARP_3DataSet10();
            this.müsterilerTableAdapter2 = new GA_ARP_3._GA_ARP_3DataSet10TableAdapters.MüsterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(576, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 459);
            this.listBox1.TabIndex = 0;
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
            this.AracGridWiew.Location = new System.Drawing.Point(3, 33);
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
            // MusteriGridWiew
            // 
            this.MusteriGridWiew.AutoGenerateColumns = false;
            this.MusteriGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriGridWiew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.talepDataGridViewTextBoxColumn,
            this.acılarDataGridViewTextBoxColumn});
            this.MusteriGridWiew.DataSource = this.müsterilerBindingSource2;
            this.MusteriGridWiew.Location = new System.Drawing.Point(3, 45);
            this.MusteriGridWiew.Name = "MusteriGridWiew";
            this.MusteriGridWiew.Size = new System.Drawing.Size(543, 416);
            this.MusteriGridWiew.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 463);
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
            ((System.ComponentModel.ISupportInitialize)(this.MusteriGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GA_ARP_3DataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private _GA_ARP_3DataSet4 _GA_ARP_3DataSet4;
        private System.Windows.Forms.BindingSource müsterilerBindingSource;
        private _GA_ARP_3DataSet4TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter;
        private System.Windows.Forms.DataGridView AracGridWiew;

        private System.Windows.Forms.BindingSource aracBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private _GA_ARP_3DataSet8 _GA_ARP_3DataSet8;
        private System.Windows.Forms.BindingSource müsterilerBindingSource1;
        private _GA_ARP_3DataSet8TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter1;
        private System.Windows.Forms.DataGridView MusteriGridWiew;
        private _GA_ARP_3DataSet10 _GA_ARP_3DataSet10;
        private System.Windows.Forms.BindingSource müsterilerBindingSource2;
        private _GA_ARP_3DataSet10TableAdapters.MüsterilerTableAdapter müsterilerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acılarDataGridViewTextBoxColumn;
    }
}