using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LB4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<BuildingMaterial> materials = new();

        public MainWindow()
        {
            InitializeComponent();
            WoodTreatment.SelectedIndex = 0;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                double cementPrice = double.Parse(CementPrice.Text);
                int cementQty = int.Parse(CementQuantity.Text);
                double cementWeight = double.Parse(CementWeight.Text);

                Cement cement = new Cement(
                    "Цемент",
                    cementPrice,
                    cementQty,
                    cementWeight
                );

                
                double paintPrice = double.Parse(PaintPrice.Text);
                int paintQty = int.Parse(PaintQuantity.Text);

                Paint paint = new Paint(paintPrice, paintQty);
                double paintCost = paint.CalculateCost();
                PaintResult.Text = $"Вартість фарби: {paintCost} грн";

                

                double cementCost = cement.CalculateCost();
                CementResult.Text = $"Вартість цементу: {cementCost} грн";

                
                double woodPrice = double.Parse(WoodPrice.Text);
                int woodQty = int.Parse(WoodQuantity.Text);
                string treatment =
                    ((ComboBoxItem)WoodTreatment.SelectedItem).Content.ToString();

                Wood wood = new Wood(
                    "Дерево",
                    woodPrice,
                    woodQty,
                    treatment
                );

                double woodCost = wood.CalculateCost();
                WoodResult.Text = $"Вартість дерева: {woodCost} грн";

                
                List<ICostCalculable> list = new List<ICostCalculable>();
                list.Add(cement);
                list.Add(wood);
                list.Add(paint);

                MaterialCalculator calculator = new MaterialCalculator();
                double total = calculator.TotalCost(list);

                TotalResult.Text = $"ЗАГАЛЬНА ВАРТІСТЬ: {total} грн";

            }
            catch
            {
                MessageBox.Show(
                    "Перевірте введені дані!",
                    "Помилка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }
    }
}