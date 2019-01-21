using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReemplazaCadena
{
    public class ChangeString
    {
        public string alfabeto= "abcdefghijklmnñopqrstuvwxyz";
        int indiceEncontrado = -1;
        public string build(string cadenaEvaluar)
        {           
            
            string cadenaDevolver = "";
            
            for (int i = 0; i < cadenaEvaluar.Length; i++)
            {
                char caracterEvaluado = cadenaEvaluar[i];
                if (Char.IsLetter(caracterEvaluado))
                {
                    if (Char.IsUpper(caracterEvaluado))
                    {
                        caracterEvaluado = char.ToLower(caracterEvaluado);
                        if (caracterEvaluado == 'z')
                        {
                            indiceEncontrado = -1;
                        }
                        else
                        {
                            indiceEncontrado = alfabeto.IndexOf(caracterEvaluado);
                        }
                        
                        cadenaDevolver = cadenaDevolver + Char.ToUpper(alfabeto[indiceEncontrado + 1]);
                    }
                    else
                    {
                        if (caracterEvaluado == 'z')
                        {
                            indiceEncontrado = -1;
                        }
                        else
                        {
                            indiceEncontrado = alfabeto.IndexOf(caracterEvaluado);
                        }                       
                        cadenaDevolver = cadenaDevolver + alfabeto[indiceEncontrado + 1];
                    }
                    
                }
                else
                {
                    cadenaDevolver = cadenaDevolver + caracterEvaluado;
                }   
            }

            return cadenaDevolver;

        }

        static void Main(string[] args)
        {
            
            ChangeString objetoPrueba = new ChangeString();
            //string cadenaPrueba = "**Casa 52Z";
            string cadenaPrueba = "";
            Console.WriteLine("*****Imprimiendo Cadenas****");
            Console.WriteLine("Ingrese una Cadena:");
            cadenaPrueba = Console.ReadLine();
            Console.WriteLine(objetoPrueba.build(cadenaPrueba));           
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
