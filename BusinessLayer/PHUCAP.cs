﻿using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BusinessLayer
{
    public class PHUCAP
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_PHUCAP getItem(int id)
        {
            return db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
        }

        public tb_PHUCAP getItemPC(int id)
        {
            return db.tb_PHUCAP.FirstOrDefault(x => x.IDPC == id);
        }
        public List<NHANVIEN_PHUCAP_DTO> getListFull()
        {
            var lstNVPC = db.tb_NHANVIEN_PHUCAP.ToList();
            List<NHANVIEN_PHUCAP_DTO> lstDTO = new List<NHANVIEN_PHUCAP_DTO>();
            NHANVIEN_PHUCAP_DTO nvpc;
            NHANVIEN _nhanvien = new NHANVIEN();
            foreach (var item in lstNVPC)
            {
                nvpc = new NHANVIEN_PHUCAP_DTO();
                nvpc.ID = item.ID;
                var nv = _nhanvien.getItemFull(int.Parse(item.MANV.ToString()));
                nvpc.HOTEN = nv.HOTEN;
                nvpc.TENCV = nv.TENCV;
                nvpc.IDPC = item.IDPC;
                var pc = db.tb_PHUCAP.FirstOrDefault(x => x.IDPC == item.IDPC);
                nvpc.TENPC = pc.TENPC;
                nvpc.SOTIEN = item.SOTIEN;
                nvpc.NOIDUNG = item.NOIDUNG;
                nvpc.IDPC = item.IDPC;
                nvpc.CREATE_DATE = item.CREATE_DATE;
                nvpc.CREATE_BY = item.CREATE_BY;
                nvpc.DELTED_DATE = item.DELTED_DATE;
                nvpc.DELETED_BY = item.DELETED_BY;
                nvpc.UPDATED_BY = item.UPDATED_BY;
                nvpc.UPDATED_DATE = item.UPDATED_DATE;
                lstDTO.Add(nvpc);
            }
            return lstDTO; 
        }

        public List<tb_PHUCAP> getListPC()
        {
            return db.tb_PHUCAP.ToList();
        }

        public tb_NHANVIEN_PHUCAP Add(tb_NHANVIEN_PHUCAP pc)
        {
            try
            {
                db.tb_NHANVIEN_PHUCAP.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id, int iduser)
        {
            try
            {
                var _pc = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
                _pc.DELETED_BY = iduser;
                _pc.DELTED_DATE = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NHANVIEN_PHUCAP Update(tb_NHANVIEN_PHUCAP pc)
        {
            try
            {
                var _pc = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == pc.ID);
                _pc.IDPC = pc.IDPC;
                _pc.MANV = pc.MANV;
                _pc.NGAYCAP = pc.NGAYCAP;
                _pc.NOIDUNG = pc.NOIDUNG;
                _pc.SOTIEN = pc.SOTIEN;
                _pc.UPDATED_BY = pc.UPDATED_BY;
                _pc.UPDATED_DATE = pc.UPDATED_DATE;
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

