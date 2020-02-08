using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    class Program
    //Realizar una aplicación que permita registrar contactos telefónicos , también editarlo , listarlo y eliminarlo. Del contacto se debe pedir los siguientes datos: su nombre , apellido y numero telefónico.

    //El sistema debe de validar que el contacto que se este ingresado no tenga un numero de teléfono que ya este registrado, si existe alguien con ese numero de teléfono debe indicarle que existe y enviarlo al menu principal, en caso de que sea valido pues lo permite agregar, solo se validara los teléfonos al momento de agregar un nuevo contacto para el editar no lo tomaremos en cuenta por cuestiones de tiempo.

    //Consideraciones: Se Deben utilizar metodos para simplificar los proceso y tenerlo cada uno bien segmentado dentro del codigo.
    {
        static string[] Names = new string[15];
        static string[] Numbers = new string[15];

        static void Main(string[] args)
        {
            bool PaCerrar = true;
            while (PaCerrar == true)
            {
                Console.WriteLine("Bienvenido a su directorio de contactos! Elija la opcion: \n" +
                      "\n 1- Agregar un contacto. \n" +
                      "\n 2- Editar un contacto. \n" +
                      "\n 3- Ver lista de contactos. \n" +
                      "\n 4- Eliminar contactos.\n" +
                      "\n 5- Salir del programa.");
                int index = Convert.ToInt32(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 3:
                        Ver();
                        break;
                    case 4:
                        Eliminar();
                        break;
                    case 5:
                        PaCerrar = false;
                        break;
                }
            }

            if (PaCerrar == false)
            {
                Console.Clear();
                Console.WriteLine("Gracias por utilizar nuestros servicios!");
                Console.ReadKey();
            }
        }

        private static void Agregar()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Introduzca el nombre: ");

            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(Names[14]))
            {
                Console.Clear();
                for (int index = 0; index < Names.Length; index++)
                {

                    string elemento = Names[index];


                    if (string.IsNullOrEmpty(elemento))
                    {

                        Names[index] = name;
                        break;
                    }

                }
                Console.WriteLine("Introduzca el numero: ");
                string num = Console.ReadLine();

                for (int index = 0; index < Numbers.Length; index++)
                {

                    string elemento2 = Numbers[index];


                    if (string.IsNullOrEmpty(elemento2))
                    {

                        Numbers[index] = num;
                        break;
                    }

                }
                
            }
            else
            {
                Console.WriteLine("No hay mas espacio.");
                Console.ReadKey();
            }
            Console.Clear();
            



        }

        private static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Introduzca el contacto a editar de esta lista: ");
            for (int i = 0; i < Names.Length; i++)

            {
                string elemento = Names[i];
                Console.WriteLine((i + 1) + "-" + elemento);
            }

            int Edit = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Que quiere editar? \n" +
                "1- Nombre \n" +
                "2- Numero \n");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Escriba el nuevo nombre:");
                    Names[Edit - 1] = Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Escriba el nuevo numero:");
                    Numbers[Edit - 1] = Console.ReadLine();
                    break;

            }
            Console.Clear();
            








        }

        private static void Ver()
        {
            
            Console.Clear();
            Console.WriteLine("Lista de contactos: \n");

            for (int index = 0; index < Names.Length; index++)
            {
                string elemento = Names[index];
                string elemento2 = Numbers[index];


                Console.WriteLine((index + 1) + "-" + elemento + "              " + elemento2);

            }
            Console.ReadKey();
            Console.Clear();





        }
        private static void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Introduzca el contacto a eliminar de esta lista: ");
            for (int i = 0; i < Names.Length; i++)

            {
                string elemento = Names[i];
                Console.WriteLine((i + 1) + "-" + elemento);
            }

            int Delete = Convert.ToInt32(Console.ReadLine());
            Names[Delete - 1] = null;
            Numbers[Delete - 1] = null;

            Console.WriteLine("Contacto eliminado!");
            Console.ReadKey();
            Console.Clear();


        }
    }
    }

