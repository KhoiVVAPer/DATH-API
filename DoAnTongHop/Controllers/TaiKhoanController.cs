using DoAnTongHop.Models;
using DoAnTongHop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DoAnTongHop.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class TaiKhoanController : ApiController
    {
        private DATHEntities _db;
        public TaiKhoanController()
        {
            this._db = new DATHEntities();
        }
        [HttpPost]
        public IHttpActionResult Login(LoginModel model)
        {
            ErrorsModel errors = new ErrorsModel();
            if(string.IsNullOrEmpty(model.taikhoan))
            {
                errors.ThemLoi("Tai khoan khong duoc trong");
            }
            if(string.IsNullOrEmpty(model.matkhau))
            {
                errors.ThemLoi("Mat khau khong duoc trong");
            }
            if(errors.DanhSachLoi.Count > 0)
            {
                return Ok(errors);
            }
            else
            {
                var result = _db.NguoiDungs.FirstOrDefault(user => user.mataikhoan == model.taikhoan && user.matkhau == model.matkhau);
               
                if ( result != null)
                {
                    var md = new TaiKhoanModel()
                    {
                        id = result.id,
                        mataikhoan = result.mataikhoan,
                        tennguoidung = result.tennguoidung,
                        matkhau = result.matkhau,
                        hovaten = result.hovaten,
                        sdt = result.sdt,
                        email = result.email,
                        hinhdaidien = result.hinhdaidien,
                        id_chucvu = result.id_chucvu
                    };
                    return Ok(md);
                }
                else
                {
                    return Ok();
                }
                
            }
        }
    }
}