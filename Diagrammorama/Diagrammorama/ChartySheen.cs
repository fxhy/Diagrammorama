using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Diagrammorama
{
    public class ChartySheen
    {
        public PlotModel CharlesCharteten=new PlotModel();
        
        public string WhatsMyName;
        public string sub;

        //public Chart CharlesCharteten = new Chart();
        public string X_Achse;
        public List<string> Y_Achse=new List<string>();
        public DataTable Tabelle;
        public double uper;
        public double lower;
        public List<string> Legende = new List<string>();
        public ChartySheen(DataTable T)
        {
            Tabelle = T;
        }

        public void datamana(double high, double low)
        {
            DataView H = new DataView(Tabelle);
            H.RowFilter = X_Achse + " <= " + high;
            DataTable HTab = H.ToTable();
            DataView L = new DataView(HTab);
            L.RowFilter = X_Achse + " >= " + low;
            Tabelle = L.ToTable();
        }
        public PlotModel HerrGraph()
        {
            DataTable Tabellerich = Tabelle;
            LinearAxis AxelX = new LinearAxis();
            AxelX.Position = AxisPosition.Bottom;
            CharlesCharteten.Axes.Add(AxelX);
            LinearAxis AxelY = new LinearAxis();
            CharlesCharteten.Axes.Add(AxelY);

            List<DataPointSeries> Scotty = new List<DataPointSeries>();
            int found = 0;
            bool line = false;
        for (int i = 0; i < Tabellerich.Columns.Count; i++)
            {
                string serieName = Tabellerich.Columns[i].ColumnName;
                if ((Y_Achse.Contains(serieName)) && (serieName != X_Achse) && !(line))
                {
                    ScatterSeries RoundScotty = new ScatterSeries();
                    RoundScotty.Title = serieName;
                    RoundScotty.ItemsSource = Tabellerich.AsEnumerable();
                    RoundScotty.DataFieldX = X_Achse;
                    RoundScotty.DataFieldY = serieName;
                    /*CharlesCharteten.Series.Add(serieName);
                    //CharlesCharteten.Series[serieName].ChartType = SeriesChartType.FastLine;
                    for (int row = 1; row < Tabellerich.Rows.Count; row++)
                    {
                        Scotty[found].Points.Add(new OxyPlot.DataPoint(Convert.ToDouble(Tabellerich.Rows[row][X_Achse]), Convert.ToDouble(Tabellerich.Rows[row][serieName])));
                        //CharlesCharteten.Series[serieName].Points.AddXY
                        //  (Tabellerich.Rows[row][X_Achse], Tabellerich.Rows[row][serieName]);
                    }*/
                    CharlesCharteten.Series.Add(RoundScotty);
                    found++;
                }
                else if ((Y_Achse.Contains(serieName)) && (serieName != X_Achse) && (line))
                {
                    LineSeries SkinnyScotty = new LineSeries();
                    SkinnyScotty.Title = serieName;
                    SkinnyScotty.ItemsSource = Tabellerich.AsEnumerable();
                    SkinnyScotty.DataFieldX = X_Achse;
                    SkinnyScotty.DataFieldY = serieName;
                    CharlesCharteten.Series.Add(SkinnyScotty);
                    found++;
                }
            }
            return CharlesCharteten;
            /*CharlesCharteten.DataSource = Tabellerich;

            for (int i = 0; i < Tabellerich.Columns.Count; i++)
            {
                string serieName = Tabellerich.Columns[i].ColumnName;
                if ((Y_Achse.Contains(serieName)) & (serieName != X_Achse))
                {
                    CharlesCharteten.Series.Add(serieName);
                    CharlesCharteten.Series[serieName].ChartType = SeriesChartType.FastLine;
                    for (int row = 1; row < Tabellerich.Rows.Count; row++)
                    {
                        CharlesCharteten.Series[serieName].Points.AddXY
                            (Tabellerich.Rows[row][X_Achse], Tabellerich.Rows[row][serieName]);
                    }
                }
            }*/
        }
    }
}
