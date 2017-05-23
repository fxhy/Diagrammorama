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
        private ChartySheen Charty;
        private PRN_Reader PRN;
        private Diagramm dg;
        private Oxy o;
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
                PRN = new PRN_Reader(file);
                DataTable prnT = PRN.Tabelle();
                Anzeige.DataSource = prnT;
                //ein neues Objekt der ChartySheen Klasse wird erzeugt und die Datenquelle übergeben
                Charty = new ChartySheen(prnT);
                LB(prnT);

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
        private void LB(DataTable val)
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
            if ((LB_X.SelectedItem.ToString()!= null) & (Charty!=null))
            {
                Charty.X_Achse = LB_X.SelectedItem.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> graph = new List<string>();
            double L = Convert.ToDouble(Anfangswert.Text);
            double H = Convert.ToDouble(Endwert.Text);
            Charty.datamana(H, L);
            //übernehmen der ausgewählten Datenquellen für die Graphen
            Charty.Y_Achse.Clear();
            foreach (object itemChecked in LB_Y.CheckedItems)
            {
                Charty.Y_Achse.Add(itemChecked.ToString());
            }
            foreach  (int ind in LB_Y.CheckedIndices)
            {
                graph.Add(LB_G.Items[ind].ToString());
            }
            Charty.Legende = graph;
            dg = new Diagramm(Charty);
            dg.Show();
            o = new Oxy(Charty);
            o.Show();
            
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
