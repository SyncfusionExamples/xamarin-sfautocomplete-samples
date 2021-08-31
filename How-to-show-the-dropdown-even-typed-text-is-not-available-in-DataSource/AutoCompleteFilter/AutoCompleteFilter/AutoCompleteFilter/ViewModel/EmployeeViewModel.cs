using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AutoCompleteFilter
{
    public class EmployeeViewModel
    {
        private ObservableCollection<Employee> employeeCollection;
        public ObservableCollection<Employee> EmployeeCollection
        {
            get { return employeeCollection; }
            set { employeeCollection = value; }
        }
        public EmployeeViewModel()
        {
            employeeCollection = new ObservableCollection<Employee>();
            employeeCollection.Add(new Employee() { ID = 1, Name = "Eric" });
            employeeCollection.Add(new Employee() { ID = 2, Name = "James" });
            employeeCollection.Add(new Employee() { ID = 3, Name = "Jacob" });
            employeeCollection.Add(new Employee() { ID = 4, Name = "Lucas" });
            employeeCollection.Add(new Employee() { ID = 5, Name = "Mark" });
            employeeCollection.Add(new Employee() { ID = 6, Name = "Aldan" });
            employeeCollection.Add(new Employee() { ID = 7, Name = "Aldrin" });
            employeeCollection.Add(new Employee() { ID = 8, Name = "Alan" });
            employeeCollection.Add(new Employee() { ID = 9, Name = "Aaron" });
        }
    }
}
