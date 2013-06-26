<%@ Page language="C#"   Inherits="Microsoft.SharePoint.Publishing.PublishingLayoutPage,Microsoft.SharePoint.Publishing,Version=12.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>
<%@ Register Tagprefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> <%@ Register Tagprefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceholderID="PlaceHolderAdditionalPageHead" runat="server">
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
	</style>
	<PublishingWebControls:editmodepanel runat="server" id="editmodestyles" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&amp;#xD;&amp;#xA;			&amp;lt;!-- Styles for edit mode only--&amp;gt;&amp;#xD;&amp;#xA;			&amp;lt;SharePointWebControls:CssRegistration name=&amp;quot;&amp;lt;% $SPUrl:~sitecollection/Style Library/~language/Core Styles/zz2_editMode.css %&amp;gt;&amp;quot; runat=&amp;quot;server&amp;quot; __designer:Preview=&amp;quot;&amp;amp;lt;link rel=&amp;amp;quot;stylesheet&amp;amp;quot; type=&amp;amp;quot;text/css&amp;amp;quot; href=&amp;amp;quot;/Style%20Library/en-US/Core%20Styles/zz2_editMode.css&amp;amp;quot;/&amp;amp;gt;&amp;#xA;&amp;quot; __designer:Values=&amp;quot;&amp;amp;lt;P N='Name' Bound='True' T='SPUrl:~sitecollection/Style Library/~language/Core Styles/zz2_editMode.css' /&amp;amp;gt;&amp;amp;lt;P N='ID' T='ctl00' /&amp;amp;gt;&amp;amp;lt;P N='InDesign' T='False' /&amp;amp;gt;&amp;amp;lt;P N='Page' ID='1' /&amp;amp;gt;&amp;amp;lt;P N='TemplateControl' R='1' /&amp;amp;gt;&amp;amp;lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&amp;amp;gt;&amp;quot;/&amp;gt;&amp;#xD;&amp;#xA;	&quot; /&gt;&lt;/Regions&gt;&lt;table height=&quot;&quot; width=&quot;&quot; style=&quot;color:Black; ;&quot; cellpadding=1 cellspacing=0&gt;
                &lt;tr&gt;
                    &lt;td nowrap align=center valign=middle style=&quot;color:Black; background-color:LightBlue; font-family:Tahoma; font-size:X-Small; &quot;&gt;Edit Mode Panel&lt;/td&gt;
                &lt;/tr&gt;
                &lt;tr&gt;
                    &lt;td nowrap style=&quot;vertical-align:top;;&quot; _designerRegion=0&gt;&lt;/td&gt;
                &lt;/tr&gt;
            &lt;/table&gt;" __designer:Values="&lt;P N='ID' ID='1' T='editmodestyles' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;P N='Page' ID='3' /&gt;&lt;P N='TemplateControl' R='3' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;&lt;P N='Visible' T='False' /&gt;">
			<!-- Styles for edit mode only-->
			<SharePointWebControls:CssRegistration name="<% $SPUrl:~sitecollection/Style Library/~language/Core Styles/zz2_editMode.css %>" runat="server"/>
	</PublishingWebControls:editmodepanel>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderPageTitle" runat="server">
	<SharePointWebControls:FieldValue id="HomePageTitleInTitleArea" FieldName="Title" runat="server" __designer:Preview="AxisHomePage" __designer:Values="&lt;P N='ID' ID='1' T='HomePageTitleInTitleArea' /&gt;&lt;P N='ItemFieldValue' ID='2' Serial='AAEAAAD/////AQAAAAAAAAAGAQAAAAxBeGlzSG9tZVBhZ2UL' /&gt;&lt;P N='ListItemFieldValue' R='2' /&gt;&lt;P N='Visible' T='True' /&gt;&lt;P N='FieldName' T='Title' /&gt;&lt;P N='ControlMode' E='1' /&gt;&lt;P N='InDesign' T='False' /&gt;&lt;P N='Page' ID='3' /&gt;&lt;P N='TemplateControl' R='3' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;"/>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderMain" runat="server">
		<SharePointWebControls:CssRegistration name="<% $SPUrl:~sitecollection/Style Library/~language/Core Styles/pageLayouts.css %>" runat="server" __designer:Preview="&lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/Style%20Library/en-US/Core%20Styles/pageLayouts.css&quot;/&gt;
