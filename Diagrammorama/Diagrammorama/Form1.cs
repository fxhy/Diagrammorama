using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;

namespace Diagrammorama
{
    public partial class Form1 : Form
    {
        private bool _check = false;
        private ChartySheen _charty;
        private PrnReader _prn;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Datei_Click(object sender, EventArgs e)
        {
            //es wird der Explorer geöffnet um eine prn datei auswählen zu können
            OpenFileDialog ofd = new OpenFileDialog {Filter = "Unterstützte Dateien (*.prn)|*.prn"};
            //datei wird überprüft
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _check =true;
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
            if (_check)
            {
                _charty.charterinos.Add(new PlotModel());
                var charterini = _charty.CharlesCharteten;
                //Überschrift übernehmen
                _charty.WhatsMyName = upperschrift.Text;
                //X-Achsen Überschrift übernehmen
                _charty.Axel = XTitle.Text;
                charterini.LegendPosition = (LegendPosition)GetIndex();
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
                foreach (int ind in LB_Y.CheckedIndices)
                {
                    graph.Add(LB_G.Items[ind].ToString());
                }
                _charty.Legende = graph;
                //Überschrift der Legende übernehmen
                charterini.LegendTitle = legUpperschrift.Text;
                //Legendenposition wählen
                if (rb_innen.Checked)
                {
                    charterini.LegendPlacement = LegendPlacement.Inside;
                }
                else
                {
                    charterini.LegendPlacement = LegendPlacement.Outside;
                }
                Diagramm dg = new Diagramm(_charty);
                dg.Show();
            }
            else
            {
                MessageBox.Show("Bitte Datei Laden!");
            }
        }

        private int GetIndex()
        {
            var checkedButton = panel_iAmLegend.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            switch (checkedButton.Name)
            {
                case "rb_topLeft":
                    return 0;
                case "rb_topCenter":
                    return 1;
                case "rb_topRight":
                    return 2;
                case "rb_bottomLeft":
                    return 3;
                case "rb_bottomCenter":
                    return 4;
                case "rb_bottomRight":
                    return 5;
                case "rb_leftMiddle":
                    return 7;
                case "rb_rightMiddle":
                    return 10;
                default:
                    return 2;

            }
        }

        private void GraphNeu_Click(object sender, EventArgs e)
        {
            LB_G.Items[LB_G.SelectedIndex]= graph_neu.Text;
        }
    }
}
