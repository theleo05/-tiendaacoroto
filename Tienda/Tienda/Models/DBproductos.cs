using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tienda.Models
{

	public class DBproductos
	{
		IDbConnection _conx = DBcon.conexion();

		//metodo agregar
		public int AgregarProducto(Productos bproductos)
		{
			_conx.Open();
			SqlCommand _command = new SqlCommand("AgregarProducto", _conx as SqlConnection);
			_command.CommandType = CommandType.StoredProcedure;
			_command.Parameters.Add(new SqlParameter("@nombre", bproductos.nombre));
			_command.Parameters.Add(new SqlParameter("@precio", bproductos.precio));
			_command.Parameters.Add(new SqlParameter("@describcion", bproductos.describcion));
			_command.Parameters.Add(new SqlParameter("@imagen", bproductos.imagen));
			int total = _command.ExecuteNonQuery();
			_conx.Close();
			return total;
		}

		//metodo de cosultar

		public List<Productos> ConsultarProductos()
		{
			_conx.Open();
			SqlCommand _command = new SqlCommand("ConsultarProductos", _conx as SqlConnection);
			_command.CommandType = CommandType.StoredProcedure;
			IDataReader _reader = _command.ExecuteReader();
			List<Productos> _lista = new List<Productos>();
			while (_reader.Read()){

				Productos bproductos = new Productos();
				bproductos.nombre = _reader.GetString(1);
				bproductos.precio = _reader.GetString(2);
				bproductos.describcion = _reader.GetString(3);
				bproductos.imagen = _reader.GetString(4);

				_lista.Add(bproductos);
			}
			_conx.Close();
			return _lista;
		}
	}
}