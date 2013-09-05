using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cola
{
    class Lista : ICola
    {
        private Nodo nodoInicial;
        
        private int tamanio;
        
        public Lista()
        {
            this.tamanio = 0;
            this.nodoInicial = new Nodo(null);
        }
        
        public bool IsEmpty { get { return ((int)this.nodoInicial.getDato() == -1); } }

        public int Size { get { return this.tamanio; } }

        public void Add(object item)
        { // agregar un item. 
            if (this.nodoInicial.getDato() == null)
            {
                this.nodoInicial = new Nodo(item);                
            }
            else
            {
                Nodo auxiliar = this.nodoInicial;
                while (auxiliar.getSiguiente() != null) 
                    auxiliar = auxiliar.getSiguiente();
                Nodo nuevo = new Nodo(item);
                auxiliar.setSiguiente(nuevo);                
            }
            this.tamanio++;
        }

        public object Top
        { // retornar el primer item, lanzar exception si esta vacio.        
            get
            {
                if (this.nodoInicial.getDato() == null) throw new InvalidOperationException();
                else return (object) this.nodoInicial.getDato();                                
            }            
        }

        public void Remove() // remover el primer item, lanzar exception si esta vacio.
        {
            if (this.nodoInicial.getDato() == null) throw new InvalidOperationException();
            else
            {
                this.nodoInicial = this.nodoInicial.getSiguiente();
                this.tamanio--;
            }
        } 
    }
}
