using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Archivo_Configuracion
{
	public class EncriptarDato
	{
		#region CONSTRUCTOR
		public EncriptarDato()
		{
		}
		#endregion
		
		#region ENCRIPTAR_TEXTO
      	public  string Encriptar(string textoQueEncriptaremos) 
      	{
      		return Encriptar(textoQueEncriptaremos,"pass75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128); 
      	} 
		     	
     	public  string Encriptar(string textoQueEncriptaremos,string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
     	{
        	byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector); 
        	byte[] saltValueBytes  = Encoding.ASCII.GetBytes(saltValue); 
        	byte[] plainTextBytes  = Encoding.UTF8.GetBytes(textoQueEncriptaremos);  
	        PasswordDeriveBytes password = new PasswordDeriveBytes(passBase,
	        saltValueBytes, hashAlgorithm, passwordIterations); 
        	byte[] keyBytes = password.GetBytes(keySize / 8); 
        	RijndaelManaged symmetricKey = new RijndaelManaged() { 
          		Mode = CipherMode.CBC 
        	};
        	ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes,
          	initVectorBytes); 
        	MemoryStream memoryStream = new MemoryStream();        
        	CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, 
         	CryptoStreamMode.Write); 
        	cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length); 
        	cryptoStream.FlushFinalBlock();  
        	byte[] cipherTextBytes = memoryStream.ToArray(); 
        	memoryStream.Close(); 
       	 	cryptoStream.Close(); 
        	String cipherText = Convert.ToBase64String(cipherTextBytes);       
        	return cipherText; 
      	} 
      	#endregion
      	
		#region DESENCRIPTAR_TEXTO
      	public  string Desencriptar(string textoEncriptado) 
      	{
   			return Desencriptar(textoEncriptado, "pass75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128); 
      	}  
	
      	public string Desencriptar(string textoEncriptado, string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
      	{
        	byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector); 
        	byte[] saltValueBytes  = Encoding.ASCII.GetBytes(saltValue); 
        	byte[] cipherTextBytes = Convert.FromBase64String(textoEncriptado); 
        	PasswordDeriveBytes password = new PasswordDeriveBytes(passBase,saltValueBytes, hashAlgorithm, passwordIterations); 
        	byte[] keyBytes = password.GetBytes(keySize / 8); 
        	RijndaelManaged symmetricKey = new RijndaelManaged() { 
        		Mode = CipherMode.CBC 
        	};
        	ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes,initVectorBytes); 
        	MemoryStream  memoryStream = new MemoryStream(cipherTextBytes); 
        	CryptoStream  cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read); 
        	byte[] plainTextBytes = new byte[cipherTextBytes.Length]; 
        	int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0,plainTextBytes.Length);  
        	memoryStream.Close(); 
        	cryptoStream.Close(); 
        	string plainText = Encoding.UTF8.GetString(plainTextBytes, 0,decryptedByteCount); 
        	return plainText; 
    	}
		#endregion
	}
}
