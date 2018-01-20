﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PapaBobs1.DTO;

namespace PapaBobs1.persistance
{
    public class OrderRepository1
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PapaBobsDb1Entities();

            var order = convertToEntity(orderDTO);
            db.Orders.Add(order);
            db.SaveChanges();

        }
        private static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();

            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Zip = orderDTO.Zip;
            order.Phone = orderDTO.Phone;
            order.PaymentType = orderDTO.PaymentType;
            order.Completed = orderDTO.Completed;

            return order;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new PapaBobsDb1Entities();

            var order = db.Orders.FirstOrDefault(p => p.OrderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new PapaBobsDb1Entities();
            var orders = db.Orders; Where(p => p.Completed == false).ToList;
            var ordersDTO = new OrderDTO();
          

            convertToDTO(orders);
            return ordersDTO;
        }

        private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();

            foreach (var order in orders)
            {
                var orderDTO = new DTO.OrderDTO();
                orderDTO.OrderId = order.OrderId;
                orderDTO.Crust = order.Crust;
                orderDTO.Size = order.Size;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.Zip = order.Zip;
                orderDTO.Phone = order.Phone;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.PaymentType = order.PaymentType;
                orderDTO.Completed = order.Completed;
                orderDTO.TotalCost = order.TotalCost;

                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;

        }
    }
}
