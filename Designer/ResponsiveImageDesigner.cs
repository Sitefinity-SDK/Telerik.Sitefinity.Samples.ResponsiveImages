using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Sitefinity.Web.UI.Fields;

namespace ResponsiveImages.Designer
{
    /// <summary>
    /// Represents a designer for the <typeparamref name="ResponsiveImages.Designer.ResponsiveImageDesigner"/> widget
    /// </summary>
    public class ResponsiveImageDesigner : ControlDesignerBase
    {       
        #region Properties

        /// <inheritdoc />
        protected override string LayoutTemplateName
        {
            get
            {
                return ResponsiveImageDesigner.layoutTemplatePath;
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
            var assemblyName = this.GetType().Assembly.GetName().ToString();
            scripts.Add(new ScriptReference(ResponsiveImageDesigner.scriptReference, assemblyName));
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

        #region Private members & constants

        private const string scriptReference = "ResponsiveImages.Designer.ResponsiveImageDesigner.js";
        private static readonly string layoutTemplatePath = "ResponsiveImages.Designer.ResponsiveImageDesigner.ascx";

        #endregion
    }
}