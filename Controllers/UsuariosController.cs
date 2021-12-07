using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProductos.Models;

namespace WebProductos.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("../Views/productos/Index");
        }

        [HttpGet]
        public ActionResult login(string categoria = "")
        {
            //if (categoria == "")
            //    return View();
            //else
            //{
            //    DynamicParameters param = new DynamicParameters();
            //    param.Add("@Categoria", categoria);
            //    return View(DapperORM.ReturnList<productosModel>("productViewCategoria", param));
            //}

            return View();
        }
    }
}
