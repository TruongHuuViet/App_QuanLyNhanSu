using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }

        PHUCAP _phucap;
        NHANVIEN _nhanvien;
        bool _them;
        int _id;

        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            _them = false;
            _phucap = new PHUCAP();
            _nhanvien = new NHANVIEN();
            _showHide(true);
            loadData();
            loadNhanVien();
            loadPhuCap();
            cboPhuCap.SelectedIndexChanged += CboPhuCap_SelectedIndexChanged;
        }

        private void CboPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pc = _phucap.getItemPC(int.Parse(cboPhuCap.SelectedValue.ToString()));
            if(pc!= null)
            {
                spSoTien.EditValue = pc.SOTIEN;
            }
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtNoiDung.Enabled = !kt;
            spSoTien.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            cboPhuCap.Enabled = !kt;
        }

        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            slkNhanVien.Properties.DisplayMember = "HOTEN";
            slkNhanVien.Properties.ValueMember = "MANV";
        }

        void loadPhuCap()
        {
            cboPhuCap.DataSource = _phucap.getListPC();
            cboPhuCap.DisplayMember = "TENPC";
            cboPhuCap.ValueMember = "IDPC";
        }

        void loadData()
        {
            gcDanhSach.DataSource = _phucap.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            slkNhanVien.EditValue = 0;
            cboPhuCap.SelectedIndex = 0;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _phucap.Delete(_id, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN_PHUCAP pc = new tb_NHANVIEN_PHUCAP();
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                pc.NGAYCAP = DateTime.Now;
                pc.NOIDUNG = txtNoiDung.Text;
                pc.CREATE_BY = 1;
                pc.CREATE_DATE = DateTime.Now;
                _phucap.Add(pc);
            }
            else
            {
                var pc = _phucap.getItem(_id);
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                pc.NGAYCAP = DateTime.Now;
                pc.NOIDUNG = txtNoiDung.Text;
                pc.CREATE_BY = 1;
                pc.CREATE_DATE = DateTime.Now;
                _phucap.Update(pc);
            }
        }

        private void splitContainer2_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
            spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
            slkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
            cboPhuCap.SelectedValue  = gvDanhSach.GetFocusedRowCellValue("IDPC");
        }

       
    }
}