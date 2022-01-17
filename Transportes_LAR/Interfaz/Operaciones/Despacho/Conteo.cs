using System;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	public class Conteo
	{
		public Conteo(Int64 ID_OPERADOR)
		{
			ID_O=ID_OPERADOR;
		}
		
		public Int64 ID_O;
		String[,] relacion = new String[20,20];
		int guia = 0;
		
		public void agregar(String empresa, int cant)
		{
			if(relacion.Length>0)
			{
				bool entra = false;
				for(int x=0; x<relacion.Length; x++)
				{
					if(relacion[x, 0]==empresa)
					{
						relacion[x, 0] = empresa;
						relacion[x, 1] = (Convert.ToInt16(relacion[x, 1])+cant).ToString();
						entra = true;
					}
				}
				
				if(entra==false)
				{
					guia ++;
					relacion[guia, 0] = empresa;
					relacion[guia, 1] = "1";
				}
			}
			else
			{
				relacion[guia, 0] = empresa;
				relacion[guia, 1] = "1";
			}
		}
		
		public int getCantidad()
		{
			int cant=0;
			
			if(relacion.Length>0)
			{
				for(int x=0; x<relacion.Length; x++)
				{
					/*if()
					{
						cant = cant+Convert.ToInt16(relacion[x, 1]);
					}*/
					cant++;
				}
			}
			
			return cant;
		}
	}
}
