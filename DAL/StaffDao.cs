using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class StaffDao : BaseDao
    {
        public Staff LoginStaff(int staffID, int passCode)
        {
            string query = "select Staff_ID, First_Name, Last_Name, Passcode, Has_Permission from staff WHERE [Passcode] = @pass and [Staff_ID] = @ID ";
            SqlParameter[] sqlParameters = { new SqlParameter ("@pass", passCode),
                    new SqlParameter ("@ID", staffID) };

            return ReadStaff(ExecuteSelectQuery(query, sqlParameters));
        }

        public Staff ReadStaff(DataTable dataTable)
        {
            Staff staff = new Staff();
            if (dataTable.Rows.Count >= 1)
            {
                DataRow dr = dataTable.Rows[0];

                staff.FirstName = (string)dr["First_Name"];
                staff.LastName = (string)dr["Last_Name"];
                staff.StaffID = (int)dr["Staff_ID"];
                staff.PassCode = (int)dr["Passcode"];
                //ask Dimitar how to convert it 
                //staff.HasPermission = (bool)(dr["Has_Permission"]) ? 0 : 1;
            }
            return staff;

        }
    }
}
