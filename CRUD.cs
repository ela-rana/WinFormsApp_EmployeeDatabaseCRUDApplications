//CRUD: Create Read Update Delete, the most common actions performed on data or a database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_EmployeeDatabaseCRUDApplications
{
    interface CRUD
    {
        int GetMaxId();
        void AddRecord(Employee employee);
        void DeleteRecord(Employee employee);
        ICollection<Employee> GetAllRecords();
        Employee FindEmployee(int id);
        void UpdateRecord(int id, Employee employee);
        ICollection<Department> GetAllDepartments();
    }
    class EmpRepository : CRUD
    {
        //list
        EmployeeSystemEntities entities;    //makes an object variable of your database representation
                                            //our db name is EmployeeSystem
        public EmpRepository()
        {
            entities = new EmployeeSystemEntities();
        }
        public void AddRecord(Employee employee)
        {
            entities.Employees.Add(employee);   //add employee object in list
            entities.SaveChanges();     //to update the actual db server
        }

        public void DeleteRecord(Employee employee)
        {
            entities.Employees.Remove(employee); //remove passed employee object from list
            entities.SaveChanges();     //to update the actual db server. Here we are saving our changes after each update because it is a small local server
                                        //if it was a large enterprise business server, we may want to save changes only once by placing this statement somewhere else
                                        //more centralized after we finish all CRUD actions, because CRUDing the large enterprise server might be an intnsive time and resource consuming process
        }

        public Employee FindEmployee(int id)
        {
            return entities.Employees.Find(id);
        }

        public ICollection<Department> GetAllDepartments()
        {
            return entities.Departments.ToList();
        }

        public ICollection<Employee> GetAllRecords()
        {
            return entities.Employees.ToList();
        }

        public int GetMaxId()
        {
            return entities.Employees.Max(x => x.EmpID);
        }

        public void UpdateRecord(int id, Employee employee)
        {
            Employee empToUpdate = entities.Employees.Find(id); //to get the reference of the emp to update
            empToUpdate.EmpID = employee.EmpID;
            empToUpdate.FirstName = employee.FirstName;
            empToUpdate.LastName = employee.LastName;
            empToUpdate.DateOfBirth = employee.DateOfBirth;
            empToUpdate.DeptID = employee.DeptID;
            entities.SaveChanges();
        }
    }
}
