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

        //created the below to only load the payment form
        public Table(int id)
        {
            Id = id;
        }
        public Table(int id, int status)
        {
            Id = id;
            TableStatus = status;
            ReservationTime = new DateTime();
        }
        public int Id { get; set; }

        public int TableStatus { get; set; }

        public DateTime ReservationTime { get; set; }
    }
}
