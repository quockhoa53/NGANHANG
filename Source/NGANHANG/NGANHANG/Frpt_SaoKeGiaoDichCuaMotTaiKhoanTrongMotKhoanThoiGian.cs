﻿using DevExpress.XtraReports.UI;
using NGANHANG.View;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian : Form
    {
        public Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian()
        {
            InitializeComponent();
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTK);

        }

        private void Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.ImportDataDic(cbChiNhanh);
            cbChiNhanh.SelectedItem = ComboBoxHelper.tenCN_Help;
            checkExist.checkReportSaoKe = true;
            dSTK.EnforceConstraints = false;
            this.tAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tAIKHOANTableAdapter.Fill(this.dSTK.TAIKHOAN);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stk = txtSTK.Text;
            string tungay = DEtungay.Text;
            string denngay = DEdenngay.Text;
            string macn = "";
            if (Program.ExecSqlKiemTra1("SP_KIEMTRASTK", txtSTK.Text) == 0)
            {
                MessageBox.Show("Số tài khoản không tồn tại!");
                txtSTK.Text = "";
                txtSTK.Focus();
                return;
            }

            string cmd = "SELECT MACN FROM TAIKHOAN WHERE SOTK = @SOTK";
            Program.KetNoi();
            using (SqlCommand command = new SqlCommand(cmd, Program.conn))
            {
                command.Parameters.AddWithValue("@SOTK", stk);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        macn = (reader.GetString(0).Trim() == "BENTHANH" ? "Bến Thành" : "Tân Định");
                        Console.WriteLine(macn);
                    }
                }
            }
            DateTime dateTungay;
            DateTime dateDenngay;
            if (DateTime.TryParse(tungay, out dateTungay) && DateTime.TryParse(denngay, out dateDenngay))
            {
                if (dateTungay > dateDenngay)
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                    DEdenngay.Text = "";
                    DEdenngay.Focus();
                    return;
                }
                else
                {
                    Xrpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian rpt = new Xrpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian(stk, tungay, denngay, macn);
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTraCuuKhachHang f = new frmTraCuuKhachHang();
            f.Show();
        }
    }
}
