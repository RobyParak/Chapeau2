using Model;
using System;

public class Bill
{
    public int BillId { get; set; }
    public double AmountDue { get; set; }
    public double Tip { get; set; }
    public double TotalDue { get; set; }
    public PaymentType PaymentMethod { get; set; }
    public double VAT { get; set; }
    public string Feedback { get; set; }

}