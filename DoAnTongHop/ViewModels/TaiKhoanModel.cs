using DoAnTongHop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnTongHop.ViewModels
{
    public class TaiKhoanModel
    {
        public int id { get; set; }
        public string mataikhoan { get; set; }
        public string tennguoidung { get; set; }
        public string matkhau { get; set; }
        public string hovaten { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string hinhdaidien { get; set; }
        public int? id_chucvu { get; set; }
        public TaiKhoanModel()
        {

        }
    }
}