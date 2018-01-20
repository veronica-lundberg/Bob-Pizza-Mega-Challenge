﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs1.web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class = "container">

        <div class ="page-header">
            <h1>Papa Bob's Pizza</h1>
            <p>Pizza to Code By</p>
        </div>

      



        <div class ="form-group">
            <label>Size: </label>
            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass ="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost"></asp:DropDownList>
                <asp:ListItem Text="Choose One..." Value ="" Selected="True" />
                <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium" />
                <asp:ListItem Text="Large (16 inch - $16)" Value="Large" />
            </asp:DropDownList>     
        </div>

        <div class ="form-group">
            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass ="form-control" AutoPostBack="true"  OnSelectedIndexChanged="recalculateTotalCost" ></asp:DropDownList>
                <asp:ListItem Text="Choose One..." Value="" Selected="True" />
                <asp:ListItem Text="Regular" Value="Regular" />
                <asp:ListItem Text="Thin" Value="Thin" />
                <asp:ListItem Text="Thick (+$2)" Value="Thick" />
        
        </div>

        <div class ="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Sausage</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Pepperoni</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Onions</label></div>
        <div class ="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Green Peppers</label></div>






        <h3>Deliver To:</h3>

        <div class="form-group">
            <label>Name</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class="form-group">
            <label>Address</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

         <div class="form-group">
            <label>Zip</label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

         <div class="form-group">
            <label>Phone</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
         </div>







        <h3>Payment:</h3>
        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PaymentGroup" Checked ="true" />Cash</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup" />Credit</label></div>
        <asp:Label ID="validationLabel" runat="server" Text="" CssClass="bg-danger" Visible="false"></asp:Label>
        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click"/>




       <h3>Total Cost:<asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3> 

        <p>&nbsp;</p>
        <p>&nbsp;</p>

    </div>
    </form>
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</body>
</html>