" __designer:Values="&lt;P N='Name' Bound='True' T='SPUrl:~sitecollection/Style Library/~language/Core Styles/pageLayouts.css' /&gt;&lt;P N='ID' ID='1' T='ctl00' /&gt;&lt;P N='InDesign' T='False' /&gt;&lt;P N='Page' ID='2' /&gt;&lt;P N='TemplateControl' R='2' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;"/>
	
	<table width="100%" border="0" cellpadding="0" cellspacing="0" bordercolor="#0000CC">
  <tr>
    <td width="70%">
    <WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftfirst" FrameType="None"   Title="This is World Axis Capital" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftfirst&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;This is World Axis Capital&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='This is World Axis Capital' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftfirst' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>
 
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="50%">
	<WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftsecond" FrameType="None"   Title="News" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftsecond&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;News&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='News' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftsecond' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>    
    </td>
    <td width="50%">
	<WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftsecond2" FrameType="None"   Title="News" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftsecond2&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;News&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='News' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftsecond2' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>    
    
    </td>
  </tr>
</table>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="33%">
    <WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftthirdrow1" FrameType="None"   Title="My Links 1" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftthirdrow1&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;My Links 1&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='My Links 1' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftthirdrow1' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>    
    </td>
    <td width="33%"><WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftthirdrow2" FrameType="None"   Title="My Links 2" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftthirdrow2&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;My Links 2&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='My Links 2' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftthirdrow2' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>    </td>
    <td width="34%"><WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzleftthirdrow3" FrameType="None"   Title="My Links 3" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzleftthirdrow3&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;My Links 3&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='My Links 3' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzleftthirdrow3' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>    </td>
  </tr>
</table>
    </td>
    <td width="30%"> 
        <WebPartPages:WebPartZone runat="server" AllowPersonalization="false" ID="wpzrightfirst" FrameType="None"   Title="Right Side Panel" Orientation="Vertical" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&quot; NamingContainer=&quot;True&quot; /&gt;&lt;/Regions&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; border=&quot;0&quot; id=&quot;wpzrightfirst&quot;&gt;
	&lt;tr&gt;
		&lt;td style=&quot;white-space:nowrap;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
			&lt;tr&gt;
				&lt;td style=&quot;white-space:nowrap;&quot;&gt;Right Side Panel&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;&lt;tr&gt;
		&lt;td style=&quot;height:100%;&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;border-color:Gray;border-width:1px;border-style:Solid;width:100%;height:100%;&quot;&gt;
			&lt;tr valign=&quot;top&quot;&gt;
				&lt;td _designerRegion=&quot;0&quot;&gt;&lt;table cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; border=&quot;0&quot; style=&quot;width:100%;&quot;&gt;
					&lt;tr&gt;
						&lt;td style=&quot;height:100%;&quot;&gt;&lt;/td&gt;
					&lt;/tr&gt;
				&lt;/table&gt;&lt;/td&gt;
			&lt;/tr&gt;
		&lt;/table&gt;&lt;/td&gt;
	&lt;/tr&gt;
&lt;/table&gt;" __designer:Values="&lt;P N='AllowPersonalization' T='False' /&gt;&lt;P N='FrameType' E='0' /&gt;&lt;P N='Title' ID='1' T='Right Side Panel' /&gt;&lt;P N='HeaderText' R='1' /&gt;&lt;P N='DisplayTitle' R='1' /&gt;&lt;P N='MenuPopupStyle'&gt;&lt;P N='CellPadding' T='1' /&gt;&lt;P N='CellSpacing' T='0' /&gt;&lt;/P&gt;&lt;P N='PartChromeType' E='2' /&gt;&lt;P N='ControlStyle'&gt;&lt;P N='BorderColor' T='Gray' /&gt;&lt;P N='BorderWidth' T='1px' /&gt;&lt;P N='BorderStyle' E='4' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;/P&gt;&lt;P N='Font' R='2' /&gt;&lt;P N='ID' ID='3' T='wpzrightfirst' /&gt;&lt;P N='Page' ID='4' /&gt;&lt;P N='TemplateControl' R='4' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;" __designer:Templates="&lt;Group Name=&quot;ZoneTemplate&quot;&gt;&lt;Template Name=&quot;ZoneTemplate&quot; Content=&quot;&quot; /&gt;&lt;/Group&gt;"><ZoneTemplate></ZoneTemplate></WebPartPages:WebPartZone>
    
    </td>
  </tr>
