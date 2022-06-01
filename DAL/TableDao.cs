using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class TableDao : BaseDao 
    {
        public List<Table> Db_Get_Table_Data()
        {
            string query = "Select [Table_ID], [Status] from Tables";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Id = (int)dr["Table_ID"],
                    TableStatus = (int)dr["Status"]
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
