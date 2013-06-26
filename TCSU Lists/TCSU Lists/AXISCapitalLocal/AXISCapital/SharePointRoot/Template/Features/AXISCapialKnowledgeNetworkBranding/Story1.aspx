<%@ Page language="C#"   Inherits="Microsoft.SharePoint.Publishing.PublishingLayoutPage,Microsoft.SharePoint.Publishing,Version=12.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>
<%@ Register Tagprefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceholderID="PlaceHolderAdditionalPageHead" runat="server">
	<style type="text/css">
		#left-nav { display: none; }

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
			.articledesc
			{
				font-family:Verdana;
				font-size:10px;
			}
			.pageTitle
			{
				font-size: 20pt;
				margin-bottom: 0;
				border-top: 1px solid #aaa;
				padding-top: 15px;
			}
			div#article-byline {
				font-size: 11pt;
				padding: 5px 0 20px;
				border-bottom: 1px solid #aaa;
			}
			p#article-date {
				font-size: 8pt;
				margin: 10px 0 20px;
			}
			.mainContent {
				margin: 0;

				position: relative;
				top: 0;
			}
			
			#article-image {
				float: right;
				padding: 10px;
			}
			#article-image-caption  {
				font-size: 8pt;
				color: #666;
					
			}
			
			#a-closer-look {
				background: #e4e4e4;
				padding: 10px;
			}
#a-closer-look h3 {
	border-bottom: 1px solid #aaa;
	margin: 0;
	font-size: 9pt;
}
	</style>
	
	<PublishingWebControls:editmodepanel runat="server" id="editmodestyles">
			<!-- Styles for edit mode only-->
			<SharePointWebControls:cssregistration name="<% $SPUrl:~sitecollection/Style Library/~language/Core Styles/zz2_editMode.css %>" runat="server"/>
	</PublishingWebControls:editmodepanel>
</asp:Content>

<asp:Content ContentPlaceholderID="PlaceHolderPageTitleInTitleArea" runat="server">
	<SharePointWebControls:TextField runat="server" id="TitleField" FieldName="Title"/>
</asp:Content>

<asp:Content ContentPlaceholderID="PlaceHolderPageTitle" runat="server">
	<SharePointWebControls:fieldvalue id="HomePageTitleInTitleArea" FieldName="Title" runat="server"/>
</asp:Content>

<asp:Content ContentPlaceholderID="PlaceHolderMain" runat="server">
	<SharePointWebControls:CssRegistration name="<% $SPUrl:~sitecollection/Style Library/~language/Core Styles/pageLayouts.css %>" runat="server"/>
	<!-- Byline -->
	<div id="article-byline">
		<SharePointWebControls:TextField FieldName="ArticleByLine" runat="server"/>
	</div>
	<!-- Date -->
	<p id="article-date">&nbsp;<SharePointWebControls:datetimefield FieldName="ArticleStartDate" runat="server" id="datetimefield3"></SharePointWebControls:datetimefield></p>

	<div class="clearfix">
	    <div style="width:75%; float: left; margin-right: 20px;">
		    <div id="article-image">
			    <PublishingWebControls:RichImageField id="ImageField" FieldName="PublishingPageImage" runat="server"/>
		    	<div id="article-image-caption">
					<PublishingWebControls:RichHtmlField id="Caption" FieldName="PublishingImageCaption"  AllowTextMarkup="false" AllowTables="false" AllowFonts="false" PreviewValueSize="Small" runat="server"/>
				</div>
		    </div>
	   		<PublishingWebControls:RichHtmlField id="Content" FieldName="PublishingPageContent" runat="server"/>		
	    </div>
	    <div style="width:18%; float: left;">
	       		<WebPartPages:WebPartZone runat="server" AllowPersonalization="true" ID="RightColumn"
				Title="<%$Resources:cms,WebPartZoneTitle_Top%>" FrameType="TitleBarOnly"  Orientation="Vertical"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>
    	   		<PublishingWebControls:RichHtmlField id="PageContent2" FieldName="PageContent2" runat="server"/>		
	    </div>
	</div>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderTitleBreadcrumb" runat="server"/>
<asp:Content ContentPlaceholderID="PlaceHolderLeftNavBar" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server" />
<asp:Content ContentPlaceholderID="PlaceHolderNavSpacer" runat="server" />