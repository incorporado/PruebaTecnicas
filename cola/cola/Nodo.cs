using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cola
{
    class Nodo
    {
        object dato;
        private Nodo siguiente;

        public void setDato (object dato) { this.dato = dato;}
        public void setSiguiente(Nodo nuevo) { this.siguiente = nuevo;}
        public object getDato () { return this.dato;}
        public Nodo getSiguiente () { return this.siguiente;}
        public Nodo(object dato)
        {
            this.dato = dato;
            this.siguiente = null;            
        }
    }
}
