<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Page Language="C#" CodeBehind="NewAgenda.aspx.cs" Inherits="MARTA.PaperlessBoard.NewAgenda" MasterPageFile="~masterurl/default.master" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:ListFormPageTitle runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server">
	<span class="die">
	<SharePoint:ListProperty Property="LinkTitle" runat="server" id="ID_LinkTitle"/>
	: </span>
	<SharePoint:ListItemProperty id="ID_ItemProperty" maxlength="40" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server">
	<img src="/_layouts/images/blank.gif" width='1' height='1' alt="" />
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderLeftNavBar" runat="server" >
<SharePoint:UIVersionedContent UIVersion="4" runat="server">
	<ContentTemplate>
				<div class="ms-quicklaunchouter">
				<div class="ms-quickLaunch">
				<SharePoint:UIVersionedContent UIVersion="3" runat="server">
					<ContentTemplate>
						<h3 class="ms-standardheader"><label class="ms-hidden"><SharePoint:EncodedLiteral runat="server" text="<%$Resources:wss,quiklnch_pagetitle%>" EncodeMethod="HtmlEncode"/></label>
						<Sharepoint:SPSecurityTrimmedControl runat="server" PermissionsString="ViewFormPages">
							<div class="ms-quicklaunchheader"><SharePoint:SPLinkButton id="idNavLinkViewAll" runat="server" NavigateUrl="~site/_layouts/viewlsts.aspx" Text="<%$Resources:wss,quiklnch_allcontent%>" accesskey="<%$Resources:wss,quiklnch_allcontent_AK%>"/></div>
						</SharePoint:SPSecurityTrimmedControl>
						</h3>
					</ContentTemplate>
				</SharePoint:UIVersionedContent>
				<Sharepoint:SPNavigationManager
				id="QuickLaunchNavigationManager"
				runat="server"
				QuickLaunchControlId="QuickLaunchMenu"
				ContainedControl="QuickLaunch"
				EnableViewState="false"
				CssClass="ms-quicklaunch-navmgr"
				>
				<div>
					<SharePoint:DelegateControl runat="server" ControlId="QuickLaunchDataSource">
						<Template_Controls>
						<asp:SiteMapDataSource SiteMapProvider="SPNavigationProvider" ShowStartingNode="False" id="QuickLaunchSiteMap" StartingNodeUrl="sid:1025" runat="server" />
					 </Template_Controls>
					</SharePoint:DelegateControl>
					<SharePoint:UIVersionedContent UIVersion="3" runat="server">
						<ContentTemplate>
							<SharePoint:AspMenu id="QuickLaunchMenu" runat="server" DataSourceId="QuickLaunchSiteMap" Orientation="Vertical" StaticDisplayLevels="2" ItemWrap="true" MaximumDynamicDisplayLevels="0" StaticSubMenuIndent="0" SkipLinkText="" CssClass="s4-die">
								<LevelMenuItemStyles>
									<asp:menuitemstyle CssClass="ms-navheader" />
									<asp:menuitemstyle CssClass="ms-navitem" />
								</LevelMenuItemStyles>
								<LevelSubMenuStyles>
									<asp:submenustyle CssClass="ms-navSubMenu1" />
									<asp:submenustyle CssClass="ms-navSubMenu2" />
								</LevelSubMenuStyles>
								<LevelSelectedStyles>
									<asp:menuitemstyle CssClass="ms-selectednavheader" />
									<asp:menuitemstyle CssClass="ms-selectednav" />
								</LevelSelectedStyles>
							</SharePoint:AspMenu>
						</ContentTemplate>
					</SharePoint:UIVersionedContent>
					<SharePoint:UIVersionedContent UIVersion="4" runat="server">
						<ContentTemplate>
							<SharePoint:AspMenu id="V4QuickLaunchMenu" runat="server" EnableViewState="false" DataSourceId="QuickLaunchSiteMap" UseSimpleRendering="true" Orientation="Vertical" StaticDisplayLevels="2" MaximumDynamicDisplayLevels="0" SkipLinkText="" CssClass="s4-ql" />
						</ContentTemplate>
					</SharePoint:UIVersionedContent>
				</div>
				</Sharepoint:SPNavigationManager>
			<Sharepoint:UIVersionedContent runat="server" UIVersion="3">
				<ContentTemplate>
					<Sharepoint:SPNavigationManager
					id="TreeViewNavigationManager"
					runat="server"
					ContainedControl="TreeView"
					>
					  <table class="ms-navSubMenu1" cellpadding="0" cellspacing="0" border="0">
						<tr>
						  <td>
							<table class="ms-navheader" width="100%" cellpadding="0" cellspacing="0" border="0">
							  <tr>
								<td nowrap="nowrap" id="idSiteHierarchy">
								  <SharePoint:SPLinkButton runat="server" NavigateUrl="~site/_layouts/viewlsts.aspx" id="idNavLinkSiteHierarchy" Text="<%$Resources:wss,treeview_header%>" accesskey="<%$Resources:wss,quiklnch_allcontent_AK%>"/>
								</td>
							  </tr>
							</table>
						  </td>
						</tr>
					  </table>
					  <div class="ms-treeviewouter">
						<SharePoint:DelegateControl runat="server" ControlId="TreeViewAndDataSource">
						  <Template_Controls>
							<SharePoint:SPHierarchyDataSourceControl
							 runat="server"
							 id="TreeViewDataSource"
							 RootContextObject="Web"
							 IncludeDiscussionFolders="true"
							/>
							<SharePoint:SPRememberScroll runat="server" id="TreeViewRememberScroll" onscroll="javascript:_spRecordScrollPositions(this);" style="overflow: auto;height: 400px;width: 150px; ">
							  <Sharepoint:SPTreeView
								id="WebTreeView"
								runat="server"
								ShowLines="false"
								DataSourceId="TreeViewDataSource"
								ExpandDepth="0"
								SelectedNodeStyle-CssClass="ms-tvselected"
								NodeStyle-CssClass="ms-navitem"
								NodeStyle-HorizontalPadding="2"
								SkipLinkText=""
								NodeIndent="12"
								ExpandImageUrl="/_layouts/images/tvplus.gif"
								CollapseImageUrl="/_layouts/images/tvminus.gif"
								NoExpandImageUrl="/_layouts/images/tvblank.gif"
							  >
							  </Sharepoint:SPTreeView>
							</Sharepoint:SPRememberScroll>
						  </Template_Controls>
						</SharePoint:DelegateControl>
					  </div>
					</Sharepoint:SPNavigationManager>
				</ContentTemplate>
			</SharePoint:UIVersionedContent>
			<Sharepoint:UIVersionedContent runat="server" UIVersion="4">
				<ContentTemplate>
					<Sharepoint:SPNavigationManager
					id="TreeViewNavigationManagerV4"
					runat="server"
					ContainedControl="TreeView"
					CssClass="s4-treeView"
					>
					  <SharePoint:SPLinkButton runat="server" NavigateUrl="~site/_layouts/viewlsts.aspx" id="idNavLinkSiteHierarchyV4" Text="<%$Resources:wss,treeview_header%>" accesskey="<%$Resources:wss,quiklnch_allcontent_AK%>" CssClass="s4-qlheader" />
						  <div class="ms-treeviewouter">
							<SharePoint:DelegateControl runat="server" ControlId="TreeViewAndDataSource">
							  <Template_Controls>
								<SharePoint:SPHierarchyDataSourceControl
								 runat="server"
								 id="TreeViewDataSourceV4"
								 RootContextObject="Web"
								 IncludeDiscussionFolders="true"
								/>
								<SharePoint:SPRememberScroll runat="server" id="TreeViewRememberScrollV4" onscroll="javascript:_spRecordScrollPositions(this);" style="overflow: auto;height: 400px;width: 155px; ">
								  <Sharepoint:SPTreeView
									id="WebTreeViewV4"
									runat="server"
									ShowLines="false"
									DataSourceId="TreeViewDataSourceV4"
									ExpandDepth="0"
									SelectedNodeStyle-CssClass="ms-tvselected"
									NodeStyle-CssClass="ms-navitem"
									SkipLinkText=""
									NodeIndent="12"
									ExpandImageUrl="/_layouts/images/tvclosed.png"
									ExpandImageUrlRtl="/_layouts/images/tvclosedrtl.png"
									CollapseImageUrl="/_layouts/images/tvopen.png"
									CollapseImageUrlRtl="/_layouts/images/tvopenrtl.png"
									NoExpandImageUrl="/_layouts/images/tvblank.gif"
								  >
								  </Sharepoint:SPTreeView>
								</Sharepoint:SPRememberScroll>
							  </Template_Controls>
							</SharePoint:DelegateControl>
						  </div>
					</Sharepoint:SPNavigationManager>
				</ContentTemplate>
			</SharePoint:UIVersionedContent>
				<SharePoint:UIVersionedContent UIVersion="3" runat="server" id="PlaceHolderQuickLaunchBottomV3">
					<ContentTemplate>
						<table width="100%" cellpadding="0" cellspacing="0" border="0" class="s4-die">
						<tbody>
						<tr><td>
						<table class="ms-recyclebin" width="100%" cellpadding="0" cellspacing="0" border="0">
						<tbody>
						<tr><td nowrap="nowrap">
						<SharePoint:SPLinkButton runat="server" NavigateUrl="~site/_layouts/recyclebin.aspx" id="v3idNavLinkRecycleBin" ImageUrl="/_layouts/images/recycbin.gif" Text="<%$Resources:wss,StsDefault_RecycleBin%>" PermissionsString="DeleteListItems" />
						</td></tr>
						</table>
						</td></tr>
						</table>
					</ContentTemplate>
				</SharePoint:UIVersionedContent>
				<SharePoint:UIVersionedContent UIVersion="4" runat="server" id="PlaceHolderQuickLaunchBottomV4">
					<ContentTemplate>
						<ul class="s4-specialNavLinkList">
							<li>
								<SharePoint:ClusteredSPLinkButton
									runat="server"
									NavigateUrl="~site/_layouts/recyclebin.aspx"
									ImageClass="s4-specialNavIcon"
									ImageUrl="/_layouts/images/fgimg.png"
									ImageWidth=16
									ImageHeight=16
									OffsetX=0
									OffsetY=428
									id="idNavLinkRecycleBin"
									Text="<%$Resources:wss,StsDefault_RecycleBin%>"
									CssClass="s4-rcycl"
									PermissionsString="DeleteListItems" />
							</li>
							<li>
								<SharePoint:ClusteredSPLinkButton
									id="idNavLinkViewAllV4"
									runat="server"
									PermissionsString="ViewFormPages"
									NavigateUrl="~site/_layouts/viewlsts.aspx"
									ImageClass="s4-specialNavIcon"
									ImageUrl="/_layouts/images/fgimg.png"
									ImageWidth=16
									ImageHeight=16
									OffsetX=0
									OffsetY=0
									Text="<%$Resources:wss,quiklnch_allcontent_short%>"
									accesskey="<%$Resources:wss,quiklnch_allcontent_AK%>"/>
							</li>
						</ul>
					</ContentTemplate>
				</SharePoint:UIVersionedContent>
				</div>
				</div>
	</ContentTemplate>
</SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">
<SharePoint:ScriptLink Name="SP.js" runat="server" OnDemand="true" Localizable="false" />
<SharePoint:ScriptLink Name="jquery-1.6.1.min.js" runat="server" OnDemand="true" Localizable="false" />
<script language="ecmascript" type="text/ecmascript">
    
    var lic;
    $(document).ready(function () {
        $('tr.invisible').hide();

        

         $('select[id*=ddlAgendaType]').bind('change', function (e) {
            var agendaType = $(this).val();

            if (agendaType != "")
            {
                $('select[id*=field_AgendaType]').val(agendaType);
            }
            else
            {
                 $('select[id*=field_AgendaType]').val('');
            }
         });

         $('select[id*=ddlAGMOffice]').bind('change', function (e) {
            var agmOffice = $(this).val();

            if (agmOffice != "")
            {
                $('select[id*=field_AGM_Office]').val(agmOffice);
            }
            else
            {
                 $('select[id*=field_AGM_Office]').val('');
            }
         });


        $('select[id*=field_Committee]').bind('change', function (e) {
            var committee = $(this).val();
            $('select[id*=ddlCategories] > option').remove();
             $('select[id*=ddlCategories]').append(
                            $('<option></option>').val('0').html('Select a meeting')
                        );
             
             var ctx = new SP.ClientContext.get_current();
             
             var targetList = ctx.get_web().get_lists().getByTitle('BoardMeetings');
             
             var query = "<View><Query><Where><And><Eq><FieldRef Name='Committee'/><Value Type='Text'>" + committee + "</Value></Eq><Geq><FieldRef Name='MeetingDate' /><Value Type='DateTime'><Today/></Value></Geq></And></Where></Query></View>";
             var cq = new SP.CamlQuery();
             cq.set_viewXml(query);

             lic = targetList.getItems(cq);
             
             ctx.load(lic);
            
             ctx.executeQueryAsync(Function.createDelegate(this, getAllMeetingsSuccess), 
                        Function.createDelegate(this, getAllMeetingsFailure));
                         /*
            */
        });

        $('select[id*=ddlCategories]').bind('change', function (e) {
            var meetingID = $(this).val();
            if (meetingID != 0)
            {
                $('input[id*=MeetingID]').val(meetingID);
            }
        });
        
        $("input[id*=field_Title]").keypress(function(e){
            var code = e.which || e.keyCode;
            // 65 - 90 for A-Z and 97 - 122 for a-z 95 for _ 45 for - 46 for .
            if (!((code >= 65 && code <= 90) || (code >= 48 && code <=57) || (code >= 97 && code <= 122) || code == 95 || code == 46 || code == 45 || code == 32))
            {
                //var text = $("input[id*=field_Title]").val();
                //text = text.substring(0,text.length);
                //$("#aliasEntry").val(text);
                e.preventDefault();
            }
        });

        $("input[id*=field_Title]").keyup(function(){  
            // get new length of characters  
            var new_length = $(this).val().length;  
            var chars_left = 80 - new_length;
            // update  
            $('span#fieldLength').html(chars_left);  
        });  


    });

    function getAllMeetingsSuccess(sender, args) {
            var listEnumerator = lic.getEnumerator();
            while (listEnumerator.moveNext()) {
                 $('select[id*=ddlCategories]').append(
                            $('<option></option>').val(listEnumerator.get_current().get_item("MeetingID")).html(listEnumerator.get_current().get_item("Title"))
                        );

            }
        }

    function getAllMeetingsFailure(sender, args) {
            alert('Failed to get list items. \nError: ' + args.get_message() + '\nStackTrace: ' + args.get_stackTrace());
    }
   

