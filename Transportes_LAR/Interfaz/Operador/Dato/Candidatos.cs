using System;

namespace Transportes_LAR.Interfaz.Operador.Dato
{
	public class Candidatos
	{
		
	}
	
	public class Telefonos
	{
		public string id				{get;set;}
		public string tipo				{get;set;}
		public string numero			{get;set;}
		public string relacion			{get;set;}
		public string nombre    		{get;set;}
		public string estatus    		{get;set;}
	}
	
	public class Parametros
	{
		public string edadMin			{get;set;}
		public string edadMax			{get;set;}
		public string imagen			{get;set;}
		public string tatuajes    		{get;set;}
		public string percing			{get;set;}
		public string infonavit			{get;set;}
		public string expDual			{get;set;}
		public string expDirTrasera    	{get;set;}
		public string expTransPersonal	{get;set;}
		public string descEstatal		{get;set;}
		public string descFederal		{get;set;}
		public string descAptoMedico    {get;set;}
		public string licEstatal		{get;set;}
		public string vigEstatal		{get;set;}
		public string licFederal		{get;set;}
		public string vigFederal    	{get;set;}
		public string vigAptoMedico    	{get;set;}
		public string contactoTaller	{get;set;}
		public string numeroTaller		{get;set;}
		public string contactoOficina   {get;set;}
		public string numeroOficina		{get;set;}
	}
	
	
	public class LicenciasAjuste
	{
		public string id				{get;set;}
		public string estatal			{get;set;}
		public string estatal_vence		{get;set;}
		public string federal			{get;set;}
		public string federal_vence		{get;set;}
		public string medico			{get;set;}
		public string medico_vence		{get;set;}
		public String observaciones    	{get;set;}
	}
	
	public class Zonas
	{
		public string id			{get;set;}
		public string tipo			{get;set;}
		public string nombre		{get;set;}
		public string estatus    	{get;set;}		
	}
	
	public class Fuentes
	{
		public string id			{get;set;}
		public string tipo			{get;set;}
		public string nombre		{get;set;}
		public string estatus    	{get;set;}		
	}
}
