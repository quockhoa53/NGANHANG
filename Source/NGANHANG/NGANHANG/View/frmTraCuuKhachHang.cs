using DevExpress.XtraEditors;
using NGANHANG.DSTKTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.View
{
    public partial class frmTraCuuKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmTraCuuKhachHang()
        {
            InitializeComponent();
        }
        partial class THONGTINKHTableAdapter
        {
            private KHACHHANGTableAdapter khachHangTableAdapter = new KHACHHANGTableAdapter();
            private TAIKHOANTableAdapter taiKhoanTableAdapter = new TAIKHOANTableAdapter();

            public KHACHHANGTableAdapter KHACHHANGTableAdapter
            {
                get { return khachHangTableAdapter; }
                set { khachHangTableAdapter = value; }
            }

            public TAIKHOANTableAdapter TAIKHOANTableAdapter
            {
                get { return taiKhoanTableAdapter; }
                set { taiKhoanTableAdapter = value; }
            }
        }
        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTK);

        }

        private void frmTraCuuKhachHang_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào ComboBox cbChiNhanh
            ComboBoxHelper.ImportDataDic(cbChiNhanh);

            // Thiết lập mục được chọn mặc định cho cbChiNhanh
            cbChiNhanh.SelectedItem = ComboBoxHelper.tenCN_Help;

            // Vô hiệu hóa các ràng buộc của DataSet dSTK (nếu cần thiết)
            dSTK.EnforceConstraints = false;

            // Khởi tạo THONGTINKHTableAdapter
            THONGTINKHTableAdapter thongTinKHAdapter = new THONGTINKHTableAdapter();

            // Lấy dữ liệu từ KHACHHANGTableAdapter và TAIKHOANTableAdapter
            DataTable dtKhachHang = thongTinKHAdapter.KHACHHANGTableAdapter.GetData();
            DataTable dtTaiKhoan = thongTinKHAdapter.TAIKHOANTableAdapter.GetData();

            // Tạo DataTable mới để chứa dữ liệu từ cả dtKhachHang và dtTaiKhoan
            DataTable dtCombined = new DataTable();

            // Tạo các cột cho dtCombined dựa trên dtKhachHang
            foreach (DataColumn col in dtKhachHang.Columns)
            {
                dtCombined.Columns.Add(col.ColumnName, col.DataType);
            }

            // Sao chép dữ liệu từ dtKhachHang vào dtCombined
            foreach (DataRow row in dtKhachHang.Rows)
            {
                dtCombined.ImportRow(row);
            }

            // Sao chép dữ liệu từ dtTaiKhoan vào dtCombined
            foreach (DataRow row in dtTaiKhoan.Rows)
            {
                dtCombined.ImportRow(row);
            }
            // Đổ dữ liệu vào dataGridViewCombined
            gridView1.DataSource = dtCombined;
        }



        private void sOTKTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*pnTTKH.Visible = true;*/
            if (string.IsNullOrEmpty(txtinCMND.Text))
            {
                MessageBox.Show("CMND không được để trống!");
                return;
            }

        }

        private void txtinCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void kHACHHANGGridControl_Click(object sender, EventArgs e)
        {

        }

        private void pnTTKH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kHACHHANGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTK);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}