<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="CalculatorApp.CalculatorUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="div_id">
                <span>
                    <span>ID</span>
                    <asp:Label ID="idLabel" runat="server" />
                </span>
            </div>

            <table>
                <tr>
                    <td>Department
                    </td>
                    <td>
                        <asp:DropDownList ID="departmentDropDownList" runat="server">
                        </asp:DropDownList>
                    </td>

                </tr>

                <tr>
                    <td>First Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>Address
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>

                </tr>


            </table>



        </div>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="addButton_Click" Text="Save" Width="73px" />
            <asp:Button ID="retrieveButton" runat="server" Text="Retrieve" OnClick="retrieveButton_Click" />
        </p>

        <asp:Label ID="messageLabel" runat="server" />
    </form>
</body>
</html>
