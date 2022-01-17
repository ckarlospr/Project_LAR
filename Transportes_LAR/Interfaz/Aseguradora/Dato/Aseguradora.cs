using System;

namespace Transportes_LAR.Interfaz.Aseguradora.Dato
{
	/// <summary>
	/// COLECCION DE GET - SET DE ASEGURADORA
	/// </summary>
	public class Aseguradora
	{
		private string _id;
		private string _nombre;
		private string _domicilio;
		private string _telefono;
				
		public Aseguradora(string id, string nom, string dom, string tel)
		{
			this._id = id;
			this._nombre = nom;
			this._domicilio = dom;
			this._telefono = tel;
		}
		
		public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
		
		public string nombre
		{
			get { return _nombre; }
			set{ _nombre = value; }
		}
		
		public string domicilio
		{
			get { return _domicilio; }
			set { _domicilio = value; }
		}
		
		public string telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}
	}
}
