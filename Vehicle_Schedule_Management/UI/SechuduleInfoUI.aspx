<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SechuduleInfoUI.aspx.cs" Inherits="Vehicle_Schedule_Management.SechuduleInfoUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> View schedule of a vehicle </h1>

    <asp:Label ID="Label1" runat="server" Text="Select Vehicle"></asp:Label><br/>
    <asp:DropDownList ID="regNoDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Vehicle_id" DataValueField="Vehicle_id"></asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VehicleDBConnectionString %>" SelectCommand="SELECT [Vehicle_id] FROM [Table_1]"></asp:SqlDataSource>

    <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
    <br />
    <asp:GridView ID="sechuduleGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="202px">
        <Columns>
            <asp:BoundField DataField="Select_Date" HeaderText="Select_Date" SortExpression="Select_Date" />
            <asp:BoundField DataField="Select_Shift" HeaderText="Select_Shift" SortExpression="Select_Shift" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:VehicleDBConnectionString %>" SelectCommand="SELECT [Select_Date], [Select_Shift] FROM [Table_1]"></asp:SqlDataSource>
    <br />
    <br />
    
    


</asp:Content>
