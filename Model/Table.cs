using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Table
    {
        //public Table()
        //{

        //}
        
        public Table(int id, int status)
        {
            Id = id;
            TableStatus = status;
            BillId = -1;
            ReservationTime = new DateTime();
        }
        public int Id { get; set; }

        public int TableStatus { get; set; }

        public int BillId { get; set; }

        public DateTime ReservationTime { get; set; }
    }
}
