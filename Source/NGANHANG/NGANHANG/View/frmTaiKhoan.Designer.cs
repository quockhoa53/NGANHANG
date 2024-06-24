﻿
namespace NGANHANG.View
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.maNV_login = new DevExpress.XtraBars.BarButtonItem();
            this.hoTen_login = new DevExpress.XtraBars.BarButtonItem();
            this.nhom_login = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem4 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem5 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem6 = new DevExpress.XtraBars.BarHeaderItem();
            this.pn1 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSTK = new NGANHANG.DSTK();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            this.pn2 = new System.Windows.Forms.Panel();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn3 = new System.Windows.Forms.Panel();
            this.lbTTTK = new System.Windows.Forms.Label();
            this.DENgayMTK = new DevExpress.XtraEditors.DateEdit();
            this.txtCN = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.pn4 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnXacNhanChuyen = new System.Windows.Forms.Button();
            this.btnXacNhanRut = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSoTienRut = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienGui = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienChuyen = new DevExpress.XtraEditors.TextEdit();
            this.lbSoTienChuyen = new System.Windows.Forms.Label();
            this.lbSTKNhan = new System.Windows.Forms.Label();
            this.lbChuyenTien = new System.Windows.Forms.Label();
            this.lbGuiTien = new System.Windows.Forms.Label();
            this.lbSoTienRut = new System.Windows.Forms.Label();
            this.lbRutTien = new System.Windows.Forms.Label();
            this.btnXacNhanGui = new System.Windows.Forms.Button();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.txtSTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new NGANHANG.DSTKTableAdapters.KHACHHANGTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DENgayMTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgayMTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            this.pn4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienRut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienGui.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(163, 73);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(89, 17);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(163, 127);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(163, 182);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(50, 17);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "Số dư:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(163, 253);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(75, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Chi nhánh:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Cursor = System.Windows.Forms.Cursors.No;
            nGAYMOTKLabel.Location = new System.Drawing.Point(163, 309);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(129, 17);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "Ngày mở tài khoản:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barStaticItem1,
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhuchoi,
            this.btnThoat,
            this.barStaticItem2,
            this.barHeaderItem1,
            this.barButtonItem2,
            this.barHeaderItem2,
            this.btnSua,
            this.barButtonItem3,
            this.maNV_login,
            this.hoTen_login,
            this.nhom_login,
            this.barHeaderItem3,
            this.barHeaderItem4,
            this.barHeaderItem5,
            this.barHeaderItem6});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 21;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Mở tài khoản";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.barHeaderItem1.Appearance.Options.UseFont = true;
            this.barHeaderItem1.Id = 8;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHeaderItem1_ItemClick);
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barHeaderItem2.Appearance.Options.UseFont = true;
            this.barHeaderItem2.Caption = "TÀI KHOẢN VÀ GIAO DỊCH";
            this.barHeaderItem2.Id = 10;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.maNV_login),
            new DevExpress.XtraBars.LinkPersistInfo(this.hoTen_login),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.nhom_login, "", false, false, true, 0)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // maNV_login
            // 
            this.maNV_login.Caption = "barButtonItem4";
            this.maNV_login.Id = 13;
            this.maNV_login.Name = "maNV_login";
            // 
            // hoTen_login
            // 
            this.hoTen_login.Caption = "barButtonItem4";
            this.hoTen_login.Id = 14;
            this.hoTen_login.Name = "hoTen_login";
            // 
            // nhom_login
            // 
            this.nhom_login.Caption = "barButtonItem4";
            this.nhom_login.Id = 15;
            this.nhom_login.Name = "nhom_login";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1882, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 756);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1882, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 701);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1882, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 701);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "QUẢN LÝ TÀI KHOẢN";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Id = 5;
            this.btnPhuchoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.ImageOptions.Image")));
            this.btnPhuchoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.ImageOptions.LargeImage")));
            this.btnPhuchoi.Name = "btnPhuchoi";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "TÀI KHOẢN, GIAO DỊCH";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSua
            // 
            this.btnSua.Id = 20;
            this.btnSua.Name = "btnSua";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "MANV:";
            this.barHeaderItem3.Id = 16;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // barHeaderItem4
            // 
            this.barHeaderItem4.Caption = "Họ và tên:";
            this.barHeaderItem4.Id = 17;
            this.barHeaderItem4.Name = "barHeaderItem4";
            // 
            // barHeaderItem5
            // 
            this.barHeaderItem5.Id = 18;
            this.barHeaderItem5.Name = "barHeaderItem5";
            // 
            // barHeaderItem6
            // 
            this.barHeaderItem6.Caption = "Nhóm:";
            this.barHeaderItem6.Id = 19;
            this.barHeaderItem6.Name = "barHeaderItem6";
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.cbChiNhanh);
            this.pn1.Controls.Add(this.label1);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 55);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1882, 75);
            this.pn1.TabIndex = 4;
            this.pn1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(128, 16);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(290, 24);
            this.cbChiNhanh.TabIndex = 5;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dSTK
            // 
            this.dSTK.DataSetName = "DSTK";
            this.dSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TAIKHOAN";
            this.bdsTK.DataSource = this.dSTK;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.gcTK);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn2.Location = new System.Drawing.Point(0, 130);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(1882, 227);
            this.pn2.TabIndex = 9;
            // 
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTK.Location = new System.Drawing.Point(0, 0);
            this.gcTK.MainView = this.gridView1;
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(1882, 227);
            this.gcTK.TabIndex = 0;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcTK.Click += new System.EventHandler(this.gcTK_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTK;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // pn3
            // 
            this.pn3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn3.Controls.Add(this.lbTTTK);
            this.pn3.Controls.Add(nGAYMOTKLabel);
            this.pn3.Controls.Add(this.DENgayMTK);
            this.pn3.Controls.Add(mACNLabel);
            this.pn3.Controls.Add(this.txtCN);
            this.pn3.Controls.Add(sODULabel);
            this.pn3.Controls.Add(this.txtSoDu);
            this.pn3.Controls.Add(cMNDLabel);
            this.pn3.Controls.Add(this.txtCMND);
            this.pn3.Controls.Add(sOTKLabel);
            this.pn3.Controls.Add(this.txtSTK);
            this.pn3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn3.Location = new System.Drawing.Point(0, 357);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(982, 399);
            this.pn3.TabIndex = 10;
            this.pn3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbTTTK
            // 
            this.lbTTTK.AutoSize = true;
            this.lbTTTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTTK.Location = new System.Drawing.Point(256, 15);
            this.lbTTTK.Name = "lbTTTK";
            this.lbTTTK.Size = new System.Drawing.Size(240, 23);
            this.lbTTTK.TabIndex = 15;
            this.lbTTTK.Text = "THÔNG TIN TÀI KHOẢN";
            this.lbTTTK.Click += new System.EventHandler(this.label2_Click);
            // 
            // DENgayMTK
            // 
            this.DENgayMTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.DENgayMTK.EditValue = null;
            this.DENgayMTK.Enabled = false;
            this.DENgayMTK.Location = new System.Drawing.Point(324, 304);
            this.DENgayMTK.MenuManager = this.barManager1;
            this.DENgayMTK.Name = "DENgayMTK";
            this.DENgayMTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DENgayMTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DENgayMTK.Size = new System.Drawing.Size(184, 22);
            this.DENgayMTK.TabIndex = 9;
            // 
            // txtCN
            // 
            this.txtCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txtCN.Enabled = false;
            this.txtCN.Location = new System.Drawing.Point(324, 248);
            this.txtCN.MenuManager = this.barManager1;
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(184, 22);
            this.txtCN.TabIndex = 7;
            this.txtCN.EditValueChanged += new System.EventHandler(this.mACNTextEdit_EditValueChanged);
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txtSoDu.Enabled = false;
            this.txtSoDu.Location = new System.Drawing.Point(324, 179);
            this.txtSoDu.MenuManager = this.barManager1;
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(185, 22);
            this.txtSoDu.TabIndex = 5;
            this.txtSoDu.EditValueChanged += new System.EventHandler(this.txtSoDu_EditValueChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(324, 122);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(185, 22);
            this.txtCMND.TabIndex = 3;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txtSTK.Enabled = false;
            this.txtSTK.Location = new System.Drawing.Point(324, 68);
            this.txtSTK.MenuManager = this.barManager1;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(185, 22);
            this.txtSTK.TabIndex = 1;
            this.txtSTK.EditValueChanged += new System.EventHandler(this.sOTKTextEdit_EditValueChanged);
            // 
            // pn4
            // 
            this.pn4.AutoSize = true;
            this.pn4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn4.Controls.Add(this.btnCheck);
            this.pn4.Controls.Add(this.btnXacNhanChuyen);
            this.pn4.Controls.Add(this.btnXacNhanRut);
            this.pn4.Controls.Add(this.btnHuy);
            this.pn4.Controls.Add(this.txtSoTienRut);
            this.pn4.Controls.Add(this.txtSoTienGui);
            this.pn4.Controls.Add(this.txtSoTienChuyen);
            this.pn4.Controls.Add(this.lbSoTienChuyen);
            this.pn4.Controls.Add(this.lbSTKNhan);
            this.pn4.Controls.Add(this.lbChuyenTien);
            this.pn4.Controls.Add(this.lbGuiTien);
            this.pn4.Controls.Add(this.lbSoTienRut);
            this.pn4.Controls.Add(this.lbRutTien);
            this.pn4.Controls.Add(this.btnXacNhanGui);
            this.pn4.Controls.Add(this.lbSoTienGui);
            this.pn4.Controls.Add(this.txtSTKNhan);
            this.pn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn4.Location = new System.Drawing.Point(982, 357);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(900, 399);
            this.pn4.TabIndex = 15;
            this.pn4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGiaoDich_Paint);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(635, 84);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 33);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // btnXacNhanChuyen
            // 
            this.btnXacNhanChuyen.Location = new System.Drawing.Point(334, 194);
            this.btnXacNhanChuyen.Name = "btnXacNhanChuyen";
            this.btnXacNhanChuyen.Size = new System.Drawing.Size(95, 31);
            this.btnXacNhanChuyen.TabIndex = 20;
            this.btnXacNhanChuyen.Text = "Xác nhận";
            this.btnXacNhanChuyen.UseVisualStyleBackColor = true;
            this.btnXacNhanChuyen.Visible = false;
            this.btnXacNhanChuyen.Click += new System.EventHandler(this.btnXacNhanChuyen_Click);
            // 
            // btnXacNhanRut
            // 
            this.btnXacNhanRut.Location = new System.Drawing.Point(334, 194);
            this.btnXacNhanRut.Name = "btnXacNhanRut";
            this.btnXacNhanRut.Size = new System.Drawing.Size(95, 31);
            this.btnXacNhanRut.TabIndex = 16;
            this.btnXacNhanRut.Text = "Xác nhận";
            this.btnXacNhanRut.UseVisualStyleBackColor = true;
            this.btnXacNhanRut.Visible = false;
            this.btnXacNhanRut.Click += new System.EventHandler(this.btnXacNhanRut_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(481, 194);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 31);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSoTienRut
            // 
            this.txtSoTienRut.Location = new System.Drawing.Point(386, 91);
            this.txtSoTienRut.MenuManager = this.barManager1;
            this.txtSoTienRut.Name = "txtSoTienRut";
            this.txtSoTienRut.Size = new System.Drawing.Size(178, 22);
            this.txtSoTienRut.TabIndex = 14;
            this.txtSoTienRut.Visible = false;
            this.txtSoTienRut.EditValueChanged += new System.EventHandler(this.txtSoTienRut_EditValueChanged);
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(386, 89);
            this.txtSoTienGui.MenuManager = this.barManager1;
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(178, 22);
            this.txtSoTienGui.TabIndex = 13;
            this.txtSoTienGui.Visible = false;
            this.txtSoTienGui.EditValueChanged += new System.EventHandler(this.txtSoTienGui_EditValueChanged);
            // 
            // txtSoTienChuyen
            // 
            this.txtSoTienChuyen.Location = new System.Drawing.Point(386, 140);
            this.txtSoTienChuyen.MenuManager = this.barManager1;
            this.txtSoTienChuyen.Name = "txtSoTienChuyen";
            this.txtSoTienChuyen.Size = new System.Drawing.Size(178, 22);
            this.txtSoTienChuyen.TabIndex = 12;
            this.txtSoTienChuyen.Visible = false;
            this.txtSoTienChuyen.EditValueChanged += new System.EventHandler(this.txtSoTienChuyen_EditValueChanged);
            // 
            // lbSoTienChuyen
            // 
            this.lbSoTienChuyen.AutoSize = true;
            this.lbSoTienChuyen.Location = new System.Drawing.Point(225, 143);
            this.lbSoTienChuyen.Name = "lbSoTienChuyen";
            this.lbSoTienChuyen.Size = new System.Drawing.Size(105, 17);
            this.lbSoTienChuyen.TabIndex = 11;
            this.lbSoTienChuyen.Text = "Số tiền chuyển:";
            this.lbSoTienChuyen.Visible = false;
            // 
            // lbSTKNhan
            // 
            this.lbSTKNhan.AutoSize = true;
            this.lbSTKNhan.Location = new System.Drawing.Point(225, 94);
            this.lbSTKNhan.Name = "lbSTKNhan";
            this.lbSTKNhan.Size = new System.Drawing.Size(124, 17);
            this.lbSTKNhan.TabIndex = 10;
            this.lbSTKNhan.Text = "Số tài khoản nhận:";
            this.lbSTKNhan.Visible = false;
            // 
            // lbChuyenTien
            // 
            this.lbChuyenTien.AutoSize = true;
            this.lbChuyenTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenTien.Location = new System.Drawing.Point(350, 26);
            this.lbChuyenTien.Name = "lbChuyenTien";
            this.lbChuyenTien.Size = new System.Drawing.Size(258, 23);
            this.lbChuyenTien.TabIndex = 9;
            this.lbChuyenTien.Text = "GIAO DỊCH CHUYỂN TIỀN";
            this.lbChuyenTien.Visible = false;
            this.lbChuyenTien.Click += new System.EventHandler(this.lbChuyenTien_Click);
            // 
            // lbGuiTien
            // 
            this.lbGuiTien.AutoSize = true;
            this.lbGuiTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuiTien.Location = new System.Drawing.Point(350, 26);
            this.lbGuiTien.Name = "lbGuiTien";
            this.lbGuiTien.Size = new System.Drawing.Size(214, 23);
            this.lbGuiTien.TabIndex = 8;
            this.lbGuiTien.Text = "GIAO DỊCH GỬI TIỀN";
            this.lbGuiTien.Visible = false;
            // 
            // lbSoTienRut
            // 
            this.lbSoTienRut.AutoSize = true;
            this.lbSoTienRut.Location = new System.Drawing.Point(272, 94);
            this.lbSoTienRut.Name = "lbSoTienRut";
            this.lbSoTienRut.Size = new System.Drawing.Size(77, 17);
            this.lbSoTienRut.TabIndex = 7;
            this.lbSoTienRut.Text = "Số tiền rút:";
            this.lbSoTienRut.Visible = false;
            // 
            // lbRutTien
            // 
            this.lbRutTien.AutoSize = true;
            this.lbRutTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutTien.Location = new System.Drawing.Point(348, 26);
            this.lbRutTien.Name = "lbRutTien";
            this.lbRutTien.Size = new System.Drawing.Size(216, 23);
            this.lbRutTien.TabIndex = 6;
            this.lbRutTien.Text = "GIAO DỊCH RÚT TIỀN";
            this.lbRutTien.Visible = false;
            // 
            // btnXacNhanGui
            // 
            this.btnXacNhanGui.Location = new System.Drawing.Point(334, 194);
            this.btnXacNhanGui.Name = "btnXacNhanGui";
            this.btnXacNhanGui.Size = new System.Drawing.Size(95, 31);
            this.btnXacNhanGui.TabIndex = 5;
            this.btnXacNhanGui.Text = "Xác nhận";
            this.btnXacNhanGui.UseVisualStyleBackColor = true;
            this.btnXacNhanGui.Visible = false;
            this.btnXacNhanGui.Click += new System.EventHandler(this.btnXacNhanGui_Click);
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Location = new System.Drawing.Point(272, 94);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(77, 17);
            this.lbSoTienGui.TabIndex = 2;
            this.lbSoTienGui.Text = "Số tiền gủi:";
            this.lbSoTienGui.Visible = false;
            this.lbSoTienGui.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSTKNhan
            // 
            this.txtSTKNhan.Location = new System.Drawing.Point(386, 91);
            this.txtSTKNhan.MenuManager = this.barManager1;
            this.txtSTKNhan.Name = "txtSTKNhan";
            this.txtSTKNhan.Size = new System.Drawing.Size(178, 22);
            this.txtSTKNhan.TabIndex = 1;
            this.txtSTKNhan.Visible = false;
            this.txtSTKNhan.EditValueChanged += new System.EventHandler(this.txtSTKNhan_EditValueChanged);
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dSTK;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 783);
            this.Controls.Add(this.pn4);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DENgayMTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgayMTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            this.pn4.ResumeLayout(false);
            this.pn4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienRut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienGui.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        public DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTK dSTK;
        private DSTKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Panel pn3;
        private DevExpress.XtraEditors.TextEdit txtCN;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        public System.Windows.Forms.Panel pn2;
        public DevExpress.XtraGrid.GridControl gcTK;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.DateEdit DENgayMTK;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        public System.Windows.Forms.Label lbTTTK;
        public System.Windows.Forms.Panel pn4;
        public System.Windows.Forms.Label lbSoTienGui;
        public DevExpress.XtraEditors.TextEdit txtSTKNhan;
        public System.Windows.Forms.Button btnXacNhanGui;
        public System.Windows.Forms.Label lbSoTienRut;
        public System.Windows.Forms.Label lbRutTien;
        public System.Windows.Forms.Label lbGuiTien;
        public DevExpress.XtraEditors.TextEdit txtSoTienChuyen;
        public System.Windows.Forms.Label lbSoTienChuyen;
        public System.Windows.Forms.Label lbSTKNhan;
        public System.Windows.Forms.Label lbChuyenTien;
        public DevExpress.XtraEditors.TextEdit txtSoTienRut;
        public DevExpress.XtraEditors.TextEdit txtSoTienGui;
        public System.Windows.Forms.Button btnXacNhanChuyen;
        public System.Windows.Forms.Button btnXacNhanRut;
        public System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem maNV_login;
        private DevExpress.XtraBars.BarButtonItem hoTen_login;
        private DevExpress.XtraBars.BarButtonItem nhom_login;
        public System.Windows.Forms.Button btnCheck;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem4;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem6;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem5;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DSTKTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
    }
}