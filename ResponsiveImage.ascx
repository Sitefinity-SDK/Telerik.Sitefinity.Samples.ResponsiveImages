<%@ Control Language="C#" %>

<%@ Import Namespace="Telerik.Sitefinity.Modules.Libraries" %>
<%@ Import Namespace="Telerik.Sitefinity.Libraries.Model" %>

<p>
    <strong>
        <asp:Label ID="MessageLabel" Text="Text" runat="server" />
    </strong>
</p>
<p>
    <strong>Original Image :
    <img src="<%= ((MediaContent)Context.Items["Image"]).ResolveMediaUrl() %>" />
    </strong>
</p>

<br />
<strong>Responsive Image:</strong>
<p>
    <picture>
		    <!--[if IE 9]><video style="display: none;"><![endif]-->
		    <source srcset="<%= ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb768", true) %>" media="(min-width: 768px)"/>
		    <source srcset="<%= ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb600", true) %>" media="(min-width: 600px)"/>
            <source srcset="<%= ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb480", true) %>"/>
		    <!--[if IE 9]></video><![endif]-->
		    <img srcset="<%= ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb480", true) %>" />
    </picture>
</p>
<%--     
    Alternative way to set the different thumbnails
<p>
	<img sizes="100vw, (min-width: 40em) 80vw"
			srcset="examples/images/pic-small.png 400w, examples/images/pic-medium.png 800w, examples/images/pic-large.png 1200w">
</p>
--%>