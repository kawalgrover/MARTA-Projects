<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExecTaskNewForm.aspx.cs" Inherits="ExecutiveTaskTracking.Layouts.ExecutiveTaskTracking.ExecTaskNewForm" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">



     <h2>Executive Task Tracking for: <asp:Label runat="server" ID="lblExecutiveTaskSource"></asp:Label></h2>
     <h3>Task Coordinator: <asp:Label runat="server" ID="lblExeutiveTaskCoordinator"></asp:Label> </h3>
     <table id="newExecutiveTask"  border="0"  width="100%"> 
                     <tr> 
                         <td  class="ms-toolbar"  nowrap="nowrap"> 
                            <SharePoint:FormToolBar ID="FormToolBar1"  runat="server"  ControlMode="New"  /> 
                         </td> 
                     </tr> 
                     <tr> 
                         <td> 
                                 <table  border="0"  cellspacing="0"  width="100%"> 
                                    <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Subject<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Name"  ControlMode="New"  FieldName="Name"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Name_description"  FieldName="Name" 
                                                 ControlMode="New"  /> 
                                              
                                         </td> 
                                     </tr> 
                                     <tr style="height:20px">
                                        <td colspan="2"></td>
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> High Priority</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_HighPriority"  ControlMode="New"  FieldName="HighPriority"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_HighPriority_Description"  FieldName="HighPriority" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                      <tr style="height:20px">
                                        <td colspan="2"></td>
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> To:</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_DelegateTo"  ControlMode="New"  FieldName="DelegateTo"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DelegateTo_Description"  FieldName="DelegateTo" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                      <tr style="height:20px">
                                        <td colspan="2"></td>
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_DelegateDueDate"  ControlMode="New"  FieldName="DelegateDueDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DueDate_Description"  FieldName="DelegateDueDate" 
                                                 ControlMode="New"  /> 
                                            
                                         </td> 
                                     </tr>
                                      <tr style="height:20px">
                                        <td colspan="2"></td>
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Action Required</nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_ActionRequired"  ControlMode="New"  FieldName="ActionRequired"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ActionRequired_Description"  FieldName="ActionRequired" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 

                                     

                                     
                                    
                                    <tr>
                                        <td colspan="2">
                                          <table  width="100%"  border="0"  cellspacing="0"> 
                                             <tr> 
                                                 <td  width="99%"  class="ms-toolbar"  nowrap="nowrap"> 
                                                     <img  src="/_layouts/images/blank.gif"  width="1"  height="18" alt=""  /> 
                                                 </td> 
                                                 <td  class="ms-toolbar"  nowrap="nowrap"> 
                                                     <SharePoint:SaveButton  runat="server"  ControlMode="New"  ID="savebutton"  /> 
                                                </td> 
                                                 <td  class="ms-separator"> 
                                                 </td> 
                                                 <td  class="ms-toolbar"  nowrap="nowrap"  align="right"> 
                                                     <SharePoint:GoBackButton  runat="server"  ControlMode="New"  ID="gobackbutton"  /> 
                                                 </td> 
                                             </tr> 
                                         </table> 
                                        </td>
                                    </tr>
                                    
                                    
                                    
                             
                             <SharePoint:ItemHiddenVersion ID="ItemHiddenVersion1"  runat="server"   /> 
                         </td> 
                     </tr> 
                 </table> 
 
 
	
<SharePoint:UIVersionedContent ID="UIVersionedContent1" UIVersion="4" runat="server">
	
</SharePoint:UIVersionedContent>


</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
New Executive Task
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
New Executive Task
</asp:Content>
