<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>

<%@ Register Tagprefix="SPNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuiteLinks.ascx.cs" Inherits="Navigation.CONTROLTEMPLATES.SuiteLinks" %>
<script src="http://ajax.aspnetcdn.com/ajax/knockout/knockout-2.2.1.js"></script>
<script src="/_layouts/15/Navigation/MARTA.GlobalNavigation.js"></script>
<div>
    <ul class="ms-core-suiteLinkList" data-bind="foreach: globalMenuItems">
        <li class="ms-core-suiteLink">
            <a class="ms-core-suiteLink-a" data-bind="attr: { href: url }">
                <span>
                    <span data-bind="text: title"></span>
                    <!-- ko if: location.href.slice(0, url.length) == url || (location.href.slice(0, 8) === 'https://' && location.href.slice(0, url.replace(':443/', '/').length) == url.replace(':443/', '/')) -->
                    <span class="ms-suitenav-caratBox" id="Suite_ActiveLinkIndicator_Clip"><img class="ms-suitenav-caratIcon" id="Suite_ActiveLinkIndicator" src="/_layouts/15/images/spcommon.png?rev=23" /></span>
                    <!-- /ko -->
                </span>
            </a>

        </li>
    </ul>
</div>
<asp:PlaceHolder ID="InitTopNavPlaceHolder" runat="server" />

