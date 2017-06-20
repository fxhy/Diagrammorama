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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_X = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Anfangswert = new System.Windows.Forms.TextBox();
            this.Endwert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_Y = new System.Windows.Forms.CheckedListBox();
            this.Graphen = new System.Windows.Forms.GroupBox();
            this.LB_G = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.graph_neu = new System.Windows.Forms.TextBox();
            this.GraphNeu = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Anzeige = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Graphen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anzeige)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datei
            // 
            this.Datei.Location = new System.Drawing.Point(9, 10);
            this.Datei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Datei.Name = "Datei";
            this.Datei.Size = new System.Drawing.Size(69, 19);
            this.Datei.TabIndex = 0;
            this.Datei.Text = "Datei laden";
            this.Datei.UseVisualStyleBackColor = true;
            this.Datei.Click += new System.EventHandler(this.Datei_Click);
            // 
            // Dateipfad
            // 
            this.Dateipfad.Location = new System.Drawing.Point(82, 11);
            this.Dateipfad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dateipfad.Name = "Dateipfad";
            this.Dateipfad.Size = new System.Drawing.Size(194, 20);
            this.Dateipfad.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 10);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(560, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LB_X);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Achse";
            // 
            // LB_X
            // 
            this.LB_X.FormattingEnabled = true;
            this.LB_X.Location = new System.Drawing.Point(14, 20);
            this.LB_X.Margin = new System.Windows.Forms.Padding(2);
            this.LB_X.Name = "LB_X";
            this.LB_X.Size = new System.Drawing.Size(91, 69);
            this.LB_X.TabIndex = 2;
            this.LB_X.SelectedIndexChanged += new System.EventHandler(this.LB_X_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Endwert);
            this.groupBox3.Controls.Add(this.Anfangswert);
            this.groupBox3.Location = new System.Drawing.Point(4, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(141, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wertebereich";
            // 
            // Anfangswert
            // 
            this.Anfangswert.Location = new System.Drawing.Point(4, 48);
            this.Anfangswert.Margin = new System.Windows.Forms.Padding(2);
            this.Anfangswert.Name = "Anfangswert";
            this.Anfangswert.Size = new System.Drawing.Size(76, 20);
            this.Anfangswert.TabIndex = 0;
            // 
            // Endwert
            // 
            this.Endwert.Location = new System.Drawing.Point(4, 84);
            this.Endwert.Margin = new System.Windows.Forms.Padding(2);
            this.Endwert.Name = "Endwert";
            this.Endwert.Size = new System.Drawing.Size(76, 20);
            this.Endwert.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Graphen);
            this.groupBox2.Controls.Add(this.LB_Y);
            this.groupBox2.Location = new System.Drawing.Point(159, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(150, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Achse";
            // 
            // LB_Y
            // 
            this.LB_Y.CheckOnClick = true;
            this.LB_Y.FormattingEnabled = true;
            this.LB_Y.Location = new System.Drawing.Point(15, 20);
            this.LB_Y.Margin = new System.Windows.Forms.Padding(2);
            this.LB_Y.Name = "LB_Y";
            this.LB_Y.Size = new System.Drawing.Size(91, 64);
            this.LB_Y.TabIndex = 0;
            // 
            // Graphen
            // 
            this.Graphen.Controls.Add(this.GraphNeu);
            this.Graphen.Controls.Add(this.graph_neu);
            this.Graphen.Controls.Add(this.label3);
            this.Graphen.Controls.Add(this.LB_G);
            this.Graphen.Location = new System.Drawing.Point(4, 135);
            this.Graphen.Margin = new System.Windows.Forms.Padding(2);
            this.Graphen.Name = "Graphen";
            this.Graphen.Padding = new System.Windows.Forms.Padding(2);
            this.Graphen.Size = new System.Drawing.Size(141, 158);
            this.Graphen.TabIndex = 1;
            this.Graphen.TabStop = false;
            this.Graphen.Text = "Graphen";
            // 
            // LB_G
            // 
            this.LB_G.Location = new System.Drawing.Point(9, 16);
            this.LB_G.Margin = new System.Windows.Forms.Padding(2);
            this.LB_G.Name = "LB_G";
            this.LB_G.Size = new System.Drawing.Size(91, 69);
            this.LB_G.TabIndex = 2;
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
            // graph_neu
            // 
            this.graph_neu.Location = new System.Drawing.Point(9, 103);
            this.graph_neu.Margin = new System.Windows.Forms.Padding(2);
            this.graph_neu.Name = "graph_neu";
            this.graph_neu.Size = new System.Drawing.Size(91, 20);
            this.graph_neu.TabIndex = 2;
            // 
            // GraphNeu
            // 
            this.GraphNeu.Location = new System.Drawing.Point(9, 126);
            this.GraphNeu.Margin = new System.Windows.Forms.Padding(2);
            this.GraphNeu.Name = "GraphNeu";
            this.GraphNeu.Size = new System.Drawing.Size(90, 19);
            this.GraphNeu.TabIndex = 3;
            this.GraphNeu.Text = "Übernehmen";
            this.GraphNeu.UseVisualStyleBackColor = true;
            this.GraphNeu.Click += new System.EventHandler(this.GraphNeu_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Anzeige);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(560, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Anzeige
            // 
            this.Anzeige.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Anzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Anzeige.Location = new System.Drawing.Point(4, 5);
            this.Anzeige.Margin = new System.Windows.Forms.Padding(2);
            this.Anzeige.Name = "Anzeige";
            this.Anzeige.RowTemplate.Height = 24;
            this.Anzeige.Size = new System.Drawing.Size(554, 366);
            this.Anzeige.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 400);
            this.tabControl1.TabIndex = 4;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Graphen.ResumeLayout(false);
            this.Graphen.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Anzeige)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
    }
}

