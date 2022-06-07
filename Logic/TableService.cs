using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic
{
    public class TableService
    {
        TableDao tableDao = new TableDao();

        public List<Table> GetTableData()
        {
            return tableDao.Db_Get_Table_Data();
        }

        public void SeatTable(int tableId)
        {
            tableDao.Db_Seat_Table(tableId);
        }

        public void ServeTable(int tableId)
        {
            tableDao.Db_Serve_Table(tableId);
        }

        public void ChangeTableToAvailable(int tableId)
        {
            tableDao.Db_Change_Table_to_Available(tableId);
        }
    }
}
