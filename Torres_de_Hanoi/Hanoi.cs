using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torres_de_Hanoi;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public int m = 0;
        public int extra = 0;
        public int nRR = 0;
      
        public void mover_disco(Pila a, Pila b)
        {
          
            if (a.Top == 0 || b.Top == 0)
            {
              
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

        public void imprimir(Pila ini, Pila aux, Pila fin)
        {

            Console.Write("Pila Inicial:  " + ini.Size + " Disco en la cima: " + ini.Top + " Estado: "); imprimirPila(ini);
            Console.Write("\n");
            Console.Write("Pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + " Estado: "); imprimirPila(aux);
            Console.Write("\n");
            Console.Write("Pila Final:    " + fin.Size + " Disco en la cima: " + fin.Top + " Estado: "); imprimirPila(fin);
            Console.Write("\n");
            Console.Write("\n");
        }
        public void imprimirPila(Pila p)
        {
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.Valor + " ");
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            nRR = n;
            int devolver;
            m = 0;
            if (n % 2 == 0)//par
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
            else//impar
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

