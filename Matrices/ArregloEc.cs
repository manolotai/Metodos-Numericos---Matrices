using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices {
    [Serializable]
    public class ArregloEc {
        public double[] Coeficientes { get; set; }  //Almacenamiento:
        public double Solucion { get; set; }
        public double[] Aumentado {                 //referencia:
            get { return Coeficientes.Concat(new double[] { Solucion }).ToArray(); }
            set { Coeficientes = value.Take(value.Length - 1).ToArray();
                Solucion = value.Last(); }
        }
        public int Pivote {
            get { int pivote = Coeficientes.ToList().FindIndex(p => p != 0);
                return pivote >= 0 ? pivote : Coeficientes.Length; }
        }
        public double PivoteValor {
            get { return Coeficientes[Pivote]; }
            set { Coeficientes[Pivote] = value; }
        }

        public ArregloEc(double[] coeficientes, double solucion = 0 )
        {
            Coeficientes = coeficientes;
            Solucion = solucion;
        }

        //Operadores
        public static ArregloEc operator +(ArregloEc a, double[] b ) {
            return new ArregloEc(b.Take(b.Length - 1).ToArray(), b.Last());
        }

        public static ArregloEc operator +(ArregloEc a, double b){
            return new ArregloEc(a.Coeficientes.ToArray(), b);
        }
    }
}
