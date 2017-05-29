using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace Diagrammorama
{
    public class ChartySheen
    {
        public Chart CharlesCharteten = new Chart();
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
        public Chart HerrGraph()
        {
            DataTable Tabellerich = Tabelle;
            CharlesCharteten.DataSource = Tabellerich;

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
            }
            return CharlesCharteten;
        }
    }
}
