﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Models;



namespace Tienda.Controllers
{
    public class HomeController : Controller
    {
		ProductosBL _bl = new ProductosBL();
		// GET: Home
		public ActionResult Index()
        {
			ViewBag.ListaProductos = _bl.ConsultarProductos().ToList();

			return View();
        }

		public ActionResult Agregar()
		{
			
			return View();
		}

		public ActionResult Agregar2(Productos produc)
		{
			_bl.AgregarProducto(produc);

			return RedirectToAction("Index");

		}


	}
}