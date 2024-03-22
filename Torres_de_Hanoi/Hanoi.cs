using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torres_de_Hanoi; // Importa la clase Pila del mismo namespace

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        // Variables para contar el número de movimientos y otras utilidades
        public int m = 0;
        public int extra = 0;
        public int nRR = 0;

        /* TODO: Implementar métodos */

        // Método para mover un disco de una pila a otra
        public void mover_disco(Pila a, Pila b)
        {
            // Comprueba si una de las pilas está vacía
            if (a.Top == 0 || b.Top == 0)
            {
                // Mueve el disco de la pila no vacía a la pila vacía
                if (a.Top < b.Top)
                {
                    a.push(b.pop());
                    m = m + 1;
                }
                else
                {
                    b.push(a.pop());
                    m = m + 1;
                }
                Console.WriteLine("Movimientos: " + m);
            }
            else
            {
                // Mueve el disco de la pila con el disco más pequeño a la otra pila
                if (a.Top > b.Top)
                {
                    a.push(b.pop());
                    m = m + 1;
                }
                else
                {
                    b.push(a.pop());
                    m = m + 1;
                }
                Console.WriteLine("Movimientos: " + m);
            }
        }

        // Método para imprimir el estado de las tres pilas
        public void imprimir(Pila ini, Pila aux, Pila fin)
        {
            Console.Write("Pila Inicial:  " + ini.Size + " Disco en la cima: " + ini.Top + " Estado: ");
            imprimirPila(ini);
            Console.Write("\n");
            Console.Write("Pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + " Estado: ");
            imprimirPila(aux);
            Console.Write("\n");
            Console.Write("Pila Final:    " + fin.Size + " Disco en la cima: " + fin.Top + " Estado: ");
            imprimirPila(fin);
            Console.Write("\n\n");
        }

        // Método para imprimir los elementos de una pila
        public void imprimirPila(Pila p)
        {
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.Valor + " ");
            }
        }

        // Método para resolver el problema de las Torres de Hanoi de manera iterativa
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            // Inicializar variables
            nRR = n;
            int devolver;
            m = 0;

            // Algoritmo para resolver el problema iterativamente
            if (n % 2 == 0) // Si el número de discos es par
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    imprimir(ini, aux, fin);

                    mover_disco(ini, fin);
                    imprimir(ini, aux, fin);

                    mover_disco(aux, fin);
                    imprimir(ini, aux, fin);
                }
            }
            else // Si el número de discos es impar
            {
                while (aux.Size != n)
                {
                    mover_disco(ini, fin);
                    imprimir(ini, aux, fin);

                    if (fin.Size == n)
                    {
                        devolver = m;
                        m = 0;
                        return devolver;
                    }

                    mover_disco(ini, aux);
                    imprimir(ini, aux, fin);

                    mover_disco(aux, fin);
                    imprimir(ini, aux, fin);
                }
            }
            devolver = m;
            m = 0;
            return devolver;
        }

        // Método para resolver el problema de las Torres de Hanoi de manera recursiva
        public int recursivo(int nR, Pila iniR, Pila finR, Pila auxR)
        {
            if (nR == 1)
            {
                mover_disco(iniR, finR);
                imprimir(iniR, auxR, finR);
            }
            else
            {
                recursivo(nR - 1, iniR, auxR, finR);
                mover_disco(iniR, finR);
                imprimir(iniR, auxR, finR);
                recursivo(nR - 1, auxR, finR, iniR);
            }
            extra = extra + 1;
            return m;
        }
    }
}

