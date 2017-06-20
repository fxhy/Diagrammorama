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
    public partial class Diagramm : Form
    {
        //private PlotModel Diagramme;
        private ChartySheen ChartyChart;
        public Diagramm(ChartySheen charty, bool first)
        {
            ChartyChart = charty;
            this.InitializeComponent();
            ChartyChart.HerrGraph();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //Diagramme = ChartyChart.CharlesCharteten;
            if (first)
            {
                this.plot1.Model = ChartyChart.CharlesCharteten;
            }
            else
            {
                plot1.Update();
            }
        }

        private void Diagramm_Load(object sender, EventArgs e)
        {
        }
       /* public void Graph()
        {
            DataTable tab = ChartyChart.Tabelle;
            Diagramme.DataSource = tab;
            
            for (int i = 0; i < tab.Columns.Count; i++)
            {
                string serieName = tab.Columns[i].ColumnName;
                if ((ChartyChart.Y_Achse.Contains(serieName))&(serieName!=ChartyChart.X_Achse))
                {
                    Diagramme.Series.Add(serieName);
                    Diagramme.Series[serieName].ChartType = SeriesChartType.FastLine;
                    for (int row = 1; row < tab.Rows.Count; row++)
                    {
                        Diagramme.Series[serieName].Points.AddXY
                            (tab.Rows[row][ChartyChart.X_Achse], tab.Rows[row][serieName]);
                    }
                }
            }
        }*/

        private void Speichern_Click(object sender, EventArgs e)
        {
           /* SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            sfd.Title = "Diagramm Speichern";
            sfd.ShowDialog();
            if (sfd.FileName !="")
            {
                FileStream fs = (FileStream)sfd.OpenFile();
                switch (sfd.FilterIndex)
                {
                    case 1:
                        Diagramme.SaveImage(fs,ChartImageFormat.Jpeg);
                        break;
                    case 2:
                        Diagramme.SaveImage(fs, ChartImageFormat.Bmp);
                        break;
                    case 3:
                        Diagramme.SaveImage(fs, ChartImageFormat.Gif);
                        break;
                    case 4:
                        Diagramme.SaveImage(fs, ChartImageFormat.svg);
                        break;
                }
                fs.Close();
            }*/
        }
    }
}
