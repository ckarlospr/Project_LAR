using System;

namespace Transportes_LAR.Interfaz.Operador.Dato
{
	public class Licencia
	{
		public string id				{get;set;}
		public string clase				{get;set;}
		public string numero			{get;set;}
		public string tipo				{get;set;}
		public string vigencia			{get;set;}
	}
	
	public class Telefono
	{
		public string id				{get;set;}
		public string tipo				{get;set;}
		public string numero			{get;set;}
		public string descripcion		{get;set;}
	}
	
	public class Dependiente
	{
		public string id				{get;set;}
		public string parentesco		{get;set;}
		public string sexo				{get;set;}
		public string fechaNacimiento	{get;set;}
	}
	
	public class Contacto
	{
		public string id				{get;set;}
		public string nombre			{get;set;}
		public string apellidoPat		{get;set;}
		public string apellidoMat		{get;set;}
		public string telefono			{get;set;}
		public string calle				{get;set;}
		public string numInterior		{get;set;}
		public string numExterior		{get;set;}
		public string colonia			{get;set;}
		public string municipio			{get;set;}
		public string estado			{get;set;}
		public string cp				{get;set;}
	}
	
	public class Operador
	{
		public string id_Operador		{get;set;}
		public string alias				{get;set;}
	}
	
	public class Patron 
	{
		public string Nombre				{get;set;}
		public string Ns				{get;set;}
		public string nacionalidad		{get;set;}
		public string edad				{get;set;}
		public string sexo				{get;set;}
		public string estadoCivil		{get;set;}
		public string domicilio			{get;set;}
	}
	
	public class OperadorDato
	{
		public string nombre			{get;set;}
		public string edad				{get;set;}
		public string estadoCivil		{get;set;}
		public string domicilio			{get;set;}
	}
	
	public class OperadorContrato
	{
		public string nacionalidad 		{get;set;}
		public string sexo 				{get;set;}
		public string servicioPersonal	{get;set;}
		public string lugarDesempeno	{get;set;}
		public string duracionJornada	{get;set;}
		public string tarifa			{get;set;}
		public string impuestoRenta		{get;set;}
		public string diaPago			{get;set;}
		public string lugarPago			{get;set;}
		public string firmaPor			{get;set;}
		public string lugarFirma		{get;set;}
		public string tiempoCelebracion {get;set;}
		public string vacaciones		{get;set;}
	}
}
