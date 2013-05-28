/// <reference path="viewModel.js" />

(function (lightSwitchApplication) {

    var $parameters = [document.createElement("div"), msls.ContentItem];

    msls._addEntryPoints(lightSwitchApplication.BrowseBands, {
        /// <field>
        /// Called when a new BrowseBands screen is created.
        /// <br/>created(msls.application.BrowseBands screen)
        /// </field>
        created: [lightSwitchApplication.BrowseBands],
        /// <field>
        /// Called before changes on an active BrowseBands screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseBands screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseBands],
        /// <field>
        /// Called after the BandList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        BandList_postRender: $parameters,
        /// <field>
        /// Called after the Band content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Band_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the band_naam content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_naam_postRender: $parameters,
        /// <field>
        /// Called after the band_soortMuziek content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_soortMuziek_postRender: $parameters,
        /// <field>
        /// Called after the band_url content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_url_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditBand, {
        /// <field>
        /// Called when a new AddEditBand screen is created.
        /// <br/>created(msls.application.AddEditBand screen)
        /// </field>
        created: [lightSwitchApplication.AddEditBand],
        /// <field>
        /// Called before changes on an active AddEditBand screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditBand screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditBand],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the band_naam content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_naam_postRender: $parameters,
        /// <field>
        /// Called after the band_soortMuziek content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_soortMuziek_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the band_url content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        band_url_postRender: $parameters,
        /// <field>
        /// Called after the EditBand content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EditBand_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseGeregistreerdeGebruikers, {
        /// <field>
        /// Called when a new BrowseGeregistreerdeGebruikers screen is created.
        /// <br/>created(msls.application.BrowseGeregistreerdeGebruikers screen)
        /// </field>
        created: [lightSwitchApplication.BrowseGeregistreerdeGebruikers],
        /// <field>
        /// Called before changes on an active BrowseGeregistreerdeGebruikers screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseGeregistreerdeGebruikers screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseGeregistreerdeGebruikers],
        /// <field>
        /// Called after the GeregistreerdeGebruikerList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        GeregistreerdeGebruikerList_postRender: $parameters,
        /// <field>
        /// Called after the GeregistreerdeGebruiker content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        GeregistreerdeGebruiker_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the gebr_naam content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_naam_postRender: $parameters,
        /// <field>
        /// Called after the gebr_adres content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_adres_postRender: $parameters,
        /// <field>
        /// Called after the gebr_gebDat content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_gebDat_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditGeregistreerdeGebruiker, {
        /// <field>
        /// Called when a new AddEditGeregistreerdeGebruiker screen is created.
        /// <br/>created(msls.application.AddEditGeregistreerdeGebruiker screen)
        /// </field>
        created: [lightSwitchApplication.AddEditGeregistreerdeGebruiker],
        /// <field>
        /// Called before changes on an active AddEditGeregistreerdeGebruiker screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditGeregistreerdeGebruiker screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditGeregistreerdeGebruiker],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the gebr_naam content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_naam_postRender: $parameters,
        /// <field>
        /// Called after the gebr_adres content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_adres_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the gebr_gebDat content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        gebr_gebDat_postRender: $parameters
    });

}(msls.application));
