using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Diagrammorama
{
    public partial class Oxy : Form
    {
        private ChartySheen ChartyChart;
        public Oxy(ChartySheen ChartyChart)
        {
            InitializeComponent();
            ChartyChart.HerrGraph();
            //Diagramme = ChartyChart.CharlesCharteten;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            var pm = new PlotModel
            {
                Title = "Trigonometric functions",
                Subtitle = "Example using the FunctionSeries",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White
            };
            pm.Series.Add(new FunctionSeries(Math.Sin, -10, 10, 0.1, "sin(x)"));
            pm.Series.Add(new FunctionSeries(Math.Cos, -10, 10, 0.1, "cos(x)"));
            pm.Series.Add(new FunctionSeries(t => 5 * Math.Cos(t), t => 5 * Math.Sin(t), 0, 2 * Math.PI, 0.1, "cos(t),sin(t)"));
            plot1.Model = pm;
        }

        private void Oxy_Load(object sender, EventArgs e)
        {
            /*PlotView myPlot = new PlotView();
myPlot.Location = new Point(0, 0);
myPlot.Dock = DockStyle.Fill;
myPlot.Model = CreatePlotModel(prn);
            pm.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0 });
pm.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0 });

for (int i = 1; i < tab.Columns.Count; i++)
{
string serieName = tab.Columns[i].ColumnName;
LineSeries serie = new LineSeries();
if (serieName != "order")
{
for (int row = 1; row < tab.Rows.Count; row++)
{
double x = Convert.ToDouble( tab.Rows[row][tab.Columns[0].ColumnName]);
double y = Convert.ToDouble(tab.Rows[row][serieName]);
serie.Points.Add(new OxyPlot.DataPoint (x, y));

}
pm.Series.Add(serie);
}

}
return pm;

}*/
        }
    }
}
