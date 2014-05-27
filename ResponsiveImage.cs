using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Web.UI;

namespace SitefinityWebApp
{
    /// <summary>
    /// Class used to create custom page widget
    /// </summary>
    [Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(SitefinityWebApp.Designer.ResponsiveImageDesigner))]
    public class ResponsiveImage : SimpleScriptView
    {
        #region Private members & constants
        private static readonly string TheLayoutTemplatePath = "~/ResponsiveImage.ascx";
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the message that will be displayed in the label.
        /// </summary>
        public Guid? ImageId { get; set; }

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    return ResponsiveImage.TheLayoutTemplatePath;
                return base.LayoutTemplatePath;
            }

            set
            {
                base.LayoutTemplatePath = value;
            }
        }

        /// <summary>
        /// Obsolete. Use LayoutTemplatePath instead.
        /// </summary>
        protected override string LayoutTemplateName
        {
            get
            {
                return string.Empty;
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

        #endregion

        #region Methods

        /// <summary>
        /// Gets a collection of script descriptors that represent ECMAScript (JavaScript) client components.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerable" /> collection of <see cref="T:System.Web.UI.ScriptDescriptor" /> objects.
        /// </returns>
        public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            var descriptor = new ScriptControlDescriptor(typeof(ResponsiveImage).FullName, this.ClientID);
            return new[] { descriptor };
        }

        /// <summary>
        /// Gets a collection of <see cref="T:System.Web.UI.ScriptReference" /> objects that define script resources that the control requires.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerable" /> collection of <see cref="T:System.Web.UI.ScriptReference" /> objects.
        /// </returns>
        public override IEnumerable<ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>();
            scripts.Add(new ScriptReference("~/Scripts/picturefill.js"));
            return scripts;
        }

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
            }
        }
        #endregion
    }
}
