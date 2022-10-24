using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Model
{
    public enum PaidStatus
    { IsPaid, IsNotPaid }

    public static class PaidStatusConverter
    {
        public static int ConvertToInt(PaidStatus status)
        {
            int s = 0;
            if (status == PaidStatus.IsPaid)
                s = 1;
            return s;
        }
    }
}
