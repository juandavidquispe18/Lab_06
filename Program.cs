using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Program
    {
        static int max_asistentes;
        static int asistentes_actuales;
        static int total_ingresos;
        static int total_salidas;
        static int veces_lleno = 0;
        static int veces_vacio;
        static List<int> historial_ingresos = new List<int>();
        static List<int> historial_salidas = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número máximo de personas: ");
            max_asistentes = int.Parse(Console.ReadLine());

            Console.Clear();

            while (true)
            {

                Console.WriteLine("=====================================");
                Console.WriteLine("| Asistentes actuales | " + asistentes_actuales);
                Console.WriteLine("| Aforo               | " + (asistentes_actuales * 100 / max_asistentes) + "%");
                Console.WriteLine("| Máximo              | " + max_asistentes + " personas");
                Console.WriteLine("=====================================");
                Console.WriteLine("Presione: ");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");

                char opcion = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (opcion)
                {

                    case 'i':
                        ingresar_persona();
                        break;
                    case 's':
                        salir_persona();
                        break;
                    case 'x':
                        mostrar_estadisticas();
                        return;
                    default:
                        Console.WriteLine("Opcion no válida. Por favor, ingrese 'i', 's' o 'x'. ");
                        break;
                }
            }
        }

        static void ingresar_persona()
        {

            if (asistentes_actuales < max_asistentes)
            {
                asistentes_actuales++;
                total_ingresos++;
            }
            else
            {
                Console.WriteLine("El local se encuentra lleno. ");
                veces_lleno++;
            }
        }

        static void salir_persona()
        {

            if (asistentes_actuales > 0)
            {
                asistentes_actuales--;
                total_salidas++;
            }
            else
            {
                Console.WriteLine("El local se encuentra vacío. ");
                veces_vacio++;
            }
        }

        static void mostrar_estadisticas()
        {

            Console.Clear();
            Console.WriteLine("El programa ha finalizado");
            Console.WriteLine("=====================================");
            Console.WriteLine("Estadísticas: ");
            Console.WriteLine("=====================================");
            Console.WriteLine(total_ingresos + " personas ingresaron");
            Console.WriteLine(total_salidas + " personas salieron");
            Console.WriteLine(veces_lleno + " veces se llenó el local");
            Console.WriteLine("Estuvo vacío " + veces_vacio + " veces");
            Console.WriteLine("=====================================");
            Console.WriteLine("Presione cualquier tecla para salir. ");
            Console.ReadKey();
        }
    }
}
