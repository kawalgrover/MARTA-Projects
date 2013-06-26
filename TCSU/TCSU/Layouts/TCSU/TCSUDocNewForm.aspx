<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TCSUDocNewForm.aspx.cs" Inherits="TCSU.Layouts.TCSUDocNewForm" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">

<SharePoint:ScriptLink ID="ScriptLink1" Name="SP.js" runat="server" OnDemand="true" Localizable="false" />
<SharePoint:ScriptLink ID="ScriptLink2" Name="jquery-1.6.1.min.js" runat="server" OnDemand="true" Localizable="false" />

<script language="ecmascript" type="text/ecmascript">

    var lic;
    $(document).ready(function () {
        $('tr.invisible').hide();


        $('input[id*=field_CDRLList]').attr("readonly", true);


        $('select[id*=ddlAlstomDocumentNumbers]').bind('change', function (e) {
            var docNumber = $(this).val();
            if (docNumber != "0") {
                $('input[id*=field_AlstomDocumentNumber]').val(docNumber);
                LoadCDRLList(docNumber);
            } else {
                $('input[id*=field_AlstomDocumentNumber]').val('');
            }
        });

        $('select[id*=field_Discipline]').bind('change', function (e) {
            var discipline = $(this).val();
            $('input[id*=field_LocationVehicle]').val('');
            if (discipline != "") {
                //$('input[id*=field_Discipline]').val(discipline);
                LoadLocationVehicles(discipline);
            } else {
                $("select[id*=lbLocationVehicles] > option").remove();
            }
        });

        $('select[id*=lbLocationVehicles]').bind('change', function (e) {
            var discipline = $(this).val();
            $('input[id*=field_LocationVehicle]').val(discipline);

        });

        
    });

    function LoadCDRLList(documentNumber) {

        var ctx = new SP.ClientContext.get_current();
        var targetList = ctx.get_web().get_lists().getByTitle('DocumentNumbers');
        var query = "<View><Query><Where><Eq><FieldRef Name='AlstomDocumentDescription'/><Value Type='Text'>" + documentNumber + "</Value></Eq></Where></Query></View>";
        var cq = new SP.CamlQuery();
        cq.set_viewXml(query);

        lic = targetList.getItems(cq);

        ctx.load(lic);

        ctx.executeQueryAsync(Function.createDelegate(this, getAllDocumentsSuccess),
                        Function.createDelegate(this, getAllItemsFailure));
    }

    function LoadLocationVehicles(descipline) {
        $("select[id*=lbLocationVehicles] > option").remove();

        var ctx = new SP.ClientContext.get_current();
        var targetList = ctx.get_web().get_lists().getByTitle('Disciplines');
        var query = "<View><Query><Where><Eq><FieldRef Name='Discipline'/><Value Type='Text'>" + descipline + "</Value></Eq></Where></Query></View>";
        var cq = new SP.CamlQuery();
        cq.set_viewXml(query);

        lic = targetList.getItems(cq);

        ctx.load(lic);

        ctx.executeQueryAsync(Function.createDelegate(this, getAllLocationsSuccess),
                        Function.createDelegate(this, getAllItemsFailure));
    }



    function getAllLocationsSuccess(sender, args) {
        var listEnumerator = lic.getEnumerator();
        while (listEnumerator.moveNext()) {
            var locationVehicle = listEnumerator.get_current().get_item("Title") + " - " + listEnumerator.get_current().get_item("Code")
            AddItem(locationVehicle, locationVehicle);
        }
    }

    function getAllDocumentsSuccess(sender, args) {

        var listEnumerator = lic.getEnumerator();
        while (listEnumerator.moveNext()) {
            $('input[id*=field_CDRLList]').val(listEnumerator.get_current().get_item("Title"));
        }
    }

    function AddItem(text, val) {
        // Create an Option object
        $('select[id*=lbLocationVehicles]').append($('<option></option>').val(val).html(text));

    }
    

    function getAllItemsFailure(sender, args) {
        alert('Failed to get list items. \nError: ' + args.get_message() + '\nStackTrace: ' + args.get_stackTrace());
    }
   

    
   

</script>

     <table id="agendaFormTable"  border="0"  width="100%"> 
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
                                                 <nobr> Name<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Name"  ControlMode="New"  FieldName="Name"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Name_Description"  FieldName="Name" 
                                                 ControlMode="New"  /> 
                                              
                                         </td> 
                                     </tr>
                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Title</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Title"  ControlMode="New"  FieldName="Title"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Title_Description"  FieldName="Title" 
                                                 ControlMode="New"  /> 
                                              
                                         </td> 
                                     </tr>
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Submittal Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_SubmittalDate"  ControlMode="New"  FieldName="SubmittalDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_SubmittalDate_Description"  FieldName="SubmittalDate" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_DueDate"  ControlMode="New"  FieldName="DueDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_DueDate_Description"  FieldName="DueDate" 
                                                 ControlMode="New"  /> 
                                            
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Review Due Date</nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_ReviewDueDate"  ControlMode="New"  FieldName="ReviewDueDate"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_ReviewDueDate_Description"  FieldName="ReviewDueDate" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr>
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Discipline </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Discipline"  ControlMode="New"  FieldName="Discipline"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Discipline_Description"  FieldName="Discipline" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr>
                                     
                                     <tr>
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr>Select a Location/Vehicle: </nobr> 
                                            </h3> 
                                         </td> 
                                         <td>
                                            <asp:ListBox ID="lbLocationVehicles" runat="server" SelectionMode="Single"></asp:ListBox>
                                         </td>
                                     </tr>
                                     
                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Location/Vehicle </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_LocationVehicle"  ControlMode="New"  FieldName="LocationVehicle"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_LocationVehicle_Description"  FieldName="LocationVehicle" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr>
                                    

                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Alstom Document Number </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                              <asp:DropDownList ID="ddlAlstomDocumentNumbers" runat="server" /> 
                                               <br />
                                             <span>For adding/editing Alstom Document Numbers items, click <asp:HyperLink ID="lnkDocumentNumbers" runat="server">here.</asp:HyperLink> </span>
                                         </td> 
                                     </tr>

                                     <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Alstom Document Number </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AlstomDocumentNumber"  ControlMode="New"  FieldName="AlstomDocumentNumber"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AlstomDocumentNumber_Description"  FieldName="AlstomDocumentNumber" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr>

                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> CDRL List </nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                           <SharePoint:FormField  runat="server"  ID="field_CDRLList"  ControlMode="New"  FieldName="CDRLList"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_CDRLList_Description"  FieldName="CDRLList" 
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
New TCSU Document
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
New TCSU Document
</asp:Content>
