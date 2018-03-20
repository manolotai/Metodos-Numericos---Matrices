using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices {
    [Serializable]
    public class MatrizMath {
        public ArregloEc[] AumentadaFilas { get; set; }     //Almacenamiento

        public int LengthF {                                //Referencias: 
            get => AumentadaFilas[0].Coeficientes.Length;
        }

        public int LengthC {
            get => AumentadaFilas.Length;
        }

        public double DetCofactores {
            get {
                var ordenCeros = CoeficientesF.OrderByDescending(p => p.Count((q => q == 0))).ToArray();
                return IsCuadrada ? DetCofactor(ordenCeros) : 0;
            }
        }

        public bool IsCuadrada {
            get => LengthC == LengthF;
        }

        public bool IsDiagonalDominante {
            get => IsCuadrada ? Diagonal.Zip(DiagonalResto,
                (p, q) => Math.Abs(p.Sum()) > q.Sum(c => Math.Abs(c))).All(p => true) : false;
        }

        public double[] Solucion {
            get => AumentadaFilas.Select(p => p.Solucion).ToArray();
            set {
                for (int i = 0; i < AumentadaFilas.Length; i++) {
                    AumentadaFilas[i].Solucion = value[i]; 
                }
            }
        }
        public double[][] CoeficientesF {
            get => AumentadaFilas.Select(p => p.Coeficientes).ToArray();
        }

        public double[][] CoeficientesC {//Trabajar despues en el set para cramer
            get => AumentadaFilas.First().Coeficientes.Select( 
                (p, i) => AumentadaFilas.Select(q => q.Coeficientes[i]).ToArray()).ToArray();
        }

        public double[][] Diagonal {
            get => IsCuadrada ? AumentadaFilas.Select(
                    (p, y) => p.Coeficientes.Select((q, x) => x == y ? q : 0).ToArray()).ToArray() :
                null;
        }

        public double[][] DiagonalResto {
            get => IsCuadrada ? AumentadaFilas.Select(
                    (p, y) => p.Coeficientes.Select((q, x) => x != y ? q : 0).ToArray()).ToArray() :
                null;
        }


        //Constructores
        public MatrizMath(double[,] matriz, double[] matrizSolucion = null)
        {
            double[] tempArr = new double[matriz.GetLength(1)];
            AumentadaFilas = new ArregloEc[matriz.GetLength(0)];

            for (int y = 0; y < matriz.GetLength(0); y++) {
                for (int x = 0; x < matriz.GetLength(1); x++) {
                    tempArr[x] = matriz[y, x];//ajustado a la definicion natural [,]
                }
                AumentadaFilas[y] = matrizSolucion == null ?
                    new ArregloEc(tempArr.ToArray()) : 
                    new ArregloEc(tempArr.ToArray(), matrizSolucion[y]);
            }
        }

        public MatrizMath(double[][] matriz, double[] matrizSolucion = null)
        {
            if (matriz.All(p => p.Length == matriz[0].Length)) {
                double[] tempArr = new double[matriz[0].Length];
                AumentadaFilas = new ArregloEc[matriz.Length];

                for (int y = 0; y < matriz.Length; y++) {
                    for (int x = 0; x < matriz[0].Length; x++) {
                        tempArr[x] = matriz[y][x];
                    }
                    AumentadaFilas[y] = matrizSolucion == null ?
                        new ArregloEc(tempArr.ToArray()) :
                        new ArregloEc(tempArr.ToArray(), matrizSolucion[y]);
                }
            } else throw new Exception("La matriz debe ser almenos rectangular.");
        }

        //Metodos
        private static double DetCofactor(double[][] matriz)
        {
            double determinante = 0;

            if (matriz.Length == 1) {
                return matriz[0][0];
            } else {
                for (int i = 0, signo = 1; i < matriz.Length; i++, signo *= -1) {
                    if (matriz[0][i] != 0) {
                        var m = matriz.Skip(1).Select(p => p.Where((q, idx) => idx != i).ToArray()).ToArray();
                        determinante += signo * matriz[0][i] * DetCofactor(m);
                    }
                }
                return determinante;
            }
        }


        //Operadores
        public static MatrizMath operator +(MatrizMath matriz1, MatrizMath matriz2)
        {
            if (matriz1.LengthC != matriz2.LengthC || matriz1.LengthF != matriz2.LengthF)
                return null;
            double[] sumaR = new double[matriz1.LengthC];
            double[,] suma = new double[matriz1.LengthC, matriz1.LengthF];

            for (int y = 0; y < matriz1.LengthC; y++) {
                for (int x = 0; x < matriz1.LengthF; x++) {
                    suma[y, x] = 
                        matriz1.AumentadaFilas[y].Coeficientes[x] 
                        + matriz2.AumentadaFilas[y].Coeficientes[x];
                }
                sumaR[y] = matriz1.Solucion[y] + matriz2.Solucion[y];
            }

            return new MatrizMath(suma, sumaR);
        }

        public static MatrizMath operator -(MatrizMath matriz1, MatrizMath matriz2)
        {
            if (matriz1.LengthC != matriz2.LengthC || matriz1.LengthF != matriz2.LengthF)
                return null;
            double[] restaR = new double[matriz1.LengthC];
            double[,] resta = new double[matriz1.LengthC, matriz1.LengthF];

            for (int y = 0; y < matriz1.LengthC; y++) {
                for (int x = 0; x < matriz1.LengthF; x++) {
                    resta[y, x] =
                        matriz1.AumentadaFilas[y].Coeficientes[x]
                        - matriz2.AumentadaFilas[y].Coeficientes[x];
                }
                restaR[y] = matriz1.Solucion[y] - matriz2.Solucion[y];
            }

            return new MatrizMath(resta, restaR);
        }

        public static MatrizMath operator*(MatrizMath matriz1, MatrizMath matriz2)
        {
            if (matriz1.LengthC != matriz2.LengthF)
                return null;

            var productoMatriz = matriz1.CoeficientesF.Select(
                f => matriz2.CoeficientesC.Select(
                    c => f.Zip(c, (p, q) => p * q).Sum())
                    .ToArray()).ToArray();
            return new MatrizMath(productoMatriz);
        }
        public static MatrizMath operator *(MatrizMath matriz1, double[][] matriz2)
        {
            if (matriz1.LengthC != matriz2[0].Length)
                return null;
            var matrizClm = new MatrizMath(matriz2).CoeficientesC;

            var productoMatriz = matriz1.CoeficientesF.Select(
                f => matrizClm.Select(
                    c => f.Zip(c, (p, q) => p * q).Sum())
                    .ToArray()).ToArray();
            return new MatrizMath(productoMatriz);
        }

        public static MatrizMath operator *(MatrizMath matriz1, double[] matriz2)
        {
            if (matriz1.LengthC != matriz2.Length)
                return null;
            var matrizClm = new double[][] { matriz2 };

            var productoMatriz = matriz1.CoeficientesF.Select(
                f => matrizClm.Select(
                    c => f.Zip(c, (p, q) => p * q).Sum())
                    .ToArray()).ToArray();
            return new MatrizMath(productoMatriz);
        }
    }
}
