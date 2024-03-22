using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        // Método para imprimir el estado de las tres pilas para que el usuario lo vea
        public static void imprimir(Pila ini, Pila aux, Pila fin)
        {

            // Imprime el tamaño y el disco en la cima de la pila inicial
            Console.Write("Pila Inicial:  " + ini.Size + " Disco en la cima: " + ini.Top + " Estado: ");
            imprimirPila(ini);
            Console.Write("\n");

            // Imprime el tamaño y el disco en la cima de la pila auxiliar
            Console.Write("Pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + " Estado: ");
            imprimirPila(aux);
            Console.Write("\n");

            // Imprime el tamaño y el disco en la cima de la pila final
            Console.Write("Pila Final:    " + fin.Size + " Disco en la cima: " + fin.Top + " Estado: ");
            imprimirPila(fin);
            Console.Write("\n\n");
        }
        // Método para imprimir los elementos de una pila
        public static void imprimirPila(Pila p)
        {
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.Valor + " ");
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("INICIO DEL PROGRAMA");

            String recolectaStr = "";
            int recolecta = 0;

            // Solicitar al usuario un número para el tamaño inicial de la pila
            Console.WriteLine("Dame un número:");
            recolectaStr = Console.ReadLine();
            recolecta = Int32.Parse(recolectaStr);

            // Inicializar las tres pilas: ini (inicial), aux (auxiliar) y fin (final)
            Pila ini = new Pila(recolecta);
            Pila aux = new Pila();
            Pila fin = new Pila();

            // Imprimir el estado inicial de las tres pilas
            imprimir(ini, aux, fin);
            Console.Write("\n\n");

            Console.WriteLine("INICIO DEL ITERATIVO");

            // Imprimir el estado antes de iniciar el algoritmo iterativo
            imprimir(ini, aux, fin);

            // Crear una instancia de la clase Hanoi para usar su método iterativo
            Hanoi hanoi = new Hanoi();

            // Ejecutar el algoritmo iterativo y obtener el número de movimientos
            int movimientosI = hanoi.iterativo(recolecta, ini, fin, aux);

            // Imprimir el número de movimientos realizados
            Console.WriteLine("Movimientos: " + movimientosI);
            Console.WriteLine("Fin ITERATIVO");
            Console.WriteLine("\n\n");

            Console.WriteLine("INICIO DEL RECURSIVO");

            // Inicializar nuevamente las pilas para el algoritmo recursivo
            Pila iniR = new Pila(recolecta);
            Pila auxR = new Pila();
            Pila finR = new Pila();

            // Imprimir el estado inicial de las tres pilas para el algoritmo recursivo
            imprimir(iniR, auxR, finR);

            // Ejecutar el algoritmo recursivo y obtener el número de movimientos
            int movimientosR = hanoi.recursivo(recolecta, iniR, finR, auxR);

            // Imprimir el número de movimientos realizados por el algoritmo recursivo
            Console.WriteLine("Movimientos: " + movimientosR);
            Console.WriteLine("Fin RECURSIVO");
            Console.Read();
        }
    }
}