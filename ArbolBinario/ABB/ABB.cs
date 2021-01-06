using System;
using ArbolBinario;

namespace ABB
{
    public class ABB
    {
        public Nodo raiz;

        //metodo insertar 
        public ABB() {
            raiz = null;
        }

        public void insertar() {
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else 
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
            }
        }
    }
}