</script>

<SharePoint:UIVersionedContent UIVersion="4" runat="server">
	<ContentTemplate>
	<div style="padding-left:5px">
	</ContentTemplate>
</SharePoint:UIVersionedContent>
	<table cellpadding="0" cellspacing="0" id="onetIDListForm" style="width:100%">
	 <tr>
	  <td>
	 <WebPartPages:WebPartZone runat="server" FrameType="None" ID="Main" Title="loc:Main">
     




     <ZoneTemplate>

    </ZoneTemplate>



</WebPartPages:WebPartZone>

<!-- ikarstein: Insert such a structure for each field you want to show on you page --> 
                 <table id="agendaFormTable"  border="0"  width="100%"> 
                     <tr> 
                         <td  class="ms-toolbar"  nowrap="nowrap"> 
                            <SharePoint:FormToolBar  runat="server"  ControlMode="New"  /> 
                         </td> 
                     </tr> 
                     <tr> 
                         <td> 
                             <span  id="part1">  <!-- ikarstein: This line is important for "Attachments" --> 
                                 <table  border="0"  cellspacing="0"  width="100%"> 
                                    
                                   
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Agenda For<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <asp:DropDownList id="ddlAgendaType" runat="server" >
                                                <asp:ListItem Selected="True" Text="Select the Agenda Type" Value=""/>
                                                <asp:ListItem Text="Procurement Resolution" Value="Procurement Resolution"/>
                                                <asp:ListItem Text="Non-Procurement Resolution" Value="Non-Procurement Resolution"/>
                                                <asp:ListItem Text="Other Matters" Value="Other Matters"/>
                                                <asp:ListItem Text="Briefing" Value="Briefing"/>
                                                <asp:ListItem Text="Meeting Minutes" Value="Meeting Minutes"/>
                                             </asp:DropDownList>
                                             
                                         </td> 
                                     </tr> 

                                    <tr class="invisible"> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Agenda For<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_AgendaType"  ControlMode="New"  FieldName="AgendaType"    /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AgendaType_Description"  FieldName="AgendaType" 
                                                 ControlMode="New" />
                                         </td> 
                                     </tr> 

                                      <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> AGM Office<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <asp:DropDownList id="ddlAGMOffice" runat="server" OnSelectedIndexChanged="AGMOffice_SelectedIndexChanged" AutoPostBack="true">
                                                <asp:ListItem Selected="True" Text="Select Office" Value=""/>
                                                <asp:ListItem Text="AGM-Audit" Value="AGM-Audit"/>
                                                <asp:ListItem Text="AGM-Bus Operations" Value="AGM-Bus Operations"/>
                                                <asp:ListItem Text="AGM-Communications and External Affairs" Value="AGM-Communications and External Affairs"/>
                                                <asp:ListItem Text="AGM-Contracts and Procurement" Value="AGM-Contracts and Procurement"/>
                                                <asp:ListItem Text="AGM-Finance" Value="AGM-Finance"/>
                                                <asp:ListItem Text="AGM-Human Resources" Value="AGM-Human Resources"/>
                                                <asp:ListItem Text="AGM-Legal Services" Value="AGM-Legal Services"/>
                                                <asp:ListItem Text="AGM-Operations" Value="AGM-Operations"/>
                                                <asp:ListItem Text="AGM-Planning" Value="AGM-Planning"/>
                                                <asp:ListItem Text="AGM-Police" Value="AGM-Police"/>
                                                <asp:ListItem Text="AGM-Rail Operations" Value="AGM-Rail Operations"/>
                                                <asp:ListItem Text="AGM-Safety and QA" Value="AGM-Safety and QA"/>
                                                <asp:ListItem Text="AGM-Technology" Value="AGM-Technology"/>
                                                <asp:ListItem Text="Executive Director" Value="Executive Director"/>
                                                <asp:ListItem Text="DGM" Value="DGM"/>
                                                <asp:ListItem Text="CBSS" Value="CBSS"/>
                                                <asp:ListItem Text="GM" Value="GM"/>
                                             </asp:DropDownList>
                                             <SharePoint:FieldDescription  runat="server"  ID="field_AGM_Office_Description"  FieldName="AGM Office" 
                                                ControlMode="New"  /> 
                                         </td> 
                                     </tr> 

                                     <tr class="invisible"> 
                                        <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                            <h3  class="ms-standardheader"> 
                                                <nobr> AGM Office<span  class="ms-formvalidation">  *</span></nobr> 
                                        </h3> 
                                        </td> 
                                        <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_AGM_Office"  ControlMode="New"  FieldName="AGM Office"  /> 
                                            
                                        </td> 
                                    </tr>

                                     <asp:Panel id="pnlAgenda" runat="server">
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Title<span  class="ms-formvalidation">  *</span></nobr> 
                                             </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Title"  ControlMode="New"  FieldName="Title"  /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Title_Description"  FieldName="Title" 
                                                 ControlMode="New"  /> 
                                             <span id="fieldLength">80</span><span> characters remaining.</span>
                                         </td> 
                                     </tr> 
                                     
                                     
                                     
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Committee<span  class="ms-formvalidation">  *</span></nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <SharePoint:FormField  runat="server"  ID="field_Committee"  ControlMode="New" FieldName="Committee"   /> 
                                             <SharePoint:FieldDescription  runat="server"  ID="field_Committee_Description"  FieldName="Committee" 
                                                 ControlMode="New"  /> 
                                         </td> 
                                     </tr> 
                                     <tr> 
                                         <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                             <h3  class="ms-standardheader"> 
                                                 <nobr> Committee Meetings<span  class="ms-formvalidation">  *</span></nobr> 
                                            </h3> 
                                         </td> 
                                         <td  width="400px"  valign="top"  class="ms-formbody"> 
                                             <asp:DropDownList ID="ddlCategories" runat="server" />
                                         </td> 
                                     </tr> 
                                    
                                    <tr> 
                                        <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                            <h3  class="ms-standardheader"> 
                                                <nobr> Presenter</nobr> 
                                        </h3> 
                                        </td> 
                                        <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_Presenter"  ControlMode="New"  FieldName="Presenter"  /> 
                                            <SharePoint:FieldDescription  runat="server"  ID="field_Presenter_Description"  FieldName="Presenter" 
                                                ControlMode="New"  /> 
                                        </td> 
                                    </tr>
                                    <tr> 
                                        <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                            <h3  class="ms-standardheader"> 
                                                <nobr> Owner</nobr> 
                                        </h3> 
                                        </td> 
                                        <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_Owner"  ControlMode="New"  FieldName="Owner"  /> 
                                            <SharePoint:FieldDescription  runat="server"  ID="field_Owner_Description"  FieldName="Owner" 
                                                ControlMode="New"  /> 
                                        </td> 
                                    </tr>
                                   
                                    <tr class="invisible"> 
                                        <td  width="190px"  valign="top"  class="ms-formlabel"> 
                                            <h3  class="ms-standardheader"> 
                                                <nobr> Meeting ID</nobr> 
                                        </h3> 
                                        </td> 
                                        <td  width="400px"  valign="top"  class="ms-formbody"> 
                                            <SharePoint:FormField  runat="server"  ID="field_MeetingID"  ControlMode="New"  FieldName="CommitteeMeeting"  /> 
                                            
                                        </td> 
                                    </tr>
                                    

                                     <!-- ikarstein: Add this table for "Save" and "Cancel" buttons / BEGIN --> 
                                     <table  width="100%"  border="0"  cellspacing="0"> 
                                         <tr> 
                                             <td  width="99%"  class="ms-toolbar"  nowrap="nowrap"> 
                                                 <img  src="/_layouts/images/blank.gif"  width="1"  height="18"  /> 
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
                                     <!-- ikarstein: END --> 
                             </span> 
                             <SharePoint:AttachmentUpload  runat="server"  ControlMode="New"  /> 
                             <SharePoint:ItemHiddenVersion  runat="server"  ControlMode="New"  /> 
                         </td> 
                     </tr> 
                     </asp:Panel>
                      <asp:Panel id="pnlNotAuthorized" runat="server" visible="false">
                         <tr>
                            <span class="ms-formvalidation">Sorry, you are not authorized to create this type of Agenda</span>
                         </tr>
                      </asp:Panel>
                 </table> 
 
 
	 <img src="/_layouts/images/blank.gif" width='590' height='1' alt="" />
	  </td>
	 </tr>



	</table>
