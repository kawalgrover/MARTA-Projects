<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgendaListUserControl.ascx.cs" Inherits="PaperlessBoard_Board_Webparts.AgendaList.AgendaListUserControl" %>

<div id="AgendaList">
    <div id="StatusMessage">
        <asp:Label runat="server" ID="lblStatusMessage"></asp:Label>
    </div>
    <table style="width:100%">
        <tr>
            <td colspan="2">
                <table style="width:100%;font-weight:bold">
                    <tr style="height:30px">
                        <td style="width:10%">Item Number</td>
                        <td style="width:55%">Subject</td>
                        <td style="width:20%">Presenter</td>
                        <td style="width:15%">Documents</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2">

            <SharePoint:SPGridView ID="grdAgendaList" runat="server" AutoGenerateColumns="false"  DataKeyNames="ID, Documents" OnRowCommand="grdActionsOwed_RowComand" ShowHeader="false">
            
                <Columns>
                    <asp:BoundField DataField="ItemNumber" HeaderText="Item Number" ItemStyle-Width="10%"  />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" ItemStyle-Width="55%" />
                    <asp:BoundField DataField="Sponsor" HeaderText="Presenter" SortExpression="Action" ItemStyle-Width="20%" />
                    <asp:TemplateField HeaderText="Meeting" ItemStyle-Font-Bold="true">
                        <ItemStyle Height="30px" />
                        <ItemTemplate>
                            <a href="<%# (bool)Eval("IsPublished") == true ? Eval("Documents") : "" %>"><%# (bool) Eval("IsPublished") == true ? "Documents" : ""%></a>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </SharePoint:SPGridView>
               
            </td>
        </tr>
        
    </table>
</div>
