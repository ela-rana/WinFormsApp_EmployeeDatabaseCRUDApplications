using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_EmployeeDatabaseCRUDApplications
{
    public partial class Department
    {

    }
    public partial class Employee   //we already have another Employee class auto-generated
               //by the database entity framework so using partial keyword means it is the
               //same class but we are putting some of the functionality here and some there
               //but it is all the same merged class in the end
               //WHY NOT update the original Employee class, instead of creating a new partial?
               //Because we don't want to mess with the Employee.cs file that was auto-generated by
    {
        public string DeptName { get; set; }
    }
}