using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs1.domain
{
    public class OrderManager1
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            //validation
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("Name is required");

            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception("Address is required");

            if (orderDTO.Zip.Trim().Length == 0)
                throw new Exception("Zip code is required");

            if (orderDTO.Phone.Trim().Length == 0)
                throw new Exception("Phone number is required");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager1.CalculatePizzaCost(orderDTO);
            persistance.OrderRepository1.CreateOrder(orderDTO);
        }

        public static void CompleteOrder(Guid orderId)
        {
            persistance.OrderRepository1.CompleteOrder(orderId);
        }

        public static object GetOrders()
        {
            return persistance.OrderRepository1.GetOrders();
        }
    }
}
