using Model;
using System;
using System.Collections.Generic;

public class Bill
{
    public int BillId { get; set; }
    public double AmountDue { get; set; }
    public double Tip { get; set; }
    public double TotalDue { get; set; }
    public PaymentType PaymentMethod { get; set; }
    public double VAT { get; set; }
    public string Feedback { get; set; }
    public List<Order> Orders { get; set; }

    public Order Order { get; set; }

    public Bill(int id)
    {
        BillId = id;
        Orders = new List<Order>();
    }
    public Bill()
    {
        Orders = new List<Order>();
    }

}