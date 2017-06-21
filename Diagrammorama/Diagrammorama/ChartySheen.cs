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
        public string Sub;

        //public Chart CharlesCharteten = new Chart();
        public string XAchse;
        public List<string> YAchse=new List<string>();
        public DataTable Tabelle;
        public double Upper;
        public double Lower;
        public List<string> Legende = new List<string>();
        public ChartySheen(DataTable T)
        {
            Tabelle = T;
        }
        //Min. und Max. werden festgelegt
        public void Datamana(double high, double low)
        {
            DataView h = new DataView(Tabelle);
            h.RowFilter = XAchse + " <= " + high;
            DataTable hTab = h.ToTable();
            DataView l = new DataView(hTab);
            l.RowFilter = XAchse + " >= " + low;
            Tabelle = l.ToTable();
        }


        public void HerrGraph()
        {
            DataTable tabellerich = Tabelle;

            LinearAxis axelX = new LinearAxis();
            axelX.Position = AxisPosition.Bottom;
            CharlesCharteten.Axes.Add(axelX);

            LinearAxis axelY = new LinearAxis();
            CharlesCharteten.Axes.Add(axelY);
            CharlesCharteten.Series.Clear();

            int found = 0;
            List<LineSeries> addy = new List<LineSeries>();

            for (int i = 0; i < tabellerich.Columns.Count; i++)
            {
                string serieName = tabellerich.Columns[i].ColumnName;
                if ((YAchse.Contains(serieName)) && (serieName != XAchse))
                {
                    addy.Add (new LineSeries());
                    addy[found].Title = serieName;
                    for (int row = 1; row < tabellerich.Rows.Count; row++)
                    {
                        addy[found].Points.Add(new OxyPlot.DataPoint(Convert.ToDouble(tabellerich.Rows[row][XAchse]), Convert.ToDouble(tabellerich.Rows[row][serieName])));
                    }
                    CharlesCharteten.Series.Add(addy[found]);
                    found++;
                }
            }
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
