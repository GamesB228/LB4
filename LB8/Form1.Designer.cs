namespace LB8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtStep = new TextBox();
            txtTerms = new TextBox();
            btnCalculate = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // txtStep
            // 
            txtStep.Location = new Point(12, 12);
            txtStep.Name = "txtStep";
            txtStep.Size = new Size(100, 23);
            txtStep.TabIndex = 0;
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(142, 12);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(100, 23);
            txtTerms.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(272, 12);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Вивести графік";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 68);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(743, 350);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart1);
            Controls.Add(btnCalculate);
            Controls.Add(txtTerms);
            Controls.Add(txtStep);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStep;
        private TextBox txtTerms;
        private Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
