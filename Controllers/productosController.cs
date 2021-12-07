using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProductos.Models;

namespace WebProductos.Controllers
{
    public class productosController : Controller
    {

        public IActionResult Index()
        {
            return View(DapperORM.ReturnList<productosModel>("productViewAll"));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id",id);
                return View(DapperORM.ReturnList<productosModel>("productViewById",param).FirstOrDefault<productosModel>());
            }
               
        }

        [HttpPost]
        public ActionResult AddOrEdit(productosModel pro)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", pro.Id);
            param.Add("@Codigo", pro.Codigo);
            param.Add("@Nombre", pro.Nombre);
            param.Add("@Cantidad", pro.Cantidad);
            param.Add("@Precio", pro.Precio);
            param.Add("@FechaCreacion", pro.FechaCreacion);
            param.Add("@Categoria", pro.Categoria);
            param.Add("@imagen", pro.imagen);

            DapperORM.ExecuteWithoutReturn("ProductAddOrEdit", param);

            return RedirectToAction("Index");
        }



        
        public ActionResult Categoria(string Categoria="")
        {
            //if (Categoria== "")
            //    return View();
            //else
            if(Categoria != "")
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Categoria", Categoria);
                return View(DapperORM.ReturnList<productosModel>("productViewCategoria", param));

            }
            else
            {
                return View();
            }

            

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


    }
}
