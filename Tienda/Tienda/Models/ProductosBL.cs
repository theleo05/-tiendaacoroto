using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
	public class ProductosBL
	{
		DBproductos _cproductos = new DBproductos();

		public int AgregarProducto(Productos bproductos)
		{
			return _cproductos.AgregarProducto(bproductos);
		}

		public List<Productos> ConsultarProductos()
		{
			return _cproductos.ConsultarProductos ();
		}
	} 
}