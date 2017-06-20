using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot;

namespace Diagrammi
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
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
    }
}
