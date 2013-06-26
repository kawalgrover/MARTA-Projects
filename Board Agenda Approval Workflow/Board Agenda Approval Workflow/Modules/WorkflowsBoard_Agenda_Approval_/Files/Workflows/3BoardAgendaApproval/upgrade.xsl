<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:dfs="http://schemas.microsoft.com/office/infopath/2003/dataFormSolution" xmlns:d="http://schemas.microsoft.com/office/infopath/2009/WSSList/dataFields" xmlns:pc="http://schemas.microsoft.com/office/infopath/2007/PartnerControls" xmlns:ma="http://schemas.microsoft.com/office/2009/metadata/properties/metaAttributes" xmlns:q="http://schemas.microsoft.com/office/infopath/2009/WSSList/queryFields" xmlns:dms="http://schemas.microsoft.com/office/2009/documentManagement/types" xmlns:xd="http://schemas.microsoft.com/office/infopath/2003" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2011-06-08T02:14:49" version="1.0">
	<xsl:output encoding="UTF-8" method="xml"/>
	<xsl:template match="/">
		<xsl:copy-of select="processing-instruction() | comment()"/>
		<xsl:choose>
			<xsl:when test="dfs:myFields">
				<xsl:apply-templates select="dfs:myFields" mode="_0"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:variable name="var">
					<xsl:element name="dfs:myFields"/>
				</xsl:variable>
				<xsl:apply-templates select="msxsl:node-set($var)/*" mode="_0"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<xsl:template match="q:SharePointListItem_RW" mode="_2">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:if test="q:ExpandGroups">
				<xsl:element name="q:ExpandGroups">
					<xsl:copy-of select="q:ExpandGroups/@xsi:nil"/>
					<xsl:copy-of select="q:ExpandGroups/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:DueDateforAllTasks">
				<xsl:element name="q:DueDateforAllTasks">
					<xsl:copy-of select="q:DueDateforAllTasks/@xsi:nil"/>
					<xsl:copy-of select="q:DueDateforAllTasks/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:DurationforSerialTasks">
				<xsl:element name="q:DurationforSerialTasks">
					<xsl:copy-of select="q:DurationforSerialTasks/@xsi:nil"/>
					<xsl:copy-of select="q:DurationforSerialTasks/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:DurationUnits">
				<xsl:element name="q:DurationUnits">
					<xsl:copy-of select="q:DurationUnits/@xsi:nil"/>
					<xsl:copy-of select="q:DurationUnits/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:CancelonRejection">
				<xsl:element name="q:CancelonRejection">
					<xsl:copy-of select="q:CancelonRejection/@xsi:nil"/>
					<xsl:copy-of select="q:CancelonRejection/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:CancelonChange">
				<xsl:element name="q:CancelonChange">
					<xsl:copy-of select="q:CancelonChange/@xsi:nil"/>
					<xsl:copy-of select="q:CancelonChange/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="q:EnableContentApproval">
				<xsl:element name="q:EnableContentApproval">
					<xsl:copy-of select="q:EnableContentApproval/@xsi:nil"/>
					<xsl:copy-of select="q:EnableContentApproval/text()[1]"/>
				</xsl:element>
			</xsl:if>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="dfs:queryFields" mode="_1">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="q:SharePointListItem_RW[1]" mode="_2"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="pc:Person" mode="_8">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:if test="pc:DisplayName">
				<xsl:element name="pc:DisplayName">
					<xsl:copy-of select="pc:DisplayName/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="pc:AccountId">
				<xsl:element name="pc:AccountId">
					<xsl:copy-of select="pc:AccountId/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="pc:AccountType">
				<xsl:element name="pc:AccountType">
					<xsl:copy-of select="pc:AccountType/text()[1]"/>
				</xsl:element>
			</xsl:if>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="d:Assignee" mode="_7">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="pc:Person" mode="_8"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="d:Assignment" mode="_6">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="d:Assignee[1]" mode="_7"/>
			<xsl:if test="d:Stage">
				<xsl:element name="d:Stage">
					<xsl:copy-of select="d:Stage/@xsi:nil"/>
					<xsl:copy-of select="d:Stage/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:AssignmentType">
				<xsl:element name="d:AssignmentType">
					<xsl:copy-of select="d:AssignmentType/text()[1]"/>
				</xsl:element>
			</xsl:if>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="d:Approvers" mode="_5">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="d:Assignment" mode="_6"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="pc:Person" mode="_10">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="d:CC" mode="_9">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="pc:Person" mode="_10"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="d:SharePointListItem_RW" mode="_4">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="d:Approvers[1]" mode="_5"/>
			<xsl:if test="d:ExpandGroups">
				<xsl:element name="d:ExpandGroups">
					<xsl:copy-of select="d:ExpandGroups/@xsi:nil"/>
					<xsl:copy-of select="d:ExpandGroups/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:NotificationMessage">
				<xsl:element name="d:NotificationMessage">
					<xsl:copy-of select="d:NotificationMessage/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:DueDateforAllTasks">
				<xsl:element name="d:DueDateforAllTasks">
					<xsl:copy-of select="d:DueDateforAllTasks/@xsi:nil"/>
					<xsl:copy-of select="d:DueDateforAllTasks/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:DurationforSerialTasks">
				<xsl:element name="d:DurationforSerialTasks">
					<xsl:copy-of select="d:DurationforSerialTasks/@xsi:nil"/>
					<xsl:copy-of select="d:DurationforSerialTasks/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:DurationUnits">
				<xsl:element name="d:DurationUnits">
					<xsl:copy-of select="d:DurationUnits/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:apply-templates select="d:CC[1]" mode="_9"/>
			<xsl:if test="d:CancelonRejection">
				<xsl:element name="d:CancelonRejection">
					<xsl:copy-of select="d:CancelonRejection/@xsi:nil"/>
					<xsl:copy-of select="d:CancelonRejection/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:CancelonChange">
				<xsl:element name="d:CancelonChange">
					<xsl:copy-of select="d:CancelonChange/@xsi:nil"/>
					<xsl:copy-of select="d:CancelonChange/text()[1]"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="d:EnableContentApproval">
				<xsl:element name="d:EnableContentApproval">
					<xsl:copy-of select="d:EnableContentApproval/@xsi:nil"/>
					<xsl:copy-of select="d:EnableContentApproval/text()[1]"/>
				</xsl:element>
			</xsl:if>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="dfs:dataFields" mode="_3">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="d:SharePointListItem_RW[1]" mode="_4"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="dfs:myFields" mode="_0">
		<xsl:copy>
			<xsl:copy-of select="@*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'urn:schemas-microsoft-com:xml-msdata' or namespace-uri() = 'urn:schemas-microsoft-com:xml-diffgram-v1']"/>
			<xsl:apply-templates select="dfs:queryFields[1]" mode="_1"/>
			<xsl:apply-templates select="dfs:dataFields[1]" mode="_3"/>
			<xsl:element name="my:God">
				<xsl:choose>
					<xsl:when test="my:God/text()[1]">
						<xsl:copy-of select="my:God/text()[1]"/>
					</xsl:when>
					<xsl:otherwise>false</xsl:otherwise>
				</xsl:choose>
			</xsl:element>
			<xsl:element name="my:Super_God">
				<xsl:choose>
					<xsl:when test="my:Super_God/text()[1]">
						<xsl:copy-of select="my:Super_God/text()[1]"/>
					</xsl:when>
					<xsl:otherwise>false</xsl:otherwise>
				</xsl:choose>
			</xsl:element>
			<xsl:element name="my:Super_Duper_God">
				<xsl:choose>
					<xsl:when test="my:Super_Duper_God/text()[1]">
						<xsl:copy-of select="my:Super_Duper_God/text()[1]"/>
					</xsl:when>
					<xsl:otherwise>false</xsl:otherwise>
				</xsl:choose>
			</xsl:element>
			<xsl:copy-of select="*[namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/adomapping' or namespace-uri() = 'http://schemas.microsoft.com/office/infopath/2003/changeTracking']"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>