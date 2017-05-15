namespace Diagrammorama
{
    partial class Diagramm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Diagramme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Speichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diagramme)).BeginInit();
            this.SuspendLayout();
            // 
            // Diagramme
            // 
            this.Diagramme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Diagramme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Diagramme.Legends.Add(legend1);
            this.Diagramme.Location = new System.Drawing.Point(12, 41);
            this.Diagramme.Name = "Diagramme";
            this.Diagramme.Size = new System.Drawing.Size(693, 374);
            this.Diagramme.TabIndex = 4;
            this.Diagramme.Text = "chart1";
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(12, 12);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(75, 23);
            this.Speichern.TabIndex = 5;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.Speichern);
            this.Controls.Add(this.Diagramme);
            this.Name = "Diagramm";
            this.Text = "Diagramm";
            this.Load += new System.EventHandler(this.Diagramm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diagramme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Speichern;
        public System.Windows.Forms.DataVisualization.Charting.Chart Diagramme;
    }
}