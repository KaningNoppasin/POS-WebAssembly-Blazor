using System;

namespace MudBlazor.Examples.Data.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductBarcode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public uint Price { get; set; }
        public int Stock { get; set; }
    }
}