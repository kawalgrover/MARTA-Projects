<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerDelegation.ascx.cs" Inherits="MARTADelegations.Webparts.ManagerDelegation.ManagerDelegation" %>
<div>
    <asp:Label ID="lblMessage" runat="server" />
    <asp:Panel ID="pnlDelegation" runat="server">
       
    <table>
        <tr>
            <td width="113" class="ms-formlabel" nowrap="true" valign="top">Delegate To:</td>
            <td width="350" class="ms-formbody" valign="top">
                <asp:DropDownList ID="ddlSubordinates" runat="server" />
            </td>
        </tr>
        <tr>
            <td width="113" class="ms-formlabel" nowrap="true" valign="top">From:</td>
            <td width="350" class="ms-formbody" valign="top">
                <SharePoint:DateTimeControl ID="calDelegateFrom" runat="server" />
            </td>
        </tr>
        <tr>
            <td width="113" class="ms-formlabel" nowrap="true" valign="top">To:</td>
            <td width="350" class="ms-formbody" valign="top">
                <SharePoint:DateTimeControl ID="calDelegateTo" runat="server" />
                </td>
        </tr>
        <tr>
            <td width="100%" align="center" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
        </asp:Panel>

</div>