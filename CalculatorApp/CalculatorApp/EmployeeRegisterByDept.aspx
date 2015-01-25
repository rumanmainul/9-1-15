<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegisterByDept.aspx.cs" Inherits="CalculatorApp.EmployeeRegisterByDept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:DropDownList ID="departmentDropDownList" runat="server" OnSelectedIndexChanged="departmentDropDownList_SelectedIndexChanged" />
            </p>
            <p>
            <asp:DropDownList ID="employeeDropDownList" runat="server" />
            </p>

            <p>
                <asp:Button runat="server" ID="confirmButton" OnClick="confirmButton_Click" Text="Confirm" />
            </p>
        </div>
    </form>
</body>
</html>
