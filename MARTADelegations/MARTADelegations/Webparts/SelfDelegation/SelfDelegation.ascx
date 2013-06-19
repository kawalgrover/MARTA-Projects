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
                <td width="25%" class="ms-formlabel" nowrap="true" valign="top">Delegate To:</td>
                <td width="75%" class="ms-formbody" valign="top"><SharePoint:PeopleEditor ID="spPeoplePicker" runat="server" SelectionSet="User" AllowEmpty="false" MultiSelect="false" />
                    </td>
            </tr>
            <tr>
                <td width="113" class="ms-formlabel" nowrap="true" valign="top">From:</td>
                <td width="350" class="ms-formbody" valign="top"><SharePoint:DateTimeControl ID="calDelegateFrom" runat="server" />
                    </td>
            </tr>
            <tr>
                <td width="113" class="ms-formlabel" nowrap="true" valign="top">To:</td>
                <td width="350" class="ms-formbody" valign="top"><SharePoint:DateTimeControl ID="calDelegateTo" runat="server" />
                    </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:HiddenField ID="delegationID" runat="server" />
                </td>
            </tr>
        </table>
    </asp:Panel>

   <asp:Panel ID="pnlAllDelegations" runat="server">
       <SharePoint:SPGridView ID="grdAllDelegations" runat="server" AutoGenerateColumns="false" DataKeyNames="Id">
           <Columns>
               <asp:BoundField HeaderText="Delegate To" DataField="AssignedTo" />
               <asp:BoundField HeaderText="From" DataField="StartDate" />
               <asp:BoundField HeaderText="To" DataField="EndDate" />
               <asp:BoundField HeaderText="Type" DataField="DelegationType" />
               <asp:TemplateField HeaderText ="">
                   <ItemTemplate>
                       <asp:Button ID="btnEditDelegation" runat="server" Text="Edit" Visible='<%# (Eval("DelegationType").ToString() == "Self") ? true : false %>' CommandName="EditDelegation" CommandArgument='<%# Eval("Id") %>' OnCommand="btnEditDelegation_Command" />
                       <asp:Button ID="btnDeleteDelegation" runat="server" Text="Delete" Visible='<%# (Eval("DelegationType").ToString() == "Self") ? true : false %>' CommandName="DeleteDelegation" CommandArgument='<%# Eval("Id") %>' OnCommand="btnDeleteDelegation_Command" />
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
       </SharePoint:SPGridView>
   </asp:Panel>
    
</div>

