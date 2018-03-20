using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using System.Collections;
using System.Reflection;

using Jace;

namespace Matrices {

    public partial class Form1 : Form {
        private struct CoordText {
            public RichTextBox X;
            public RichTextBox Y;

            public CoordText(RichTextBox x, RichTextBox y)
            {
                X = x;
                Y = y;
            }
        }

        private RichTextBox[,] __TxtMatriz;
        private RichTextBox[] __TxtMatrizSolucion;
        private TableLayoutPanel __PanelTblMatriz;
        private TableLayoutPanel __PanelTblMatrizSolucion;

        private RichTextBox[,] __TxtMatrizR;
        private RichTextBox[] __TxtMatrizSolucionR;
        private TableLayoutPanel __PanelTblMatrizR;
        private TableLayoutPanel __PanelTblMatrizSolucionR;

        private TableLayoutPanel __PanelTblPuntos;
        private List<CoordText> __TxtPuntosList;

        public Form1()
        {
            InitializeComponent();
            MyInitcomponents();
            //var t = new MatrizMath(new double[,] {
            //    { 2, 1 },
            //    { 5, 7 } }, new double[] { 11, 13 });
            //CMatrizCalc.GaussSeidel(t, new double[]{1, 1}, 7);
            //var list = new List<Point> {
            //    new Point(-1, -3),
            //    new Point(0, -2),
            //    new Point(1, 0),
            //    new Point(2, 2)
            //};
        }

        private void MyInitcomponents()
        {
            __TxtNxN.Text = "" + 3;
            __TxtNPuntos.Text = "" + 4;
            textBox1.Text = "" + 7;

            InitMatriz(3);
            InitiLista(4);
        }

        public void InitMatriz(int n)
        {
            if (__PanelTblMatriz != null) {
                __PanelTblMatriz.Dispose();
                __PanelTblMatrizR.Dispose();
                __PanelTblMatrizSolucion.Dispose();
                __PanelTblMatrizSolucionR.Dispose();
            }

            var genericCell = new RichTextBox() {
                TabIndex = 0,
                Name = "__TxtCell",
                AutoSize = false,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.None,
                Multiline = false,
                Location = new Point(0, 0)
            };

            var genericCellR = new RichTextBox() {
                TabIndex = 0,
                Name = "__TxtCell",
                AutoSize = false,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.None,
                Multiline = false,
                Location = new Point(0, 0),
                Enabled = false
            };

            __PanelTblMatriz = GenerarPnlTbl(n, n, "__PanelTblMatriz");
            __PanelTblMatrizR = GenerarPnlTbl(n, n, "__PanelTblMatrizR");
            __PanelTblMatrizSolucion = GenerarPnlTbl(1, n, "__PanelTblMatrizSolucion");
            __PanelTblMatrizSolucionR = GenerarPnlTbl(1, n, "__PanelTblMatrizSolucionR");

            __PanelTbl2.Controls.Add(__PanelTblMatriz, 0, 1);
            __PanelTbl2.Controls.Add(__PanelTblMatrizR, 2, 1);
            __PanelTbl2.Controls.Add(__PanelTblMatrizSolucion, 1, 1);
            __PanelTbl2.Controls.Add(__PanelTblMatrizSolucionR, 3, 1);

            __TxtMatriz = DefinirMatriz(n, n, genericCell);
            __TxtMatrizR = DefinirMatriz(n, n, genericCellR);
            __TxtMatrizSolucion = DefinirArreglo(n, genericCell);
            __TxtMatrizSolucionR = DefinirArreglo(n, genericCellR);

            for (int y = 0; y < n; y++) {
                for (int x = 0; x < n; x++) {
                    __PanelTblMatriz.Controls.Add(__TxtMatriz[y, x], x, y);
                    __PanelTblMatrizR.Controls.Add(__TxtMatrizR[y, x], x, y);
                }
                __PanelTblMatrizSolucion.Controls.Add(__TxtMatrizSolucion[y], 1, y);
                __PanelTblMatrizSolucionR.Controls.Add(__TxtMatrizSolucionR[y], 1, y);
            }
        }

        public void InitiLista(int n)
        {
            if (__PanelTblPuntos != null) {
                __PanelTblPuntos.Dispose();
            }

            var genericCell = new RichTextBox() {
                TabIndex = 0,
                Name = "__TxtCell",
                AutoSize = false,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.None,
                Multiline = false,
                Location = new Point(0, 0)
            };
            __PanelTblPuntos = GenerarPnlTbl(2, n, "__PanelTblPuntos");
            __PanelTblPuntos.Dock = DockStyle.Top;
            __PanelPuntosMain.Controls.Add(__PanelTblPuntos);
            __TxtPuntosList = new List<CoordText>();

            for (int i = 0; i < n; i++) {
                __TxtPuntosList.Add(new CoordText((RichTextBox)CloneControlForm(genericCell),
                (RichTextBox)CloneControlForm(genericCell)));
                __TxtPuntosList.Last().X.AutoSize = true;
                __TxtPuntosList.Last().Y.AutoSize = true;
                //__PanelTblPuntos.RowStyles.Insert(i, new RowStyle(SizeType.Absolute));
                //__PanelTblPuntos.RowStyles.RemoveAt(i + 1);
                __PanelTblPuntos.Controls.Add(__TxtPuntosList.Last().X, 0, i);
                __PanelTblPuntos.Controls.Add(__TxtPuntosList.Last().Y, 1, i);
            }
        }

