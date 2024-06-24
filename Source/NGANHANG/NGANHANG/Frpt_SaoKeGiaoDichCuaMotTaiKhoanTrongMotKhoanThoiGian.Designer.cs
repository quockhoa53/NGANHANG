
namespace NGANHANG
{
    partial class Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian
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
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXembaocao = new System.Windows.Forms.Button();
            this.DEdenngay = new DevExpress.XtraEditors.DateEdit();
            this.DEtungay = new DevExpress.XtraEditors.DateEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.dSTK = new NGANHANG.DSTK();
            this.label1 = new System.Windows.Forms.Label();
            this.tAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            sOTKLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(687, 195);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(87, 17);
            sOTKLabel.TabIndex = 1;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Cursor = System.Windows.Forms.Cursors.No;
            nGAYMOTKLabel.Location = new System.Drawing.Point(687, 270);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(60, 17);
            nGAYMOTKLabel.TabIndex = 10;
            nGAYMOTKLabel.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.No;
            label3.Location = new System.Drawing.Point(687, 350);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 17);
            label3.TabIndex = 12;
            label3.Text = "Đến ngày";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXembaocao);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.DEdenngay);
            this.panel1.Controls.Add(nGAYMOTKLabel);
            this.panel1.Controls.Add(this.DEtungay);
            this.panel1.Controls.Add(sOTKLabel);
            this.panel1.Controls.Add(this.txtSTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 744);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1025, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(808, 413);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(256, 24);
            this.cbChiNhanh.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chi nhánh";
            // 
            // btnXembaocao
            // 
            this.btnXembaocao.Location = new System.Drawing.Point(761, 490);
            this.btnXembaocao.Name = "btnXembaocao";
            this.btnXembaocao.Size = new System.Drawing.Size(152, 38);
            this.btnXembaocao.TabIndex = 14;
            this.btnXembaocao.Text = "Xuất báo cáo";
            this.btnXembaocao.UseVisualStyleBackColor = true;
            this.btnXembaocao.Click += new System.EventHandler(this.button1_Click);
            // 
            // DEdenngay
            // 
            this.DEdenngay.EditValue = null;
            this.DEdenngay.Location = new System.Drawing.Point(808, 345);
            this.DEdenngay.Name = "DEdenngay";
            this.DEdenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEdenngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEdenngay.Size = new System.Drawing.Size(128, 22);
            this.DEdenngay.TabIndex = 13;
            // 
            // DEtungay
            // 
            this.DEtungay.EditValue = null;
            this.DEtungay.Location = new System.Drawing.Point(808, 265);
            this.DEtungay.Name = "DEtungay";
            this.DEtungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEtungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEtungay.Size = new System.Drawing.Size(128, 22);
            this.DEtungay.TabIndex = 11;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txtSTK.Location = new System.Drawing.Point(811, 201);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(125, 22);
            this.txtSTK.TabIndex = 2;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TAIKHOAN";
            this.bdsTK.DataSource = this.dSTK;
            // 
            // dSTK
            // 
            this.dSTK.DataSetName = "DSTK";
            this.dSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAO KÊ GIAO DỊCH CỦA MỘT TÀI KHOẢN TRONG MỘT KHOẢNG THỜI GIAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 744);
            this.Controls.Add(this.panel1);
            this.Name = "Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian";
            this.Text = "Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian";
            this.Load += new System.EventHandler(this.Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DSTK dSTK;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        public DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraEditors.DateEdit DEdenngay;
        private System.Windows.Forms.Button btnXembaocao;
        private DevExpress.XtraEditors.DateEdit DEtungay;
        public System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}