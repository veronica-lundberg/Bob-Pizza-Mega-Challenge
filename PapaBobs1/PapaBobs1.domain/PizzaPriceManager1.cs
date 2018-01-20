using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobs1.DTO;
using PapaBobs1.domain;

namespace PapaBobs1.domain
{
    public class PizzaPriceManager1
    {
        public static decimal CalculatePizzaCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();
            cost += calculateSizeCost(order, prices);
            cost += calculateCrustCost(order, prices);
            cost += calculateToppings(order, prices);

            return cost;
        }

        private static decimal calculateToppings(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onions) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;
            return cost;
        }

        private static decimal calculateCrustCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Crust)
            {
                case PapaBobs1.DTO.Enums1.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case PapaBobs1.DTO.Enums1.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case PapaBobs1.DTO.Enums1.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal calculateSizeCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Size)
            {
                case PapaBobs1.DTO.Enums1.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case PapaBobs1.DTO.Enums1.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case PapaBobs1.DTO.Enums1.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = persistance.PizzaPriceRepository1.GetPizzaPrices();
            return prices;
        }
    }
}
