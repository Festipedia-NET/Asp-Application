/// <reference path="data.js" />

(function (lightSwitchApplication) {

    var $Screen = msls.Screen,
        $defineScreen = msls._defineScreen,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString,
        $defineShowScreen = msls._defineShowScreen;

    function BrowseBands(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseBands screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Bands" type="msls.VisualCollection" elementType="msls.application.Band">
        /// Gets the bands for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseBands.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseBands", parameters);
    }

    function AddEditBand(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditBand screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Band" type="msls.application.Band">
        /// Gets or sets the band for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditBand.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditBand", parameters);
    }

    function BrowseGeregistreerdeGebruikers(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseGeregistreerdeGebruikers screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="GeregistreerdeGebruikers" type="msls.VisualCollection" elementType="msls.application.GeregistreerdeGebruiker">
        /// Gets the geregistreerdeGebruikers for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseGeregistreerdeGebruikers.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseGeregistreerdeGebruikers", parameters);
    }

    function AddEditGeregistreerdeGebruiker(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditGeregistreerdeGebruiker screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="GeregistreerdeGebruiker" type="msls.application.GeregistreerdeGebruiker">
        /// Gets or sets the geregistreerdeGebruiker for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditGeregistreerdeGebruiker.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditGeregistreerdeGebruiker", parameters);
    }

    msls._addToNamespace("msls.application", {

        BrowseBands: $defineScreen(BrowseBands, [
            {
                name: "Bands", kind: "collection", elementType: lightSwitchApplication.Band,
                createQuery: function () {
                    return this.dataWorkspace.groep15_festivalsData.Bands;
                }
            }
        ], [
        ]),

        AddEditBand: $defineScreen(AddEditBand, [
            { name: "Band", kind: "local", type: lightSwitchApplication.Band }
        ], [
        ]),

        BrowseGeregistreerdeGebruikers: $defineScreen(BrowseGeregistreerdeGebruikers, [
            {
                name: "GeregistreerdeGebruikers", kind: "collection", elementType: lightSwitchApplication.GeregistreerdeGebruiker,
                createQuery: function () {
                    return this.dataWorkspace.groep15_festivalsData.GeregistreerdeGebruikers;
                }
            }
        ], [
        ]),

        AddEditGeregistreerdeGebruiker: $defineScreen(AddEditGeregistreerdeGebruiker, [
            { name: "GeregistreerdeGebruiker", kind: "local", type: lightSwitchApplication.GeregistreerdeGebruiker }
        ], [
        ]),

        showBrowseBands: $defineShowScreen(function showBrowseBands(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseBands screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseBands", parameters, options);
        }),

        showAddEditBand: $defineShowScreen(function showAddEditBand(Band, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditBand screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditBand", parameters, options);
        }),

        showBrowseGeregistreerdeGebruikers: $defineShowScreen(function showBrowseGeregistreerdeGebruikers(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseGeregistreerdeGebruikers screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseGeregistreerdeGebruikers", parameters, options);
        }),

        showAddEditGeregistreerdeGebruiker: $defineShowScreen(function showAddEditGeregistreerdeGebruiker(GeregistreerdeGebruiker, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditGeregistreerdeGebruiker screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditGeregistreerdeGebruiker", parameters, options);
        })

    });

}(msls.application));
