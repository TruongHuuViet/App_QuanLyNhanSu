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
    public partial class frmKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KYLUAT _ktkl;
        NHANVIEN _nhanvien;

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new KYLUAT();
            _nhanvien = new NHANVIEN();
            _them = false;
            _showHide(true);
            loadData();
            loadNHanVien();
            splitContainer1.Panel1Collapsed = true;
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
            txtSoQD.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
        }

        private void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            txtLyDo.Text = string.Empty;

        }

        void loadNHanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }

        void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soQD, 3);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void SaveData()
        {
            if (_them)
            {
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KYLUAT kt = new tb_KYLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2023/QDKL";
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.NOIDUNG = txtNoiDung.Text;
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.LOAI = 1;
                kt.CREATE_BY = 1;
                kt.CREATE_DATE = DateTime.Now;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                 kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.NOIDUNG = txtNoiDung.Text;
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.UPDATED_BY = 1;
                kt.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(kt);
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                txtLyDo.Text = kt.LYDO;
                txtNoiDung.Text = kt.NOIDUNG;
                slkNhanVien.EditValue = kt.MANV;
                dtNgay.Value = kt.NGAY.Value;

            }
        }
    }
}