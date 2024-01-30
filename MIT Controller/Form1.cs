using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MIT_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Добавление нового графика
            Series series = chart1.Series.Add("New");

            // Добавление точек на график
            series.Points.AddXY(1, 1);
            series.Points.AddXY(2, 3);
            series.Points.AddXY(3, 7);

            // Настройка вида графика (тип, цвет и др.)
            series.ChartType = SeriesChartType.Line;
            series.Color = System.Drawing.Color.Blue;

            // Настройка осей
            chart1.ChartAreas[0].AxisX.Title = "X Axis";
            chart1.ChartAreas[0].AxisY.Title = "Y Axis";
        }
    }
}
