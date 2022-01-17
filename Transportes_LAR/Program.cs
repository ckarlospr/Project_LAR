using System;
using System.Windows.Forms;

namespace Transportes_LAR
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{			
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LAR());
			//Application.Run(new Interfaz.Operador.Pre_Seleccion.FormLlamada());	
			//Application.Run(new Interfaz.Combustible.FormMovimientos());
			//Application.Run(new Interfaz.Operador.Pre_Seleccion.FormContratacion());	
			//Application.Run(new Interfaz.Nomina.Nomina_Fiscal.FormSueldoReal());			
		}
	}
}
