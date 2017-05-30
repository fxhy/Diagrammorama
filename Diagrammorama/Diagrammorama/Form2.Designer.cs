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
            this.Speichern = new System.Windows.Forms.Button();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
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
            // plot1
            // 
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Margin = new System.Windows.Forms.Padding(0);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(632, 446);
            this.plot1.TabIndex = 0;
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.Speichern);
            this.Name = "Diagramm";
            this.Text = "Diagramm";
            this.Load += new System.EventHandler(this.Diagramm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Speichern;
        private OxyPlot.WindowsForms.PlotView plot1;
    }
}