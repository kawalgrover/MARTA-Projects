<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:ma="http://schemas.microsoft.com/office/2009/metadata/properties/metaAttributes" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:dfs="http://schemas.microsoft.com/office/infopath/2003/dataFormSolution" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2011-06-08T02:14:49" xmlns:d="http://schemas.microsoft.com/office/infopath/2009/WSSList/dataFields" xmlns:pc="http://schemas.microsoft.com/office/infopath/2007/PartnerControls" xmlns:q="http://schemas.microsoft.com/office/infopath/2009/WSSList/queryFields" xmlns:dms="http://schemas.microsoft.com/office/2009/documentManagement/types" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns:xdExtension="http://schemas.microsoft.com/office/infopath/2003/xslt/extension" xmlns:xdXDocument="http://schemas.microsoft.com/office/infopath/2003/xslt/xDocument" xmlns:xdSolution="http://schemas.microsoft.com/office/infopath/2003/xslt/solution" xmlns:xdFormatting="http://schemas.microsoft.com/office/infopath/2003/xslt/formatting" xmlns:xdImage="http://schemas.microsoft.com/office/infopath/2003/xslt/xImage" xmlns:xdUtil="http://schemas.microsoft.com/office/infopath/2003/xslt/Util" xmlns:xdMath="http://schemas.microsoft.com/office/infopath/2003/xslt/Math" xmlns:xdDate="http://schemas.microsoft.com/office/infopath/2003/xslt/Date" xmlns:sig="http://www.w3.org/2000/09/xmldsig#" xmlns:xdSignatureProperties="http://schemas.microsoft.com/office/infopath/2003/SignatureProperties" xmlns:ipApp="http://schemas.microsoft.com/office/infopath/2006/XPathExtension/ipApp" xmlns:xdEnvironment="http://schemas.microsoft.com/office/infopath/2006/xslt/environment" xmlns:xdUser="http://schemas.microsoft.com/office/infopath/2006/xslt/User" xmlns:xdServerInfo="http://schemas.microsoft.com/office/infopath/2009/xslt/ServerInfo">
	<xsl:output method="html" indent="no"/>
	<xsl:template match="dfs:myFields">
		<html dir="ltr" xmlns:xsf="http://schemas.microsoft.com/office/infopath/2003/solutionDefinition" xmlns:xsf2="http://schemas.microsoft.com/office/infopath/2006/solutionDefinition/extensions" xmlns:xsf3="http://schemas.microsoft.com/office/infopath/2009/solutionDefinition/extensions" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xhtml="http://www.w3.org/1999/xhtml">
			<head>
				<meta content="text/html" http-equiv="Content-Type"></meta>
				<style controlStyle="controlStyle">@media screen 			{ 			BODY{margin-left:21px;background-position:21px 0px;} 			} 		BODY{color:windowtext;background-color:window;layout-grid:none;} 		.xdListItem {display:inline-block;width:100%;vertical-align:text-top;} 		.xdListBox,.xdComboBox{margin:1px;} 		.xdInlinePicture{margin:1px; BEHAVIOR: url(#default#urn::xdPicture) } 		.xdLinkedPicture{margin:1px; BEHAVIOR: url(#default#urn::xdPicture) url(#default#urn::controls/Binder) } 		.xdHyperlinkBox{word-wrap:break-word; text-overflow:ellipsis;overflow-x:hidden; OVERFLOW-Y: hidden; WHITE-SPACE:nowrap; display:inline-block;margin:1px;padding:5px;border: 1pt solid #dcdcdc;color:windowtext;BEHAVIOR: url(#default#urn::controls/Binder) url(#default#DataBindingUI)} 		.xdSection{border:1pt solid transparent ;margin:0px 0px 0px 0px;padding:0px 0px 0px 0px;} 		.xdRepeatingSection{border:1pt solid transparent;margin:0px 0px 0px 0px;padding:0px 0px 0px 0px;} 		.xdMultiSelectList{margin:1px;display:inline-block; border:1pt solid #dcdcdc; padding:1px 1px 1px 5px; text-indent:0; color:windowtext; background-color:window; overflow:auto; behavior: url(#default#DataBindingUI) url(#default#urn::controls/Binder) url(#default#MultiSelectHelper) url(#default#ScrollableRegion);} 		.xdMultiSelectListItem{display:block;white-space:nowrap}		.xdMultiSelectFillIn{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;overflow:hidden;text-align:left;}		.xdBehavior_Formatting {BEHAVIOR: url(#default#urn::controls/Binder) url(#default#Formatting);} 	 .xdBehavior_FormattingNoBUI{BEHAVIOR: url(#default#CalPopup) url(#default#urn::controls/Binder) url(#default#Formatting);} 	.xdExpressionBox{margin: 1px;padding:1px;word-wrap: break-word;text-overflow: ellipsis;overflow-x:hidden;}.xdBehavior_GhostedText,.xdBehavior_GhostedTextNoBUI{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#TextField) url(#default#GhostedText);}	.xdBehavior_GTFormatting{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#Formatting) url(#default#GhostedText);}	.xdBehavior_GTFormattingNoBUI{BEHAVIOR: url(#default#CalPopup) url(#default#urn::controls/Binder) url(#default#Formatting) url(#default#GhostedText);}	.xdBehavior_Boolean{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#BooleanHelper);}	.xdBehavior_Select{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#SelectHelper);}	.xdBehavior_ComboBox{BEHAVIOR: url(#default#ComboBox)} 	.xdBehavior_ComboBoxTextField{BEHAVIOR: url(#default#ComboBoxTextField);} 	.xdRepeatingTable{BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word;}.xdScrollableRegion{BEHAVIOR: url(#default#ScrollableRegion);} 		.xdLayoutRegion{display:inline-block;} 		.xdMaster{BEHAVIOR: url(#default#MasterHelper);} 		.xdActiveX{margin:1px; BEHAVIOR: url(#default#ActiveX);} 		.xdFileAttachment{display:inline-block;margin:1px;BEHAVIOR:url(#default#urn::xdFileAttachment);} 		.xdSharePointFileAttachment{display:inline-block;margin:2px;BEHAVIOR:url(#default#xdSharePointFileAttachment);} 		.xdAttachItem{display:inline-block;width:100%%;height:25px;margin:1px;BEHAVIOR:url(#default#xdSharePointFileAttachItem);} 		.xdSignatureLine{display:inline-block;margin:1px;background-color:transparent;border:1pt solid transparent;BEHAVIOR:url(#default#SignatureLine);} 		.xdHyperlinkBoxClickable{behavior: url(#default#HyperlinkBox)} 		.xdHyperlinkBoxButtonClickable{border-width:1px;border-style:outset;behavior: url(#default#HyperlinkBoxButton)} 		.xdPictureButton{background-color: transparent; padding: 0px; behavior: url(#default#PictureButton);} 		.xdPageBreak{display: none;}BODY{margin-right:21px;} 		.xdTextBoxRTL{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-align:right;word-wrap:normal;} 		.xdRichTextBoxRTL{display:inline-block;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow-x:hidden;word-wrap:break-word;text-overflow:ellipsis;text-align:right;font-weight:normal;font-style:normal;text-decoration:none;vertical-align:baseline;} 		.xdDTTextRTL{height:100%;width:100%;margin-left:22px;overflow:hidden;padding:0px;white-space:nowrap;} 		.xdDTButtonRTL{margin-right:-21px;height:17px;width:20px;behavior: url(#default#DTPicker);} 		.xdMultiSelectFillinRTL{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;overflow:hidden;text-align:right;}.xdTextBox{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-align:left;word-wrap:normal;} 		.xdRichTextBox{display:inline-block;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow-x:hidden;word-wrap:break-word;text-overflow:ellipsis;text-align:left;font-weight:normal;font-style:normal;text-decoration:none;vertical-align:baseline;} 		.xdDTPicker{;display:inline;margin:1px;margin-bottom: 2px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-indent:0; layout-grid: none} 		.xdDTText{height:100%;width:100%;margin-right:22px;overflow:hidden;padding:0px;white-space:nowrap;} 		.xdDTButton{margin-left:-21px;height:17px;width:20px;behavior: url(#default#DTPicker);} 		.xdRepeatingTable TD {VERTICAL-ALIGN: top;}</style>
				<style tableEditor="TableStyleRulesID">TABLE.xdLayout TD {
	BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; BORDER-TOP: medium none; BORDER-RIGHT: medium none
}
TABLE.msoUcTable TD {
	BORDER-BOTTOM: 1pt solid; BORDER-LEFT: 1pt solid; BORDER-TOP: 1pt solid; BORDER-RIGHT: 1pt solid
}
TABLE {
	BEHAVIOR: url (#default#urn::tables/NDTable)
}
</style>
				<style themeStyle="urn:office.microsoft.com:themeOffice">TABLE {
	BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; BORDER-COLLAPSE: collapse; BORDER-TOP: medium none; BORDER-RIGHT: medium none
}
TD {
	BORDER-BOTTOM-COLOR: #d8d8d8; BORDER-TOP-COLOR: #d8d8d8; BORDER-RIGHT-COLOR: #d8d8d8; BORDER-LEFT-COLOR: #d8d8d8
}
TH {
	BORDER-BOTTOM-COLOR: #000000; BACKGROUND-COLOR: #f2f2f2; BORDER-TOP-COLOR: #000000; COLOR: black; BORDER-RIGHT-COLOR: #000000; BORDER-LEFT-COLOR: #000000
}
.xdTableHeader {
	BACKGROUND-COLOR: #f2f2f2; COLOR: black
}
.light1 {
	BACKGROUND-COLOR: #ffffff
}
.dark1 {
	BACKGROUND-COLOR: #000000
}
.light2 {
	BACKGROUND-COLOR: #f5f6f7
}
.dark2 {
	BACKGROUND-COLOR: #182738
}
.accent1 {
	BACKGROUND-COLOR: #0072bc
}
.accent2 {
	BACKGROUND-COLOR: #ec008c
}
.accent3 {
	BACKGROUND-COLOR: #00adee
}
.accent4 {
	BACKGROUND-COLOR: #fd9f08
}
.accent5 {
	BACKGROUND-COLOR: #36b000
}
.accent6 {
	BACKGROUND-COLOR: #fae032
}
</style>
				<style tableStyle="SharePoint">TR.xdTitleRow {
	MIN-HEIGHT: 58px
}
TD.xdTitleCell {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 6px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 18px
}
TR.xdTitleRowWithHeading {
	MIN-HEIGHT: 58px
}
TD.xdTitleCellWithHeading {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 18px
}
TR.xdTitleRowWithSubHeading {
	MIN-HEIGHT: 58px
}
TD.xdTitleCellWithSubHeading {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 18px
}
TR.xdTitleRowWithOffsetBody {
	MIN-HEIGHT: 58px
}
TD.xdTitleCellWithOffsetBody {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 6px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 18px
}
TR.xdTitleHeadingRow {
	MIN-HEIGHT: 38px
}
TD.xdTitleHeadingCell {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 12px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 0px; valign: top
}
TR.xdTitleSubheadingRow {
	MIN-HEIGHT: 67px
}
TD.xdTitleSubheadingCell {
	BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 18px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #243b56 1pt solid; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 8px
}
TD.xdVerticalFill {
	BORDER-BOTTOM: #d8d8d8 1pt solid; BORDER-LEFT: #d8d8d8 1pt solid; BACKGROUND-COLOR: #6890be; BORDER-TOP: #d8d8d8 1pt solid
}
TD.xdTableContentCellWithVerticalOffset {
	BORDER-BOTTOM: #d8d8d8 1pt solid; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 85px; PADDING-RIGHT: 10px; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 12px
}
TR.xdTableContentRow {
	MIN-HEIGHT: 140px
}
TD.xdTableContentCell {
	BORDER-BOTTOM: #d8d8d8 1pt solid; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 0px
}
TD.xdTableContentCellWithVerticalFill {
	BORDER-BOTTOM: #d8d8d8 1pt solid; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: #ffffff; PADDING-LEFT: 1px; PADDING-RIGHT: 1px; BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-TOP: 0px
}
TD.xdTableStyleOneCol {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TR.xdContentRowOneCol {
	MIN-HEIGHT: 45px; valign: center
}
TR.xdHeadingRow {
	MIN-HEIGHT: 36px
}
TD.xdHeadingCell {
	BORDER-BOTTOM: #6890be 1.5pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; PADDING-TOP: 6px
}
TR.xdSubheadingRow {
	MIN-HEIGHT: 27px
}
TD.xdSubheadingCell {
	BORDER-BOTTOM: #a5a5a5 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; PADDING-TOP: 4px
}
TR.xdHeadingRowEmphasis {
	MIN-HEIGHT: 36px
}
TD.xdHeadingCellEmphasis {
	BORDER-BOTTOM: #6890be 1.5pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; PADDING-TOP: 6px
}
TR.xdSubheadingRowEmphasis {
	MIN-HEIGHT: 27px
}
TD.xdSubheadingCellEmphasis {
	BORDER-BOTTOM: #a5a5a5 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 22px; PADDING-TOP: 4px
}
TR.xdTableLabelControlStackedRow {
	MIN-HEIGHT: 45px
}
TD.xdTableLabelControlStackedCellLabel {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TD.xdTableLabelControlStackedCellComponent {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TR.xdTableRow {
	MIN-HEIGHT: 30px
}
TD.xdTableCellLabel {
	PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; PADDING-TOP: 4px
}
TD.xdTableCellComponent {
	PADDING-BOTTOM: 4px; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; PADDING-TOP: 4px
}
TD.xdTableMiddleCell {
	PADDING-BOTTOM: 4px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 4px
}
TR.xdTableEmphasisRow {
	MIN-HEIGHT: 30px
}
TD.xdTableEmphasisCellLabel {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TD.xdTableEmphasisCellComponent {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TD.xdTableMiddleCellEmphasis {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TR.xdTableOffsetRow {
	MIN-HEIGHT: 30px
}
TD.xdTableOffsetCellLabel {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
TD.xdTableOffsetCellComponent {
	BORDER-BOTTOM: #d8d8d8 1pt solid; PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-TOP: 4px
}
P {
	MARGIN-TOP: 0px; COLOR: #3f3f3f; FONT-SIZE: 10pt
}
H1 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f; FONT-SIZE: 22pt; FONT-WEIGHT: normal
}
H2 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #262626; FONT-SIZE: 15pt; FONT-WEIGHT: normal
}
H3 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f; FONT-SIZE: 12pt; FONT-WEIGHT: bold
}
H4 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f; FONT-SIZE: 10pt; FONT-WEIGHT: normal
}
H5 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f; FONT-SIZE: 10pt; FONT-WEIGHT: bold
}
H6 {
	MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f; FONT-SIZE: 10pt; FONT-WEIGHT: normal
}
BODY {
	COLOR: black
}
</style>
				<style languageStyle="languageStyle">body, select{font-family:Calibri;font-size:10pt} table{font-family:Calibri;font-size:10pt;font-weight:normal;font-style:normal;color:black; text-transform: none} .optionalPlaceholder{font-family:Calibri;font-size:9pt;color:#333333;font-weight:normal;font-style:normal;text-decoration:none;padding-left:20px;BEHAVIOR:url(#default#xOptional)} .langFont{width:150px;font-family:Calibri; font-size:10pt;} .defaultInDocUI{font-family:Calibri;font-size:9pt;} .optionalPlaceholder{padding-right:20px}</style>
			</head>
			<body style="DIRECTION: ltr">
				<div align="center">
					<table style="BORDER-BOTTOM-STYLE: none; BORDER-LEFT-STYLE: none; WIDTH: 681px; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word; BORDER-TOP-STYLE: none; TABLE-LAYOUT: fixed; BORDER-RIGHT-STYLE: none" class="xdFormLayout">
						<colgroup>
							<col style="WIDTH: 681px"></col>
						</colgroup>
						<tbody>
							<tr style="MIN-HEIGHT: 4px" class="xdTableContentRow">
								<td vAlign="top" class="xdTableContentCell" style="BORDER-TOP: #d8d8d8 1pt solid">
									<div> </div>
									<div>
										<table style="BORDER-BOTTOM-STYLE: none; BORDER-LEFT-STYLE: none; WIDTH: 677px; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word; BORDER-TOP-STYLE: none; TABLE-LAYOUT: fixed; BORDER-RIGHT-STYLE: none" class="xdFormLayout xdTableStyleTwoCol">
											<colgroup>
												<col style="WIDTH: 169px"></col>
												<col style="WIDTH: 312px"></col>
												<col style="WIDTH: 196px"></col>
											</colgroup>
											<tbody vAlign="top">
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Approvers</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<div>
															<table style="BORDER-BOTTOM-STYLE: none; BORDER-LEFT-STYLE: none; WIDTH: 455px; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word; BORDER-TOP-STYLE: none; TABLE-LAYOUT: fixed; BORDER-RIGHT-STYLE: none" class="xdRepeatingTable msoUcTable" title="" border="1" xd:CtrlId="CTRL18" xd:widgetIndex="0">
																<colgroup>
																	<col style="WIDTH: 305px"></col>
																	<col style="WIDTH: 150px"></col>
																</colgroup>
																<tbody class="xdTableHeader">
																	<tr>
																		<td style="TEXT-ALIGN: center; BORDER-LEFT: medium none; PADDING-BOTTOM: 1px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; BORDER-RIGHT: medium none; PADDING-TOP: 1px">
																			<div>
																				<h5 style="FONT-WEIGHT: normal">
																					<strong>Assign To</strong>
																				</h5>
																			</div>
																		</td>
																		<td style="TEXT-ALIGN: center; BORDER-LEFT: medium none; PADDING-BOTTOM: 1px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; BORDER-RIGHT: medium none; PADDING-TOP: 1px">
																			<div>
																				<h5 style="FONT-WEIGHT: normal">
																					<strong>Order</strong>
																				</h5>
																			</div>
																		</td>
																	</tr>
																</tbody><tbody xd:xctname="RepeatingTable">
																	<xsl:for-each select="dfs:dataFields/d:SharePointListItem_RW/d:Approvers/d:Assignment">
																		<tr>
																			<td style="BORDER-LEFT: medium none; PADDING-BOTTOM: 1px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; BORDER-RIGHT: medium none; PADDING-TOP: 1px">
																				<object hideFocus="1" style="WIDTH: 100%; HEIGHT: 22px" class="xdActiveX" classid="clsid:61e40d31-993d-4777-8fa0-19ca59b6d0bb" tabIndex="0" xd:disableEditing="no" xd:SharePointGroup="0" xd:SearchPeopleOnly="false" xd:AllowMultiple="true" xd:boundProp="xd:inline" xd:bindingProperty="Value" xd:bindingType="xmlNode" xd:server="http://m264981:1411" xd:CtrlId="CTRL19" xd:xctname="{{61e40d31-993d-4777-8fa0-19ca59b6d0bb}}" tabStop="true" contentEditable="false" xd:binding="d:Assignee">
																					<xsl:if test="function-available('xdImage:getImageUrl')">
																						<xsl:attribute name="src"><xsl:value-of select="xdImage:getImageUrl(d:Assignee)"/></xsl:attribute>
																					</xsl:if>
																					<param NAME="ButtonFont" VALUE="Verdana,10,0,400,0,0,0"/>
																					<param NAME="ButtonText" VALUE=""/>
																					<param NAME="DisplayNameXPath" VALUE="pc:DisplayName"/>
																					<param NAME="ObjectIdXPath" VALUE="pc:AccountId"/>
																					<param NAME="ObjectTypeXPath" VALUE="pc:AccountType"/>
																					<param NAME="SiteUrlXPath" VALUE="/Context/@siteUrl"/>
																					<param NAME="SiteUrlDataSource" VALUE="Context"/>
																					<param NAME="NewNodeTemplate" VALUE="&lt;pc:Person&gt;&#xA;	&lt;pc:DisplayName&gt;&lt;/pc:DisplayName&gt;&#xA;	&lt;pc:AccountId&gt;&lt;/pc:AccountId&gt;&#xA;	&lt;pc:AccountType&gt;&lt;/pc:AccountType&gt;&#xA;&lt;/pc:Person&gt;"/>
																					<param NAME="BackgroundColor" VALUE="2147483653"/>
																					<param NAME="MaxLines" VALUE="4"/>
																					<param NAME="Direction" VALUE="0"/>
																				</object>
																			</td>
																			<td style="BORDER-LEFT: medium none; PADDING-BOTTOM: 1px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; BORDER-RIGHT: medium none; PADDING-TOP: 1px">
																				<select style="WIDTH: 100%" class="xdComboBox xdBehavior_Select" title="" size="1" xd:CtrlId="CTRL21" xd:xctname="dropdown" xd:disableEditing="no" xd:boundProp="value" value="Serial" xd:binding="d:AssignmentType" tabIndex="0">
																					<xsl:attribute name="value">
																						<xsl:value-of select="d:AssignmentType"/>
																					</xsl:attribute>
																					<xsl:choose>
																						<xsl:when test="function-available('xdXDocument:GetDOM')">
																							<xsl:variable name="val" select="d:AssignmentType"/>
																							<xsl:if test="not(xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/AssignmentType/SharePointListChoice_RW[.=$val] or $val='')">
																								<option selected="selected">
																									<xsl:attribute name="value">
																										<xsl:value-of select="$val"/>
																									</xsl:attribute>
																									<xsl:value-of select="$val"/>
																								</option>
																							</xsl:if>
																							<xsl:for-each select="xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/AssignmentType/SharePointListChoice_RW">
																								<option>
																									<xsl:attribute name="value">
																										<xsl:value-of select="."/>
																									</xsl:attribute>
																									<xsl:if test="$val=.">
																										<xsl:attribute name="selected">selected</xsl:attribute>
																									</xsl:if>
																									<xsl:value-of select="@DisplayName"/>
																								</option>
																							</xsl:for-each>
																						</xsl:when>
																						<xsl:otherwise>
																							<option>
																								<xsl:value-of select="d:AssignmentType"/>
																							</option>
																						</xsl:otherwise>
																					</xsl:choose>
																				</select>
																			</td>
																		</tr>
																	</xsl:for-each>
																</tbody>
															</table>
															<div class="optionalPlaceholder" xd:xmlToEdit="Approvers_1" tabIndex="0" xd:action="xCollection::insert" style="WIDTH: 455px">Add a new stage</div>
														</div>
														<div>
															<h6 style="FONT-WEIGHT: normal">Enter the names of the people to whom the workflow will assign tasks, and choose the order in which those tasks are assigned. Separate them with semicolons. You can also add stages to assign tasks to more people in different orders.</h6>
														</div>
													</td>
												</tr>
												<tr style="MIN-HEIGHT: 10px" class="xdTableOffsetRow">
													<td rowSpan="3" class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Select Positions</span>
														</h4>
													</td>
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal">God</h6>
													</td>
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" xd:CtrlId="CTRL1" xd:xctname="CheckBox" tabIndex="0" xd:boundProp="xd:value" xd:binding="my:God" xd:onValue="true" xd:offValue="false">
																<xsl:attribute name="xd:value">
																	<xsl:value-of select="my:God"/>
																</xsl:attribute>
																<xsl:if test="my:God=&quot;true&quot;">
																	<xsl:attribute name="CHECKED">CHECKED</xsl:attribute>
																</xsl:if>
															</input>
														</h6>
													</td>
												</tr>
												<tr style="MIN-HEIGHT: 10px">
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal">Super God</h6>
													</td>
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" xd:CtrlId="CTRL2" xd:xctname="CheckBox" tabIndex="0" xd:boundProp="xd:value" xd:binding="my:Super_God" xd:onValue="true" xd:offValue="false">
																<xsl:attribute name="xd:value">
																	<xsl:value-of select="my:Super_God"/>
																</xsl:attribute>
																<xsl:if test="my:Super_God=&quot;true&quot;">
																	<xsl:attribute name="CHECKED">CHECKED</xsl:attribute>
																</xsl:if>
															</input>
														</h6>
													</td>
												</tr>
												<tr style="MIN-HEIGHT: 10px">
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal">Super Duper God</h6>
													</td>
													<td class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #f5f6f7; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" xd:CtrlId="CTRL3" xd:xctname="CheckBox" tabIndex="0" xd:boundProp="xd:value" xd:binding="my:Super_Duper_God" xd:onValue="true" xd:offValue="false">
																<xsl:attribute name="xd:value">
																	<xsl:value-of select="my:Super_Duper_God"/>
																</xsl:attribute>
																<xsl:if test="my:Super_Duper_God=&quot;true&quot;">
																	<xsl:attribute name="CHECKED">CHECKED</xsl:attribute>
																</xsl:if>
															</input>
														</h6>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Expand Groups</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" value="" type="checkbox" xd:CtrlId="CTRL22" xd:xctname="CheckBox" tabIndex="0" xd:disableEditing="no" xd:boundProp="xd:value" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:ExpandGroups" xd:onValue="true" xd:offValue="false" style="">
																<xsl:attribute name="xd:value">
																	<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:ExpandGroups"/>
																</xsl:attribute>
																<xsl:if test="dfs:dataFields/d:SharePointListItem_RW/d:ExpandGroups=&quot;true&quot;">
																	<xsl:attribute name="CHECKED">CHECKED</xsl:attribute>
																</xsl:if>
															</input>For each group entered, assign a task to every member of that group.</h6>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Request</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px"><span hideFocus="1" class="xdTextBox" title="" xd:CtrlId="CTRL23" xd:xctname="PlainText" tabIndex="0" xd:disableEditing="no" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:NotificationMessage" xd:datafmt="&quot;string&quot;,&quot;plainMultiline&quot;" style="OVERFLOW-X: auto; OVERFLOW-Y: auto; WIDTH: 100%; WORD-WRAP: break-word; WHITE-SPACE: normal; HEIGHT: 50px">
															<xsl:choose>
																<xsl:when test="function-available('xdFormatting:formatString')">
																	<xsl:value-of select="xdFormatting:formatString(dfs:dataFields/d:SharePointListItem_RW/d:NotificationMessage,&quot;string&quot;,&quot;plainMultiline&quot;)" disable-output-escaping="yes"/>
																</xsl:when>
																<xsl:otherwise>
																	<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:NotificationMessage" disable-output-escaping="yes"/>
																</xsl:otherwise>
															</xsl:choose>
														</span>
														<div>
															<h6 style="FONT-WEIGHT: normal">This message will be sent to the people assigned tasks.</h6>
														</div>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Due Date for All Tasks</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<div style="WIDTH: 100%" class="xdDTPicker" title="" noWrap="1" xd:CtrlId="CTRL24" xd:xctname="DTPicker"><span hideFocus="1" class="xdDTText xdBehavior_FormattingNoBUI" contentEditable="true" xd:xctname="DTPicker_DTText" tabIndex="0" xd:disableEditing="no" xd:boundProp="xd:num" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks" xd:datafmt="&quot;datetime&quot;,&quot;dateFormat:Short Date;timeFormat:none;&quot;" xd:innerCtrl="_DTText">
																<xsl:attribute name="xd:num">
																	<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks"/>
																</xsl:attribute>
																<xsl:choose>
																	<xsl:when test="function-available('xdFormatting:formatString')">
																		<xsl:value-of select="xdFormatting:formatString(dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks,&quot;datetime&quot;,&quot;dateFormat:Short Date;timeFormat:none;&quot;)"/>
																	</xsl:when>
																	<xsl:otherwise>
																		<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks"/>
																	</xsl:otherwise>
																</xsl:choose>
															</span>
															<button class="xdDTButton" xd:xctname="DTPicker_DTButton" xd:innerCtrl="_DTButton" tabIndex="-1">
																<img src="res://infopath.exe/calendar.gif"/>
															</button>
														</div>
														<div>
															<h6 style="FONT-WEIGHT: normal">The date by which all tasks are due.</h6>
														</div>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Duration Per Task</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px"><span hideFocus="1" class="xdTextBox xdBehavior_Formatting" title="" contentEditable="true" xd:CtrlId="CTRL25" xd:xctname="PlainText" tabIndex="0" xd:disableEditing="no" xd:boundProp="xd:num" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks" xd:datafmt="&quot;number&quot;,&quot;numDigits:auto;negativeOrder:1;&quot;" style="WIDTH: 100%">
															<xsl:attribute name="xd:num">
																<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks"/>
															</xsl:attribute>
															<xsl:choose>
																<xsl:when test="function-available('xdFormatting:formatString')">
																	<xsl:value-of select="xdFormatting:formatString(dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks,&quot;number&quot;,&quot;numDigits:auto;negativeOrder:1;&quot;)"/>
																</xsl:when>
																<xsl:otherwise>
																	<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks"/>
																</xsl:otherwise>
															</xsl:choose>
														</span>
														<div>
															<h6 style="FONT-WEIGHT: normal">The amount of time until a task is due. Choose the units by using the Duration Units.</h6>
														</div>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">Duration Units</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<select style="WIDTH: 100%" class="xdComboBox xdBehavior_Select" title="" size="1" xd:CtrlId="CTRL26" xd:xctname="dropdown" xd:disableEditing="no" xd:boundProp="value" value="Day" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits" tabIndex="0">
															<xsl:attribute name="value">
																<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/>
															</xsl:attribute>
															<xsl:choose>
																<xsl:when test="function-available('xdXDocument:GetDOM')">
																	<xsl:variable name="val" select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/>
																	<xsl:if test="not(xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/DurationUnits/SharePointListChoice_RW[.=$val] or $val='')">
																		<option selected="selected">
																			<xsl:attribute name="value">
																				<xsl:value-of select="$val"/>
																			</xsl:attribute>
																			<xsl:value-of select="$val"/>
																		</option>
																	</xsl:if>
																	<xsl:for-each select="xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/DurationUnits/SharePointListChoice_RW">
																		<option>
																			<xsl:attribute name="value">
																				<xsl:value-of select="."/>
																			</xsl:attribute>
																			<xsl:if test="$val=.">
																				<xsl:attribute name="selected">selected</xsl:attribute>
																			</xsl:if>
																			<xsl:value-of select="@DisplayName"/>
																		</option>
																	</xsl:for-each>
																</xsl:when>
																<xsl:otherwise>
																	<option>
																		<xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/>
																	</option>
																</xsl:otherwise>
															</xsl:choose>
														</select>
														<div>
															<h6 style="FONT-WEIGHT: normal">Define the units of time used by the Duration Per Task.</h6>
														</div>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td class="xdTableOffsetCellLabel" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 22px; PADDING-RIGHT: 5px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<h4>
															<span class="xdlabel">CC</span>
														</h4>
													</td>
													<td colSpan="2" class="xdTableOffsetCellComponent" style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: #7f7f7f; PADDING-LEFT: 5px; PADDING-RIGHT: 22px; VERTICAL-ALIGN: top; PADDING-TOP: 4px">
														<object hideFocus="1" style="WIDTH: 100%; HEIGHT: 22px" class="xdActiveX" classid="clsid:61e40d31-993d-4777-8fa0-19ca59b6d0bb" tabIndex="0" xd:disableEditing="no" xd:SharePointGroup="0" xd:SearchPeopleOnly="false" xd:AllowMultiple="true" xd:boundProp="xd:inline" xd:bindingProperty="Value" xd:bindingType="xmlNode" xd:server="http://m264981:1411" xd:CtrlId="CTRL27" xd:xctname="{{61e40d31-993d-4777-8fa0-19ca59b6d0bb}}" tabStop="true" contentEditable="false" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:CC">
															<xsl:if test="function-available('xdImage:getImageUrl')">
																<xsl:attribute name="src"><xsl:value-of select="xdImage:getImageUrl(dfs:dataFields/d:SharePointListItem_RW/d:CC)"/></xsl:attribute>
															</xsl:if>
															<param NAME="ButtonFont" VALUE="Verdana,10,0,400,0,0,0"/>
															<param NAME="ButtonText" VALUE=""/>
															<param NAME="DisplayNameXPath" VALUE="pc:DisplayName"/>
															<param NAME="ObjectIdXPath" VALUE="pc:AccountId"/>
															<param NAME="ObjectTypeXPath" VALUE="pc:AccountType"/>
															<param NAME="SiteUrlXPath" VALUE="/Context/@siteUrl"/>
															<param NAME="SiteUrlDataSource" VALUE="Context"/>
															<param NAME="NewNodeTemplate" VALUE="&lt;pc:Person&gt;&#xA;	&lt;pc:DisplayName&gt;&lt;/pc:DisplayName&gt;&#xA;	&lt;pc:AccountId&gt;&lt;/pc:AccountId&gt;&#xA;	&lt;pc:AccountType&gt;&lt;/pc:AccountType&gt;&#xA;&lt;/pc:Person&gt;"/>
															<param NAME="BackgroundColor" VALUE="2147483653"/>
															<param NAME="MaxLines" VALUE="4"/>
															<param NAME="Direction" VALUE="0"/>
														</object>
														<div>
															<h6 style="FONT-WEIGHT: normal">Notify these people when the workflow starts and ends without assigning tasks to them.</h6>
														</div>
													</td>
												</tr>
												<tr class="xdTableOffsetRow">
													<td colSpan="3" class="xdTableOffsetCellLabel" style="BORDER-BOTTOM: #dbe5f1 1pt; PADDING-BOTTOM: 4px; PADDING-LEFT: 1px; PADDING-RIGHT: 1px; PADDING-TOP: 8px">
														<div align="left"><input style="WIDTH: auto" class="langFont" title="" value="Start" type="button" xd:CtrlId="CTRL36" xd:xctname="Button" tabIndex="0"/>  <input style="WIDTH: auto" class="langFont" title="" value="Cancel" type="button" xd:CtrlId="CTRL41" xd:xctname="Button" tabIndex="0"/>  </div>
													</td>
												</tr>
											</tbody>
										</table>
									</div>
									<div> </div>
								</td>
							</tr>
						</tbody>
					</table>
				</div>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
