using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DanhmucRespo : IdanhmucRespo
    {
        private readonly IDatabaseHelper _Helper;
        public DanhmucRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }

        public bool create_danh_muc(danhmuc dm)
        {
            string msgError = "";
            try
            {
                var dt = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "create_danh_muc", "@ten_danhmuc",dm.tendm);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool delete_danh_muc(int id)
        {
            string msgError = "";
            try
            {
                var dt = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "delete_danh_muc", "@danhmuc_id", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool edit_danh_muc(int id, danhmuc dm)
        {
            string msgError = "";
            try
            {
                var dt = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "edit_danh_muc_agian", "@id_danhmuc", id, "@ten_danhmuc", dm.tendm);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<danhmuc> get_all_danh_muc()
        {
            string msgError = "";
            try
            {
                var dt = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_all_danh_muc");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<danhmuc>().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public danhmuc get_danh_muc_by_id(int id)
        {
            string msgError = "";
            try
            {
                var dt = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_danh_muc_by_id", "@id_danhmuc", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<danhmuc>().FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
