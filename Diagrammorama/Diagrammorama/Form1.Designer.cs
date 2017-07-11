namespace Diagrammorama
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datei = new System.Windows.Forms.Button();
            this.Dateipfad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Graphen = new System.Windows.Forms.GroupBox();
            this.GraphNeu = new System.Windows.Forms.Button();
            this.graph_neu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_G = new System.Windows.Forms.ListBox();
            this.LB_Y = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Endwert = new System.Windows.Forms.TextBox();
            this.Anfangswert = new System.Windows.Forms.TextBox();
            this.LB_X = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ToExcel = new System.Windows.Forms.Button();
            this.Anzeige = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Legendenposition = new System.Windows.Forms.Panel();
            this.rb_innen = new System.Windows.Forms.RadioButton();
            this.rb_aussen = new System.Windows.Forms.RadioButton();
            this.legUpperschrift = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_iAmLegend = new System.Windows.Forms.Panel();
            this.rb_rightMiddle = new System.Windows.Forms.RadioButton();
            this.rb_leftMiddle = new System.Windows.Forms.RadioButton();
            this.rb_bottomRight = new System.Windows.Forms.RadioButton();
            this.rb_bottomCenter = new System.Windows.Forms.RadioButton();
            this.rb_bottomLeft = new System.Windows.Forms.RadioButton();
            this.rb_topRight = new System.Windows.Forms.RadioButton();
            this.rb_topCenter = new System.Windows.Forms.RadioButton();
            this.rb_topLeft = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.upperschrift = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Graphen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anzeige)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Legendenposition.SuspendLayout();
            this.panel_iAmLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datei
            // 
            this.Datei.Location = new System.Drawing.Point(9, 10);
            this.Datei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Datei.Name = "Datei";
            this.Datei.Size = new System.Drawing.Size(116, 19);
            this.Datei.TabIndex = 0;
            this.Datei.Text = "Datei hinzufügen";
            this.Datei.UseVisualStyleBackColor = true;
            this.Datei.Click += new System.EventHandler(this.Datei_Click);
            // 
            // Dateipfad
            // 
            this.Dateipfad.Location = new System.Drawing.Point(138, 9);
            this.Dateipfad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dateipfad.Name = "Dateipfad";
            this.Dateipfad.Size = new System.Drawing.Size(194, 20);
            this.Dateipfad.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Änderungen übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(560, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.Graphen);
            this.groupBox2.Controls.Add(this.LB_Y);
            this.groupBox2.Location = new System.Drawing.Point(159, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Achse";
            // 
            // Graphen
            // 
            this.Graphen.BackColor = System.Drawing.Color.DarkGray;
            this.Graphen.Controls.Add(this.GraphNeu);
            this.Graphen.Controls.Add(this.graph_neu);
            this.Graphen.Controls.Add(this.label3);
            this.Graphen.Controls.Add(this.LB_G);
            this.Graphen.Location = new System.Drawing.Point(4, 135);
            this.Graphen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Graphen.Name = "Graphen";
            this.Graphen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Graphen.Size = new System.Drawing.Size(141, 158);
            this.Graphen.TabIndex = 1;
            this.Graphen.TabStop = false;
            this.Graphen.Text = "Graphen";
            // 
            // GraphNeu
            // 
            this.GraphNeu.Location = new System.Drawing.Point(9, 126);
            this.GraphNeu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GraphNeu.Name = "GraphNeu";
            this.GraphNeu.Size = new System.Drawing.Size(90, 19);
            this.GraphNeu.TabIndex = 3;
            this.GraphNeu.Text = "Übernehmen";
            this.GraphNeu.UseVisualStyleBackColor = true;
            this.GraphNeu.Click += new System.EventHandler(this.GraphNeu_Click);
            // 
            // graph_neu
            // 
            this.graph_neu.Location = new System.Drawing.Point(9, 103);
            this.graph_neu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graph_neu.Name = "graph_neu";
            this.graph_neu.Size = new System.Drawing.Size(91, 20);
            this.graph_neu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Neue Bezeichnung";
            // 
            // LB_G
            // 
            this.LB_G.Location = new System.Drawing.Point(9, 16);
            this.LB_G.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB_G.Name = "LB_G";
            this.LB_G.Size = new System.Drawing.Size(91, 69);
            this.LB_G.TabIndex = 2;
            // 
            // LB_Y
            // 
            this.LB_Y.CheckOnClick = true;
            this.LB_Y.FormattingEnabled = true;
            this.LB_Y.Location = new System.Drawing.Point(15, 20);
            this.LB_Y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB_Y.Name = "LB_Y";
            this.LB_Y.Size = new System.Drawing.Size(91, 64);
            this.LB_Y.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LB_X);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Achse";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.XTitle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Endwert);
            this.groupBox3.Controls.Add(this.Anfangswert);
            this.groupBox3.Location = new System.Drawing.Point(4, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(141, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wertebereich";
            // 
            // XTitle
            // 
            this.XTitle.Location = new System.Drawing.Point(5, 124);
            this.XTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XTitle.Name = "XTitle";
            this.XTitle.Size = new System.Drawing.Size(91, 20);
            this.XTitle.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Achsen Bezeichnung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endwert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anfangswert";
            // 
            // Endwert
            // 
            this.Endwert.Location = new System.Drawing.Point(4, 84);
            this.Endwert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Endwert.Name = "Endwert";
            this.Endwert.Size = new System.Drawing.Size(76, 20);
            this.Endwert.TabIndex = 1;
            // 
            // Anfangswert
            // 
            this.Anfangswert.Location = new System.Drawing.Point(4, 48);
            this.Anfangswert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Anfangswert.Name = "Anfangswert";
            this.Anfangswert.Size = new System.Drawing.Size(76, 20);
            this.Anfangswert.TabIndex = 0;
            // 
            // LB_X
            // 
            this.LB_X.FormattingEnabled = true;
            this.LB_X.Location = new System.Drawing.Point(14, 20);
            this.LB_X.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB_X.Name = "LB_X";
            this.LB_X.Size = new System.Drawing.Size(91, 69);
            this.LB_X.TabIndex = 2;
            this.LB_X.SelectedIndexChanged += new System.EventHandler(this.LB_X_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ToExcel);
            this.tabPage1.Controls.Add(this.Anzeige);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(560, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ToExcel
            // 
            this.ToExcel.Location = new System.Drawing.Point(4, 353);
            this.ToExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToExcel.Name = "ToExcel";
            this.ToExcel.Size = new System.Drawing.Size(108, 19);
            this.ToExcel.TabIndex = 3;
            this.ToExcel.Text = "Tabelle Speichern";
            this.ToExcel.UseVisualStyleBackColor = true;
            this.ToExcel.Click += new System.EventHandler(this.ToExcel_Click);
            // 
            // Anzeige
            // 
            this.Anzeige.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Anzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Anzeige.Location = new System.Drawing.Point(4, 5);
            this.Anzeige.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Anzeige.Name = "Anzeige";
            this.Anzeige.RowTemplate.Height = 24;
            this.Anzeige.Size = new System.Drawing.Size(554, 344);
            this.Anzeige.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 400);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Form";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox4.Controls.Add(this.Legendenposition);
            this.groupBox4.Controls.Add(this.legUpperschrift);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.panel_iAmLegend);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.upperschrift);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(173, 369);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text";
            // 
            // Legendenposition
            // 
            this.Legendenposition.Controls.Add(this.rb_innen);
            this.Legendenposition.Controls.Add(this.rb_aussen);
            this.Legendenposition.Location = new System.Drawing.Point(19, 84);
            this.Legendenposition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Legendenposition.Name = "Legendenposition";
            this.Legendenposition.Size = new System.Drawing.Size(68, 38);
            this.Legendenposition.TabIndex = 8;
            // 
            // rb_innen
            // 
            this.rb_innen.AutoSize = true;
            this.rb_innen.Checked = true;
            this.rb_innen.Location = new System.Drawing.Point(7, 0);
            this.rb_innen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_innen.Name = "rb_innen";
            this.rb_innen.Size = new System.Drawing.Size(52, 17);
            this.rb_innen.TabIndex = 6;
            this.rb_innen.TabStop = true;
            this.rb_innen.Text = "Innen";
            this.rb_innen.UseVisualStyleBackColor = true;
            // 
            // rb_aussen
            // 
            this.rb_aussen.AutoSize = true;
            this.rb_aussen.Location = new System.Drawing.Point(7, 19);
            this.rb_aussen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_aussen.Name = "rb_aussen";
            this.rb_aussen.Size = new System.Drawing.Size(56, 17);
            this.rb_aussen.TabIndex = 7;
            this.rb_aussen.Text = "Außen";
            this.rb_aussen.UseVisualStyleBackColor = true;
            // 
            // legUpperschrift
            // 
            this.legUpperschrift.Location = new System.Drawing.Point(47, 285);
            this.legUpperschrift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.legUpperschrift.Name = "legUpperschrift";
            this.legUpperschrift.Size = new System.Drawing.Size(90, 20);
            this.legUpperschrift.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Legendenüberschrift";
            // 
            // panel_iAmLegend
            // 
            this.panel_iAmLegend.BackgroundImage = global::Diagrammorama.Properties.Resources.Backround;
            this.panel_iAmLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_iAmLegend.Controls.Add(this.rb_rightMiddle);
            this.panel_iAmLegend.Controls.Add(this.rb_leftMiddle);
            this.panel_iAmLegend.Controls.Add(this.rb_bottomRight);
            this.panel_iAmLegend.Controls.Add(this.rb_bottomCenter);
            this.panel_iAmLegend.Controls.Add(this.rb_bottomLeft);
            this.panel_iAmLegend.Controls.Add(this.rb_topRight);
            this.panel_iAmLegend.Controls.Add(this.rb_topCenter);
            this.panel_iAmLegend.Controls.Add(this.rb_topLeft);
            this.panel_iAmLegend.Location = new System.Drawing.Point(16, 128);
            this.panel_iAmLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_iAmLegend.Name = "panel_iAmLegend";
            this.panel_iAmLegend.Size = new System.Drawing.Size(142, 129);
            this.panel_iAmLegend.TabIndex = 3;
            // 
            // rb_rightMiddle
            // 
            this.rb_rightMiddle.AutoSize = true;
            this.rb_rightMiddle.Location = new System.Drawing.Point(114, 54);
            this.rb_rightMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_rightMiddle.Name = "rb_rightMiddle";
            this.rb_rightMiddle.Size = new System.Drawing.Size(14, 13);
            this.rb_rightMiddle.TabIndex = 10;
            this.rb_rightMiddle.UseVisualStyleBackColor = true;
            // 
            // rb_leftMiddle
            // 
            this.rb_leftMiddle.AutoSize = true;
            this.rb_leftMiddle.Location = new System.Drawing.Point(15, 54);
            this.rb_leftMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_leftMiddle.Name = "rb_leftMiddle";
            this.rb_leftMiddle.Size = new System.Drawing.Size(14, 13);
            this.rb_leftMiddle.TabIndex = 9;
            this.rb_leftMiddle.UseVisualStyleBackColor = true;
            // 
            // rb_bottomRight
            // 
            this.rb_bottomRight.AutoSize = true;
            this.rb_bottomRight.Location = new System.Drawing.Point(114, 95);
            this.rb_bottomRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_bottomRight.Name = "rb_bottomRight";
            this.rb_bottomRight.Size = new System.Drawing.Size(14, 13);
            this.rb_bottomRight.TabIndex = 8;
            this.rb_bottomRight.UseVisualStyleBackColor = true;
            // 
            // rb_bottomCenter
            // 
            this.rb_bottomCenter.AutoSize = true;
            this.rb_bottomCenter.Location = new System.Drawing.Point(61, 95);
            this.rb_bottomCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_bottomCenter.Name = "rb_bottomCenter";
            this.rb_bottomCenter.Size = new System.Drawing.Size(14, 13);
            this.rb_bottomCenter.TabIndex = 7;
            this.rb_bottomCenter.UseVisualStyleBackColor = true;
            // 
            // rb_bottomLeft
            // 
            this.rb_bottomLeft.AutoSize = true;
            this.rb_bottomLeft.Location = new System.Drawing.Point(15, 95);
            this.rb_bottomLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_bottomLeft.Name = "rb_bottomLeft";
            this.rb_bottomLeft.Size = new System.Drawing.Size(14, 13);
            this.rb_bottomLeft.TabIndex = 6;
            this.rb_bottomLeft.UseVisualStyleBackColor = true;
            // 
            // rb_topRight
            // 
            this.rb_topRight.AutoSize = true;
            this.rb_topRight.Checked = true;
            this.rb_topRight.Location = new System.Drawing.Point(114, 17);
            this.rb_topRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_topRight.Name = "rb_topRight";
            this.rb_topRight.Size = new System.Drawing.Size(14, 13);
            this.rb_topRight.TabIndex = 2;
            this.rb_topRight.TabStop = true;
            this.rb_topRight.UseVisualStyleBackColor = true;
            // 
            // rb_topCenter
            // 
            this.rb_topCenter.AutoSize = true;
            this.rb_topCenter.Location = new System.Drawing.Point(61, 17);
            this.rb_topCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_topCenter.Name = "rb_topCenter";
            this.rb_topCenter.Size = new System.Drawing.Size(14, 13);
            this.rb_topCenter.TabIndex = 1;
            this.rb_topCenter.UseVisualStyleBackColor = true;
            // 
            // rb_topLeft
            // 
            this.rb_topLeft.AutoSize = true;
            this.rb_topLeft.Location = new System.Drawing.Point(15, 17);
            this.rb_topLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_topLeft.Name = "rb_topLeft";
            this.rb_topLeft.Size = new System.Drawing.Size(14, 13);
            this.rb_topLeft.TabIndex = 0;
            this.rb_topLeft.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Legendenposition";
            // 
            // upperschrift
            // 
            this.upperschrift.Location = new System.Drawing.Point(38, 47);
            this.upperschrift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upperschrift.Name = "upperschrift";
            this.upperschrift.Size = new System.Drawing.Size(90, 20);
            this.upperschrift.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Überschrift";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Dateipfad);
            this.Controls.Add(this.Datei);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Einstellungen";
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Graphen.ResumeLayout(false);
            this.Graphen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Anzeige)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Legendenposition.ResumeLayout(false);
            this.Legendenposition.PerformLayout();
            this.panel_iAmLegend.ResumeLayout(false);
            this.panel_iAmLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datei;
        private System.Windows.Forms.TextBox Dateipfad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Graphen;
        private System.Windows.Forms.Button GraphNeu;
        private System.Windows.Forms.TextBox graph_neu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LB_G;
        private System.Windows.Forms.CheckedListBox LB_Y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Endwert;
        private System.Windows.Forms.TextBox Anfangswert;
        private System.Windows.Forms.ListBox LB_X;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Anzeige;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox upperschrift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_iAmLegend;
        private System.Windows.Forms.RadioButton rb_topRight;
        private System.Windows.Forms.RadioButton rb_topCenter;
        private System.Windows.Forms.RadioButton rb_topLeft;
        private System.Windows.Forms.RadioButton rb_rightMiddle;
        private System.Windows.Forms.RadioButton rb_leftMiddle;
        private System.Windows.Forms.RadioButton rb_bottomRight;
        private System.Windows.Forms.RadioButton rb_bottomCenter;
        private System.Windows.Forms.RadioButton rb_bottomLeft;
        private System.Windows.Forms.TextBox legUpperschrift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_aussen;
        private System.Windows.Forms.RadioButton rb_innen;
        private System.Windows.Forms.Panel Legendenposition;
        private System.Windows.Forms.TextBox XTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ToExcel;
    }
}

