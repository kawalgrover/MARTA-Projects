<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TCSUDocSetDisplayForm.aspx.cs" Inherits="TCSU.Layouts.TCSU.TCSUDocSetDisplayForm" DynamicMasterPageFile="~masterurl/default.master" %>

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
                                                 <nobr> Letter<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Letter"  ControlMode="Display"  FieldName="Letter"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Letter_Description"  FieldName="Letter" 
                                                 ControlMode="Display"  /> 
                                              
                                         </td> 
                                     </tr> 
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Transmittal</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_Transmittal"  ControlMode="Display"  FieldName="Transmittal"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Transmittal_Description"  FieldName="Transmittal" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr> 
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Submittal Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_SubmittalDate"  ControlMode="Display"  FieldName="SubmittalDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_SubmittalDate_Description"  FieldName="SubmittalDate" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr> 
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_DueDate"  ControlMode="Display"  FieldName="DueDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DueDate_Description"  FieldName="DueDate" 
                                                 ControlMode="Display"  /> 
                                            
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Review Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_ReviewDueDate"  ControlMode="Display"  FieldName="ReviewDueDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ReviewDueDate_Description"  FieldName="ReviewDueDate" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>


                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Submittal Type</nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_SubmittalType"  ControlMode="Display"  FieldName="SubmittalType"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_SubmittalType_Description"  FieldName="SubmittalType" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr> 

                                  

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Release </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Release"  ControlMode="Display"  FieldName="Release"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Release_Description"  FieldName="Release" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                  

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Revision </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Revision"  ControlMode="Display"  FieldName="Revision"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Revision_Description"  FieldName="Revision" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>
                                     

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Section/Function </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_SectionFunction"  ControlMode="Display"  FieldName="SectionFunction"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_SectionFunction_Description"  FieldName="SectionFunction" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Alstom Document Number </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AlstomDocumentNumber"  ControlMode="Display"  FieldName="AlstomDocumentNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AlstomDocumentNumber_Description"  FieldName="AlstomDocumentNumber" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> CDRL List </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                           <SharePoint:FormField  runat="server"  ID="field_CDRLList"  ControlMode="Display"  FieldName="CDRLList"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_CDRLList_Description"  FieldName="CDRLList" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Discipline </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Discipline"  ControlMode="Display"  FieldName="Discipline"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Discipline_Description"  FieldName="Discipline" 
                                                 ControlMode="Display"  /> 
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Location/Vehicle </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_LocationVehicle"  ControlMode="Display"  FieldName="LocationVehicle"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LocationVehicle_Description"  FieldName="LocationVehicle" 
                                                 ControlMode="Display"  /> 
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

</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >

</asp:Content>
