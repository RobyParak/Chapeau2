﻿using System;
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
        public Staff LoginStaff(string hash)
        {
            
            string query = "select Staff_ID, First_Name, Last_Name, Role, Hash from staff WHERE [Hash] = @Hash";
            SqlParameter[] sqlParameters = { new SqlParameter("@Hash", hash) };

            return ReadStaff(ExecuteSelectQuery(query, sqlParameters));
        }

        public Staff ReadStaff(DataTable dataTable)
        { 
            // do samething as tableDao (delete constructor)
            
            Staff staff = new Staff();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];

                staff.FirstName = (string)dr["First_Name"];
                staff.LastName = (string)dr["Last_Name"];
                staff.StaffID = (int)dr["Staff_ID"];
                staff.Hash = (string)dr["Hash"];
                staff.Role = (RolesEnum)(int)dr["Role"];
            }
            return staff;
        }
    }
}