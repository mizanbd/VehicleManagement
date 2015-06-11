<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VehicalSecheduleUI.aspx.cs" Inherits="Vehicle_Schedule_Management.VehicalSecheduleUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <h1> Sechedule vehicle</h1>
        <asp:Label ID="Label5" runat="server" Text="Select Vehicle"></asp:Label><br/>
        <asp:DropDownList ID="regNoDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Reg_No" DataValueField="Reg_No"></asp:DropDownList>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VehicleDBConnectionString %>" SelectCommand="SELECT [Reg_No] FROM [tbl_VehicleInfo]"></asp:SqlDataSource>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Select Date"></asp:Label><br/>
        <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="Select shift"></asp:Label><br/>
        <asp:DropDownList ID="shiftDropDownList" runat="server">
            <asp:ListItem>Morning</asp:ListItem>
            <asp:ListItem>Evening</asp:ListItem>
        </asp:DropDownList><br/>
        <asp:Label ID="Label3" runat="server" Text="Booked By"></asp:Label><br/>
        <asp:TextBox ID="bookedByTextBox" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label><br/>
        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox><br/>
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
    </div>
    

</asp:Content>
