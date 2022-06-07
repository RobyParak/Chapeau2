using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;
using static Model.Staff;

namespace DAL
{
    public class StaffDao : BaseDao
    {
        public Staff LoginStaff(int staffID, int passCode)
        {
            string query = "select Staff_ID, First_Name, Last_Name, Passcode, Role from staff WHERE [Passcode] = @pass and [Staff_ID] = @ID ";
            SqlParameter[] sqlParameters = { new SqlParameter ("@pass", passCode),
                    new SqlParameter ("@ID", staffID) };

            return ReadStaff(ExecuteSelectQuery(query, sqlParameters));
        }

        public Staff ReadStaff(DataTable dataTable)
        { 
            // do samething as tableDao (delete constructor)
            
            Staff staff = new Staff();
            if (dataTable.Rows.Count >= 1)
            {
                DataRow dr = dataTable.Rows[0];

                staff.FirstName = (string)dr["First_Name"];
                staff.LastName = (string)dr["Last_Name"];
                staff.StaffID = (int)dr["Staff_ID"];
                staff.PassCode = (int)dr["Passcode"];
                staff.Roles = (RolesEnum)(int)dr["Role"];
            }
            return staff;
        }
    }
}