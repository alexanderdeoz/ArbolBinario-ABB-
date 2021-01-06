using System;

namespace ArbolBinario
{
    public class Nodo
    {
        public Nodo hijoIzquierdo;
        public Nodo hijoDerecho;
        public int valor;

        // inicializamos hijos
        public Nodo() 
        {
            hijoIzquierdo = null;
            hijoDerecho = null;
            valor = 0;
        }
    }
}
