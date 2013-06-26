<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsf="http://schemas.microsoft.com/office/infopath/2003/solutionDefinition" xmlns:xsf2="http://schemas.microsoft.com/office/infopath/2006/solutionDefinition/extensions" xmlns:xsf3="http://schemas.microsoft.com/office/infopath/2009/solutionDefinition/extensions" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xdUtil="http://schemas.microsoft.com/office/infopath/2003/xslt/Util" xmlns:xdXDocument="http://schemas.microsoft.com/office/infopath/2003/xslt/xDocument" xmlns:xdMath="http://schemas.microsoft.com/office/infopath/2003/xslt/Math" xmlns:xdDate="http://schemas.microsoft.com/office/infopath/2003/xslt/Date" xmlns:xdExtension="http://schemas.microsoft.com/office/infopath/2003/xslt/extension" xmlns:xdEnvironment="http://schemas.microsoft.com/office/infopath/2006/xslt/environment" xmlns:xdUser="http://schemas.microsoft.com/office/infopath/2006/xslt/User" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:dms="http://schemas.microsoft.com/office/2009/documentManagement/types" xmlns:dfs="http://schemas.microsoft.com/office/infopath/2003/dataFormSolution" xmlns:q="http://schemas.microsoft.com/office/infopath/2009/WSSList/queryFields" xmlns:d="http://schemas.microsoft.com/office/infopath/2009/WSSList/dataFields" xmlns:ma="http://schemas.microsoft.com/office/2009/metadata/properties/metaAttributes" xmlns:pc="http://schemas.microsoft.com/office/infopath/2007/PartnerControls" xmlns:xhtml="http://www.w3.org/1999/xhtml" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns:xdSolution="http://schemas.microsoft.com/office/infopath/2003/xslt/solution" xmlns:xdFormatting="http://schemas.microsoft.com/office/infopath/2003/xslt/formatting" xmlns:xdImage="http://schemas.microsoft.com/office/infopath/2003/xslt/xImage" xmlns:sig="http://www.w3.org/2000/09/xmldsig#" xmlns:xdSignatureProperties="http://schemas.microsoft.com/office/infopath/2003/SignatureProperties" xmlns:ipApp="http://schemas.microsoft.com/office/infopath/2006/XPathExtension/ipApp"><xsl:output method="html" indent="no"/><xsl:template match="dfs:myFields"><html dir="ltr"><head><meta http-equiv="Content-Type" content="text/html"></meta><style tableEditor="TableStyleRulesID">TABLE.xdLayout TD {BORDER-RIGHT: medium none; BORDER-TOP: medium none; BORDER-LEFT: medium none; BORDER-BOTTOM: medium none}TABLE.msoUcTable TD {BORDER-RIGHT: 1pt solid; BORDER-TOP: 1pt solid; BORDER-LEFT: 1pt solid; BORDER-BOTTOM: 1pt solid}TABLE {BEHAVIOR: url (#default#urn::tables/NDTable)}</style><style controlStyle="controlStyle">@media screen 			{ 			BODY{margin-left:21px;background-position:21px 0px;} 			} 		BODY{color:windowtext;background-color:window;layout-grid:none;} 		.xdListItem {display:inline-block;width:100%;vertical-align:text-top;} 		.xdListBox,.xdComboBox{margin:1px;} 		.xdInlinePicture{margin:1px; BEHAVIOR: url(#default#urn::xdPicture) } 		.xdLinkedPicture{margin:1px; BEHAVIOR: url(#default#urn::xdPicture) url(#default#urn::controls/Binder) } 		.xdHyperlinkBox{word-wrap:break-word; text-overflow:ellipsis;overflow-x:hidden; OVERFLOW-Y: hidden; WHITE-SPACE:nowrap; display:inline-block;margin:1px;padding:5px;border: 1pt solid #dcdcdc;color:windowtext;BEHAVIOR: url(#default#urn::controls/Binder) url(#default#DataBindingUI)} 		.xdSection{border:1pt solid transparent ;margin:0px 0px 0px 0px;padding:0px 0px 0px 0px;} 		.xdRepeatingSection{border:1pt solid transparent;margin:0px 0px 0px 0px;padding:0px 0px 0px 0px;} 		.xdMultiSelectList{margin:1px;display:inline-block; border:1pt solid #dcdcdc; padding:1px 1px 1px 5px; text-indent:0; color:windowtext; background-color:window; overflow:auto; behavior: url(#default#DataBindingUI) url(#default#urn::controls/Binder) url(#default#MultiSelectHelper) url(#default#ScrollableRegion);} 		.xdMultiSelectListItem{display:block;white-space:nowrap}		.xdMultiSelectFillIn{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;overflow:hidden;text-align:left;}		.xdBehavior_Formatting {BEHAVIOR: url(#default#urn::controls/Binder) url(#default#Formatting);} 	 .xdBehavior_FormattingNoBUI{BEHAVIOR: url(#default#CalPopup) url(#default#urn::controls/Binder) url(#default#Formatting);} 	.xdExpressionBox{margin: 1px;padding:1px;word-wrap: break-word;text-overflow: ellipsis;overflow-x:hidden;}.xdBehavior_GhostedText,.xdBehavior_GhostedTextNoBUI{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#TextField) url(#default#GhostedText);}	.xdBehavior_GTFormatting{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#Formatting) url(#default#GhostedText);}	.xdBehavior_GTFormattingNoBUI{BEHAVIOR: url(#default#CalPopup) url(#default#urn::controls/Binder) url(#default#Formatting) url(#default#GhostedText);}	.xdBehavior_Boolean{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#BooleanHelper);}	.xdBehavior_Select{BEHAVIOR: url(#default#urn::controls/Binder) url(#default#SelectHelper);}	.xdBehavior_ComboBox{BEHAVIOR: url(#default#ComboBox)} 	.xdBehavior_ComboBoxTextField{BEHAVIOR: url(#default#ComboBoxTextField);} 	.xdRepeatingTable{BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word;}.xdScrollableRegion{BEHAVIOR: url(#default#ScrollableRegion);} 		.xdLayoutRegion{display:inline-block;} 		.xdMaster{BEHAVIOR: url(#default#MasterHelper);} 		.xdActiveX{margin:1px; BEHAVIOR: url(#default#ActiveX);} 		.xdFileAttachment{display:inline-block;margin:1px;BEHAVIOR:url(#default#urn::xdFileAttachment);} 		.xdSharePointFileAttachment{display:inline-block;margin:2px;BEHAVIOR:url(#default#xdSharePointFileAttachment);} 		.xdAttachItem{display:inline-block;width:100%%;height:25px;margin:1px;BEHAVIOR:url(#default#xdSharePointFileAttachItem);} 		.xdSignatureLine{display:inline-block;margin:1px;background-color:transparent;border:1pt solid transparent;BEHAVIOR:url(#default#SignatureLine);} 		.xdHyperlinkBoxClickable{behavior: url(#default#HyperlinkBox)} 		.xdHyperlinkBoxButtonClickable{border-width:1px;border-style:outset;behavior: url(#default#HyperlinkBoxButton)} 		.xdPictureButton{background-color: transparent; padding: 0px; behavior: url(#default#PictureButton);} 		.xdPageBreak{display: none;}BODY{margin-right:21px;} 		.xdTextBoxRTL{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-align:right;word-wrap:normal;} 		.xdRichTextBoxRTL{display:inline-block;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow-x:hidden;word-wrap:break-word;text-overflow:ellipsis;text-align:right;font-weight:normal;font-style:normal;text-decoration:none;vertical-align:baseline;} 		.xdDTTextRTL{height:100%;width:100%;margin-left:22px;overflow:hidden;padding:0px;white-space:nowrap;} 		.xdDTButtonRTL{margin-right:-21px;height:17px;width:20px;behavior: url(#default#DTPicker);} 		.xdMultiSelectFillinRTL{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;overflow:hidden;text-align:right;}.xdTextBox{display:inline-block;white-space:nowrap;text-overflow:ellipsis;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-align:left;word-wrap:normal;} 		.xdRichTextBox{display:inline-block;;padding:1px;margin:1px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow-x:hidden;word-wrap:break-word;text-overflow:ellipsis;text-align:left;font-weight:normal;font-style:normal;text-decoration:none;vertical-align:baseline;} 		.xdDTPicker{;display:inline;margin:1px;margin-bottom: 2px;border: 1pt solid #dcdcdc;color:windowtext;background-color:window;overflow:hidden;text-indent:0; layout-grid: none} 		.xdDTText{height:100%;width:100%;margin-right:22px;overflow:hidden;padding:0px;white-space:nowrap;} 		.xdDTButton{margin-left:-21px;height:17px;width:20px;behavior: url(#default#DTPicker);} 		.xdRepeatingTable TD {VERTICAL-ALIGN: top;}</style><style themeStyle="urn:office.microsoft.com:themeOffice">TABLE {BORDER-RIGHT: medium none; BORDER-TOP: medium none; BORDER-LEFT: medium none; BORDER-BOTTOM: medium none; BORDER-COLLAPSE: collapse}TD {BORDER-LEFT-COLOR: #d8d8d8; BORDER-BOTTOM-COLOR: #d8d8d8; BORDER-TOP-COLOR: #d8d8d8; BORDER-RIGHT-COLOR: #d8d8d8}TH {BORDER-LEFT-COLOR: #000000; BORDER-BOTTOM-COLOR: #000000; COLOR: black; BORDER-TOP-COLOR: #000000; BACKGROUND-COLOR: #f2f2f2; BORDER-RIGHT-COLOR: #000000}.xdTableHeader {COLOR: black; BACKGROUND-COLOR: #f2f2f2}.light1 {BACKGROUND-COLOR: #ffffff}.dark1 {BACKGROUND-COLOR: #000000}.light2 {BACKGROUND-COLOR: #f5f6f7}.dark2 {BACKGROUND-COLOR: #182738}.accent1 {BACKGROUND-COLOR: #0072bc}.accent2 {BACKGROUND-COLOR: #ec008c}.accent3 {BACKGROUND-COLOR: #00adee}.accent4 {BACKGROUND-COLOR: #fd9f08}.accent5 {BACKGROUND-COLOR: #36b000}.accent6 {BACKGROUND-COLOR: #fae032}</style><style tableStyle="SharePoint">TR.xdTitleRow {MIN-HEIGHT: 58px}TD.xdTitleCell {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 6px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 18px; BACKGROUND-COLOR: #ffffff}TR.xdTitleRowWithHeading {MIN-HEIGHT: 58px}TD.xdTitleCellWithHeading {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 18px; BACKGROUND-COLOR: #ffffff}TR.xdTitleRowWithSubHeading {MIN-HEIGHT: 58px}TD.xdTitleCellWithSubHeading {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 18px; BACKGROUND-COLOR: #ffffff}TR.xdTitleRowWithOffsetBody {MIN-HEIGHT: 58px}TD.xdTitleCellWithOffsetBody {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 6px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 18px; BACKGROUND-COLOR: #ffffff}TR.xdTitleHeadingRow {MIN-HEIGHT: 38px}TD.xdTitleHeadingCell {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; PADDING-LEFT: 22px; PADDING-BOTTOM: 12px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 0px; BACKGROUND-COLOR: #ffffff; valign: top}TR.xdTitleSubheadingRow {MIN-HEIGHT: 67px}TD.xdTitleSubheadingCell {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 22px; BORDER-TOP: #243b56 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 18px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 8px; BACKGROUND-COLOR: #ffffff}TD.xdVerticalFill {BORDER-TOP: #d8d8d8 1pt solid; BORDER-LEFT: #d8d8d8 1pt solid; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #6890be}TD.xdTableContentCellWithVerticalOffset {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 10px; PADDING-LEFT: 85px; PADDING-BOTTOM: 0px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 12px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #ffffff}TR.xdTableContentRow {MIN-HEIGHT: 140px}TD.xdTableContentCell {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 0px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #ffffff}TD.xdTableContentCellWithVerticalFill {BORDER-RIGHT: #d8d8d8 1pt solid; PADDING-RIGHT: 1px; PADDING-LEFT: 1px; PADDING-BOTTOM: 0px; BORDER-LEFT: #d8d8d8 1pt solid; PADDING-TOP: 0px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #ffffff}TD.xdTableStyleOneCol {PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid}TR.xdContentRowOneCol {MIN-HEIGHT: 45px; valign: center}TR.xdHeadingRow {MIN-HEIGHT: 36px}TD.xdHeadingCell {PADDING-RIGHT: 22px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 6px; BORDER-BOTTOM: #6890be 1.5pt solid}TR.xdSubheadingRow {MIN-HEIGHT: 27px}TD.xdSubheadingCell {PADDING-RIGHT: 22px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #a5a5a5 1pt solid}TR.xdHeadingRowEmphasis {MIN-HEIGHT: 36px}TD.xdHeadingCellEmphasis {PADDING-RIGHT: 22px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 6px; BORDER-BOTTOM: #6890be 1.5pt solid}TR.xdSubheadingRowEmphasis {MIN-HEIGHT: 27px}TD.xdSubheadingCellEmphasis {PADDING-RIGHT: 22px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #a5a5a5 1pt solid}TR.xdTableLabelControlStackedRow {MIN-HEIGHT: 45px}TD.xdTableLabelControlStackedCellLabel {PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid}TD.xdTableLabelControlStackedCellComponent {PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid}TR.xdTableRow {MIN-HEIGHT: 30px}TD.xdTableCellLabel {PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px}TD.xdTableCellComponent {PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px}TD.xdTableMiddleCell {PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px}TR.xdTableEmphasisRow {MIN-HEIGHT: 30px}TD.xdTableEmphasisCellLabel {PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #f5f6f7}TD.xdTableEmphasisCellComponent {PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #f5f6f7}TD.xdTableMiddleCellEmphasis {PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #f5f6f7}TR.xdTableOffsetRow {MIN-HEIGHT: 30px}TD.xdTableOffsetCellLabel {PADDING-RIGHT: 5px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid}TD.xdTableOffsetCellComponent {PADDING-RIGHT: 22px; BORDER-TOP: #d8d8d8 1pt solid; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; PADDING-TOP: 4px; BORDER-BOTTOM: #d8d8d8 1pt solid; BACKGROUND-COLOR: #f5f6f7}P {MARGIN-TOP: 0px; FONT-SIZE: 10pt; COLOR: #3f3f3f}H1 {MARGIN-TOP: 0px; FONT-WEIGHT: normal; FONT-SIZE: 22pt; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f}H2 {MARGIN-TOP: 0px; FONT-WEIGHT: normal; FONT-SIZE: 15pt; MARGIN-BOTTOM: 0px; COLOR: #262626}H3 {MARGIN-TOP: 0px; FONT-WEIGHT: bold; FONT-SIZE: 12pt; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f}H4 {MARGIN-TOP: 0px; FONT-WEIGHT: normal; FONT-SIZE: 10pt; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f}H5 {MARGIN-TOP: 0px; FONT-WEIGHT: bold; FONT-SIZE: 10pt; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f}H6 {MARGIN-TOP: 0px; FONT-WEIGHT: normal; FONT-SIZE: 10pt; MARGIN-BOTTOM: 0px; COLOR: #3f3f3f}BODY {COLOR: black}</style><style languageStyle="languageStyle">body, select{font-family:Calibri;font-size:10pt} table{font-family:Calibri;font-size:10pt;font-weight:normal;font-style:normal;color:black; text-transform: none} .optionalPlaceholder{font-family:Calibri;font-size:9pt;color:#333333;font-weight:normal;font-style:normal;text-decoration:none;padding-left:20px;BEHAVIOR:url(#default#xOptional)} .langFont{width:150px;font-family:Calibri; font-size:10pt;} .defaultInDocUI{font-family:Calibri;font-size:9pt;} .optionalPlaceholder{padding-right:20px}</style></head><body style="DIRECTION: ltr"><div align="center"><table class="xdFormLayout" style="BORDER-TOP-STYLE: none; BORDER-BOTTOM-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word;"><tbody><tr class="xdTableContentRow" style="MIN-HEIGHT: 4px"><td vAlign="top" style="BORDER-TOP: #d8d8d8 1pt solid" class="xdTableContentCell"><div> </div><div><table class="xdFormLayout xdTableStyleTwoCol" style="TABLE-LAYOUT: fixed; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-COLLAPSE: collapse; WORD-WRAP: break-word; BORDER-BOTTOM-STYLE: none; WIDTH: 649px"><colgroup><col style="WIDTH: 169px"></col><col style="WIDTH: 480px"></col></colgroup><tbody vAlign="top"><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">Due Date for All Tasks</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><div class="xdDTPicker" title="" style="WIDTH: 100%" noWrap="1" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="DTPicker" xd:CtrlId="CTRL29"><span class="xdDTText xdBehavior_FormattingNoBUI" hideFocus="1" contentEditable="true" tabIndex="0" xd:xctname="DTPicker_DTText" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks" xd:datafmt="&quot;datetime&quot;,&quot;dateFormat:Short Date;timeFormat:none;&quot;" xd:boundProp="xd:num" xd:innerCtrl="_DTText" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="xd:num"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks"/></xsl:attribute><xsl:choose xmlns:xsl="http://www.w3.org/1999/XSL/Transform"><xsl:when test="function-available('xdFormatting:formatString')"><xsl:value-of select="xdFormatting:formatString(dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks,&quot;datetime&quot;,&quot;dateFormat:Short Date;timeFormat:none;&quot;)"/></xsl:when><xsl:otherwise><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DueDateforAllTasks"/></xsl:otherwise></xsl:choose></span><button class="xdDTButton" xd:xctname="DTPicker_DTButton" xd:innerCtrl="_DTButton" tabIndex="-1"><img src="res://infopath.exe/calendar.gif"/></button></div><div><h6 style="FONT-WEIGHT: normal">The date by which all tasks are due.</h6></div></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">Duration Per Task</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><span class="xdTextBox xdBehavior_Formatting" hideFocus="1" title="" tabIndex="0" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="PlainText" xd:CtrlId="CTRL30" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks" xd:datafmt="&quot;number&quot;,&quot;numDigits:auto;negativeOrder:1;&quot;" xd:boundProp="xd:num" style="WIDTH: 100%" contentEditable="true" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="xd:num"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks"/></xsl:attribute><xsl:choose xmlns:xsl="http://www.w3.org/1999/XSL/Transform"><xsl:when test="function-available('xdFormatting:formatString')"><xsl:value-of select="xdFormatting:formatString(dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks,&quot;number&quot;,&quot;numDigits:auto;negativeOrder:1;&quot;)"/></xsl:when><xsl:otherwise><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationforSerialTasks"/></xsl:otherwise></xsl:choose></span><div><h6 style="FONT-WEIGHT: normal">The amount of time until a task is due. Choose the units by using the Duration Units.</h6></div></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">Duration Units</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><select class="xdComboBox xdBehavior_Select" title="" style="WIDTH: 100%" size="1" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="dropdown" xd:CtrlId="CTRL31" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits" value="Day" xd:boundProp="value" tabIndex="0" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="value"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/></xsl:attribute><xsl:choose xmlns:xsl="http://www.w3.org/1999/XSL/Transform"><xsl:when test="function-available('xdXDocument:GetDOM')"><xsl:variable name="val" select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/><xsl:if test="not(xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/DurationUnits/SharePointListChoice_RW[.=$val] or $val='')"><option selected="selected"><xsl:attribute name="value"><xsl:value-of select="$val"/></xsl:attribute><xsl:value-of select="$val"/></option></xsl:if><xsl:for-each select="xdXDocument:GetDOM(&quot;Choices Data Connection&quot;)/root/DurationUnits/SharePointListChoice_RW"><option><xsl:attribute name="value"><xsl:value-of select="."/></xsl:attribute><xsl:if test="$val=."><xsl:attribute name="selected">selected</xsl:attribute></xsl:if><xsl:value-of select="@DisplayName"/></option></xsl:for-each></xsl:when><xsl:otherwise><option><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:DurationUnits"/></option></xsl:otherwise></xsl:choose></select><div><h6 style="FONT-WEIGHT: normal">Define the units of time used by the Duration Per Task.</h6></div></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">CC</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><object class="xdActiveX" hideFocus="1" style="WIDTH: 100%;" classid="clsid:61e40d31-993d-4777-8fa0-19ca59b6d0bb" tabIndex="0" tabStop="true" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="{{61e40d31-993d-4777-8fa0-19ca59b6d0bb}}" xd:CtrlId="CTRL32" xd:server="http://m264981:1411" xd:bindingType="xmlNode" xd:bindingProperty="Value" xd:boundProp="xd:inline" contentEditable="false" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:CC" xd:AllowMultiple="true" xd:SearchPeopleOnly="false" xd:SharePointGroup="0" xd:disableEditing="no"><xsl:if xmlns:xsl="http://www.w3.org/1999/XSL/Transform" test="function-available('xdImage:getImageUrl')"><xsl:attribute name="src"><xsl:value-of select="xdImage:getImageUrl(dfs:dataFields/d:SharePointListItem_RW/d:CC)"/></xsl:attribute></xsl:if><param NAME="ButtonFont" VALUE="Verdana,10,0,400,0,0,0"/><param NAME="ButtonText" VALUE=""/><param NAME="DisplayNameXPath" VALUE="pc:DisplayName"/><param NAME="ObjectIdXPath" VALUE="pc:AccountId"/><param NAME="ObjectTypeXPath" VALUE="pc:AccountType"/><param NAME="SiteUrlXPath" VALUE="/Context/@siteUrl"/><param NAME="SiteUrlDataSource" VALUE="Context"/><param NAME="NewNodeTemplate" VALUE="&lt;pc:Person&gt;&#xA;	&lt;pc:DisplayName&gt;&lt;/pc:DisplayName&gt;&#xA;	&lt;pc:AccountId&gt;&lt;/pc:AccountId&gt;&#xA;	&lt;pc:AccountType&gt;&lt;/pc:AccountType&gt;&#xA;&lt;/pc:Person&gt;"/><param NAME="BackgroundColor" VALUE="2147483653"/><param NAME="MaxLines" VALUE="4"/></object><div><h6 style="FONT-WEIGHT: normal">Notify these people when the workflow starts and ends without assigning tasks to them.</h6></div></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">End on First Rejection</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" tabIndex="0" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="CheckBox" xd:CtrlId="CTRL33" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:CancelonRejection" xd:boundProp="xd:value" xd:offValue="false" xd:onValue="true" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="xd:value"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:CancelonRejection"/></xsl:attribute><xsl:if xmlns:xsl="http://www.w3.org/1999/XSL/Transform" test="dfs:dataFields/d:SharePointListItem_RW/d:CancelonRejection=&quot;true&quot;"><xsl:attribute name="CHECKED">CHECKED</xsl:attribute></xsl:if></input>Automatically reject the document if it is rejected by any participant.</h6></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">End on Document Change</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" tabIndex="0" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="CheckBox" xd:CtrlId="CTRL34" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:CancelonChange" xd:boundProp="xd:value" xd:offValue="false" xd:onValue="true" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="xd:value"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:CancelonChange"/></xsl:attribute><xsl:if xmlns:xsl="http://www.w3.org/1999/XSL/Transform" test="dfs:dataFields/d:SharePointListItem_RW/d:CancelonChange=&quot;true&quot;"><xsl:attribute name="CHECKED">CHECKED</xsl:attribute></xsl:if></input>Automatically reject the document if it is changed before the workflow is completed.</h6></td></tr><tr class="xdTableOffsetRow"><td style="PADDING-RIGHT: 5px; PADDING-LEFT: 22px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellLabel"><h4><span class="xdlabel">Enable Content Approval</span></h4></td><td style="PADDING-RIGHT: 22px; PADDING-LEFT: 5px; PADDING-BOTTOM: 4px; VERTICAL-ALIGN: top; PADDING-TOP: 4px" class="xdTableOffsetCellComponent"><h6 style="FONT-WEIGHT: normal"><input class="xdBehavior_Boolean" title="" type="checkbox" tabIndex="0" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="CheckBox" xd:CtrlId="CTRL35" xd:binding="dfs:dataFields/d:SharePointListItem_RW/d:EnableContentApproval" xd:boundProp="xd:value" xd:offValue="false" xd:onValue="true" xd:disableEditing="no"><xsl:attribute xmlns:xsl="http://www.w3.org/1999/XSL/Transform" name="xd:value"><xsl:value-of select="dfs:dataFields/d:SharePointListItem_RW/d:EnableContentApproval"/></xsl:attribute><xsl:if xmlns:xsl="http://www.w3.org/1999/XSL/Transform" test="dfs:dataFields/d:SharePointListItem_RW/d:EnableContentApproval=&quot;true&quot;"><xsl:attribute name="CHECKED">CHECKED</xsl:attribute></xsl:if></input>Update the approval status after the workflow is completed (use this workflow to control content approval).</h6></td></tr><tr class="xdTableOffsetRow"><td colSpan="2" style="BORDER-BOTTOM: #dbe5f1 1pt; PADDING-TOP: 8px; PADDING-BOTTOM: 4px; PADDING-RIGHT: 1px; PADDING-LEFT: 1px;" class="xdTableOffsetCellLabel"><div align="left"><input class="langFont" title="" type="button" value="Save" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="Button" xd:CtrlId="CTRL44" tabIndex="0" style="width:auto"/>  <input class="langFont" title="" type="button" value="Cancel" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xd:xctname="Button" xd:CtrlId="CTRL48" tabIndex="0" style="width:auto"/>  </div></td></tr></tbody></table></div><div> </div></td></tr></tbody></table></div></body></html></xsl:template></xsl:stylesheet>