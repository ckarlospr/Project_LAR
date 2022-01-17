using System;

namespace Transportes_LAR.Interfaz.Unidad.Dato
{
	public class Equipamiento
	{
		public string idUnidad 		{get;set;}
		public string idCategoria 	{get;set;}
		public string categoria 	{get;set;}
		public string descripcion	{get;set;}
		public string cantidad		{get;set;}
	}
	
	public class Categoria
	{
		public string idCategoria 	{get;set;}
		public string nombre		{get;set;}
	}
}
