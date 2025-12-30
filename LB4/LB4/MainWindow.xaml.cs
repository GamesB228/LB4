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
                // ===== ЦЕМЕНТ =====
                double cementPrice = double.Parse(CementPrice.Text);
                int cementQty = int.Parse(CementQuantity.Text);
                double cementWeight = double.Parse(CementWeight.Text);

                Cement cement = new Cement(
                    "Цемент",
                    cementPrice,
                    cementQty,
                    cementWeight
                );

                double cementCost = cement.CalculateCost();
                CementResult.Text = $"Вартість цементу: {cementCost} грн";

                // ===== ДЕРЕВО =====
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

                // ===== ЗАГАЛЬНА ВАРТІСТЬ =====
                MaterialCalculator calculator = new MaterialCalculator();
                double total = calculator.TotalCost(
                    new List<BuildingMaterial> { cement, wood }
                );

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