        //Auxiliares
        private TableLayoutPanel GenerarPnlTbl(int columnas, int filas, string name = "")
        {
            var pnlTbl = new TableLayoutPanel() {
                Name = name,
                TabIndex = 0,
                Visible = true,
                Dock = DockStyle.Fill,
                RowCount = filas,
                ColumnCount = columnas,
                Margin = new Padding(0)
            };

            for (int i = 0; i < filas; i++) {
                pnlTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / filas));
            }
            for (int i = 0; i < columnas; i++) {
                pnlTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnas));
            }

            return pnlTbl;
        }

        //public T TextConvertOrDefault<T>()
        //{

        //}

        public T[,] DefinirMatriz<T> (int columnas, int filas, T inicializador) where T: Control
        {
            var matriz = new T[filas, columnas];

            for (int y = 0; y < columnas; y++) {
                for (int x = 0; x < filas; x++) {
                    matriz[y, x] = (T)CloneControlForm(inicializador);
                    matriz[y, x].Name += String.Format("{0}_{1}", y, x);
                }
            }

            return matriz;
        }

        public T[] DefinirArreglo<T>(int celdas, T inicializador) where T : Control
        {
            var matriz = new T[celdas];

            for (int i = 0; i < celdas; i++) {
                matriz[i] = (T)CloneControlForm(inicializador);
                matriz[i].Name += String.Format("{0}", i);

            }
            return matriz;
        }

        public Control CloneControlForm(Control ctrl)
        {
            string ctrlName = ctrl.GetType().Name;
            string ctrlSpace = ctrl.GetType().Namespace;
            Hashtable propList = new Hashtable();

            Type typeControl = ctrl.GetType().Assembly.GetType(ctrlSpace + "." + ctrlName);
            Control newCtrl = (Control)Activator.CreateInstance(typeControl);

            //Type typeControl = Assembly.LoadWithPartialName(ctrlSpace).GetType(ctrlSpace + "." + ctrlName); //Alternativa obsoleta
            //Control newCtrl = (Control)Activator.CreateInstance(typeControl);

            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(ctrl)) {
                try {
                    if (p.PropertyType.IsSerializable)
                        propList.Add(p.Name, p.GetValue(ctrl));
                } catch (Exception) {}
            }

            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(newCtrl)) {
                if (propList.Contains(p.Name)) {
                    Object obj = propList[p.Name];
                    try {
                        p.SetValue(newCtrl, obj);
                    } catch (Exception) {}
                }
            }
            return newCtrl;
        }

        public T CloneDeep<T>(T fuente)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("El tipo de dato debe ser serializable", "fuente");
            if (Object.ReferenceEquals(fuente, null))
                return default(T);

            using (var stream = new MemoryStream()) {
                IFormatter formato = new BinaryFormatter();
                formato.Serialize(stream, fuente);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formato.Deserialize(stream);
            }
        }
        
        //Evenetos
        private void __BtnCalcular_Click(object sender, EventArgs e)
        {
            try {
                var lengthX = __TxtMatriz.GetLength(1);
                var lengthY = __TxtMatriz.GetLength(0);

                for (int y = 0; y < lengthY; y++) {
                    for (int x = 0; x < lengthX; x++) {
                        __TxtMatrizR[y, x].Text = "";
                    }
                    __TxtMatrizSolucionR[y].Text = "";
                }

                var matriz = new double[lengthY, lengthX];
                var solucion = new double[lengthY];
                for (int y = 0; y < lengthY; y++) {
                    for (int x = 0; x < lengthX; x++) {
                        matriz[y, x] = Convert.ToDouble(__TxtMatriz[y, x].Text);
                    }
                    solucion[y] = Convert.ToDouble(__TxtMatrizSolucion[y].Text);
                    //solucion[y] = __TxtMatrizSolucion[y].Text != "" ? Convert.ToDouble(__TxtMatrizSolucion[y].Text) : 0;//para solcuion de auxiliar converter
                }

                if (__TSMItemGaussJordan.Checked) {
                    var matrizR = CMatrizCalc.GaussJordan(new MatrizMath(matriz, solucion));
                    for (int y = 0; y < lengthY; y++) {
                        for (int x = 0; x < lengthX; x++) {
                            __TxtMatrizR[y, x].Text = "" + matrizR.Matriz.AumentadaFilas[y].Coeficientes[x];
                        }
                        __TxtMatrizSolucionR[y].Text = "" + matrizR.Matriz.AumentadaFilas[y].Solucion;
                    }
                } else if (__TSMItemInversa.Checked) {
                    var matrizR = CMatrizCalc.Inversa(new MatrizMath(matriz));
                    for (int y = 0; y < lengthY; y++) {
                        for (int x = 0; x < lengthX; x++) {
                            __TxtMatrizR[y, x].Text = "" + matrizR.AumentadaFilas[y].Coeficientes[x];
                        }
                    }
                } else if(__TSMItemJacobiSeidel.Checked){
                    var vectorInicial = new double[lengthY];

                    var jacobiR = CMatrizCalc.Jacobi(new MatrizMath(matriz, solucion), vectorInicial, Convert.ToInt16(textBox1.Text));
                    var seidelR = CMatrizCalc.GaussSeidel(new MatrizMath(matriz, solucion), vectorInicial, Convert.ToInt16(textBox1.Text));

                    for (int y = 0; y < lengthY; y++) {
                        __TxtMatrizSolucionR[y].Text = "" + seidelR.Valor[y];
                    }

                    __LblIteracionesJacobiR.Text = "" + jacobiR.Iteraciones;
                    __LblIteracionesGaussR.Text = "" + seidelR.Iteraciones;

                    var tJ = jacobiR.Tiempo;
                    var tS = seidelR.Tiempo;
                    __LblTiempoJacobiR.Text = String.Format("{0}min {1}seg {2}ms {3}ts", tJ.Minutes, tJ.Seconds, tJ.Milliseconds, tJ.Ticks);
                    __LblTiempoGaussR.Text = String.Format("{0}min {1}seg {2}ms {3}ts", tS.Minutes, tS.Seconds, tS.Milliseconds, tS.Ticks);
                }
                
            } catch (Exception) { }
        }

        private void __BtnInterpolacion_Click(object sender, EventArgs e)
        {
            try {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                var conjuntoPuntos = __TxtPuntosList.Select(
                    v => {
                        chart1.Series[1].Points.AddXY(Convert.ToDouble(v.X.Text), Convert.ToDouble(v.Y.Text));
                        return new Point(Convert.ToInt32(v.X.Text), Convert.ToInt32(v.Y.Text));
                    }).ToList();

                var solucion = CMatrizCalc.InterpolacionPolinomica(conjuntoPuntos);
                string polinomio = "";
                for (int i = 0; i < solucion.Length; i++) {
                    var exceptionE = solucion[i].ToString().Contains('E') ? 
                        String.Format("{0:F9}", solucion[i]) : solucion[i].ToString();
                    polinomio += String.Format("{2}{0}*x^{1}  ", exceptionE, 
                        (solucion.Length - 1) - i, solucion[i] >= 0 ? "+" : "");
                }

                __LblPolinomio.Text = polinomio.TrimStart('+');
                var fPolinomio = (Func<double, double>)new CalculationEngine()
                    .Formula(polinomio.TrimStart('+'))
                    .Parameter("x", DataType.FloatingPoint)
                    .Result(DataType.FloatingPoint)
                    .Build();

                
                double lengthMax = conjuntoPuntos.Max(p => p.X);
                double lengthMin = conjuntoPuntos.Min(p => p.X);
                double incremento = Math.Abs(lengthMax - lengthMin) / 500;

                for (double i = lengthMin; i <= lengthMax; i += incremento != 0 ? incremento : 1) {
                    chart1.Series[0].Points.AddXY(i, fPolinomio(i));
                }
            } catch { }
        }

        private void __TxtNxN_TextChanged(object sender, EventArgs e)
        {
            try {
                InitMatriz(Convert.ToInt16(__TxtNxN.Text));
            } catch { }
        }

        private void __TxtNPuntos_TextChanged(object sender, EventArgs e)
        {
            try {
                InitiLista(Convert.ToInt16(__TxtNPuntos.Text));
            } catch { }
        }

        private void __TSMItemGaussJordan_Click(object sender, EventArgs e)
        {
            var items = __TSMMetodos.DropDownItems.GetEnumerator();
            while (items.MoveNext()) {
                var p = (ToolStripMenuItem)items.Current;
                p.Checked = p.Text.Equals("Gauss-Jordan") ? true : false;
            }
        }

        private void __TSMItemInversa_Click(object sender, EventArgs e)
        {
            var items = __TSMMetodos.DropDownItems.GetEnumerator();
            while (items.MoveNext()) {
                var p = (ToolStripMenuItem)items.Current;
                p.Checked = p.Text.Equals("Inversa") ? true : false;
            }
        }

        private void __TSMItemJacobiSeidel_Click(object sender, EventArgs e)
        {
            var items = __TSMMetodos.DropDownItems.GetEnumerator();
            while (items.MoveNext()) {
                    var p = (ToolStripMenuItem)items.Current;
                    p.Checked = p.Text.Equals("Jacobi y Seidel") ? true : false;
            }
        }
    }
}
