using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices {
    public class RegistroMatriz {

        public int Fila1 { get; set; }
        public int Fila2 { get; set; }
        public double Multiplo { get; set; }
        public MatrizMath Matriz { get; set; }
        public Action<MatrizMath> Operacion { get; set; }

        public RegistroMatriz(MatrizMath matriz, int fila1, Delegate operacion, int fila2 = -1, double multiplo = 1)
        {
            Fila1 = fila1;
            Fila2 = fila2;
            Multiplo = multiplo;
            Matriz = CClone.CloneDeep(matriz);
            if(operacion.Method.Name == "OpElIntercambio") {
                Operacion = m => CMatrizCalc.OpElIntercambio(ref m.AumentadaFilas[Fila1], ref m.AumentadaFilas[Fila2]);
            } else if (operacion.Method.Name == "OpElSuma") {
                Operacion = m => CMatrizCalc.OpElSuma(ref m.AumentadaFilas[Fila1], ref m.AumentadaFilas[Fila2], multiplo);
            } else if (operacion.Method.Name == "OpElMultiplicar") {
                Operacion = m => CMatrizCalc.OpElMultiplicar(ref m.AumentadaFilas[Fila1], multiplo);
            }
        }
    }
}
