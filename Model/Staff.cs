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
        public enum RolesEnum { Waiter, Chef, Bartender, Manager}
        public RolesEnum Roles { get; set; }

        //public Staff()
        //{

        //}

        public Staff(string firstName, string lastName, int staffId, int passCode, RolesEnum roleEnum)
        {
            FirstName = firstName;
            LastName = lastName;
            StaffID = staffId;
            PassCode = passCode;
            Roles = roleEnum;
        }

        public Staff()
        {
        }
    }
}
