using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    #region
    /*
    public sealed class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; internal set; }
        public Node<T> Previous { get; internal set; }
        public Node(T item)
        {
            this.Value = item;
        }
    }

    public sealed class CircularLinkedList<T> : ICollection<T>, IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public CircularLinkedList();
        public CircularLinkedList(IEnumerable<T> collection);
        public void AddLast(T item);
        public void AddFirstItem(T item);
        public void AddFirst(T item);
        public Node<T> Find(T item);
        protected Node<T> FindNode(Node<T> node, T valueToCompare);
        public bool Remove(T item);
        protected bool RemoveNode(Node<T> nodeToRemove);
    }
    */
    #endregion

    public class ListaCircular
    {
        class Nodo
        {
            public int info;
            public Nodo ant, sig;
        }

        private Nodo raiz;

        public ListaCircular()
        {
            raiz = null;
        }

        public void InsertarPrimero(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
                raiz = nuevo;
            }
        }

        public void InsertarUltimo(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
            }
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                do
                {
                    Console.Write(reco.info + "-");
                    reco = reco.sig;
                } while (reco != raiz);
                Console.WriteLine();
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            if (!Vacia())
            {
                Nodo reco = raiz;
                do
                {
                    cant++;
                    reco = reco.sig;
                } while (reco != raiz);
            }
            return cant;
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    if (Cantidad() == 1)
                    {
                        raiz = null;
                    }
                    else
                    {
                        Nodo ultimo = raiz.ant;
                        raiz = raiz.sig;
                        ultimo.sig = raiz;
                        raiz.ant = ultimo;
                    }
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 1; f++)
                        reco = reco.sig;
                    Nodo anterior = reco.ant;
                    reco = reco.sig;
                    anterior.sig = reco;
                    reco.ant = anterior;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaCircular lc = new ListaCircular();
            Console.WriteLine(lc.Vacia());
            lc.InsertarPrimero(100);
            lc.InsertarPrimero(45);
            lc.InsertarPrimero(12);
            lc.InsertarPrimero(4);
            Console.WriteLine("Luego de insertar 4 nodos al principio");
            lc.Imprimir();
            lc.InsertarUltimo(250);
            lc.InsertarUltimo(7);
            Console.WriteLine("Luego de insertar 2 nodos al final");
            lc.Imprimir();
            Console.WriteLine("Cantidad de nodos:" + lc.Cantidad());
            Console.WriteLine("Luego de borrar el de la primer posición:");
            lc.Borrar(1);
            lc.Imprimir();
            Console.WriteLine("Luego de borrar el de la cuarta posición:");
            lc.Borrar(4);
            lc.Imprimir();
            Console.WriteLine(lc.Vacia());
            Console.ReadKey();

        }
    }
}
