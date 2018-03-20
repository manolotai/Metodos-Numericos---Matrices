namespace Matrices {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.@__PanelMain = new System.Windows.Forms.Panel();
            this.@__PanelTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.@__PanelTbl1 = new System.Windows.Forms.TableLayoutPanel();
            this.@__PanelTbl2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.@__BtnCalcular = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.@__TxtNxN = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.@__LblTiempoJacobiR = new System.Windows.Forms.Label();
            this.@__LblIteracionesJacobiR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.@__LblTiempoGaussR = new System.Windows.Forms.Label();
            this.@__LblIteracionesGaussR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.@__LblPolinomio = new System.Windows.Forms.Label();
            this.@__PanelPuntosMain = new System.Windows.Forms.Panel();
            this.@__BtnInterpolacion = new System.Windows.Forms.Button();
            this.@__TxtNPuntos = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.@__TSMMetodos = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMItemGaussJordan = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMItemInversa = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMItemJacobiSeidel = new System.Windows.Forms.ToolStripMenuItem();
            this.@__PanelMain.SuspendLayout();
            this.@__PanelTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.@__PanelTbl1.SuspendLayout();
            this.@__PanelTbl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // __PanelMain
            // 
            this.@__PanelMain.Controls.Add(this.@__PanelTab);
            this.@__PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelMain.Location = new System.Drawing.Point(0, 24);
            this.@__PanelMain.Name = "__PanelMain";
            this.@__PanelMain.Size = new System.Drawing.Size(727, 477);
            this.@__PanelMain.TabIndex = 0;
            // 
            // __PanelTab
            // 
            this.@__PanelTab.Controls.Add(this.tabPage1);
            this.@__PanelTab.Controls.Add(this.tabPage2);
            this.@__PanelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTab.Location = new System.Drawing.Point(0, 0);
            this.@__PanelTab.Name = "__PanelTab";
            this.@__PanelTab.SelectedIndex = 0;
            this.@__PanelTab.Size = new System.Drawing.Size(727, 477);
            this.@__PanelTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.@__PanelTbl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // __PanelTbl1
            // 
            this.@__PanelTbl1.ColumnCount = 1;
            this.@__PanelTbl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.@__PanelTbl1.Controls.Add(this.@__PanelTbl2, 0, 0);
            this.@__PanelTbl1.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.@__PanelTbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTbl1.Location = new System.Drawing.Point(3, 3);
            this.@__PanelTbl1.Name = "__PanelTbl1";
            this.@__PanelTbl1.RowCount = 2;
            this.@__PanelTbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.@__PanelTbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.@__PanelTbl1.Size = new System.Drawing.Size(713, 445);
            this.@__PanelTbl1.TabIndex = 0;
            // 
            // __PanelTbl2
            // 
            this.@__PanelTbl2.ColumnCount = 4;
            this.@__PanelTbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.@__PanelTbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.@__PanelTbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTbl2.Controls.Add(this.label1, 0, 0);
            this.@__PanelTbl2.Controls.Add(this.label2, 1, 0);
            this.@__PanelTbl2.Controls.Add(this.label3, 2, 0);
            this.@__PanelTbl2.Controls.Add(this.label4, 3, 0);
            this.@__PanelTbl2.Controls.Add(this.@__BtnCalcular, 0, 2);
            this.@__PanelTbl2.Controls.Add(this.panel2, 1, 2);
            this.@__PanelTbl2.Controls.Add(this.panel5, 3, 2);
            this.@__PanelTbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTbl2.Location = new System.Drawing.Point(0, 0);
            this.@__PanelTbl2.Margin = new System.Windows.Forms.Padding(0);
            this.@__PanelTbl2.Name = "__PanelTbl2";
            this.@__PanelTbl2.RowCount = 3;
            this.@__PanelTbl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTbl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.@__PanelTbl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTbl2.Size = new System.Drawing.Size(713, 311);
            this.@__PanelTbl2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solucion";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Solucion";
            // 
            // __BtnCalcular
            // 
            this.@__BtnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.@__BtnCalcular.Location = new System.Drawing.Point(111, 282);
            this.@__BtnCalcular.Name = "__BtnCalcular";
            this.@__BtnCalcular.Size = new System.Drawing.Size(62, 25);
            this.@__BtnCalcular.TabIndex = 4;
            this.@__BtnCalcular.Text = "Calcular";
            this.@__BtnCalcular.UseVisualStyleBackColor = true;
            this.@__BtnCalcular.Click += new System.EventHandler(this.@__BtnCalcular_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.@__TxtNxN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(285, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 32);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tamaño";
            // 
            // __TxtNxN
            // 
            this.@__TxtNxN.Location = new System.Drawing.Point(14, 13);
            this.@__TxtNxN.Name = "__TxtNxN";
            this.@__TxtNxN.Size = new System.Drawing.Size(45, 20);
            this.@__TxtNxN.TabIndex = 0;
            this.@__TxtNxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.@__TxtNxN.TextChanged += new System.EventHandler(this.@__TxtNxN_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(641, 279);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 32);
            this.panel5.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cifras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 311);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.@__LblTiempoJacobiR);
            this.panel3.Controls.Add(this.@__LblIteracionesJacobiR);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 134);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tiempo";
            // 
            // __LblTiempoJacobiR
            // 
            this.@__LblTiempoJacobiR.AutoSize = true;
            this.@__LblTiempoJacobiR.Location = new System.Drawing.Point(199, 88);
            this.@__LblTiempoJacobiR.Name = "__LblTiempoJacobiR";
            this.@__LblTiempoJacobiR.Size = new System.Drawing.Size(16, 13);
            this.@__LblTiempoJacobiR.TabIndex = 5;
            this.@__LblTiempoJacobiR.Text = "...";
            // 
            // __LblIteracionesJacobiR
            // 
            this.@__LblIteracionesJacobiR.AutoSize = true;
            this.@__LblIteracionesJacobiR.Location = new System.Drawing.Point(199, 49);
            this.@__LblIteracionesJacobiR.Name = "__LblIteracionesJacobiR";
            this.@__LblIteracionesJacobiR.Size = new System.Drawing.Size(16, 13);
            this.@__LblIteracionesJacobiR.TabIndex = 4;
            this.@__LblIteracionesJacobiR.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Iteraciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jacobi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.@__LblTiempoGaussR);
            this.panel4.Controls.Add(this.@__LblIteracionesGaussR);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(356, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 134);
            this.panel4.TabIndex = 1;
            // 
            // __LblTiempoGaussR
            // 
            this.@__LblTiempoGaussR.AutoSize = true;
            this.@__LblTiempoGaussR.Location = new System.Drawing.Point(166, 88);
            this.@__LblTiempoGaussR.Name = "__LblTiempoGaussR";
            this.@__LblTiempoGaussR.Size = new System.Drawing.Size(16, 13);
            this.@__LblTiempoGaussR.TabIndex = 4;
            this.@__LblTiempoGaussR.Text = "...";
            // 
            // __LblIteracionesGaussR
            // 
            this.@__LblIteracionesGaussR.AutoSize = true;
            this.@__LblIteracionesGaussR.Location = new System.Drawing.Point(166, 49);
            this.@__LblIteracionesGaussR.Name = "__LblIteracionesGaussR";
            this.@__LblIteracionesGaussR.Size = new System.Drawing.Size(16, 13);
            this.@__LblIteracionesGaussR.TabIndex = 3;
            this.@__LblIteracionesGaussR.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tiempo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Iteraciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gauss-Seidel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polinomio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.@__LblPolinomio);
            this.panel1.Controls.Add(this.@__PanelPuntosMain);
            this.panel1.Controls.Add(this.@__BtnInterpolacion);
            this.panel1.Controls.Add(this.@__TxtNPuntos);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 445);
            this.panel1.TabIndex = 0;
            // 
            // __LblPolinomio
            // 
            this.@__LblPolinomio.AutoSize = true;
            this.@__LblPolinomio.Location = new System.Drawing.Point(31, 423);
            this.@__LblPolinomio.Name = "__LblPolinomio";
            this.@__LblPolinomio.Size = new System.Drawing.Size(16, 13);
            this.@__LblPolinomio.TabIndex = 4;
            this.@__LblPolinomio.Text = "...";
            // 
            // __PanelPuntosMain
            // 
            this.@__PanelPuntosMain.AutoScroll = true;
            this.@__PanelPuntosMain.Location = new System.Drawing.Point(34, 123);
            this.@__PanelPuntosMain.Name = "__PanelPuntosMain";
            this.@__PanelPuntosMain.Size = new System.Drawing.Size(201, 228);
            this.@__PanelPuntosMain.TabIndex = 3;
            // 
            // __BtnInterpolacion
            // 
            this.@__BtnInterpolacion.Location = new System.Drawing.Point(93, 375);
            this.@__BtnInterpolacion.Name = "__BtnInterpolacion";
            this.@__BtnInterpolacion.Size = new System.Drawing.Size(72, 24);
            this.@__BtnInterpolacion.TabIndex = 2;
            this.@__BtnInterpolacion.Text = "Interpolar";
            this.@__BtnInterpolacion.UseVisualStyleBackColor = true;
            this.@__BtnInterpolacion.Click += new System.EventHandler(this.@__BtnInterpolacion_Click);
            // 
            // __TxtNPuntos
            // 
            this.@__TxtNPuntos.Location = new System.Drawing.Point(84, 67);
            this.@__TxtNPuntos.Name = "__TxtNPuntos";
            this.@__TxtNPuntos.Size = new System.Drawing.Size(92, 20);
            this.@__TxtNPuntos.TabIndex = 1;
            this.@__TxtNPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.@__TxtNPuntos.TextChanged += new System.EventHandler(this.@__TxtNPuntos_TextChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(253, 122);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Polinomio";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Puntos";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(455, 230);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__TSMMetodos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // __TSMMetodos
            // 
            this.@__TSMMetodos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__TSMItemGaussJordan,
            this.@__TSMItemInversa,
            this.@__TSMItemJacobiSeidel});
            this.@__TSMMetodos.Name = "__TSMMetodos";
            this.@__TSMMetodos.Size = new System.Drawing.Size(66, 20);
            this.@__TSMMetodos.Text = "Metodos";
            // 
            // __TSMItemGaussJordan
            // 
            this.@__TSMItemGaussJordan.Checked = true;
            this.@__TSMItemGaussJordan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.@__TSMItemGaussJordan.Name = "__TSMItemGaussJordan";
            this.@__TSMItemGaussJordan.Size = new System.Drawing.Size(152, 22);
            this.@__TSMItemGaussJordan.Text = "Gauss-Jordan";
            this.@__TSMItemGaussJordan.Click += new System.EventHandler(this.@__TSMItemGaussJordan_Click);
            // 
            // __TSMItemInversa
            // 
            this.@__TSMItemInversa.Name = "__TSMItemInversa";
            this.@__TSMItemInversa.Size = new System.Drawing.Size(152, 22);
            this.@__TSMItemInversa.Text = "Inversa";
            this.@__TSMItemInversa.Click += new System.EventHandler(this.@__TSMItemInversa_Click);
            // 
            // __TSMItemJacobiSeidel
            // 
            this.@__TSMItemJacobiSeidel.Name = "__TSMItemJacobiSeidel";
            this.@__TSMItemJacobiSeidel.Size = new System.Drawing.Size(152, 22);
            this.@__TSMItemJacobiSeidel.Text = "Jacobi y Seidel";
            this.@__TSMItemJacobiSeidel.Click += new System.EventHandler(this.@__TSMItemJacobiSeidel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 501);
            this.Controls.Add(this.@__PanelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Matrices - Angel Emmanuel Ruiz Alcaraz";
            this.@__PanelMain.ResumeLayout(false);
            this.@__PanelTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.@__PanelTbl1.ResumeLayout(false);
            this.@__PanelTbl2.ResumeLayout(false);
            this.@__PanelTbl2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel __PanelMain;
        private System.Windows.Forms.TableLayoutPanel __PanelTbl1;
        private System.Windows.Forms.TableLayoutPanel __PanelTbl2;
        private System.Windows.Forms.TabControl __PanelTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button __BtnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button __BtnInterpolacion;
        private System.Windows.Forms.TextBox __TxtNPuntos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel __PanelPuntosMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox __TxtNxN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label __LblTiempoJacobiR;
        private System.Windows.Forms.Label __LblIteracionesJacobiR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label __LblTiempoGaussR;
        private System.Windows.Forms.Label __LblIteracionesGaussR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label __LblPolinomio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem __TSMMetodos;
        private System.Windows.Forms.ToolStripMenuItem __TSMItemGaussJordan;
        private System.Windows.Forms.ToolStripMenuItem __TSMItemInversa;
        private System.Windows.Forms.ToolStripMenuItem __TSMItemJacobiSeidel;
    }
}

