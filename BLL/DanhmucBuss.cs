using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class DanhmucBuss : IdanhmucBuss
    {
        private readonly IdanhmucRespo _Respo;
        public DanhmucBuss(IdanhmucRespo Respo)
        {
            _Respo = Respo;
        }
        public bool create_danh_muc(danhmuc dm)
        {
            return _Respo.create_danh_muc(dm);
        }

        public bool delete_danh_muc(int id)
        {
            return _Respo.delete_danh_muc(id);
        }

        public bool edit_danh_muc(int id, danhmuc dm)
        {
            return _Respo.edit_danh_muc(id, dm);
        }

        public List<danhmuc> get_all_danh_muc()
        {
            return _Respo.get_all_danh_muc();
        }

        public danhmuc get_danh_muc_by_id(int id)
        {
            return _Respo.get_danh_muc_by_id(id);
        }
    }
}
