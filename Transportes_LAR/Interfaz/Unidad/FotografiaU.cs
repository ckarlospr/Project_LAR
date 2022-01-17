using System;
using System.Drawing;

namespace Transportes_LAR.Interfaz.Unidad
{
	public class FotografiaU
	{
		private int _idu;
		private int _idfoto;
		private Image _image;
		private string _desc;
		public  int ID_Unidad
        {
            get { return _idu; }
            set { _idu = value; }
        }
		public int ID_Foto
        {
            get { return _idfoto; }
            set { _idfoto = value; }
        }
		public string Descripcion
        {
            get { return _desc; }
            set { _desc = value; }
        }
		public Image image
		{
			get { return _image;}
			set { _image = value;}
		}
		public FotografiaU(int idf, int idu,string des, Image image){
			this._idu = idu;
			this._idfoto = idf;
			this._desc = des;
			this._image = image;
		}
	}
}
