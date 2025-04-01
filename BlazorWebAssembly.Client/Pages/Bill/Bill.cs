using System;

namespace MudBlazor.Examples.Data.Models
{
    public class BillModel
    {
        public int BillID { get; set; }
        public uint CustomerID { get; set; }
        public uint TotalAmount { get; set; }
    }
}
