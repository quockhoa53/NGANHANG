
namespace NGANHANG.View
{
    partial class frmTraCuuKhachHang
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtinCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtinTen = new DevExpress.XtraEditors.TextEdit();
            this.txtinHo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dSTK = new NGANHANG.DSTK();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            this.pnTTKH = new System.Windows.Forms.Panel();
            this.kHACHHANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACNTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHACHHANGTableAdapter = new NGANHANG.DSTKTableAdapters.KHACHHANGTableAdapter();
            this.tAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtinCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            this.pnTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(770, 154);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(49, 17);
            mACNLabel.TabIndex = 18;
            mACNLabel.Text = "MACN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(367, 154);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 16;
            cMNDLabel.Text = "CMND:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(770, 92);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 14;
            tENLabel.Text = "Tên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(367, 92);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 12;
            hOLabel.Text = "Họ:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(mACNLabel);
            this.panel1.Controls.Add(cMNDLabel);
            this.panel1.Controls.Add(this.txtinCMND);
            this.panel1.Controls.Add(tENLabel);
            this.panel1.Controls.Add(this.txtinTen);
            this.panel1.Controls.Add(hOLabel);
            this.panel1.Controls.Add(this.txtinHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 310);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(855, 150);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(191, 24);
            this.cbChiNhanh.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtinCMND
            // 
            this.txtinCMND.Location = new System.Drawing.Point(463, 147);
            this.txtinCMND.Name = "txtinCMND";
            this.txtinCMND.Size = new System.Drawing.Size(195, 22);
            this.txtinCMND.TabIndex = 17;
            this.txtinCMND.EditValueChanged += new System.EventHandler(this.txtinCMND_EditValueChanged);
            // 
            // txtinTen
            // 
            this.txtinTen.Location = new System.Drawing.Point(855, 89);
            this.txtinTen.Name = "txtinTen";
            this.txtinTen.Size = new System.Drawing.Size(191, 22);
            this.txtinTen.TabIndex = 15;
            // 
            // txtinHo
            // 
            this.txtinHo.Location = new System.Drawing.Point(463, 89);
            this.txtinHo.Name = "txtinHo";
            this.txtinHo.Size = new System.Drawing.Size(195, 22);
            this.txtinHo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "TRA CỨU KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dSTK
            // 
            this.dSTK.DataSetName = "DSTK";
            this.dSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnTTKH
            // 
            this.pnTTKH.BackColor = System.Drawing.Color.Transparent;
            this.pnTTKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTTKH.Controls.Add(this.kHACHHANGGridControl);
            this.pnTTKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTTKH.Location = new System.Drawing.Point(0, 310);
            this.pnTTKH.Name = "pnTTKH";
            this.pnTTKH.Size = new System.Drawing.Size(1415, 493);
            this.pnTTKH.TabIndex = 2;
            this.pnTTKH.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTTKH_Paint);
            // 
            // kHACHHANGGridControl
            // 
            this.kHACHHANGGridControl.DataSource = this.bdsKH;
            this.kHACHHANGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.kHACHHANGGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.kHACHHANGGridControl.Location = new System.Drawing.Point(0, 0);
            this.kHACHHANGGridControl.MainView = this.gridView1;
            this.kHACHHANGGridControl.Name = "kHACHHANGGridControl";
            this.kHACHHANGGridControl.Size = new System.Drawing.Size(1411, 489);
            this.kHACHHANGGridControl.TabIndex = 0;
            this.kHACHHANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHACHHANG";
            this.bdsKH.DataSource = this.dSTK;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colSODU,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN,
            this.colMACNTK});
            this.gridView1.GridControl = this.kHACHHANGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "FK_TaiKhoan_KhachHang.SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Số dư";
            this.colCMND.FieldName = "FK_TaiKhoan_KhachHang.SODU";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            this.colTEN.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.FieldName = "FK_TaiKhoan_KhachHang.SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 4;
            this.colSODU.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 6;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 7;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SĐT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 8;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Chi nhánh tạo khách hàng";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 9;
            this.colMACN.Width = 94;
            // 
            // colMACNTK
            // 
            this.colMACNTK.Caption = "Chi nhánh tạo tài khoản";
            this.colMACNTK.FieldName = "FK_TaiKhoan_KhachHang.MACN";
            this.colMACNTK.MinWidth = 25;
            this.colMACNTK.Name = "colMACNTK";
            this.colMACNTK.Visible = true;
            this.colMACNTK.VisibleIndex = 10;
            this.colMACNTK.Width = 94;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // frmTraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 803);
            this.Controls.Add(this.pnTTKH);
            this.Controls.Add(this.panel1);
            this.Name = "frmTraCuuKhachHang";
            this.Text = "frmTraCuuKhachHang";
            this.Load += new System.EventHandler(this.frmTraCuuKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtinCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            this.pnTTKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtinCMND;
        private DevExpress.XtraEditors.TextEdit txtinTen;
        private DevExpress.XtraEditors.TextEdit txtinHo;
        private System.Windows.Forms.Label label1;
        private DSTK dSTK;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Panel pnTTKH;
        public System.Windows.Forms.ComboBox cbChiNhanh;
        private DevExpress.XtraGrid.GridControl kHACHHANGGridControl;
        private System.Windows.Forms.BindingSource bdsKH;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACNTK;
        private DSTKTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
    }
}