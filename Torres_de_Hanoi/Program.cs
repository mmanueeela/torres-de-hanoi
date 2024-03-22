using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {

        public static void imprimir(Pila ini, Pila aux, Pila fin)
        {

            Console.Write("Pila Inicial:  " + ini.Size + " Disco en la cima: " + ini.Top + " Estado: "); imprimirPila(ini);
            Console.Write("\n");
            Console.Write("Pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + " Estado: "); imprimirPila(aux);
            Console.Write("\n");
            Console.Write("Pila Final:    " + fin.Size + " Disco en la cima: " + fin.Top + " Estado: "); imprimirPila(fin);
            Console.Write("\n");
            Console.Write("\n");
        }
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
            int recoleta = 0;


            Console.WriteLine("Dame un mumero");
            recolectaStr = Console.ReadLine();
            recoleta = Int32.Parse(recolectaStr);

            Pila ini = new Pila(recoleta);
            Pila aux = new Pila();
            Pila fin = new Pila();

            imprimir(ini, aux, fin);

            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("INICIO DEL ITERATIVO");
            imprimir(ini, aux, fin);
            Hanoi hanoi = new Hanoi();
            int movimientosI = hanoi.iterativo(recoleta, ini, fin, aux);
            Console.WriteLine("Movimientos: " + movimientosI);
            Console.WriteLine("Fin ITERATIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("INICIO DEL RECURSIVO");


            Pila iniR = new Pila(recoleta);
            Pila auxR = new Pila();
            Pila finR = new Pila();
            imprimir(iniR, auxR, finR);

            int movimientosR = hanoi.recursivo(recoleta, iniR, finR, auxR);
            Console.WriteLine("Movimientos: " + movimientosR);
            Console.WriteLine("Fin RECURSIVO");
            Console.WriteLine("\n");
            Console.Read();
        }
    }
}