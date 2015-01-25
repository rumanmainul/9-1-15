<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployeeUI.aspx.cs" Inherits="EmployeeDepartmentApp.UI.AddEmployeeUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 337px; height: 223px; padding: 10px; color: #fff; margin-top:10px; background: #FFB401; border-radius: 5px; margin-left: auto; margin-right: auto; margin-bottom: 0;">
        <table width="100%">
        <tr><td>ID:</td><td><asp:Label runat="server" ID="EmployeeLabel"></asp:Label></td></tr>
        <tr><td>Department name:</td><td>
            <asp:DropDownList ID="DropDownListDptName" runat="server" AccessKey="0">
                <asp:ListItem Value="select">Select</asp:ListItem>
            </asp:DropDownList>
            </td></tr>
            <tr><td>Name:</td><td><asp:TextBox runat="server" ID="EmployeeNameTextBox"></asp:TextBox></td></tr>
        <tr><td>Address:</td><td><asp:TextBox runat="server" ID="AddressTextBox"></asp:TextBox></td></tr>
        <tr><td><asp:Label runat="server" ID="AlertLabel"></asp:Label></td><td><asp:Button runat="server" ID="SaveButton" Text="Save" OnClick="SaveButton_Click"/></td></tr>
    </table>
    </div>
</asp:Content>
