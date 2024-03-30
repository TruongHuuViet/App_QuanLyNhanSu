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
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCong()
        {
            InitializeComponent();
        }

        LOAICONG _loaicong;
        bool _them;
        int _id;

        private void frmLoaiCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaicong = new LOAICONG();
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
            txtLoaiCong.Enabled = !kt;
            spHeSo.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _loaicong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtLoaiCong.Text = string.Empty;
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
                _loaicong.Delete(_id,1);
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
                tb_LOAICONG lc = new tb_LOAICONG();
                lc.TENLC =txtLoaiCong.Text;
                lc.HESO = double.Parse(spHeSo.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaicong.Add(lc);
            }
            else
            {
                var lc = _loaicong.getItem(_id);
                lc.TENLC = txtLoaiCong.Text;
                lc.HESO = double.Parse(spHeSo.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaicong.Update(lc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLC").ToString());
            txtLoaiCong.Text = gvDanhSach.GetFocusedRowCellValue("TENLC").ToString();
            spHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HESO").ToString();
        }
    }
    
}