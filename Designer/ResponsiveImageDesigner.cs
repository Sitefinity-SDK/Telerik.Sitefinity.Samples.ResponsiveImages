using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Sitefinity.Web.UI.Fields;

namespace SitefinityWebApp.Designer
{
    /// <summary>
    /// Represents a designer for the <typeparamref name="SitefinityWebApp.ResponsiveImageDesigner"/> widget
    /// </summary>
    public class ResponsiveImageDesigner : ControlDesignerBase
    {
        #region Private members & constants

        private const string TheScriptReference = "~/Designer/ResponsiveImageDesigner.js";
        private static readonly string TheLayoutTemplatePath = "~/Designer/ResponsiveImageDesigner.ascx";
        
        #endregion
        
        #region Properties

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    return ResponsiveImageDesigner.TheLayoutTemplatePath;
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
        /// Gets the tag key
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }

        #endregion
        
        #region Control references
        
        /// <summary>
        /// Gets the control that is bound to the ImageField property
        /// </summary>
        protected virtual ImageField Image
        {
            get
            {
                return this.Container.GetControl<ImageField>("Image", true);
            }
        }
        
        #endregion
        
        #region Methods

        #region IScriptControl implementation

        /// <summary>
        ///  Gets a collection of script descriptors that represent ECMAScript (JavaScript) client components.
        /// </summary>
        /// <returns>enumeration of all script descriptors</returns>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors()
        {
            var scriptDescriptors = new List<ScriptDescriptor>(base.GetScriptDescriptors());
            var descriptor = (ScriptControlDescriptor)scriptDescriptors.Last();

            descriptor.AddComponentProperty("imageField", this.Image.ClientID);

            return scriptDescriptors;
        }

        /// <summary>
        ///  Gets a collection of ScriptReference objects that define script resources that the control requires.
        /// </summary>
        /// <returns>enumeration of all script references</returns>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences());
            scripts.Add(new ScriptReference(ResponsiveImageDesigner.TheScriptReference));
            return scripts;
        }

        #endregion

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <param name="container">the container</param>
        /// <remarks>
        /// Initialize your controls in this method. Do not override CreateChildControls method.
        /// </remarks>
        protected override void InitializeControls(GenericContainer container)
        {
        }

        #endregion
    }
}