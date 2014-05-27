Type.registerNamespace("SitefinityWebApp.Designer");

SitefinityWebApp.Designer.ResponsiveImageDesigner = function (element) {
    /* Initialize Message fields */
    this._imageField = null;
    
    /* Calls the base constructor */
    SitefinityWebApp.Designer.ResponsiveImageDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.Designer.ResponsiveImageDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.Designer.ResponsiveImageDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.Designer.ResponsiveImageDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {
        var controlData = this._propertyEditor.get_control(); /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI Message */
        if (controlData.ImageId) {
            this.get_imageField().set_value(controlData.ImageId);
        }
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control();

        /* ApplyChanges Message */
        controlData.ImageId = this.get_imageField().get_value();
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */

    /* Message properties */
    get_imageField: function () { return this._imageField; }, 
    set_imageField: function (value) { this._imageField = value; }
}

SitefinityWebApp.Designer.ResponsiveImageDesigner.registerClass('SitefinityWebApp.Designer.ResponsiveImageDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);
