using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cola
{
    class Lista : ICola
    {
        bool IsEmpty { get; }
        int Size { get; }
        void Add(object item); // agregar un item.
        object Top { get; } // retornar el primer item, lanzar exception si esta vacio.
        void Remove(); // remover el primer item, lanzar exception si esta vacio.
    }
}
