using DoAnTongHop.Models;
using DoAnTongHop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DoAnTongHop.Controllers
{
    public class HocKyController : ApiController
    {
        private DATHEntities _db = new DATHEntities();
        public HocKyController()
        {

        }
        public IHttpActionResult LayTatCa()
        {
            ErrorsModel errors = new ErrorsModel();
              
            var listHocKy = this._db.HocKies.Select(x => new HocKyModel()
            {
                id = x.id,
                tenhocky = x.tenhocky,
                id_namhoc = x.NamHoc.id
            });
            if (listHocKy == null)
            {
                errors.ThemLoi("Khong co du lieu");
                return Ok(errors);
            }
            return Ok(listHocKy);
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult LayTheoMa(int id)
        {
            ErrorsModel errors = new ErrorsModel();
            var hk = this._db.HocKies.FirstOrDefault(x => x.id == id);
            if (hk != null)
            {
                return Ok(new HocKyModel(hk));
            }
            else
            {
                errors.ThemLoi("Khong tim thay hoc ky co ma la : " + id);
            }
            return Ok(errors);
        }
        [System.Web.Http.HttpPost]
        public IHttpActionResult ThemHocKy(ThemHocKyModel model)
        {
            ErrorsModel danhsachloi = new ErrorsModel();
            if(string.IsNullOrEmpty(model.tenhocky))
            {
                danhsachloi.ThemLoi("tenhocky : khong duoc de trong");
            }
            if(model.id_namhoc == null)
            {
                danhsachloi.ThemLoi("id_namhoc : khong duoc de trong");
            }
            if(danhsachloi == null)
            {
                HocKy hk = new HocKy();
                hk.tenhocky = model.tenhocky;

                hk.id_namhoc = model.id_namhoc;
                hk = this._db.HocKies.Add(hk);
                this._db.SaveChanges();
                return Ok(hk);
            }
            return Ok(danhsachloi);
        }
    }
}