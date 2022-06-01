using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public  class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StaffID { get; set; }
        public int PassCode { get; set; }
        public bool HasPermission { get; set; }

        //public Staff()
        //{

        //}

        public Staff(string firstName, string lastName, int staffId, int passCode, bool hasPermission)
        {
            FirstName = firstName;
            LastName = lastName;
            StaffID = staffId;
            PassCode = passCode;
            HasPermission = hasPermission;
        }

        public Staff()
        {
        }
    }
}
