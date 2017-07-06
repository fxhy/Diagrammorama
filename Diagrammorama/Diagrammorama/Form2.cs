using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using SvgExporter = OxyPlot.SvgExporter;

namespace Diagrammorama
{
    public partial class Diagramm : Form
    {
        //private PlotModel Diagramme;
        public Diagramm(ChartySheen charty)
        {
            var chartyChart = charty;
            InitializeComponent();
            chartyChart.HerrGraph();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            plot1.Model = chartyChart.CharlesCharteten;
        }

        private void Diagramm_Load(object sender, EventArgs e)
        {
        }
      
        private void Speichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Image|*.pdf|PNG Image|*.png|SVG Image|*.svg";
            sfd.Title = "Diagramm Speichern";
            sfd.ShowDialog();
            if (sfd.FileName !="")
            {
                FileStream fs = (FileStream)sfd.OpenFile();
                switch (sfd.FilterIndex)
                {
                    case 1:
                        var pdfExporter = new PdfExporter { Width = 600, Height = 400 };
                        pdfExporter.Export(plot1.Model, fs);
                        break;
                    case 2:
                        var pngExporter = new PngExporter { Width = 600, Height = 400, Background = OxyColors.White };
                        pngExporter.Export(plot1.Model, fs);
                        break;
                    case 3:
                        var exporter = new SvgExporter { Width = 600, Height = 400 };
                        exporter.Export(plot1.Model, fs);
                        break;
                }
                fs.Close();
            }
        }
    }
}
