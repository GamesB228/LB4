namespace LB9
{
    public partial class Form1 : Form
    {
        Employee employee;
        Worker worker;
        Accountant accountant;
        Manager manager;

        public Form1()
        {
            InitializeComponent();

            employee = new Employee("Іван");
            worker = new Worker("Петро");
            accountant = new Accountant("Ольга");
            manager = new Manager("Анна");

            // Підписка на широкомовну подію
            employee.SalaryPaid += worker.ReceiveNotification;
            employee.SalaryPaid += accountant.ReceiveNotification;

            // Підписка на подію відпустки
            employee.VacationRequested += manager.ApproveVacation;
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            employee.PaySalary();

        }

        private void btnVacation_Click(object sender, EventArgs e)
        {
            employee.RequestVacation();
        }
    }
}
