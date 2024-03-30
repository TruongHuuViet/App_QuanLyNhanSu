using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }
        public tb_TRINHDO getItem(int id)
        {
            return db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == id);
        }
        public tb_TRINHDO Add(tb_TRINHDO td)
        {
            try
            {
                db.tb_TRINHDO.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }

        public tb_TRINHDO Update(tb_TRINHDO td)
        {
            try
            {
                var _tg = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == td.IDTD);
                _tg.TENTD = td.TENTD;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _td = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == id);
                db.tb_TRINHDO.Remove(_td);
                db.tb_TRINHDO.Remove(_td);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
    }
}
