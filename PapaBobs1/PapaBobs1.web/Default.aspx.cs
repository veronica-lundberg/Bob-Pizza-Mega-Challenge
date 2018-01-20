using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs1.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a name";
                validationLabel.Visible = true;
                return;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter an address";
                validationLabel.Visible = true;
                return;
            }

            if (zipTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a zip code";
                validationLabel.Visible = true;
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a phone number";
                validationLabel.Visible = true;
                return;
            }

            try
            {
                var order = buildOrder();
                domain.OrderManager1.CreateOrder(order);
                Response.Redirect("success.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
                return;
            }

        }


        protected void orderButton_Click(object sender, EventArgs e)
        {
            var Order = buildOrder();
            domain.OrderManager1.CreateOrder(order);
        }
        
            /*DTO.Enums1.SizeType size;
            if (Enum.TryParse(sizeDropDownList.SelectedValue, out size)) 
                {
                order.Size = size;
                 }*/
          
        
  
        private DTO.Enums1.PaymentType determinePaymentType()
        {
            DTO.Enums1.PaymentType paymentType;
            if (cashRadioButton.Checked)
            {
                paymentType = DTO.Enums1.PaymentType.Cash;
            }
            else //if (creditRadioButton.Checked)
            {
                paymentType = DTO.Enums1.PaymentType.Credit;
            }
            //else
           //{
               // throw new Exception("Payment type not selected.");
           // }

            return PaymentType;
        }


        private DTO.Enums1.CrustType determineCrust();
        
            DTO.Enums1.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Could not determine pizza crust.");
            }
            return crust;
            }

        private DTO.Enums.SizeType determineSize()
    { 

            DTO.Enums1.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Could not determine pizza size.");
            }

                return size;
            }
        protected void recalculateTotalCost(object sender, EventArgs e)
        {
                if (sizeDropDownList.SelectedValue == String.Empty) return;
                if (crustDropDownList.SelectedValue == String.Empty) return;
                var order = buildOrder();

                try
                {
                    totalLabel.Text = Domain.PizzaPriceManager1.CalculateCost(order).ToString("C");
                }
                catch
                {
                    //swallow the error
                }
        }

         private DTO.OrderDTO buildOrder()
            {
            var order = new DTO.OrderDTO();
            order.Size = DetermineSize();
            order.Crust = determineCrust();
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Sausage = sausageCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Zip;
            order.Phone = phoneTextBox.Text;
            order.PaymentType = determinePaymentType();

            return order;
        }
    
        



