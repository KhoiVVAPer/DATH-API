using DoAnTongHop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnTongHop.ViewModels
{
    public class NamHocModel
    {
        public int id { get; set; }
        public string tennamhoc { get; set; }
        public NamHocModel() { }
        public NamHocModel(NamHoc nh)
        {
            this.id = nh.id;
            this.tennamhoc = nh.tennamhoc;
        }
    }
    public class ThemNamHocModel
    {
        public string tennamhoc { get; set; }
    }
}