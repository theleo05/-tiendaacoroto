using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tienda.Models
{
	public class DBcon
	{
		private static string conx = @"Data Source=DESKTOP-P8155G8;Initial Catalog=tienda;Integrated Security=True";

		public static IDbConnection conexion()
		{
			return new SqlConnection(conx);
		}
	}
}