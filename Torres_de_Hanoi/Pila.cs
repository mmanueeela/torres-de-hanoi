using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */
        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        public Pila(int n)
        {
            Size = n;
            Elementos = new List<Disco>();
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                Elementos.Add(disco);
            }
            Top = Elementos.Last().Valor;

        }


        public void push(Disco d)
        {
            if (d == null)
            {
                Size = 0;
                Top = 0;
            }
            else
            {
                Elementos.Add(d);
                Size = Elementos.Count();
                Top = Elementos.Last().Valor;
            }


        }

        public Disco pop()
        {
            if (this.isEmpty() == false)
            {
                Disco topD = Elementos.Last();
                Elementos.Remove(topD);
                Size = Elementos.Count();
                if (Size == 0)
                {
                    Top = 0;
                }
                else
                {
                    Top = Elementos.Last().Valor;
                }
                return topD;

            }
            else { return null; }

        }

        public bool isEmpty()
        {
            if (Elementos.Count() == 0)
            {
                return true;
            }
            return false;
        }

    }
}
