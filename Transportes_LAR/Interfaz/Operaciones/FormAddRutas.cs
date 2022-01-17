using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormAddRutas : Form
	{
		private Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones refRutas = null;
		
		private int rutaSelecc=-1;
		
		public FormAddRutas(Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones refRut, int ext)
		{
			InitializeComponent();
			refRutas=refRut;
			extendida=ext;
		}
		
		int extendida=0;
		
		void FormAddRutasLoad(object sender, EventArgs e)
		{
			lblNomEmpresa.Text=refRutas.nomEmpresa;
			for(int x=0; x<refRutas.listRutaEntrada2.Count; x++)
			{
				if(refRutas.listRutaEntrada2[x].empresa.Equals(refRutas.nomEmpresa)  && refRutas.listRutaEntrada2[x].extra=="0")
				{
					dtgRutas.Rows.Add(refRutas.listRutaEntrada2[x].id_ruta,refRutas.listRutaEntrada2[x].nombre,refRutas.listRutaEntrada2[x].sentido, refRutas.listRutaEntrada2[x].hora);
				}
			}
			for(int x=0; x<refRutas.listRutaSalida2.Count; x++)
			{
				if(refRutas.listRutaSalida2[x].empresa.Equals(refRutas.nomEmpresa)  && refRutas.listRutaSalida2[x].extra=="0")
				{
					dtgRutas.Rows.Add(refRutas.listRutaSalida2[x].id_ruta,refRutas.listRutaSalida2[x].nombre,refRutas.listRutaSalida2[x].sentido, refRutas.listRutaSalida2[x].hora);
				}
			}
			dtgRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(rutaSelecc!=-1)
			{
				if(dtgRutas[2,rutaSelecc].Value.Equals("Entrada"))
				{
					for(int x=0; x<refRutas.listRutaEntrada2.Count; x++)
					{
						if(rutaSelecc!=-1)
						{
							if(refRutas.listRutaEntrada2[x].empresa.Equals(refRutas.nomEmpresa)&&refRutas.listRutaEntrada2[x].id_ruta.Equals(dtgRutas[0,rutaSelecc].Value))
							{
								/*int N=0;
								for(int y=0; y<(refRutas.dtgEmpresas.RowCount-1) ;y++)
								{
									if(refRutas.listRutaEntrada2[x].nombre.ToString().Equals(refRutas.dtgEmpresas[13,y].Value.ToString()) && refRutas.listRutaEntrada2[x].empresa.ToString().Equals(refRutas.dtgEmpresas[1,y].Value.ToString()))
									{
										refRutas.dtgEmpresas.Rows[y].Cells[2].Value=refRutas.listRutaEntrada2[x].id_ruta;
										refRutas.dtgEmpresas.Rows[y].Cells[3].Value="Operador";
										refRutas.dtgEmpresas.Rows[y].Cells[4].Value=refRutas.listRutaEntrada2[x].hora;
										refRutas.dtgEmpresas.Rows[y].Cells[5].Value="00:00";
										refRutas.dtgEmpresas.Rows[y].Cells[6].Value=refRutas.listRutaEntrada2[x].nombre;
										refRutas.dtgEmpresas.Rows[y].Cells[7].Value="00:00";
										N=1;
										rutaSelecc=-1;
										this.Close();
										break;
									}
								}
								if(N==0)
								{*/
								if(extendida==0)
									new Conexion_Servidor.Desapacho.SQL_Operaciones().rutasExistentes(Convert.ToInt16(dtgRutas[0,rutaSelecc].Value), refRutas.refPrincipal.fecha_Base_Datos, refRutas.refPrincipal.ConsTurno, refRutas.id_Empresa);
								else
									new Conexion_Servidor.Desapacho.SQL_Operaciones().rutasExistentesExtendidas(Convert.ToInt16(dtgRutas[0,rutaSelecc].Value), refRutas.refPrincipal.fecha_Base_Datos, refRutas.refPrincipal.ConsTurno, refRutas.id_Empresa);
								
								int ID = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdRutaAgregada();
								refRutas.dtgEmpresas.Rows.Add("0", refRutas.listRutaEntrada2[x].empresa, ID, "Operador", refRutas.listRutaEntrada2[x].hora, "00:00", "Ext "+refRutas.listRutaEntrada2[x].nombre, "00:00", false, "", "", "", "", "", "", "", false, "", "", "", "", "", "", "", "", "", "", "");
								dtgRutas.Rows.RemoveAt(rutaSelecc);
								refRutas.cantRutas++;
								rutaSelecc=-1;
								this.Close();
								break;
								//}
							}
						}
					}
				}
				else
				{
					if(dtgRutas[2,rutaSelecc].Value.Equals("Salida"))
					{
						for(int x=0; x<refRutas.listRutaSalida2.Count; x++)
						{
							if(refRutas.listRutaSalida2[x].empresa.Equals(refRutas.nomEmpresa) && refRutas.listRutaSalida2[x].id_ruta.Equals(dtgRutas[0,rutaSelecc].Value))
							{
								/*int N=0;
								for(int y=0; y<(refRutas.dtgEmpresas.RowCount-1) ;y++)
								{
									if(refRutas.listRutaSalida2[x].nombre.ToString().Equals(refRutas.dtgEmpresas[6,y].Value.ToString()) && refRutas.listRutaSalida2[x].empresa.ToString().Equals(refRutas.dtgEmpresas[1,y].Value.ToString()))
									{
										refRutas.dtgEmpresas.Rows[y].Cells[9].Value=refRutas.listRutaSalida2[x].id_ruta;
										refRutas.dtgEmpresas.Rows[y].Cells[10].Value="Operador";
										refRutas.dtgEmpresas.Rows[y].Cells[11].Value=refRutas.listRutaSalida2[x].hora;
										refRutas.dtgEmpresas.Rows[y].Cells[12].Value="00:00";
										refRutas.dtgEmpresas.Rows[y].Cells[13].Value=refRutas.listRutaSalida2[x].nombre;
										refRutas.dtgEmpresas.Rows[y].Cells[14].Value="00:00";
										N=1;
										rutaSelecc=-1;
										this.Close();
										break;
									}
								}
								if(N==0)
								{*/
								if(extendida==0)
									new Conexion_Servidor.Desapacho.SQL_Operaciones().rutasExistentes(Convert.ToInt16(dtgRutas[0,rutaSelecc].Value), refRutas.refPrincipal.fecha_Base_Datos, refRutas.refPrincipal.ConsTurno, refRutas.id_Empresa);
								else
									new Conexion_Servidor.Desapacho.SQL_Operaciones().rutasExistentesExtendidas(Convert.ToInt16(dtgRutas[0,rutaSelecc].Value), refRutas.refPrincipal.fecha_Base_Datos, refRutas.refPrincipal.ConsTurno, refRutas.id_Empresa);
									
								
								int ID = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdRutaAgregada();
								refRutas.dtgEmpresas.Rows.Add( "0",refRutas.listRutaSalida2[x].empresa, "", "", "", "", "", "", false, "0", ID, "Operador", refRutas.listRutaSalida2[x].hora,"00:00","Ext "+refRutas.listRutaSalida2[x].nombre,"00:00", false, " ", "", "", "", " ", "", "", "", "", "", " ");
								refRutas.cantRutas++;
								rutaSelecc=-1;
								this.Close();
								break;
								//}
							}
						}
					}
				}
				if(dtgRutas.Rows.Count.ToString()=="0")
				{
					refRutas.indic=0;
				}
			}
			else
			{
				MessageBox.Show("Seleccione una ruta");
			}
			// Aki poner la validacion de indic a cero cuando no exista mas que agregar
		}
		
		void DtgRutasCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
		}
		
		void DtgRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if(e.RowIndex!=-1 && e.RowIndex<dtgRutas.Rows.Count)
			{
				dtgRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				rutaSelecc=e.RowIndex;
			}
		}
	}
}
