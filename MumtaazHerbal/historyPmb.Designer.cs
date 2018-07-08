﻿namespace MumtaazHerbal
{
    partial class historyPmb
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
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tglSesudah = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tglSebelum = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KodeSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamaSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoTransaksi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.KodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamaItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Satuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HargaBarang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lookSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 20);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImageOptions.Image = global::MumtaazHerbal.Properties.Resources.search11;
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(374, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 20);
            this.btnSearch.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Kata Kunci:";
            // 
            // tglSesudah
            // 
            this.tglSesudah.EditValue = null;
            this.tglSesudah.Location = new System.Drawing.Point(201, 38);
            this.tglSesudah.Name = "tglSesudah";
            this.tglSesudah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSesudah.Size = new System.Drawing.Size(100, 20);
            this.tglSesudah.TabIndex = 46;
            this.tglSesudah.EditValueChanged += new System.EventHandler(this.tglSesudah_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(172, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "S/d :";
            // 
            // tglSebelum
            // 
            this.tglSebelum.EditValue = null;
            this.tglSebelum.Location = new System.Drawing.Point(67, 38);
            this.tglSebelum.Name = "tglSebelum";
            this.tglSebelum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglSebelum.Size = new System.Drawing.Size(100, 20);
            this.tglSebelum.TabIndex = 44;
            this.tglSebelum.EditValueChanged += new System.EventHandler(this.tglSebelum_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Dari Tgl :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "Supplier :";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(16, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(749, 262);
            this.gridControl1.TabIndex = 49;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KodeSupplier,
            this.NamaSupplier,
            this.NoTransaksi,
            this.Tanggal,
            this.KodeItem,
            this.NamaItem,
            this.Satuan,
            this.HargaBarang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // KodeSupplier
            // 
            this.KodeSupplier.Caption = "Kode Supplier";
            this.KodeSupplier.FieldName = "KodeSupplier";
            this.KodeSupplier.Name = "KodeSupplier";
            this.KodeSupplier.Visible = true;
            this.KodeSupplier.VisibleIndex = 0;
            this.KodeSupplier.Width = 94;
            // 
            // NamaSupplier
            // 
            this.NamaSupplier.Caption = "Nama Supplier";
            this.NamaSupplier.FieldName = "NamaSupplier";
            this.NamaSupplier.Name = "NamaSupplier";
            this.NamaSupplier.Visible = true;
            this.NamaSupplier.VisibleIndex = 1;
            this.NamaSupplier.Width = 100;
            // 
            // NoTransaksi
            // 
            this.NoTransaksi.Caption = "No Transaksi";
            this.NoTransaksi.FieldName = "NoTransaksi";
            this.NoTransaksi.Name = "NoTransaksi";
            this.NoTransaksi.Visible = true;
            this.NoTransaksi.VisibleIndex = 2;
            this.NoTransaksi.Width = 94;
            // 
            // Tanggal
            // 
            this.Tanggal.Caption = "Tanggal";
            this.Tanggal.ColumnEdit = this.repositoryItemDateEdit1;
            this.Tanggal.FieldName = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Visible = true;
            this.Tanggal.VisibleIndex = 3;
            this.Tanggal.Width = 91;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "G";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // KodeItem
            // 
            this.KodeItem.Caption = "Kode Item";
            this.KodeItem.FieldName = "KodeItem";
            this.KodeItem.Name = "KodeItem";
            this.KodeItem.Visible = true;
            this.KodeItem.VisibleIndex = 4;
            this.KodeItem.Width = 78;
            // 
            // NamaItem
            // 
            this.NamaItem.Caption = "Nama Item";
            this.NamaItem.FieldName = "NamaItem";
            this.NamaItem.Name = "NamaItem";
            this.NamaItem.Visible = true;
            this.NamaItem.VisibleIndex = 5;
            this.NamaItem.Width = 229;
            // 
            // Satuan
            // 
            this.Satuan.Caption = "Satuan";
            this.Satuan.FieldName = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.Visible = true;
            this.Satuan.VisibleIndex = 6;
            this.Satuan.Width = 51;
            // 
            // HargaBarang
            // 
            this.HargaBarang.Caption = "Harga";
            this.HargaBarang.ColumnEdit = this.repositoryItemTextEdit1;
            this.HargaBarang.FieldName = "HargaBarang";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.Visible = true;
            this.HargaBarang.VisibleIndex = 7;
            this.HargaBarang.Width = 74;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // lookSupplier
            // 
            this.lookSupplier.Location = new System.Drawing.Point(67, 64);
            this.lookSupplier.Name = "lookSupplier";
            this.lookSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodeSupplier", "Kode Supplier", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaSupplier", "Nama Supplier", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookSupplier.Properties.DataSource = this.supplierBindingSource;
            this.lookSupplier.Properties.DisplayMember = "NamaSupplier";
            this.lookSupplier.Properties.NullText = "";
            this.lookSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookSupplier.Properties.ValueMember = "Id";
            this.lookSupplier.Size = new System.Drawing.Size(100, 20);
            this.lookSupplier.TabIndex = 50;
            this.lookSupplier.EditValueChanged += new System.EventHandler(this.lookSupplier_EditValueChanged);
            this.lookSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookSupplier_KeyDown);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(MumtaazHerbal.Supplier);
            // 
            // historyPmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 364);
            this.Controls.Add(this.lookSupplier);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tglSesudah);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tglSebelum);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelControl1);
            this.Name = "historyPmb";
            this.Text = " History Pembelian";
            this.Load += new System.EventHandler(this.historyPmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSesudah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglSebelum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit tglSesudah;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit tglSebelum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KodeSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn NoTransaksi;
        private DevExpress.XtraGrid.Columns.GridColumn Tanggal;
        private DevExpress.XtraGrid.Columns.GridColumn KodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn NamaItem;
        private DevExpress.XtraGrid.Columns.GridColumn Satuan;
        private DevExpress.XtraGrid.Columns.GridColumn HargaBarang;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.LookUpEdit lookSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn NamaSupplier;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}