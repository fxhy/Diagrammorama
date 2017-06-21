using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Diagrammorama
{
    public partial class Form1 : Form
    {
        private ChartySheen _charty;
        private PrnReader _prn;
        private bool _f = true;
        //private Diagramm dg;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Datei_Click(object sender, EventArgs e)
        {
            //es wird der Explorer geöffnet um eine prn datei auswählen zu können
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Unterstützte Dateien (*.prn)|*.prn";
            //datei wird überprüft
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                Dateipfad.Text = file;
                //ein objekt der PRN_Reader Klasse wird erzeugt und der Dateipfad übergeben
                _prn = new PrnReader(file);
                DataTable prnT = _prn.Tabelle();
                Anzeige.DataSource = prnT;
                //ein neues Objekt der ChartySheen Klasse wird erzeugt und die Datenquelle übergeben
                _charty = new ChartySheen(prnT);
                Lb(prnT);

                var minRow = prnT.Select(prnT.Columns[0].ColumnName + " = MIN(" + prnT.Columns[0].ColumnName + ")")[0];
                var maxRow = prnT.Select(prnT.Columns[0].ColumnName+ " = MAX("+ prnT.Columns[0].ColumnName +")")[0];
                Endwert.Text = Convert.ToString(maxRow[0]);
                Anfangswert.Text = Convert.ToString( minRow[0]);
                /*PlotView myPlot = new PlotView();
                myPlot.Location = new Point(0, 0);
                myPlot.Dock = DockStyle.Fill;
                myPlot.Model = CreatePlotModel(prn);*/
            }

        }
        //die auswahl boxen werden mit iformationen versorgt
        private void Lb(DataTable val)
        {
            for (int i = 0; i < val.Columns.Count; i++)
            {
                
                LB_X.Items.Add(val.Columns[i].ColumnName);
                LB_X.SelectedIndex = 0;
                LB_Y.Items.Add(val.Columns[i].ColumnName);
                LB_Y.SetItemChecked(i, true);
                LB_G.Items.Add(val.Columns[i].ColumnName);

            }
        }
        //auswahl der Datenquelle für die x-Achse
        private void LB_X_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((LB_X.SelectedItem.ToString()!= null) & (_charty!=null))
            {
                _charty.XAchse = LB_X.SelectedItem.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> graph = new List<string>();
            double l = Convert.ToDouble(Anfangswert.Text);
            double h = Convert.ToDouble(Endwert.Text);
            _charty.Datamana(h, l);
            //übernehmen der ausgewählten Datenquellen für die Graphen
            _charty.YAchse.Clear();
            foreach (object itemChecked in LB_Y.CheckedItems)
            {
                _charty.YAchse.Add(itemChecked.ToString());
            }
            foreach  (int ind in LB_Y.CheckedIndices)
            {
                graph.Add(LB_G.Items[ind].ToString());
            }
            _charty.Legende = graph;
            Diagramm dg = new Diagramm(_charty,_f);
            dg.Show();
            _f = false;
        }

        private void GraphNeu_Click(object sender, EventArgs e)
        {
            LB_G.Items[LB_G.SelectedIndex]= graph_neu.Text;
        }
        /* public PlotModel CreatePlotModel(DataTable tab)
{
PlotModel MyModel = new PlotModel();
MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0 });
MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0 });

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
MyModel.Series.Add(serie);
}

}
return MyModel;

}*/
    }
}
