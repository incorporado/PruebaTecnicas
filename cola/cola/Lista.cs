using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cola
{
    class Lista : ICola
    {
        private Nodo nodoInicial;

        private Nodo iterador;
        
        private int tamanio;
        
        public Lista()
        {            
            this.tamanio = 0;            
        }
        
        public bool IsEmpty { get { return (this.nodoInicial.getDato() == null); } }

        public int Size { get { return this.tamanio; } }

        public void Add(object item)
        { // agregar un item.            
            try
            {
                this.nodoInicial.getDato();
                try
                {
                    this.iterador.getSiguiente().getDato();
                }
                catch (NullReferenceException e)
                {
                    Nodo nuevo = new Nodo(item);
                    this.iterador.setSiguiente(nuevo);
                    this.iterador = this.iterador.getSiguiente();
                }
            }
            catch (NullReferenceException e)
            {
                this.nodoInicial = new Nodo(item);
                this.iterador = this.nodoInicial;
            }           

            this.tamanio++;
        }

        public object Top
        { // retornar el primer item, lanzar exception si esta vacio.        
            get
            {
                try
                {
                    return (object) this.nodoInicial.getDato();                                
                }
                catch (NullReferenceException e)
                {
                    throw new InvalidOperationException();
                }                
            }            
        }

        public void Remove() // remover el primer item, lanzar exception si esta vacio.
        {
            try
            {
                this.nodoInicial = this.nodoInicial.getSiguiente();
                this.tamanio--;   
            }
            catch (NullReferenceException e)
            {
                throw new InvalidOperationException();
            }           
        } 
    }
}
