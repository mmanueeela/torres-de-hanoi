using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        // Propiedad para almacenar el tamaño de la pila
        public int Size { get; set; }
        // Propiedad para almacenar el elemento superior de la pila
        public int Top { get; set; }

        // Lista para almacenar los elementos de la pila
        public List<Disco> Elementos { get; set; }

        /* Implementar métodos */

        // Constructor  de la clase Pila. Este constructor no toma ningún parámetro y se utiliza para inicializar una pila vacía.
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        // Constructor sobrecargado de la clase Pila. Se utiliza para inicializar una pila con un tamaño específico y,
        // opcionalmente, puede inicializar los elementos de la pila con valores específicos
        // (como en nuestro caso, donde se llenan con discos de tamaño decreciente).
        public Pila(int n)
        {
            Size = n;
            Elementos = new List<Disco>();

            // Llena la pila con discos de tamaño decreciente
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                Elementos.Add(disco);
            }

            // Establece el valor del elemento superior como el valor del último disco agregado
            Top = Elementos.Last().Valor;

        }

        // Método para agregar un disco a la pila
        public void push(Disco d)
        {
            // Verifica si el disco es nulo y si es establece el tamaño y el elemento superior como 0
            if (d == null)
            {
                Size = 0;
                Top = 0;
            }
            else
            {
                // Agrega el disco a la lista de elementos
                Elementos.Add(d);

                // Actualiza el tamaño de la pila
                Size = Elementos.Count();

                // Actualiza el elemento superior de la pila
                Top = Elementos.Last().Valor;
            }


        }

        // Método para eliminar y devolver el disco superior de la pila
        public Disco pop()
        {
            // Verifica si la pila no está vacía
            if (this.isEmpty() == false)
            {
                // Obtiene el disco superior de la pila
                Disco topD = Elementos.Last();

                // Elimina el disco superior de la pila
                Elementos.Remove(topD);

                // Actualiza el tamaño de la pila
                Size = Elementos.Count();

                // Si está vacía, establece el elemento superior como 0
                if (Size == 0)
                {
                    Top = 0;
                }
                else
                {
                    // Si no está vacía, actualiza el elemento superior de la pila
                    Top = Elementos.Last().Valor;
                }

                // Devuelve el disco superior eliminado
                return topD;

            }
            // Si la pila está vacía, devuelve null
            else { return null; }

        }

        // Método para verificar si la pila está vacía
        public bool isEmpty()
        {
            // Devuelve verdadero si la lista de elementos está vacía, de lo contrario, devuelve falso
            if (Elementos.Count() == 0)
            {
                return true;
            }
            return false;
        }

    }
}
