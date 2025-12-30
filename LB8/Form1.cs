namespace LB8
{
    public partial class Form1 : Form
    {
        ExpSeries exp = new ExpSeries();
        public Form1()
        {
            InitializeComponent();
            InitChart();
        }
        private void InitChart()
        {
            chart1.Series.Clear();

            chart1.Series.Add("Цикл");
            chart1.Series.Add("Рекурсія");

            chart1.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            double step = double.Parse(txtStep.Text);
            int n = int.Parse(txtTerms.Text);

            for (double x = -3 * Math.PI; x <= 3 * Math.PI; x += step)
            {
                double loop = exp.CalculateLoop(x, n);
                double rec = exp.CalculateRecursive(x, n);

                chart1.Series[0].Points.AddXY(x, loop);
                chart1.Series[1].Points.AddXY(x, rec);
            }
        }
    }
}
