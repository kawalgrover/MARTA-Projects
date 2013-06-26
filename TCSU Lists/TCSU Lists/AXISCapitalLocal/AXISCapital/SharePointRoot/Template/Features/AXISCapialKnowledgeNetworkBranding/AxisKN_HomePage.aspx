<%@ Page language="C#"   Inherits="Microsoft.SharePoint.Publishing.PublishingLayoutPage,Microsoft.SharePoint.Publishing,Version=12.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %><%@ Register Tagprefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register Tagprefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register Tagprefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><asp:Content ContentPlaceholderID="PlaceHolderAdditionalPageHead" runat="server">
	<style type="text/css">
		.ms-pagetitleareaframe table, .ms-titleareaframe
		{
			background: none;
			height: 10px;
			overflow:hidden;
		}
		.ms-pagetitle, .ms-titlearea
		{
			display:none;
		}
		.pageTitle
		{
			display:none;
		}
	
#left-nav {
	display: none;
}
	

	</style>
	
	<script language="javascript" type="text/javascript">
	function showMyLinksPopup()
	{
		__doPostBack("lnkmanagemylinks")
		
	}
	
	</script>
	<PublishingWebControls:editmodepanel runat="server" id="editmodestyles">
			<!-- Styles for edit mode only-->
			<SharePointWebControls:cssregistration name="<% $SPUrl:~sitecollection/Style Library/~language/Core Styles/zz2_editMode.css %>" runat="server"/>
	</PublishingWebControls:editmodepanel>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderPageTitle" runat="server">
	<SharePointWebControls:fieldvalue id="HomePageTitleInTitleArea" FieldName="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderMain" runat="server">

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="75%" align="left" valign="top" style="padding-right:10px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td align="left" valign="top">
		<WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsiderow1" FrameType="TitleBarOnly"
									Title="<%$Resources:cms,WebPartZoneTitle_Top%>" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone></td>
      </tr>
    </table>
    
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td align="left" valign="top">
       		<WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider2" FrameType="TitleBarOnly"
									Title="Second" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>   
          
          </td>
        </tr>
      </table>
    
     <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="33%" align="left" valign="top">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider3c1" FrameType="TitleBarOnly"
									Title="LeftThreeRow1" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>   
          
          </td>
          <td width="33%" align="left" valign="top" style="padding-left:20px;">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider3c2" FrameType="TitleBarOnly"
									Title="MiddleThreeRow1" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>   
          
          </td>
          <td width="34%" align="left" valign="top" style="padding-left:20px;">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider3c3" FrameType="TitleBarOnly"
									Title="RightThreeRow1" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>   
          
          </td>

        </tr>
      </table>
		<table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="33%" align="left" valign="top">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider4c1" FrameType="TitleBarOnly"
									Title="LeftThreeRow2" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>   
          
          </td>
          <td width="33%" align="left" valign="top" style="padding-left:20px;">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider4c2" FrameType="TitleBarOnly"
									Title="MiddleThreeRow2" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>
          
          </td>
          <td width="34%" align="left" valign="top" style="padding-left:20px;">
          <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzrightsider4c3" FrameType="TitleBarOnly"
									Title="RightThreeRow2" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>
          
          </td>
        </tr>
      </table>    

    
    
    
    </td>
    <td width="25%" align="right" valign="top">
    
    <WebPartPages:webpartzone runat="server" AllowPersonalization="false" ID="wpzleftside" FrameType="TitleBarOnly"
									Title="RightTop" Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:webpartzone>
    
    </td>
  </tr>
</table>

		
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderTitleBreadcrumb" runat="server"/>
<asp:Content ContentPlaceholderID="PlaceHolderLeftNavBar" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server" />
<asp:Content ContentPlaceholderID="PlaceHolderNavSpacer" runat="server" />










