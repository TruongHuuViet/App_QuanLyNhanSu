﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LOAICA
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_LOAICA getItem(int id)
        {
            return db.tb_LOAICA.FirstOrDefault(x => x.IDLOAICA == id);
        }
        public List<tb_LOAICA> getList()
        {
            return db.tb_LOAICA.ToList();
        }
        public tb_LOAICA Add(tb_LOAICA lc)
        {
            try
            {
                db.tb_LOAICA.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_LOAICA Update(tb_LOAICA lc)
        {
            try
            {
                var _lc = db.tb_LOAICA.FirstOrDefault(x => x.IDLOAICA == lc.IDLOAICA);
                _lc.TENLOAICA = lc.TENLOAICA;
                _lc.HESO = lc.HESO;
                _lc.UPDATED_BY = lc.UPDATED_BY;
                _lc.UPDATED_DATE = lc.UPDATED_DATE;
                db.SaveChanges();
                return lc;
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
                var _lc = db.tb_LOAICA.FirstOrDefault(x => x.IDLOAICA == id);
                _lc.DELETED_BY = iduser;
                _lc.UPDATED_DATE = DateTime.Now;
                db.tb_LOAICA.Remove(_lc);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
