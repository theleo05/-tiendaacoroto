using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
	public class Productos
	{
		public Int64 id { get; set; }
		public string nombre { get; set; }
		public string precio { get; set; }
		public string describcion { get; set;}
		public string imagen{ get; set; }
		
	}
}