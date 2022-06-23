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
                Table table = new Table((int)dr["Table_ID"], (int)dr["Status"]);
                
                tables.Add(table);
            }
            return tables;
        }

        public void Db_Seat_Table(int tableID)
        {
            string query = $"Update [Tables] set [Status] = 1 Where [Table_ID] = @TableId";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableID) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Serve_Table(int tableID)
        {
            string query = $"Update [Tables] set [Status] = 2 Where [Table_ID] = @TableId";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableID) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Change_Table_to_Available(int tableID)
        {
            string query = $"Update [Tables] set [Status] = 0 Where [Table_ID] = @TableId";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableID) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
