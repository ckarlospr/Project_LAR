using System;

namespace Transportes_LAR.Interfaz.Operaciones.Dato
{
	public class Operador
	{
		public string id						{get;set;}
		public string alias						{get;set;}
		public string estatus					{get;set;}
		public string num_viajes				{get;set;}
		public string ruta                      {get;set;} 
		public string usuario					{get;set;}
		public string empresa					{get;set;}
		
		public string telefono					{get;set;}
		public string tipoV						{get;set;}
		public string numeroV					{get;set;}
		
		public string domicilio					{get;set;}
		public string patron					{get;set;}
	}
}
