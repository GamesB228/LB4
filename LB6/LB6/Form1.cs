using System.Xml.Linq;

namespace LB6
{
    public partial class Form1 : Form
    {
        private StudentCatalog catalog = new StudentCatalog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student(
                txtName.Text,
                int.Parse(txtCourse.Text),
                txtGroup.Text,
                double.Parse(txtResult.Text)
            );

            catalog.Add(student);
            RefreshList(catalog.Students);
        }

        private void btnWinners_Click(object sender, EventArgs e)
        {
            var winners = catalog.GetWinners();
            RefreshList(winners);
        }

        private void RefreshList(List<Student> list)
        {
            listBox1.Items.Clear();
            foreach (var s in list)
                listBox1.Items.Add(s);
        }

        private async void btnImportJson_Click(object sender, EventArgs e)
        {
            if (!File.Exists("students.json"))
            {
                MessageBox.Show("Файл не знайдено!");
                return;
            }

            var reader = new JsonFileReader<List<Student>>();
            var students = await reader.ReadAsync("students.json");
            catalog.Students.Clear();
            catalog.Students.AddRange(students);
            RefreshList(catalog.Students);
            MessageBox.Show("Імпорт завершено!");
        }

        private async void btnSaveJson_Click(object sender, EventArgs e)
        {
            var writer = new JsonFileWriter<List<Student>>();
            await writer.WriteAsync("students.json", catalog.Students);
            MessageBox.Show("Дані збережено у JSON!");
        }

        private void btnSortCourse_Click(object sender, EventArgs e)
        {
            var sorted = catalog.Students.OrderBy(s => s.Course).ThenBy(s => s.FullName).ToList();
            RefreshList(sorted);
        }

        private void btnGetNames_Click(object sender, EventArgs e)
        {
            var names = catalog.GetStudentNames();
            listBox1.Items.Clear();
            foreach (var name in names)
                listBox1.Items.Add(name);
        }

        private void btnGroupByCourse_Click(object sender, EventArgs e)
        {
            var groups = catalog.GroupByCourse();
            listBox1.Items.Clear();
            foreach (var group in groups)
            {
                listBox1.Items.Add($"Курс {group.Key}:");
                foreach (var student in group.Value)
                    listBox1.Items.Add($"  {student.FullName} - {student.Result} сек");
            }
        }

        private void btnAverageResult_Click(object sender, EventArgs e)
        {
            double avg = catalog.AverageResult();
            listBox1.Items.Clear();
            listBox1.Items.Add($"Середній результат: {avg:F2} сек");
        }

        private void btnBestWorst_Click(object sender, EventArgs e)
        {
            var best = catalog.GetBestStudent();
            var worst = catalog.GetWorstStudent();
            listBox1.Items.Clear();
            listBox1.Items.Add($"Найкращий: {best.FullName} - {best.Result} сек");
            listBox1.Items.Add($"Найгірший: {worst.FullName} - {worst.Result} сек");
        }

        private void btnNamesBelowResult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMaxResult.Text, out double max))
            {
                MessageBox.Show("Введіть число!");
                return;
            }

            var names = catalog.GetNamesWithResultBelow(max);
            listBox1.Items.Clear();
            foreach (var name in names)
                listBox1.Items.Add(name);
        }

    }
}
