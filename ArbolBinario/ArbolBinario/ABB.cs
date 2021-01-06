using System;
using ArbolBinario;
namespace ABB
{
    public class ABB
    {
        public Nodo raiz;

        public ABB() 
        {
            raiz = null;
        }
        // insertar 
        public void insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.hijoIzquierdo = null;
                nuevo.hijoDerecho = null;


                // encaso la raiz no se null y recorrer  el aBB  de busqueda y reconocer dodne insertar el nuevo valor
                Nodo anterior = null, recorrer;
                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (valor < recorrer.valor)
                    {
                        recorrer = recorrer.hijoDerecho;
                    }
                    else
                    {
                        recorrer = recorrer.hijoIzquierdo;

                    }
                }
                if (valor < anterior.valor)
                {
                    anterior.hijoDerecho = nuevo;
                }
                else
                {
                    anterior.hijoIzquierdo = nuevo;
                }
            }
        }
        // mostrar arbol preorden 
        public void PreOrden(Nodo raiz)
        {
            Console.WriteLine(raiz.valor);
            //comprobar que los hijos no sean nulos
            if (raiz.hijoIzquierdo != null)
            {
                PreOrden(raiz.hijoIzquierdo);
            }
            if (raiz.hijoDerecho !=null)
            {
                PreOrden(raiz.hijoDerecho);
            }
        }
        // recorrer abb enorden
        public void EnOrden(Nodo raiz)
        {
            if (raiz.hijoIzquierdo != null)
            
                EnOrden(raiz.hijoIzquierdo);
                Console.WriteLine(raiz.valor);
            
            if (raiz.hijoDerecho != null)
            
                EnOrden(raiz.hijoDerecho);
              
            
        }
        // metodo motrar en post orden
        public void PostOrden(Nodo raiz)
        {
            if (raiz.hijoIzquierdo != null)
            
                PostOrden(raiz.hijoIzquierdo);
            
            if (raiz.hijoDerecho != null)
            
                PostOrden(raiz.hijoDerecho);
            
            Console.WriteLine(raiz.valor);
        }
    }
}
