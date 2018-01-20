using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs1.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public PapaBobs1.DTO.Enums1.SizeType Size { get; set; }
        public PapaBobs1.DTO.Enums1.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public PapaBobs1.DTO.Enums1.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }
    }
}
