<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartExecutiveTaskForm.aspx.cs" Inherits="ExecutiveTaskTracking.Layouts.ExecutiveTaskTracking.StartExecutiveTaskForm" MasterPageFile="~masterurl/default.master" %>
<%@ Register TagPrefix="wssuc" TagName="LinksTable" src="/_controltemplates/LinksTable.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="LinkSection" src="/_controltemplates/LinkSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" src="/_controltemplates/ButtonSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ActionBar" src="/_controltemplates/ActionBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" src="/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" src="/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="Welcome" src="/_controltemplates/Welcome.ascx" %>
<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
<asp:Table CellSpacing="0" CellPadding="0" BorderWidth="0" CssClass="ms-propertysheet">
    

    <input type="hidden" name="WorkflowDefinition" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["WorkflowDefinition"]),Response.Output); %>'/>
    <input type="hidden" name="WorkflowName" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["WorkflowName"]),Response.Output); %>'/>
    <input type="hidden" name="AddToStatusMenu" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["AddToStatusMenu"]),Response.Output); %>'/>
    <input type="hidden" name="AllowManual" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["AllowManual"]),Response.Output); %>'/>
    <input type="hidden" name="RoleSelect" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["RoleSelect"]),Response.Output); %>'/>
    <input type="hidden" name="GuidAssoc" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["GuidAssoc"]),Response.Output); %>'/>
    <input type="hidden" name="SetDefault" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["SetDefault"]),Response.Output); %>'/>
    <input type="hidden" name="HistoryList" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["HistoryList"]),Response.Output); %>'/>
    <input type="hidden" name="TaskList" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["TaskList"]),Response.Output); %>'/>
    <input type="hidden" name="UpdateLists" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["UpdateLists"]),Response.Output); %>'/>
    <input type="hidden" name="AutoStartCreate" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["AutoStartCreate"]),Response.Output); %>'/>
    <input type="hidden" name="AutoStartChange" value='<% SPHttpUtility.NoEncode(SPHttpUtility.HtmlEncode(Request.Form["AutoStartChange"]),Response.Output); %>'/>

    <wssuc:ButtonSection runat="server">
        <template_buttons>
            <asp:PlaceHolder runat="server">
                <asp:Button runat="server" class="ms-ButtonHeightWidth" OnClick="BtnOK_Click" Text="OK" id="btnOK" />
            </asp:PlaceHolder>
        </template_buttons>
    </wssuc:ButtonSection>
</asp:Table>
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
Start delegation for Executive Task
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
Start delegation for Executive task
</asp:Content>
