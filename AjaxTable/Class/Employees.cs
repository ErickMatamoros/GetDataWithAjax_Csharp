using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxTable.Class
{
    public class Employees
    {
        private int _EmployeeID;
        private String _FirstName;
        private String _LastName;
        private String _BirthDate;
        private int _Age;

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }

            set
            {
                _EmployeeID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return _BirthDate;
            }

            set
            {
                _BirthDate = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
            }
        }

        /// <summary>
        /// Method that calculates the age of a person
        /// </summary>
        /// <param name="BirthDate"></param>
        /// <returns></returns>
        public int calculateAge(DateTime BirthDate)
        {
            int Age = DateTime.Now.Year - BirthDate.Year;
            DateTime NowBirthDate = BirthDate.AddYears(Age);
            if (DateTime.Now.CompareTo(NowBirthDate) > 0)
            {
                Age--;
            }
            return Age;
        }

    }
}