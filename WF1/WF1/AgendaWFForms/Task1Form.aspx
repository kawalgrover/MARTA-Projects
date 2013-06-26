<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" CodeBehind="Task1Form.aspx.cs" Inherits="WF1.Task1Form" MasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
     <SharePoint:UIVersionedContent ID="UIVersionedContent1" UIVersion="4" runat="server">
         <contenttemplate>
             <SharePoint:CssRegistration Name="forms.css" runat="server"/>
         </contenttemplate>
     </SharePoint:UIVersionedContent>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:ScriptManagerProxy runat="server" ID="ProxyScriptManager">
     </asp:ScriptManagerProxy>
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
                                        <SharePoint:FormField runat="server" ID="ff4" ControlMode="Display" FieldName="Title" /><br />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td width="25%" class="ms-formlabel">
                                        <b> Approve/Reject:</b>
                                     </td>
                                     <td width="75%" class="ms-formbody">
                                        <SharePoint:FormField runat="server" ID="ff1" ControlMode="Edit" FieldName="ApproveOrReject" />
                                         <SharePoint:FieldDescription runat="server" ID="ff1description" FieldName="ApproveOrReject"
                                             ControlMode="Edit" />
                                     </td>
                                 </tr>
                                <tr>
                                     <td width="25%" class="ms-formlabel">
                                        <b> Comments:</b>
                                     </td>
                                    <td width="75%" class="ms-formbody">
                                        <SharePoint:FormField runat="server" ID="ff2" ControlMode="Edit" FieldName="ActionComments" />
                                         <SharePoint:FieldDescription runat="server" ID="ff2description" FieldName="ActionComments"
                                            ControlMode="Edit" />
                                    </td>
                                 </tr>
                                 
                             </table>
                         </td>
                     </tr>
                 </table>
                 <table cellspacing="0" cellpadding="4" border="0" width="100%">
                     <tr>
                        <td nowrap="nowrap" class="ms-vb">
                             <asp:Button Text="Save As Draft" runat="server" ID="btnSaveAsDraft" />
                        </td>
                         <td>
                             <asp:Button Text="Complete Task" runat="server" ID="btnComplete" />
                         </td>
                         <td nowrap="nowrap" class="ms-vb" width="99%">
                             <asp:Button Text="Cancel" runat="server" ID="btnCancel" />
                         </td>
                     </tr>
                 </table>
             </td>
             <td width="1%" class="ms-vb" valign="top">&nbsp;</td>
         </tr>
     </table>

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
