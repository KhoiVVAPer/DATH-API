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
    public class NamHocController : ApiController
    {
        private DATHEntities _db;
        public NamHocController()
        {
            this._db = new DATHEntities();
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult LayTatCa()
        {
            var danhSachNam = this._db.NamHocs.Select(x => new NamHocModel()
            {
                id = x.id,
                tennamhoc = x.tennamhoc
            });
            return Ok(danhSachNam);

        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult LayTheoMa(int id)
        {

            var nh = _db.NamHocs.FirstOrDefault(x => x.id == id);

            if (nh != null)
            {
                return Ok(new NamHocModel(nh));
            }
            return Ok();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult ThemNamHoc(ThemNamHocModel model)
        {
            NamHoc nh = new NamHoc();
            nh.tennamhoc = model.tennamhoc;
            nh = this._db.NamHocs.Add(nh);
            this._db.SaveChanges();
            NamHocModel viewModel = new NamHocModel(nh);

            return Ok(viewModel);
        }
    }
}