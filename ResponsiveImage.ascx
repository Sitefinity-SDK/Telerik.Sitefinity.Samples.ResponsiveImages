<%@ Control Language="C#" %>

<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sitefinity" %>

<%@ Import Namespace="Telerik.Sitefinity.Modules.Libraries" %>
<%@ Import Namespace="Telerik.Sitefinity.Libraries.Model" %>
<%@ Import Namespace="System.Web" %>

<asp:HiddenField runat="server" ID="hfMediaContentUrl" />

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server" UseEmbeddedThemes="True">
    <sitefinity:ResourceFile AssemblyInfo="ResponsiveImages.ResponsiveImage, ResponsiveImages" Name="ResponsiveImages.Scripts.picturefill.js" />
</sitefinity:ResourceLinks>

<p>
    <strong>
        <asp:Label ID="MessageLabel" Text="Text" runat="server" />
    </strong>
</p>
<p>
    <strong>Original Image :
    <img runat="server" Id="originalImage" />
    </strong>
</p>

<br />
<strong>Responsive Image:</strong>
<p>
	<img runat="server" id="responsiveImage" sizes="(min-width: 768px), (min-width: 600px), (min-width: 480px)" />
</p>
