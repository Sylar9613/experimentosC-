using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conferencia_4_Estruc.Datos
{
    public sealed class NodeSE<T>
    {
        public T Value { get; private set; }
        public NodeSE<T> Next { get; internal set; }
        public NodeSE(T item)
        {
            this.Value = item;
        }
    }

    public sealed class CListaSE<Tipo> 
    {
        NodeSE<Tipo> ptr_cabeza = null;

        public int Longitud()
        {
            int longitud = 0;
            NodeSE<Tipo> cursor = ptr_cabeza;

            while (cursor != null)
            {
                longitud++;
                cursor = cursor.Next;
            }
            return longitud;
        }

        public void Adicionar(Tipo x)
        {
            NodeSE<Tipo> nodo = new NodeSE<Tipo>(x);
            nodo.Next = null;
            NodeSE<Tipo> cursor = ptr_cabeza;

            if (ptr_cabeza == null)
            {
                ptr_cabeza = nodo;
            }
            else
            {
                cursor = ptr_cabeza;
                while (cursor.Next != null)
                {
                    cursor = cursor.Next;
                }
                cursor.Next = nodo;
            }
        }

        public void Insertar(int pos, NodeSE<Tipo> miNodo)
        {
            if (pos < 1 || pos > Longitud()) throw new Exception("Posición no válida.");

            if (pos==1)
            {
                miNodo.Next = ptr_cabeza;
                ptr_cabeza = miNodo;
            }
            else
            {
                NodeSE<Tipo> cursor = ptr_cabeza;
                int pos_cursor = 1;
                while (cursor!=null&&(pos_cursor+1)!=pos)
                {
                    pos_cursor++;
                    cursor = cursor.Next;
                }
                miNodo.Next = cursor.Next;
                cursor.Next = miNodo;
            }

        }

        public void Eliminar(int pos)
        {
            if (pos < 1 || pos > Longitud()) throw new Exception("Posición no válida.");

            NodeSE<Tipo> cursor = ptr_cabeza;
            if (pos==1)
            {
                ptr_cabeza = cursor.Next;
                cursor = null;
            }
            else
            {
                NodeSE<Tipo> anterior = ptr_cabeza;
                int pos_cursor = 1;

                while (cursor!=null&&pos_cursor!=pos)
                {
                    anterior = cursor;
                    cursor = cursor.Next;
                    pos_cursor++;
                }

                anterior.Next = cursor.Next;
                cursor.Next = null;
                cursor = null;
            }
        }

        public void Mostrar(int pos)
        {            
            if (pos < 1 || pos > Longitud()) throw new Exception("Posición no válida.");

            else
            {
                
                NodeSE<Tipo> cursor = ptr_cabeza;

                for (int i = 1; i <= pos; i++)
                {
                    cursor=cursor.Next;
                }
                Console.WriteLine(cursor);
                
            }
                
        }

    }
    class Program
    {      
        static void Main(string[] args)
        {
            CListaSE<string> listSingle = new CListaSE<string>();
            NodeSE<string> nodo1 = new NodeSE<string>("Ya ");
            NodeSE<string> nodo2 = new NodeSE<string>(" sé ");
            NodeSE<string> nodo3 = new NodeSE<string>(" trabajar ");
            NodeSE<string> nodo4 = new NodeSE<string>(" con ");
            NodeSE<string> nodo5 = new NodeSE<string>(" la ");
            NodeSE<string> nodo6 = new NodeSE<string>(" lista ");
            NodeSE<string> nodo7 = new NodeSE<string>(" simplemente ");
            NodeSE<string> nodo8 = new NodeSE<string>(" enlazada.");

            listSingle.Adicionar("Ya ");
            listSingle.Adicionar(" sé ");
            listSingle.Adicionar(" trabajar ");
            listSingle.Adicionar(" con ");
            listSingle.Adicionar(" la ");
            listSingle.Adicionar(" lista ");
            listSingle.Adicionar(" simplemente ");
            listSingle.Adicionar(" enlazada.");

            Console.WriteLine(listSingle.Longitud() + "\n");

            listSingle.Eliminar(3);
            listSingle.Eliminar(5);
            listSingle.Eliminar(6);

            Console.WriteLine(listSingle.Longitud() + "\n");

            listSingle.Adicionar("Veamos como sale");
            listSingle.Adicionar("Veamos!");
            
            Console.WriteLine(listSingle.Longitud() + "\n");

            listSingle.Mostrar(4);

            
        }
    }
}
