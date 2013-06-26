<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActionsOwedByUserWebPartUserControl.ascx.cs" Inherits="MARTAWebParts.ActionsOwedByUserWebPart.ActionsOwedByUserWebPartUserControl" %>

<div id="ActionsOwed">
    <table style="width:800px">
        <tr>
            <td style="width:50%"><asp:CheckBox ID="chkRecentTasksOnly" runat="server" AutoPostBack="true"  Text="Recent Tasks Only (Last 24 hrs)" /></td>
            <td style="width:50%"><asp:CheckBox ID="chkMyDelegatedTasks" runat="server" AutoPostBack="true" Text="My Delegated Tasks" /> </td>
        </tr>
        <tr>
            <td colspan="2">

            <SharePoint:SPGridView ID="grdActionsOwed" runat="server" AutoGenerateColumns="false" AllowSorting="true" AllowFiltering="true" DataKeyNames="TaskID, TaskLink, TaskSite" OnRowCommand="grdActionsOwed_RowComand">
                <Columns>
                    <asp:BoundField DataField="DueDateString" HeaderText="Due Date" SortExpression="DueDate" />
                    <asp:BoundField DataField="Action" HeaderText="Action Owed" SortExpression="Action" />
                    <asp:BoundField DataField="Source" HeaderText="Source" SortExpression="Source" />
                    
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    
                    <asp:CheckBoxField DataField="IsDelegated" HeaderText="Delegated" SortExpression="IsDelegated" />
                    <asp:BoundField DataField="OriginalAssignee" HeaderText="Original Assignee" SortExpression="OriginalAssignee" />
                    
                    <asp:ButtonField ButtonType="Link" HeaderText="Task" Text="Task" CommandName="Task" />
                    <asp:ButtonField ButtonType="Link" HeaderText="Related Content" Text="Documents" CommandName="Documents" />
                    
                </Columns>
            </SharePoint:SPGridView>
               
            </td>
        </tr>
        
    </table>
</div>