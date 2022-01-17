using System;

namespace Transportes_LAR.Interfaz.Libro.Dato
{
	public class ViajesEspeciales
	{
		private string _fecha 			;
		private string _h_salida 		;
		private string _h_planton 		;
		private string _h_regreso 		;
		private string _responsable		;
		private string _cliente			;
		private string _unidades		;
		private string _tipo			;
		private string _domicilio 		;
		private string _cruces 			;
		private string _colonia			;
		private string _destino			;
		private string _casetas			;
		private string _precio			;
		private string _km				;
		private string _telefono		;
		private string _datos			;
		private string _observaciones	;
		private string _pago_operador;
		
		
		public ViajesEspeciales()
		{
		
		}
		
		
		public ViajesEspeciales(string fecha, string h_salida, string h_planton, string h_regreso, 
		                        string respnsable, string cliente, string unidades, string tipo,
		                        string domicilio,
		                        string cruces, string colonia, string destino, string casetas, 
		                        string precio, string km, string telefono, string datos, 
		                        string observaciones, string pago_operador)
		{
			this._fecha = fecha;
			this._h_salida = h_salida;
			this._h_planton = h_planton;
			this._h_regreso = h_regreso;
			this._responsable = respnsable;
			this._cliente = cliente;
			this._unidades = unidades;
			this._tipo = tipo;
			this._domicilio = domicilio;
			this._cruces = cruces;
			this._colonia = colonia;
			this._destino = destino;
			this._casetas = casetas;
			this._precio = precio;
			this._km = km;
			this._telefono = telefono;
			this._datos = datos;
			this._observaciones = observaciones;
			this._pago_operador = pago_operador;
		}
		
		public void setfecha(String fecha)
		{
			this._fecha = fecha;
		}
		
		public String getfecha()
		{
			return this._fecha;
		}
		
		public void seth_salida(String h_salida)
		{
			this._h_salida = h_salida;
		}
		
		public String geth_salida()
		{
			return this._h_salida;
		}
		
		public void seth_planton(String h_planton)
		{
			this._h_planton = h_planton;
		}
		
		public String geth_planton()
		{
			return this._h_planton;
		}
		
		public void seth_regreso(String  h_regreso)
		{
			this._h_regreso = h_regreso;
		}
		
		public String get_regreso()
		{
			return this._h_regreso;
		}
		public void setresponsable(String respnsable)
		{
			this._responsable = respnsable;
		}
		
		public String getresponsable()
		{
			return this._responsable;
		}
		
		public void setclientes(String cliente)
		{
			this._cliente = cliente;
		}
		
		public String getclientes()
		{
			return this._cliente;
		}
		
		public void setunidades(String unidades)
		{
			this._unidades = unidades;
		}
		
		public String getunidades()
		{
			return this._unidades;
		}
		
		public void settipo(String tipo)
		{
			this._tipo = tipo;
		}
		
		public String gettipo()
		{
			return this._tipo;
		}
		
		public void setDomicilio(String Domicilio)
		{
			this._domicilio = Domicilio;
		}
		
		public String getDomicilio()
		{
			return this._domicilio;
		}
		
		public void setcruces(String cruces)
		{
		    this._cruces = cruces;
		}
		
		public String getcruces()
		{
			return this._cruces;
		}
		
		public void setcolonia(String colonia)
		{
			this._colonia = colonia;
		}
		
		public String getcolonia()
		{
			return this._colonia;
		}
		
		public void setdestino(String destino)
		{
			this._destino = destino;
		}
		
		public String getdestino()
		{
			return this._destino;
		}
		public void setcasetas(String casetas)
		{
			this._casetas = casetas;
		}
		
		public String getcasetas()
		{
			return this._casetas;
		}
		
		public void setprecio(String precio)
		{
			this._precio = precio;
		}
		
		public String getprecio()
		{
			return this._precio;
		}
		
		public void setKm(String km)
		{
			this._km = km;
		}
		
		public String getKm()
		{
			return this._km;
		}
		public void settelefono(String telefono)
		{
			this._telefono = telefono;
		}
		
		public String gettelefono()
		{
			return this._telefono;
		}
		
		public void setdatos(String datos)
		{
		this._datos = datos;
		}
		
		public String getdatos()
		{
			return this._datos;
		}
		
		public void setobservaciones(String observaciones)
		{
			this._observaciones = observaciones;
		}
		
		public String getobservaciones()
		{
			return this._observaciones;
		}
		public void setpago_operador(String pago_operador)
		{
			this._pago_operador = pago_operador;
		}
		
		public String getpago_operador()
		{
			return this._pago_operador;
		}
	}
}
