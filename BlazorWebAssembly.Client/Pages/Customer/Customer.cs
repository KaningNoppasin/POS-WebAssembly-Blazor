using System;

namespace MudBlazor.Examples.Data.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CardUID { get; set; } = string.Empty;
        public uint CustomerPoints { get; set; }
    }
}