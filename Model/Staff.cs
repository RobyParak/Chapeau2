using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public  class Staff
    {
        public enum Role { Waiter, Chef, Bartender, Manager}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StaffID { get; set; }
        public int PassCode { get; set; }
        public Role StaffRole { get; set; }


        //public Staff()
        //{

        //}

        public Staff(string firstName, string lastName, int staffId, int passCode, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            StaffID = staffId;
            PassCode = passCode;
            this.StaffRole = role;
        }

        public Staff()
        {
        }
    }
}
