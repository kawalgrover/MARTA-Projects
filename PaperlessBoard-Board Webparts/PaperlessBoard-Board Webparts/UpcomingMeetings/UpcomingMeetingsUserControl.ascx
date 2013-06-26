<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpcomingMeetingsUserControl.ascx.cs" Inherits="PaperlessBoard_Board_Webparts.TodaysMeetings.UpcomingMeetingsUserControl" %>

<div id="FutureMeetings">
    <table style="width:400px">
        
        <tr>
            <td colspan="2">

            <SharePoint:SPGridView ID="grdMeetings" runat="server" AutoGenerateColumns="false" AllowSorting="true" AllowFiltering="true" DataKeyNames="MeetingID, Workspace" OnRowCommand="grdActionsOwed_RowComand">
                
                <Columns>
                    
                    <asp:TemplateField HeaderText="Meeting" ItemStyle-Font-Bold="true">
                        <ItemStyle Height="30px" />
                        <ItemTemplate>
                            <a href="<%# Eval("Workspace") %>"><%# Eval("Title") %></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </SharePoint:SPGridView>
               
            </td>
        </tr>
        
    </table>
</div>