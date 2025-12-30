using LB9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class EmployeeEventsTests
    {
        [TestMethod]
        public void SalaryPaid_ShouldNotifyAllSubscribers()
        {
            // Arrange
            Employee employee = new Employee("Іван");

            bool workerNotified = false;
            bool accountantNotified = false;

            employee.SalaryPaid += msg => workerNotified = true;
            employee.SalaryPaid += msg => accountantNotified = true;

            // Act
            employee.PaySalary();

            // Assert
            Assert.IsTrue(workerNotified, "Worker не отримав сповіщення");
            Assert.IsTrue(accountantNotified, "Accountant не отримав сповіщення");
        }

        [TestMethod]
        public void VacationRequested_ShouldNotifyManager()
        {
            // Arrange
            Employee employee = new Employee("Іван");

            bool managerNotified = false;

            employee.VacationRequested += name => managerNotified = true;

            // Act
            employee.RequestVacation();

            // Assert
            Assert.IsTrue(managerNotified, "Manager не отримав запит на відпустку");
        }

        [TestMethod]
        public void SalaryPaid_ShouldBeBroadcastEvent()
        {
            // Arrange
            Employee employee = new Employee("Іван");

            int callCount = 0;

            employee.SalaryPaid += msg => callCount++;
            employee.SalaryPaid += msg => callCount++;
            employee.SalaryPaid += msg => callCount++;

            // Act
            employee.PaySalary();

            // Assert
            Assert.AreEqual(3, callCount, "Подія не є широкомовною");
        }
    }
}
