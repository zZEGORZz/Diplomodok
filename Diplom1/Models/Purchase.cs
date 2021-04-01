using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom1.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string NamePerson { get; set; }
        public string Address { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
    }
}
