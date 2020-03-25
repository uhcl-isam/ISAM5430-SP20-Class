using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430.SP20.Class08
{
    class Employee
    {
        private readonly int _id;
        private string _firstName;
        private string _lastName;
        // object composition
        private Date _hireDate;

        public Employee(int id, string firstName, string lastName, Date hireDate)
        {
            if (id < 1 || id > 9999999)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentOutOfRangeException(nameof(firstName));
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentOutOfRangeException(nameof(lastName));
            }
            if (hireDate == null)
            {
                throw new ArgumentNullException(nameof(hireDate));
            }

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _hireDate = hireDate;
        }

        public override string ToString()
        {
            return $"{_lastName}, {_firstName}";
        }

        public Date HireDate
        {
            get
            {
                // return _hireDate;
                // create a new instance taking the hire date
                // the hire date itself has some known data (month, day, year)
                return new Date(_hireDate);
                // return new Date(_hireDate.Month, _hireDate.Day, _hireDate.Year);
            }
        }

        ~Employee()
        {
            // finalizer codes.
        }
    }
}
