﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" CodeBehind="ContributeContentTask.aspx.cs" Inherits="BoardAgendaWorkflow.ContributeContentTask" MasterPageFile="~masterurl/default.master" %>


<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
 <SharePoint:UIVersionedContent ID="UIVersionedContent1" UIVersion="4" runat="server">
         <contenttemplate>
             <SharePoint:CssRegistration Name="forms.css" runat="server"/>
         </contenttemplate>
     </SharePoint:UIVersionedContent>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
<script language="ecmascript" type="text/ecmascript">

    
    $(document).ready(function () {
        $('tr.invisible').hide();

    });


</script>

     <asp:ScriptManagerProxy runat="server" ID="ProxyScriptManager">
     </asp:ScriptManagerProxy>
     <asp:panel ID="pnlTaskNotStarted" runat="server">
     <table width="100%" border="0" cellpadding="0" cellspacing="0">
         <tr>
             <td valign="top">
                <table cellspacing="0" cellpadding="4" border="0" width="100%">
                     <tr>
                         <td class="ms-vb">
                             &nbsp;
                         </td>
                     </tr>
                 </table>
                <table border="0" width="100%">
                     <tr>
                         <td>
                            <table border="0" cellspacing="0" width="100%">
                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b> Title:</b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                        <SharePoint:FormField runat="server" ID="ff4" ControlMode="Edit" FieldName="Title" /><br /> 
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b> Due Date:</b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                         <SharePoint:UserField id="dueDate" runat="server" FieldName="DueDate" ControlMode="Display"/>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b> Assigned To:</b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                         <SharePoint:UserField id="originalAssignee" runat="server" FieldName="AssignedTo" ControlMode="Display"/>
                                     </td>
                                 </tr>

                                 <!-- Delegate Task Start -->
                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b><asp:Label ID="lblDelegateTask" runat="server"> Delegate Task: </asp:Label></b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                       <asp:CheckBox runat="server" ID="chkDelegateTask" AutoPostBack="true" OnCheckChanged="chkDelegate_Checked" Text="Delegate Task" />
                                       <asp:Button Text="Re-assign to owner" runat="server" ID="btnReassignToOwner" />
                                     </td>
                                 </tr>

                                 <asp:Panel ID="pnlDelegateTask" runat="server" visible="false">
                                  <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b> Delegate To:</b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                         <SharePoint:UserField id="delegateTo" runat="server" FieldName="OriginalAssignee" ControlMode="Edit"/>
                                     </td>
                                 </tr>
                                
                                

                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b> Due Date:</b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                         <SharePoint:DateTimeControl id="delegateDueDate" runat="server" DateOnly="true" />
                                         <asp:CustomValidator ID="validateDueDate" runat="server" OnServerValidate="DueDateValidation" ErrorMessage="Due Date can not be past the original due date." />
                                     </td>
                                 </tr>
                                 
                                 <tr>
                                     <td class="ms-formlabel" valign="top" nowrap="true" width="25%">
                                        <b></b>
                                     </td>
                                     <td class="ms-formbody" valign="top" width="75%">
                                       <asp:Button Text="Delegate Task" runat="server" ID="btnDelegateTask" />
                                     </td>
                                 </tr>
                                
                                 </asp:Panel>
                                 
                                 <!-- Delegate Task End -->

                                 
                             </table>
                         </td>
                     </tr>
                 </table>
                 <table cellspacing="0" cellpadding="4" border="0" width="100%">
                     <tr>
                         <td>
                             <asp:Button Text="Completed" runat="server" ID="btnTaskCompleted" />
                         </td>
                         <td nowrap="nowrap" class="ms-vb">
                             <asp:Button Text="Cancel" runat="server" ID="btnCancel" />
                         </td>
                     </tr>
                 </table>
             </td>
             <td width="1%" class="ms-vb" valign="top">&nbsp;</td>
         </tr>
     </table>
     </asp:panel>
     <asp:panel ID="pnlTaskExpired" runat="server" visible="false">
        <span>This task is past its due date and has now been marked as 'Not Responded To' by the paperless board system administrator.</span>
     </asp:panel>

</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <SharePoint:ListFormPageTitle ID="ListFormPageTitle1" runat="server" />
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <span class="die">
         <SharePoint:ListProperty Property="LinkTitle" runat="server" ID="ID_LinkTitle" />
        : </span>
    <SharePoint:ListItemProperty ID="ID_ItemProperty" MaxLength="40" runat="server" />
</asp:Content>
