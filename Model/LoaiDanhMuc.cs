using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Model
{

    public partial class LoaiDanhMuc
    {
        public int id { get; set; }
        public string tenldm { get; set; }
        public Nullable<int> iddm { get; set; }
        public virtual danhmuc danhmuc { get; set; }
        //public virtual ICollection<sanpham> sanphams { get; set; }
    }
}
