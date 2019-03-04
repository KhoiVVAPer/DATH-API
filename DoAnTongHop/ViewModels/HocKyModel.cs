using DoAnTongHop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnTongHop.ViewModels
{
    public class HocKyModel
    {
        public int id { get; set; }
        public string tenhocky { get; set; }
        public int? id_namhoc { get; set; }
        public HocKyModel()
        { }
        public HocKyModel(HocKy hk)
        {
            id = hk.id;
            tenhocky = hk.tenhocky;
            id_namhoc = hk.NamHoc.id;
        }
    }
    public class ThemHocKyModel
    {
        public string tenhocky { get; set; }
        public int? id_namhoc { get; set; }
    }
}