</table>
	
		
	<PublishingWebControls:editmodepanel runat="server" id="editmodepanel1" __designer:Preview="&lt;Regions&gt;&lt;Region Name=&quot;0&quot; Editable=&quot;True&quot; Content=&quot;&amp;#xD;&amp;#xA;		&amp;lt;!-- Add field controls here to bind custom metadata viewable and editable in edit mode only.--&amp;gt;&amp;#xD;&amp;#xA;		&amp;lt;table cellpadding=&amp;quot;10&amp;quot; cellspacing=&amp;quot;0&amp;quot; align=&amp;quot;center&amp;quot; class=&amp;quot;editModePanel&amp;quot;&amp;gt;&amp;#xD;&amp;#xA;						&amp;lt;tr&amp;gt;&amp;#xD;&amp;#xA;							&amp;lt;td&amp;gt;&amp;#xD;&amp;#xA;								&amp;lt;SharePointWebControls:TextField runat=&amp;quot;server&amp;quot; id=&amp;quot;TitleField&amp;quot; FieldName=&amp;quot;Title&amp;quot; __designer:Preview=&amp;quot;&amp;amp;lt;div align=&amp;amp;quot;left&amp;amp;quot; class=&amp;amp;quot;ms-formfieldcontainer&amp;amp;quot;&amp;amp;gt;&amp;amp;lt;div class=&amp;amp;quot;ms-formfieldlabelcontainer&amp;amp;quot; nowrap=&amp;amp;quot;nowrap&amp;amp;quot;&amp;amp;gt;&amp;amp;lt;span class=&amp;amp;quot;ms-formfieldlabel&amp;amp;quot; nowrap=&amp;amp;quot;nowrap&amp;amp;quot;&amp;amp;gt;Title&amp;amp;lt;/span&amp;amp;gt;&amp;amp;lt;/div&amp;amp;gt;&amp;amp;lt;div class=&amp;amp;quot;ms-formfieldvaluecontainer&amp;amp;quot;&amp;amp;gt;AxisHomePage&amp;amp;lt;/div&amp;amp;gt;&amp;amp;lt;/div&amp;amp;gt;&amp;quot; __designer:Values=&amp;quot;&amp;amp;lt;P N='ID' T='TitleField' /&amp;amp;gt;&amp;amp;lt;P N='ItemFieldValue' ID='1' Serial='AAEAAAD/////AQAAAAAAAAAGAQAAAAxBeGlzSG9tZVBhZ2UL' /&amp;amp;gt;&amp;amp;lt;P N='ListItemFieldValue' R='1' /&amp;amp;gt;&amp;amp;lt;P N='Visible' T='True' /&amp;amp;gt;&amp;amp;lt;P N='FieldName' T='Title' /&amp;amp;gt;&amp;amp;lt;P N='ControlMode' E='1' /&amp;amp;gt;&amp;amp;lt;P N='InDesign' T='False' /&amp;amp;gt;&amp;amp;lt;P N='Page' ID='2' /&amp;amp;gt;&amp;amp;lt;P N='TemplateControl' R='2' /&amp;amp;gt;&amp;amp;lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&amp;amp;gt;&amp;quot;/&amp;gt;&amp;#xD;&amp;#xA;							&amp;lt;/td&amp;gt;&amp;#xD;&amp;#xA;						&amp;lt;/tr&amp;gt;&amp;#xD;&amp;#xA;		&amp;lt;/table&amp;gt;&amp;#xD;&amp;#xA;	&quot; /&gt;&lt;/Regions&gt;&lt;table height=&quot;&quot; width=&quot;&quot; style=&quot;color:Black; ;&quot; cellpadding=1 cellspacing=0&gt;
                &lt;tr&gt;
                    &lt;td nowrap align=center valign=middle style=&quot;color:Black; background-color:LightBlue; font-family:Tahoma; font-size:X-Small; &quot;&gt;Edit Mode Panel&lt;/td&gt;
                &lt;/tr&gt;
                &lt;tr&gt;
                    &lt;td nowrap style=&quot;vertical-align:top;;&quot; _designerRegion=0&gt;&lt;/td&gt;
                &lt;/tr&gt;
            &lt;/table&gt;" __designer:Values="&lt;P N='ID' ID='1' T='editmodepanel1' /&gt;&lt;P N='Font' ID='2' /&gt;&lt;P N='Page' ID='3' /&gt;&lt;P N='TemplateControl' R='3' /&gt;&lt;P N='AppRelativeTemplateSourceDirectory' R='-1' /&gt;&lt;P N='Visible' T='False' /&gt;">
		<!-- Add field controls here to bind custom metadata viewable and editable in edit mode only.-->
		<table cellpadding="10" cellspacing="0" align="center" class="editModePanel">
						<tr>
							<td>
								<SharePointWebControls:TextField runat="server" id="TitleField" FieldName="Title" />
							</td>
						</tr>
		</table>
	</PublishingWebControls:editmodepanel>
</asp:Content>
<asp:Content ContentPlaceholderID="PlaceHolderTitleBreadcrumb" runat="server"/>
<asp:Content ContentPlaceholderID="PlaceHolderLeftNavBar" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server" />
<asp:Content ContentPlaceholderID="PlaceHolderNavSpacer" runat="server" />
