using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IdanhmucRespo
    {
        List<danhmuc> get_all_danh_muc();
        danhmuc get_danh_muc_by_id(int id);
        bool create_danh_muc(danhmuc dm);
        bool edit_danh_muc(int id, danhmuc dm);
        bool delete_danh_muc(int id);
    }
}
