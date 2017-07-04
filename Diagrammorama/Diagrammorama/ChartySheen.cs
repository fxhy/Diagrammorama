using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Diagrammorama
{
    public class ChartySheen
    {
        public List<PlotModel> charterinos=new List<PlotModel>();

        public PlotModel CharlesCharteten
        {
            get { return charterinos.Last(); }
        }


        public string WhatsMyName;
        public string Sub;

        public string XAchse;
        public List<string> YAchse=new List<string>();
        public DataTable Tabelle;
        public double Upper;
        public double Lower;
        public List<string> Legende = new List<string>();
        public ChartySheen(DataTable T)
        {
            Tabelle = T;
            charterinos.Add(new PlotModel());
        }
        //Min. und Max. werden festgelegt
        public void Datamana(double high, double low)
        {
            var h = new DataView(Tabelle) {RowFilter = XAchse + " <= " + high};
            var hTab = h.ToTable();
            var l = new DataView(hTab) {RowFilter = XAchse + " >= " + low};
            Tabelle = l.ToTable();
        }


        public void HerrGraph()
        {
            var tabellerich = Tabelle;

            var axelX = new LinearAxis {Position = AxisPosition.Bottom};
            CharlesCharteten.Axes.Add(axelX);

            var axelY = new LinearAxis();
            CharlesCharteten.Axes.Add(axelY);
            CharlesCharteten.Series.Clear();

            var found = 0;
            var addy = new List<LineSeries>();

            for (var i = 0; i < tabellerich.Columns.Count; i++)
            {
                var serieName = tabellerich.Columns[i].ColumnName;
                if ((!YAchse.Contains(serieName)) || (serieName == XAchse)) continue;
                var who = YAchse.IndexOf(serieName);
                addy.Add (new LineSeries());
                addy[found].Title = Legende[who];
                for (var row = 1; row < tabellerich.Rows.Count; row++)
                {
                    addy[found].Points.Add(new OxyPlot.DataPoint(Convert.ToDouble(tabellerich.Rows[row][XAchse]), Convert.ToDouble(tabellerich.Rows[row][serieName])));
                }
                CharlesCharteten.Series.Add(addy[found]);
                found++;
            }
        }
    }
}
