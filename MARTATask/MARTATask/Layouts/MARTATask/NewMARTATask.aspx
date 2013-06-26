<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMARTATask.aspx.cs" Inherits="MARTATask.Layouts.MARTATask.NewMARTATask" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">

      <table id="agendaFormTable"  border="0"  width="100%"> 
                     <tr> 
                         <td  class="ms-toolbar"  nowrap="nowrap"> 
                            <SharePoint:FormToolBar ID="FormToolBar1"  runat="server"  ControlMode="Display"  /> 
                         </td> 
                     </tr> 
                     <tr> 
                         <td> 
                                 <table  border="0"  cellspacing="0"  width="100%"> 
                                    
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Task Name</nobr> 
                                             </h3> 
                                         </td> 
                                        
		  -->
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Name"  ControlMode="Display"  FieldName="Task Name" FieldInternalName="Title" FieldType="SPFieldText" /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Name_Description"  FieldName="Task Name" 
                                                 ControlMode="Display" /> 
                                              
                                         </td> 
                                     </tr>
                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Start Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Title"  ControlMode="Display"  FieldName="Start Date"
			 FieldInternalName="StartDate"
			 FieldType="SPFieldDateTime"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Title_Description"  FieldName="Start Date"
			 FieldInternalName="StartDate"
			 FieldType="SPFieldDateTime" ControlMode="Display" /> 
                                              
                                         </td> 
                                     </tr>
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_DueDate"  ControlMode="New"  FieldName="Due Date" FieldInternalName="DueDate" FieldType="SPFieldDateTime"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DueDate_Description"  FieldName="Due Date" FieldInternalName="DueDate"
			 FieldType="SPFieldDateTime" ControlMode="Display"  /> 
                                         </td> 
                                     </tr> 
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Assigned To</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AssignedTo"  ControlMode="New"   FieldName="Assigned To"
			 FieldInternalName="AssignedTo"
			 FieldType="SPFieldUserMulti"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AssignedTo_Description"   FieldName="Assigned To"
			 FieldInternalName="AssignedTo"
			 FieldType="SPFieldUserMulti" ControlMode="Display"  /> 
                                            
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> % Complete</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_ReviewDueDate"  ControlMode="New"  FieldName="% Complete"
			 FieldInternalName="PercentComplete"
			 FieldType="SPFieldNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ReviewDueDate_Description"  FieldName="% Complete"
			 FieldInternalName="PercentComplete"
			 FieldType="SPFieldNumber" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Description </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Discipline"  ControlMode="Display"  FieldName="Description"
			 FieldInternalName="Body"
			 FieldType="SPFieldNote"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Discipline_Description"  FieldName="Description"
			 FieldInternalName="Body"
			 FieldType="SPFieldNote" ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Priority </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AlstomDocumentNumber"  ControlMode="Display"  FieldName="Priority"
			 FieldInternalName="Priority"
			 FieldType="SPFieldChoice"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AlstomDocumentNumber_Description"  FieldName="Priority"
			 FieldInternalName="Priority"
			 FieldType="SPFieldChoice"
                                                 ControlMode="Display" /> 
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Task Status </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                           <SharePoint:FormField  runat="server"  ID="field_CDRLList"  ControlMode="Display"  FieldName="Task Status"
			 FieldInternalName="Status"
			 FieldType="SPFieldChoice"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_CDRLList_Description"  FieldName="Task Status"
			 FieldInternalName="Status"
			 FieldType="SPFieldChoice" 
                                                 ControlMode="Display" /> 
                                         </td> 
                                     </tr>
                                    
                             
                             <SharePoint:ItemHiddenVersion ID="ItemHiddenVersion1"  runat="server"   /> 
                         </td> 
                     </tr> 
                 </table> 

</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
MARTA Task
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
MARTA Task
</asp:Content>
