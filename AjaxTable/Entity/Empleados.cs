using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxTable.Entity
{
    public class Empleados
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        /// <summary>
        /// Method that calls the stored procedure SP_GetEmpleados
        /// </summary>
        /// <returns></returns>
        public List<SP_GetEmployees_Result> getEmployees()
        {
            List<SP_GetEmployees_Result> EmployeeList = null;
            try
            {
                EmployeeList = db.SP_GetEmployees().ToList();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                EmployeeList = null;
            }
            return EmployeeList;
        }
    }
}