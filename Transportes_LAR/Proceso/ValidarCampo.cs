using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Proceso
{
	public class ValidarCampo
	{
		public static bool punto = false;
		public static bool dosPunto = false;
		
		internal static void soloLetrasNumerosyOtros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!=39)
                e.Handled = false;
            else
                e.Handled = true;
        }
		
		internal static void soloLetrasyEspacios(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar) ||
                Char.IsLetter(e.KeyChar) ||
                Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
		
        internal static void soloLetrasNumerosyEspacios(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar) ||
                Char.IsLetter(e.KeyChar) ||
                Char.IsNumber(e.KeyChar) ||
                Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        internal static void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || 
                Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
       
        internal static void soloNumerosPunto(object sender, KeyPressEventArgs e)
        {
        	if (Char.IsNumber(e.KeyChar) || ((e.KeyChar)==46) || Char.IsControl(e.KeyChar))
                
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        internal static void solo0y1(object sender, KeyPressEventArgs e)
        {
        	if (((e.KeyChar)==48) || ((e.KeyChar)==49) || Char.IsControl(e.KeyChar))                
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        internal static void soloNumerosUnPunto(object sender, KeyPressEventArgs e)
        {
        	if ((e.KeyChar)==46|| 
        	    Char.IsControl(e.KeyChar))
		        	{
		        		if(punto==false)
		        		{
		        			 e.Handled = false;
		        			 punto = true;
		        			 return;
		        		}
		        		else
		        		{
		        			e.Handled = true;
		        		}
		        	}
            if (Char.IsNumber(e.KeyChar) || 
        	    Char.IsControl(e.KeyChar))
        	{
                e.Handled = false;
        	}
            else
            {
                e.Handled = true;
            }
        }
      
        internal static void soloNumerosUnPunto2(object sender, KeyPressEventArgs e)
        {
        	if ((e.KeyChar).ToString()=="."|| Char.IsControl(e.KeyChar)){
		        if(punto==false){
		        			 e.Handled = false;
		        			 punto = true;
		        			 return;
		        		}else{
		        			e.Handled = true;
		        		}
		        	}
            if (Char.IsNumber(e.KeyChar) ||  Char.IsControl(e.KeyChar)){
                e.Handled = false;
        	}else{
                e.Handled = true;
            }
        }
        
        internal static void soloNumerosDosPunto(object sender, KeyPressEventArgs e)
        {
        	
        	if ((e.KeyChar)==58|| 
        	    Char.IsControl(e.KeyChar))
		        	{
		        		if(dosPunto==false)
		        		{
		        			 e.Handled = false;
		        			 dosPunto = true;
		        			 return;
		        		}
		        		else
		        		{
		        			e.Handled = true;
		        		}
		        	}
            if (Char.IsNumber(e.KeyChar) || 
        	    Char.IsControl(e.KeyChar))
        	{
                e.Handled = false;
        	}
            else
            {
                e.Handled = true;
            }
        }
      
       	internal static void soloLetrasNumerosGuion(object sender, KeyPressEventArgs e)
       {

           if (Char.IsLetter(e.KeyChar) ||
               Char.IsNumber(e.KeyChar) ||
               (e.KeyChar == 45) ||             //ASCII de "-"
               Char.IsControl(e.KeyChar))
               e.Handled = false;
           else
               e.Handled = true;
       }
       	
        internal static void soloLetrasNumeros(object sender, KeyPressEventArgs e)
       {

           if (Char.IsLetter(e.KeyChar) ||
               Char.IsNumber(e.KeyChar) ||
               Char.IsControl(e.KeyChar))
               e.Handled = false;
           else
               e.Handled = true;
       }
        
	 	internal static void soloLetras(object sender, KeyPressEventArgs e)
       {

	 		if (Char.IsLetter(e.KeyChar)||
	 		    Char.IsControl(e.KeyChar))
               e.Handled = false;
           else
               e.Handled = true;
       }   

		internal static void soloLetrasPuntoEspacio(object sender, KeyPressEventArgs e)
       {

	 		if (Char.IsLetter(e.KeyChar)||
	 		    Char.IsControl(e.KeyChar)||
	 		    Char.IsSeparator(e.KeyChar)||
                Char.IsPunctuation(e.KeyChar) 
	 		   )
               e.Handled = false;
           else
               e.Handled = true;
       }
	 	
	 	internal static void soloVacio(object sender, KeyPressEventArgs e)
	 	{
           e.Handled = true;
	 	}
	 	
	 	internal static void cualquierCaracter(object sender, KeyPressEventArgs e)
       {	
       }
	 	
	 	internal static void soloCaracteresEmail(object sender, KeyPressEventArgs e)
        {
        	if(Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar) || ((e.KeyChar)==64) || ((e.KeyChar)==46) || Char.IsControl(e.KeyChar))
        		e.Handled = false;
        	else
        		e.Handled = true;
        }
	 	
	 	internal static void numeroGuion(object sender, KeyPressEventArgs e){
	 		if(Char.IsNumber(e.KeyChar) ||  Char.IsControl(e.KeyChar) ||(e.KeyChar == 45))
	 			e.Handled = false;
           else
               e.Handled = true;
	 	}
	 	
	 	internal static void paraTelefonos(object sender, KeyPressEventArgs e){
	 		if(Char.IsNumber(e.KeyChar) ||  Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || (e.KeyChar == 45) || (e.KeyChar == 79) || (e.KeyChar == 111))
	 			e.Handled = false;
           else
               e.Handled = true;
	 	}
	 	
	 	public static Boolean email_bien_escrito(String email)
		{
		   String expresion;
		   expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
		   if (Regex.IsMatch(email,expresion))
		   {
		      if (Regex.Replace(email, expresion, String.Empty).Length == 0)
		      {
		         return true;
		      }
		      else
		      {
		         return false;
		      }
		   }
		   else
		   {
		      return false;
		   }
		}
	 	
	 	public static int ValidarRFC(string cadena)
        {
            int i = 0;
            bool confirmacion = true;
            if (cadena.Length > 11 && cadena.Length < 14)
            {
                if (cadena.Length == 12)
                {
                    cadena = "-" + cadena;
                    i = 1;
                }
                for (int j = i; j <= 3; j++)
                {
                    if (!char.IsLetter(cadena[j]))
                        confirmacion = false;
                }
                for (int j = 4; j <= 9; j++)
                {
                    if (!char.IsDigit(cadena[j]))
                        confirmacion = false;
                }
                for (int j = 9; j < 13; j++)
                {
                    if (!char.IsLetterOrDigit(cadena[j]))
                        confirmacion = false;
                }
                if (!confirmacion)
                {
                    MessageBox.Show("El formato del RFC no es valido.", "RFC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("La longitud del RFC no es valido.", "RFC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (confirmacion)
                return 0;
            else
                return 1;
        }	 
	}
}
