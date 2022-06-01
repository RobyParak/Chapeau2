using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;

namespace Service
{
    public class StaffService
    {
        StaffDao staffDao;

        public StaffService()
        {
            staffDao = new StaffDao();
        }

        public Staff LoginStaff(int staffID, int PassCode)
        {
            Staff staff = staffDao.LoginStaff(staffID, PassCode);

            return staff;
        }
    }
}
