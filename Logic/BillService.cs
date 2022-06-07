using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class BillService
    {
        BillDao _billDao;

        public BillService()
        {
            _billDao = new BillDao();
        }

        public int CreateEmptyBill()
        {
            return _billDao.CreateEmptyBill();
        }

        public int GetBillIdByTableId(int tableId)
        {
            return _billDao.GetBillIdByTableId(tableId);
        }

        public Bill GetBillById(int billId)
        {
            return _billDao.GetBillById(billId);
        }
    }
}
