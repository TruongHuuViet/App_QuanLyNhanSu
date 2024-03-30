namespace QLNHANSU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiDB = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 36, 35, 36);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnKhenThuong,
            this.btnThoiViec,
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnPhuCap,
            this.btnBangCong,
            this.btnBangLuong,
            this.btnDoiMatKhau,
            this.btnBackup,
            this.btnPhucHoiDB,
            this.btnThoat,
            this.btnChucVu,
            this.btnKyLuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1206, 193);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanToc.ImageOptions.SvgImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrinhDo.ImageOptions.SvgImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen thưởng";
            this.btnKhenThuong.Id = 7;
            this.btnKhenThuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenThuong.ImageOptions.SvgImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi việc";
            this.btnThoiViec.Id = 9;
            this.btnThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoiViec.ImageOptions.SvgImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoiViec_ItemClick);
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Caption = "Loại ca";
            this.btnLoaiCa.Id = 10;
            this.btnLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCa.ImageOptions.SvgImage")));
            this.btnLoaiCa.Name = "btnLoaiCa";
            this.btnLoaiCa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCa_ItemClick);
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại công";
            this.btnLoaiCong.Id = 11;
            this.btnLoaiCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCong.ImageOptions.SvgImage")));
            this.btnLoaiCong.Name = "btnLoaiCong";
            this.btnLoaiCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCong_ItemClick);
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Caption = "Phụ cấp";
            this.btnPhuCap.Id = 12;
            this.btnPhuCap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuCap.ImageOptions.SvgImage")));
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhuCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuCap_ItemClick);
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng công";
            this.btnBangCong.Id = 15;
            this.btnBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangCong.ImageOptions.SvgImage")));
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBangCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangCong_ItemClick);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng lương";
            this.btnBangLuong.Id = 16;
            this.btnBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangLuong.ImageOptions.SvgImage")));
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBangLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangLuong_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 17;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 18;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnPhucHoiDB
            // 
            this.btnPhucHoiDB.Caption = "Phục hồi dữ liệu";
            this.btnPhucHoiDB.Id = 19;
            this.btnPhucHoiDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiDB.ImageOptions.SvgImage")));
            this.btnPhucHoiDB.Name = "btnPhucHoiDB";
            this.btnPhucHoiDB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhucHoiDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiDB_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 21;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ Luật";
            this.btnKyLuat.Id = 22;
            this.btnKyLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKyLuat.ImageOptions.SvgImage")));
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKyLuat_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh sách dùng chung";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKhenThuong);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKyLuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnThoiViec);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nghiệp vụ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm công";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLoaiCa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLoaiCong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPhuCap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangCong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangLuong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý chấm công";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 671);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhuCap;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiDB;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnKyLuat;
    }
}

