using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore.Entities
{
   public class Product
    {
        public int ProductCode { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SaleRate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Locations { get; set; }

    }
}
