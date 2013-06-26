<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%@ Page Language="C#" CodeBehind="ReviewWFInit.aspx.cs" Inherits="BoardAgendaWorkflows.ReviewWFInit" MasterPageFile="~masterurl/default.master" %>

<%@ Register TagPrefix="wssuc" TagName="LinksTable" src="/_controltemplates/LinksTable.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="LinkSection" src="/_controltemplates/LinkSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" src="/_controltemplates/ButtonSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ActionBar" src="/_controltemplates/ActionBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" src="/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" src="/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="Welcome" src="/_controltemplates/Welcome.ascx" %>



<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Table CellSpacing="0" CellPadding="0" BorderWidth="0" CssClass="ms-propertysheet">
    <wssuc:InputFormSection Title="Workflow Data Values" Description="Specify the default workflow data values." runat="server">
        <template_inputformcontrols>
            <wssuc:InputFormControl Runat="server" LabelText="Specify which positions should review and approve the agenda documents:">
                <Template_Control>
                   
                    <br/>
                    
                    <table border="0" cellspacing="0" cellpadding="0">
                        <!-- Start your modifications here -->
                        <tr>
                            <td width="30%">
                            <td width="20%">
                            <td width="30%">
                            <td width="20%">
                        </tr>
                        <tr>
                            <td class="ms-authoringcontrols" width="30%">
                                GM :
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_gm" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                              
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                               
                            </td>
                        </tr>
                        <tr>
                            <td class="ms-authoringcontrols" width="30%">
                                DGM :
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_dgm" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                                CBSS :
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_cbss" runat="server" /> 
                            </td>
                        </tr>

                         
                        <tr>
                            <td class="ms-authoringcontrols" width="30%">
                                AGM - Finance :
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_finance" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                                AGM - Information Technology :
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_it" runat="server" /> 
                            </td>
                        </tr>
                         <tr>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Planning  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_planning" runat="server" /> 
                            </td>
                             <td class="ms-authoringcontrols"  width="30%">
                               AGM - Human Resources  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_humanresources" runat="server" /> 
                            </td>
                         </tr>
                         <tr>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Safety & QA  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_safety" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Legal/Chief Counsel  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_legal" runat="server" /> 
                            </td>
                         </tr>
                         <tr>
                           <td class="ms-authoringcontrols"  width="30%">
                               AGM - Contracts & Procurement  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_contracts" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Audit  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_audit" runat="server" /> 
                            </td>
                         </tr>  
                         <tr>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Bus Operations : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_busoperations" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Rail Operations  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_railoperations" runat="server" /> 
                            </td>
                         </tr> 
                        
                         <tr>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Communications & External Affairs  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_communications" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                               AGM - Police : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_agm_police" runat="server" /> 
                            </td>
                         </tr> 
                         <tr>
                            <td class="ms-authoringcontrols"  width="30%">
                               Executive Director - DEO  : 
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                                <asp:CheckBox ID="chk_executive_director" runat="server" /> 
                            </td>
                            <td class="ms-authoringcontrols"  width="30%">
                               
                            </td>
                            <td class="ms-authoringcontrols" width="20%">
                               
                            </td>
                         </tr>
                          

                          <tr>
                            <td colspan=4" height="20px"></td>
                         </tr>
                          <tr>
                            
                            <td class="ms-authoringcontrols" width="30%">
                                Select Reviewers (Up to 4 reviewers allowed):
                            <td>
                            <td class="ms-authoringcontrols" colspan="3">
                               <SharePoint:PeopleEditor AllowEmpty="true" 
                                            ValidatorEnabled="true"
                                            id="userPicker"
                                            runat="server"
                                            ShowCreateButtonInActiveDirectoryAccountCreationMode="true"
                                            SelectionSet="User"/>
                            </td>
                        </tr>
                        
                    </table>
                    
                    
                </Template_Control>
            </wssuc:InputFormControl>
        </template_inputformcontrols>
    </wssuc:InputFormSection>

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
Review Agenda Workflow 
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
Review Agenda Workflow Initiation Page
</asp:Content>
