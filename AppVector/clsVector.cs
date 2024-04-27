using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;
        //constructor
        public clsVector() { 
        vector= new int [100];
        lg = 0;
        }
        //metodos (procedimiento y funciones)
        public void adicionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        // Longitud del vector
        public int longitud() {
            return lg;
        }
    }
}
