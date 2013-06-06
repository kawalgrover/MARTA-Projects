<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelfDelegation.ascx.cs" Inherits="MARTADelegations.SelfDelegation.SelfDelegation" %>
<div>
    <asp:Panel ID="pnlDelegation" runat="server">
        <asp:Label ID="lblMessage" runat="server" />
    <table>
        <tr>
            <td>Delegate To:</td>
            <td><SharePoint:PeopleEditor ID="spPeoplePicker" runat="server" SelectionSet="User" AllowEmpty="false" MultiSelect="false" />
                </td>
        </tr>
        <tr>
            <td>From:</td>
            <td><SharePoint:DateTimeControl ID="calDelegateFrom" runat="server" />
                </td>
        </tr>
        <tr>
            <td>To:</td>
            <td><SharePoint:DateTimeControl ID="calDelegateTo" runat="server" />
                </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
        </asp:Panel>

</div>