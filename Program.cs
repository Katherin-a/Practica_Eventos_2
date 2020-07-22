using System;

namespace Practica1Aris
{
    public class Persona//Creamos la clase Persona, Publica
    {
        private string n, c;
        private int e;
    


        
        public string Nombre
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }

        public string cedula
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int edad //Declarando las variables de esta clase 
        {
            // Capturar de datos         



            get //Similar a CIN De C++
            {
                return e;
            }

            set
            {
                e = value;
            }
        }

        public void Mostrar()//esto es un metodo que permite mostrar lo que get y set recibieron
        {//mostrar(): Muestra los datos de la persona.

            Console.WriteLine("Nombre: {0}", Nombre);//Mostrar el valor de la variable nombre
            Console.WriteLine("Edad: {0}", edad);//Valor de edad
            Console.WriteLine("Cedula: {0}", cedula);//Cedula ingresada
        }

        public void EsMayorDeEdad() //esMayorDeEdad(): Devuelve un valor lógico indicando si es mayor de edad.
        { //// EsMayorDeEdad() Funcion para determinar si es mayor de edad 
         
            //Estructura If C# Nada que argumentar
            if (edad > 18)
            { 
                Console.WriteLine(" ");
                Console.WriteLine("La Persona es Mayor de Edad.");
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("La Persona es Menor de Edad.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args) //Clase principal o de inicio del programa... 
        {/// 
            Persona p = new Persona();//el constructor de la clase Persona (Un constructor, donde los datos pueden estar vacíos.)
                                      //Llamamos elementos de la clase Persona dentro de Programa, como lo hariamos de una funcion o lista en Python

            Console.WriteLine("Ejercicio 1: Clase Persona."); 
            //Aqui Writeline se refiere a lo que vera como letrero el usuario al ingreso, como siempre entre comillas 
            Console.WriteLine(" ");
            Console.WriteLine("- Inserte los datos solicitados.");
            Console.WriteLine(" ");
            Console.Write("Nombre: "); //En esta solo Write para que lea dentro de la misma linea sin bajar a una linea de lectura
            
            //Al escribir p. podras ver los elementos publicos de la clase Persona
            p.Nombre = Convert.ToString(System.Console.ReadLine());//aqui se esta captando un valor para darselo a la variable nombre
            //Convert.To... nos permite hacer la convercion de datos antes de entrarlos a la variable. 
            Console.WriteLine(" ");
            Console.Write("Edad: ");
            p.edad = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Cedula: ");
            p.cedula = Convert.ToString(System.Console.ReadLine());
            Console.WriteLine(" ");
            p.Mostrar(); //Tambien llamamos la funcion mostrar que definimos en la clase persona.
            p.EsMayorDeEdad(); 
            Console.ReadKey(); // 

            //ReadKey es una lectura de cualquier tecla del teclado para hacer una pausa, 
          

        }
    }
}
