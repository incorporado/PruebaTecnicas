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
        
        public Lista(object item)
        {            
            this.tamanio = 0;
        }
        
        bool ICola.IsEmpty { get { return ((int)this.nodoInicial.getDato() == -1); } }

        int ICola.Size { get { return this.tamanio; } }

        void ICola.Add(object item)
        { // agregar un item. 
            if ((int)this.nodoInicial.getDato() == -1) this.nodoInicial = new Nodo(item);
            else
            {
                this.nodoInicial.getSiguiente().setDato(item);
                this.nodoInicial.getSiguiente().setSiguiente(-1);
            }
        }
        
        object ICola.Top
        { // retornar el primer item, lanzar exception si esta vacio.        
            get
            {
                 return (object) this.nodoInicial;                
            }            
        }

        void ICola.Remove() // remover el primer item, lanzar exception si esta vacio.
        {
            this.nodoInicial = this.nodoInicial.getSiguiente();
        } 
    }
}
