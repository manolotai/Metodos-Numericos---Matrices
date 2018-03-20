using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Matrices {
    public class CMatrizCalc {

        private delegate void DelOpElMultiplicar(ref ArregloEc fila, double c);
        private delegate void DelOpElIntercambio(ref ArregloEc fila1, ref ArregloEc fila2);
        private delegate void DelOpElSuma(ref ArregloEc fila, ref ArregloEc sumando, double c = 1);
        public struct Result{
            public MatrizMath Matriz;
            public List<RegistroMatriz> Registo;
            public Result(MatrizMath matriz, List<RegistroMatriz> registro)
            {
                Matriz = matriz;
                Registo = registro;
            }
        }

        public struct ExtendR<T> {
            public T Valor;
            public int Iteraciones;
            public TimeSpan Tiempo;
            public ExtendR(T valor, int iteraciones, TimeSpan tiempo)
            {
                Valor = valor;
                Iteraciones = iteraciones;
                Tiempo = tiempo;
            }
        }

        public static Result Gauss(MatrizMath matriz)
        {
            var newMatriz = CClone.CloneDeep(matriz);

            bool ciclo = true;
            List<RegistroMatriz> registro = new List<RegistroMatriz>();
            
            while (ciclo) {
                ciclo = false;
                for (int i = 0; i < newMatriz.LengthC - 1; i++) {
                    ref var p = ref newMatriz.AumentadaFilas[i];
                    ref var q = ref newMatriz.AumentadaFilas[i + 1];
                    if (p.Pivote > q.Pivote) {
                        registro.Add(new RegistroMatriz(newMatriz, i, new DelOpElIntercambio(OpElIntercambio), i + 1));
                        OpElIntercambio(ref p, ref q);
                        ciclo = true;
                    }
                }

                for (int i = 0; i < newMatriz.LengthC - 1; i++) {
                    ref var p = ref newMatriz.AumentadaFilas[i];

                    for (int j = i + 1; j < newMatriz.LengthC; j++) {
                        ref var q = ref newMatriz.AumentadaFilas[j];
                        if (q.Pivote == p.Pivote) {
                            double multiplo = -(q.PivoteValor / p.PivoteValor);
                            registro.Add(new RegistroMatriz(newMatriz, j, new DelOpElSuma(OpElSuma), i, multiplo));
                            OpElSuma(ref q, ref p, multiplo);
                            ciclo = true;
                        }
                    }
                }
            }

            return new Result(newMatriz, registro);
        }

        public static Result GaussJordan(MatrizMath matriz)
        {
            var jordan = Gauss(matriz);
            for (int i = 0; i < matriz.LengthF; i++) {
                ref var p = ref jordan.Matriz.AumentadaFilas[i];

                for (int j = 0; j < matriz.LengthF; j++) {
                    ref var q = ref jordan.Matriz.AumentadaFilas[j];
                    var qValor = q.Coeficientes[p.Pivote];
                    if (i != j && qValor != 0) {
                        double multiplo = -(qValor / p.PivoteValor);
                        jordan.Registo.Add(new RegistroMatriz(jordan.Matriz, j, new DelOpElSuma(OpElSuma), i, multiplo));
                        OpElSuma(ref q, ref p, multiplo);
                    }
                }
            }
            for (int i = 0; i < matriz.LengthC; i++) {
                ref var p = ref jordan.Matriz.AumentadaFilas[i];
                var multiplo = 1 / p.PivoteValor;
                jordan.Registo.Add(new RegistroMatriz(jordan.Matriz, i, new DelOpElMultiplicar(OpElMultiplicar), multiplo: multiplo));
                OpElMultiplicar(ref p, multiplo);
            }

            return new Result(jordan.Matriz, jordan.Registo);
        }

        public static MatrizMath Inversa(MatrizMath matriz)
        {
            if (matriz.DetCofactores != 0) {
                var matrizGauss = GaussJordan(matriz);
                MatrizMath identidad = MatrizIdentidad(matriz.LengthF);

                matrizGauss.Registo.ForEach(p => p.Operacion(identidad));
                return identidad;
            } else { return null; }
        }

        public static ExtendR<double[]> Jacobi(MatrizMath matriz, double[] vectorInicial, int confianza)
        {
            if (matriz.LengthC != vectorInicial.Length)
                throw new Exception("El vector inicial debe ser igual a la cantidad de filas de la matriz.");
            if (!matriz.IsDiagonalDominante)
                throw new Exception("La matriz debe ser diagonalmente dominante.");

            Stopwatch time = new Stopwatch();
            double tolerancia = 0.5 * Math.Pow(10, 2 - confianza);
            Func<double[], double[], double> eVerd =
                (mV, mA) => Math.Sqrt(
                    mV.Zip(mA, (p, q) => Math.Pow(p - q, 2)).Sum());
            
            MatrizMath x;
            MatrizMath mJordan = GaussJordan(matriz).Matriz;
            MatrizMath mIDiagonal = Inversa(new MatrizMath(matriz.Diagonal));
            int iteracion = 0;
            var iDxB = mIDiagonal * matriz.Solucion;
            var iDxR = mIDiagonal * matriz.DiagonalResto;
            //double[] vAnt;    //posiblemente para no usar gauss-jordan

            time.Start();
            do {
                //vAnt = vectorInicial;
                x = iDxB - iDxR * vectorInicial;  //x(i+1) = D^-1 * b  - D^-1 * R * xi//Revisar para simplicifcar D^-1(b-RX)
                vectorInicial = x.CoeficientesC[0];
                iteracion++;
            } while (eVerd(mJordan.Solucion, x.CoeficientesC[0]) >= tolerancia);
            time.Stop();

            return new ExtendR<double[]>(x.CoeficientesC[0], iteracion, time.Elapsed);
        }

        public static ExtendR<double[]> GaussSeidel(MatrizMath matriz, double[] vectorInicial, int confianza)
        {
            if (matriz.LengthC != vectorInicial.Length)
                throw new Exception("El vector inicial debe ser igual a la cantidad de filas de la matriz.");
            if (!matriz.IsDiagonalDominante)
                throw new Exception("La matriz debe ser diagonalmente dominante.");

            Stopwatch time = new Stopwatch();
            double tolerancia = 0.5 * Math.Pow(10, 2 - confianza);
            Func<double[], double[], double> eVerd =
                (mV, mA) => Math.Sqrt(
                    mV.Zip(mA, (p, q) => Math.Pow(p - q, 2)).Sum());

            int iteracion = 0;
            var mSolucion = matriz.Solucion;
            var mDiagonalR = matriz.DiagonalResto;
            MatrizMath mJordan = GaussJordan(matriz).Matriz;
            double[] vecIDiagonal = matriz.Diagonal.Select(p => 1 / p.First(q => q != 0)).ToArray();

            time.Start();
            do {
                for (int i = 0; i < vectorInicial.Length; i++) {
                    vectorInicial[i] = (mSolucion[i] 
                        - vectorInicial.Zip(mDiagonalR[i], (x, r) => r * x).Sum()) * vecIDiagonal[i];
                }
                iteracion++;
            } while (eVerd(mJordan.Solucion, vectorInicial) >= tolerancia);
            time.Stop();

            return new ExtendR<double[]>(vectorInicial, iteracion, time.Elapsed);
        }

        public static double[] InterpolacionPolinomica(List<System.Drawing.Point> paresP)
        {
            int length = paresP.Count;
            double[,] doubleMatriz = new double[length, length];
            //generar polinomio de grado n-1, n = paresP
            for (int y = 0; y < length; y++) {
                for (int x = 0; x < length; x++) {
                    doubleMatriz[y, (length - 1) - x] = Math.Pow(paresP[y].X, x);
                }
            }

            MatrizMath matriz = new MatrizMath(doubleMatriz, paresP.Select(p => (double)p.Y).ToArray());
            return (Inversa(matriz) * matriz.Solucion).CoeficientesC[0];
        }

        public static MatrizMath MatrizIdentidad(int dimension)
        {
            var identi = new double[dimension, dimension];
            identi.Initialize();
            for (int y = 0; y < identi.GetLength(0); y++) {
                for (int x = 0; x < identi.GetLength(1); x++) {
                    identi[y, x] = x == y ? 1 : 0;
                }
            }
            return new MatrizMath(identi);
        }

        //Metodos por referencia
        public static void OpElMultiplicar(ref ArregloEc fila, double c)
        {
            fila += fila.Aumentado.Select(p => p * c).ToArray();
        }
        public static void OpElIntercambio(ref ArregloEc fila1, ref ArregloEc fila2)
        {
            var c = CClone.CloneDeep(fila1);
            fila1 = CClone.CloneDeep(fila2);
            fila2 = c;
        }
        public static void OpElSuma(ref ArregloEc fila, ref ArregloEc sumando, double c = 1)
        {
            fila += fila.Aumentado.Zip(sumando.Aumentado, (p, q) => p + q * c).ToArray();
        }
    }
}
