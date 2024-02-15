//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace AdminSys.Utilidades.encriptar
//{
//    public class Encryption
//    {
//        private string myKey;
//        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

//        private MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

//        public Encryption()
//        {
//            string strtmp = "";
//            Random random = new Random();

//            for (int i = 1; i <= 20; i++)
//            {
//                char randomChar = (char)random.Next('A', 'Z' + 1);
//                strtmp += randomChar;
//            }

//            myKey = strtmp;
//        }

//        public Encryption(string strLlave)
//        {
//            myKey = strLlave;
//        }

//        public string Key
//        {
//            get { return myKey; }
//            set { myKey = value; }
//        }

//        private static bool ByteIsBase64(byte i)
//        {
//            if (i == 43)
//            {
//                return true; // '+'
//            }
//            else if (i >= 47 && i <= 57)
//            {
//                return true; // '/', '0' - '9'
//            }
//            else if (i == 61)
//            {
//                return true; // '='
//            }
//            else if (i >= 65 && i <= 90)
//            {
//                return true; // 'A' - 'Z'
//            }
//            else if (i >= 97 && i <= 122)
//            {
//                return true; // 'a' - 'z'
//            }
//            else
//            {
//                return false;
//            }
//        }


//        private bool IsBase64(string str)
//        {
//            if (!string.IsNullOrEmpty(str))
//            {
//                foreach (byte b in Encoding.ASCII.GetBytes(str))
//                {
//                    if (!ByteIsBase64(b))
//                        return false;
//                }

//                return str.Length % 4 == 0;
//            }
//            else
//            {
//                return false;
//            }
//        }



//        public string DesEncriptarSTR(string strTexto)
//        {
//            if (IsBase64(strTexto))
//            {
//                des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes(myKey));
//                des.Mode = CipherMode.ECB;
//                ICryptoTransform desdencrypt = des.CreateDecryptor();
//                byte[] buff = Convert.FromBase64String(strTexto);
//                return Encoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));
//            }
//            else
//            {
//                return strTexto;
//            }
//        }

//        public void ProbarDesencriptar()
//        {
//            // Cadena cifrada de ejemplo
//            string mipass = "E7V/25m8KTes4g3mbpRNbw==";

//            // Desencriptar la cadena
//            string despass = DesEncriptarSTR(mipass);

//            // Mostrar resultados
//            Console.WriteLine("Cadena cifrada: " + mipass);
//            Console.WriteLine("Cadena desencriptada: " + despass);
//        }

//        public string EncriptarSTR(string strTexto)
//        {
//            des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes(myKey));
//            des.Mode = CipherMode.ECB;
//            ICryptoTransform desdencrypt = des.CreateEncryptor();
//            byte[] buff = Encoding.ASCII.GetBytes(strTexto);
//            return Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));

//        }

//        public string GetKey()
//        {
//            return myKey;
//        }

//        public void Dispose()
//        {
//            des.Dispose();
//            hashmd5.Dispose();
//        }
//    }
//}
