using System;

namespace Transportes_LAR.Interfaz.Zona.Dato
{
	public class Zona
	{
		public int    id_Zona{get;set;}
		public string dataZona{get;set;}
	}
	public class Operador
	{
		public int    id_Operador{get;set;}
		public string dataAlias{get;set;}
		public string dataNombre{get;set;}
	}
	
	public class Ruta
	{
		public int    idRuta{get;set;}
		public string dataNombre{get;set;}
		public string dataEmpresa{get;set;}
	}
}
