using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnTongHop.ViewModels
{
    public class ErrorsModel
    {
        public List<String> DanhSachLoi;
        public ErrorsModel()
        {
            this.DanhSachLoi = new List<string>();
        }
        public void ThemLoi(string loi)
        {
            this.DanhSachLoi.Add(loi);
        }
    }
}