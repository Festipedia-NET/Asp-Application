/// <reference path="data.js" />

(function (lightSwitchApplication) {

    msls._addEntryPoints(lightSwitchApplication.Band, {
        /// <field>
        /// Called when a new band is created.
        /// <br/>created(msls.application.Band entity)
        /// </field>
        created: [lightSwitchApplication.Band]
    });

    msls._addEntryPoints(lightSwitchApplication.BandsPerFestival, {
        /// <field>
        /// Called when a new bandsPerFestival is created.
        /// <br/>created(msls.application.BandsPerFestival entity)
        /// </field>
        created: [lightSwitchApplication.BandsPerFestival]
    });

    msls._addEntryPoints(lightSwitchApplication.Camping, {
        /// <field>
        /// Called when a new camping is created.
        /// <br/>created(msls.application.Camping entity)
        /// </field>
        created: [lightSwitchApplication.Camping]
    });

    msls._addEntryPoints(lightSwitchApplication.CampingsPerFestival, {
        /// <field>
        /// Called when a new campingsPerFestival is created.
        /// <br/>created(msls.application.CampingsPerFestival entity)
        /// </field>
        created: [lightSwitchApplication.CampingsPerFestival]
    });

    msls._addEntryPoints(lightSwitchApplication.Faciliteiten, {
        /// <field>
        /// Called when a new faciliteiten is created.
        /// <br/>created(msls.application.Faciliteiten entity)
        /// </field>
        created: [lightSwitchApplication.Faciliteiten]
    });

    msls._addEntryPoints(lightSwitchApplication.FacPerCamp, {
        /// <field>
        /// Called when a new facPerCamp is created.
        /// <br/>created(msls.application.FacPerCamp entity)
        /// </field>
        created: [lightSwitchApplication.FacPerCamp]
    });

    msls._addEntryPoints(lightSwitchApplication.Festival, {
        /// <field>
        /// Called when a new festival is created.
        /// <br/>created(msls.application.Festival entity)
        /// </field>
        created: [lightSwitchApplication.Festival]
    });

    msls._addEntryPoints(lightSwitchApplication.GeregistreerdeGebruiker, {
        /// <field>
        /// Called when a new geregistreerdeGebruiker is created.
        /// <br/>created(msls.application.GeregistreerdeGebruiker entity)
        /// </field>
        created: [lightSwitchApplication.GeregistreerdeGebruiker]
    });

    msls._addEntryPoints(lightSwitchApplication.Podia, {
        /// <field>
        /// Called when a new podia is created.
        /// <br/>created(msls.application.Podia entity)
        /// </field>
        created: [lightSwitchApplication.Podia]
    });

    msls._addEntryPoints(lightSwitchApplication.sysdiagram, {
        /// <field>
        /// Called when a new sysdiagram is created.
        /// <br/>created(msls.application.sysdiagram entity)
        /// </field>
        created: [lightSwitchApplication.sysdiagram]
    });

    msls._addEntryPoints(lightSwitchApplication.Ticket, {
        /// <field>
        /// Called when a new ticket is created.
        /// <br/>created(msls.application.Ticket entity)
        /// </field>
        created: [lightSwitchApplication.Ticket]
    });

    msls._addEntryPoints(lightSwitchApplication.Tickettype, {
        /// <field>
        /// Called when a new tickettype is created.
        /// <br/>created(msls.application.Tickettype entity)
        /// </field>
        created: [lightSwitchApplication.Tickettype]
    });

    msls._addEntryPoints(lightSwitchApplication.TickettypesPerFestival, {
        /// <field>
        /// Called when a new tickettypesPerFestival is created.
        /// <br/>created(msls.application.TickettypesPerFestival entity)
        /// </field>
        created: [lightSwitchApplication.TickettypesPerFestival]
    });

}(msls.application));