<SharePoint:UIVersionedContent UIVersion="4" runat="server">
	<ContentTemplate>
	</div>
	</ContentTemplate>
</SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
	<SharePoint:UIVersionedContent UIVersion="4" runat="server"><ContentTemplate>
		<SharePoint:CssRegistration Name="forms.css" runat="server"/>
	</ContentTemplate></SharePoint:UIVersionedContent>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleLeftBorder" runat="server">
<table cellpadding="0" height="100%" width="100%" cellspacing="0">
 <tr><td class="ms-areaseparatorleft"><img src="/_layouts/images/blank.gif" width='1' height='1' alt="" /></td></tr>
</table>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleAreaClass" runat="server">
<script type="text/javascript" id="onetidPageTitleAreaFrameScript">
	if (document.getElementById("onetidPageTitleAreaFrame") != null)
	{
		document.getElementById("onetidPageTitleAreaFrame").className="ms-areaseparator";
	}
</script>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyAreaClass" runat="server">
<style type="text/css">
.ms-bodyareaframe {
	padding: 8px;
	border: none;
}
</style>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyLeftBorder" runat="server">
<div class='ms-areaseparatorleft'><img src="/_layouts/images/blank.gif" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleRightMargin" runat="server">
<div class='ms-areaseparatorright'><img src="/_layouts/images/blank.gif" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyRightMargin" runat="server">
<div class='ms-areaseparatorright'><img src="/_layouts/images/blank.gif" width='8' height='100%' alt="" /></div>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleAreaSeparator" runat="server"/>
