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
    public partial class frmLOAICA : DevExpress.XtraEditors.XtraForm
    {
        public frmLOAICA()
        {
            InitializeComponent();
        }

        LOAICA _loaica;
        bool _them;
        int _id;

        private void frmLOAICA_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaica = new LOAICA();
            _showHide(true);
            loadData();
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
            txtLoaiCa.Enabled = !kt;
            spHeSo.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _loaica.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtLoaiCa.Text = string.Empty;
            spHeSo.EditValue = 1;
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
                _loaica.Delete(_id, 1);
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
                tb_LOAICA lc = new tb_LOAICA();
                lc.TENLOAICA = txtLoaiCa.Text;
                lc.HESO = double.Parse(spHeSo.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Add(lc);
            }
            else
            {
                var lc = _loaica.getItem(_id);
                lc.TENLOAICA = txtLoaiCa.Text;
                lc.HESO = double.Parse(spHeSo.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Update(lc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAICA").ToString());
            txtLoaiCa.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAICA").ToString();
            spHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HESO").ToString();
        }
    } 
}