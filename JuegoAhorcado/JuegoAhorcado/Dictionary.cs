using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class Dictionary
    {
        private static Dictionary _instance;
        private static List<String> palabras = new List<String>();
        public static Dictionary Instance
        {
            get{
                if (_instance == null)
                    _instance = new Dictionary();
                return _instance;
            }
        }
        public void ReadDictionary(string fileRoute)
        {
            String palabra;
            palabras.Clear();
            try { 
            
                StreamReader fichero = File.OpenText(fileRoute);
                do
                {
                    palabra = fichero.ReadLine();
                    if (palabra != null)
                        palabras.Add(palabra);
                } while (palabra != null);
                fichero.Close();
            }
            catch (IOException)
            {
                StreamWriter fichero = File.CreateText(fileRoute);
                fichero.Close();
            }
            
        }
        public void AgregateToDictionary(string fileRoute, String newWord)
        {
            StreamWriter fichero = File.AppendText(fileRoute);
            fichero.WriteLine(newWord);
            palabras.Add(newWord);
            fichero.Close();
        }
        public List<String> GetWords()
        {
            return palabras;
        } 
    }
}
