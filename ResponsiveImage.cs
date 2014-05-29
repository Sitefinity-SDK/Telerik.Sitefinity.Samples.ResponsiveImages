using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;

namespace ResponsiveImages
{
    /// <summary>
    /// Class used to create custom page widget
    /// </summary>
    [ControlDesigner(typeof(ResponsiveImages.Designer.ResponsiveImageDesigner))]
    public class ResponsiveImage : SimpleView
    {
        #region Properties
        /// <summary>
        /// Gets or sets the message that will be displayed in the label.
        /// </summary>
        public Guid? ImageId { get; set; }

        protected override string LayoutTemplateName
        {
            get
            {
                return ResponsiveImage.layoutTemplatePath;
            }
        }

        /// <summary>
        /// Gets Reference to the Label control that shows the Message.
        /// </summary>
        protected virtual Label MessageLabel
        {
            get
            {
                return this.Container.GetControl<Label>("MessageLabel", true);
            }
        }

        protected virtual HtmlImage OriginalImage
        {
            get
            {
                return this.Container.GetControl<HtmlImage>("originalImage", true);
            }
        }

        protected virtual HtmlImage ResponsiveImageControl
        {
            get
            {
                return this.Container.GetControl<HtmlImage>("responsiveImage", true);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <param name="container">the container</param>
        /// <remarks>
        /// Initialize your controls in this method. Do not override CreateChildControls method.
        /// </remarks>
        protected override void InitializeControls(GenericContainer container)
        {
            if (!this.ImageId.HasValue)
            {
                this.MessageLabel.Text = "No Image Selected";
            }
            else
            {
                this.MessageLabel.Text = "Selected an Image with id : '" + this.ImageId.Value + "'";
                Context.Items.Add("Image", LibrariesManager.GetManager().GetMediaItem(this.ImageId.Value));

                //sets the original image url
                this.OriginalImage.Src = ((MediaContent)Context.Items["Image"]).ResolveMediaUrl();

                //sets the reponsive image url
                this.ResponsiveImageControl.Attributes.Add("srcset", String.Join(", ",
                    new List<string>() { ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb768", true) + " 768w",
                        ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb600", true) + " 600w",
                        ((MediaContent)Context.Items["Image"]).ResolveThumbnailUrl("thumb480", true) + " 480w"
                    }));

            }
        }

        #endregion

        #region Private members & constants

        private static readonly string layoutTemplatePath = "ResponsiveImages.ResponsiveImage.ascx";

        #endregion
    }
}
