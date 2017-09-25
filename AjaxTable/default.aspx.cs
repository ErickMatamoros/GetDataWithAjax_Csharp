using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxTable
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Web method that returns employees in database. 
        /// </summary>
        /// <returns>Boolean</returns>
        [System.Web.Services.WebMethod()]
        public static List<Class.Employees> LoadEmployees()
        {
            Entity.Empleados emp = new Entity.Empleados(); //Class that serves as a connection to the entity framework
            Class.Employees clsEmp = new Class.Employees(); //Employee class

            List<Class.Employees> employeeList = new List<Class.Employees>(); //variable that will keep the list of employees
            List<Entity.SP_GetEmployees_Result> employeesResult = emp.getEmployees(); //Loads the employees of the database.

            //It traverses the employees obtained from the data base to store them to the list of employees.
            foreach (Entity.SP_GetEmployees_Result item in employeesResult)
            {
                employeeList.Add(new Class.Employees
                {
                    EmployeeID = item.EmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = item.BirthDate.ToString(),
                    Age = clsEmp.calculateAge(DateTime.Parse(item.BirthDate.ToString()))
                });
            }
            return employeeList; //Return the employee List
        }
    }
}