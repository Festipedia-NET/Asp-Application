/// <reference path="../Scripts/msls-1.0.0.js" />

window.myapp = msls.application;

(function (lightSwitchApplication) {

    var $Entity = msls.Entity,
        $DataService = msls.DataService,
        $DataWorkspace = msls.DataWorkspace,
        $defineEntity = msls._defineEntity,
        $defineDataService = msls._defineDataService,
        $defineDataWorkspace = msls._defineDataWorkspace,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString;

    function Band(entitySet) {
        /// <summary>
        /// Represents the Band entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this band.
        /// </param>
        /// <field name="band_id" type="Number">
        /// Gets or sets the band_id for this band.
        /// </field>
        /// <field name="band_naam" type="String">
        /// Gets or sets the band_naam for this band.
        /// </field>
        /// <field name="band_soortMuziek" type="String">
        /// Gets or sets the band_soortMuziek for this band.
        /// </field>
        /// <field name="band_url" type="String">
        /// Gets or sets the band_url for this band.
        /// </field>
        /// <field name="BandsPerFestivals" type="msls.EntityCollection" elementType="msls.application.BandsPerFestival">
        /// Gets the bandsPerFestivals for this band.
        /// </field>
        /// <field name="details" type="msls.application.Band.Details">
        /// Gets the details for this band.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function BandsPerFestival(entitySet) {
        /// <summary>
        /// Represents the BandsPerFestival entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this bandsPerFestival.
        /// </param>
        /// <field name="fest_id" type="Number">
        /// Gets or sets the fest_id for this bandsPerFestival.
        /// </field>
        /// <field name="band_id" type="Number">
        /// Gets or sets the band_id for this bandsPerFestival.
        /// </field>
        /// <field name="datum" type="Date">
        /// Gets or sets the datum for this bandsPerFestival.
        /// </field>
        /// <field name="uur" type="Object">
        /// Gets or sets the uur for this bandsPerFestival.
        /// </field>
        /// <field name="Band" type="msls.application.Band">
        /// Gets or sets the band for this bandsPerFestival.
        /// </field>
        /// <field name="Festival" type="msls.application.Festival">
        /// Gets or sets the festival for this bandsPerFestival.
        /// </field>
        /// <field name="Podia" type="msls.application.Podia">
        /// Gets or sets the podia for this bandsPerFestival.
        /// </field>
        /// <field name="details" type="msls.application.BandsPerFestival.Details">
        /// Gets the details for this bandsPerFestival.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Camping(entitySet) {
        /// <summary>
        /// Represents the Camping entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this camping.
        /// </param>
        /// <field name="camp_id" type="Number">
        /// Gets or sets the camp_id for this camping.
        /// </field>
        /// <field name="camp_adres" type="String">
        /// Gets or sets the camp_adres for this camping.
        /// </field>
        /// <field name="camp_cap" type="Number">
        /// Gets or sets the camp_cap for this camping.
        /// </field>
        /// <field name="CampingsPerFestivals" type="msls.EntityCollection" elementType="msls.application.CampingsPerFestival">
        /// Gets the campingsPerFestivals for this camping.
        /// </field>
        /// <field name="FacPerCamps" type="msls.EntityCollection" elementType="msls.application.FacPerCamp">
        /// Gets the facPerCamps for this camping.
        /// </field>
        /// <field name="details" type="msls.application.Camping.Details">
        /// Gets the details for this camping.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function CampingsPerFestival(entitySet) {
        /// <summary>
        /// Represents the CampingsPerFestival entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this campingsPerFestival.
        /// </param>
        /// <field name="fest_id" type="Number">
        /// Gets or sets the fest_id for this campingsPerFestival.
        /// </field>
        /// <field name="camp_id" type="Number">
        /// Gets or sets the camp_id for this campingsPerFestival.
        /// </field>
        /// <field name="Camping" type="msls.application.Camping">
        /// Gets or sets the camping for this campingsPerFestival.
        /// </field>
        /// <field name="Festival" type="msls.application.Festival">
        /// Gets or sets the festival for this campingsPerFestival.
        /// </field>
        /// <field name="details" type="msls.application.CampingsPerFestival.Details">
        /// Gets the details for this campingsPerFestival.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Faciliteiten(entitySet) {
        /// <summary>
        /// Represents the Faciliteiten entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this faciliteiten.
        /// </param>
        /// <field name="fac_id" type="Number">
        /// Gets or sets the fac_id for this faciliteiten.
        /// </field>
        /// <field name="fac_omschr" type="String">
        /// Gets or sets the fac_omschr for this faciliteiten.
        /// </field>
        /// <field name="fac_eenhprijs" type="Number">
        /// Gets or sets the fac_eenhprijs for this faciliteiten.
        /// </field>
        /// <field name="FacPerCamps" type="msls.EntityCollection" elementType="msls.application.FacPerCamp">
        /// Gets the facPerCamps for this faciliteiten.
        /// </field>
        /// <field name="details" type="msls.application.Faciliteiten.Details">
        /// Gets the details for this faciliteiten.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function FacPerCamp(entitySet) {
        /// <summary>
        /// Represents the FacPerCamp entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this facPerCamp.
        /// </param>
        /// <field name="camp_id" type="Number">
        /// Gets or sets the camp_id for this facPerCamp.
        /// </field>
        /// <field name="fac_id" type="Number">
        /// Gets or sets the fac_id for this facPerCamp.
        /// </field>
        /// <field name="aantal" type="Number">
        /// Gets or sets the aantal for this facPerCamp.
        /// </field>
        /// <field name="Camping" type="msls.application.Camping">
        /// Gets or sets the camping for this facPerCamp.
        /// </field>
        /// <field name="Faciliteiten" type="msls.application.Faciliteiten">
        /// Gets or sets the faciliteiten for this facPerCamp.
        /// </field>
        /// <field name="details" type="msls.application.FacPerCamp.Details">
        /// Gets the details for this facPerCamp.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Festival(entitySet) {
        /// <summary>
        /// Represents the Festival entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this festival.
        /// </param>
        /// <field name="fest_id" type="Number">
        /// Gets or sets the fest_id for this festival.
        /// </field>
        /// <field name="fest_naam" type="String">
        /// Gets or sets the fest_naam for this festival.
        /// </field>
        /// <field name="fest_locatie" type="String">
        /// Gets or sets the fest_locatie for this festival.
        /// </field>
        /// <field name="fest_datum" type="Date">
        /// Gets or sets the fest_datum for this festival.
        /// </field>
        /// <field name="fest_duur" type="Number">
        /// Gets or sets the fest_duur for this festival.
        /// </field>
        /// <field name="BandsPerFestivals" type="msls.EntityCollection" elementType="msls.application.BandsPerFestival">
        /// Gets the bandsPerFestivals for this festival.
        /// </field>
        /// <field name="CampingsPerFestivals" type="msls.EntityCollection" elementType="msls.application.CampingsPerFestival">
        /// Gets the campingsPerFestivals for this festival.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this festival.
        /// </field>
        /// <field name="TickettypesPerFestivals" type="msls.EntityCollection" elementType="msls.application.TickettypesPerFestival">
        /// Gets the tickettypesPerFestivals for this festival.
        /// </field>
        /// <field name="details" type="msls.application.Festival.Details">
        /// Gets the details for this festival.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function GeregistreerdeGebruiker(entitySet) {
        /// <summary>
        /// Represents the GeregistreerdeGebruiker entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this geregistreerdeGebruiker.
        /// </param>
        /// <field name="gebr_id" type="Number">
        /// Gets or sets the gebr_id for this geregistreerdeGebruiker.
        /// </field>
        /// <field name="gebr_naam" type="String">
        /// Gets or sets the gebr_naam for this geregistreerdeGebruiker.
        /// </field>
        /// <field name="gebr_adres" type="String">
        /// Gets or sets the gebr_adres for this geregistreerdeGebruiker.
        /// </field>
        /// <field name="gebr_gebDat" type="Date">
        /// Gets or sets the gebr_gebDat for this geregistreerdeGebruiker.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this geregistreerdeGebruiker.
        /// </field>
        /// <field name="details" type="msls.application.GeregistreerdeGebruiker.Details">
        /// Gets the details for this geregistreerdeGebruiker.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Podia(entitySet) {
        /// <summary>
        /// Represents the Podia entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this podia.
        /// </param>
        /// <field name="pod_id" type="Number">
        /// Gets or sets the pod_id for this podia.
        /// </field>
        /// <field name="pod_omschr" type="String">
        /// Gets or sets the pod_omschr for this podia.
        /// </field>
        /// <field name="pod_locatie" type="String">
        /// Gets or sets the pod_locatie for this podia.
        /// </field>
        /// <field name="BandsPerFestivals" type="msls.EntityCollection" elementType="msls.application.BandsPerFestival">
        /// Gets the bandsPerFestivals for this podia.
        /// </field>
        /// <field name="details" type="msls.application.Podia.Details">
        /// Gets the details for this podia.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function sysdiagram(entitySet) {
        /// <summary>
        /// Represents the sysdiagram entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this sysdiagram.
        /// </param>
        /// <field name="name" type="String">
        /// Gets or sets the name for this sysdiagram.
        /// </field>
        /// <field name="principal_id" type="Number">
        /// Gets or sets the principal_id for this sysdiagram.
        /// </field>
        /// <field name="diagram_id" type="Number">
        /// Gets or sets the diagram_id for this sysdiagram.
        /// </field>
        /// <field name="version" type="Number">
        /// Gets or sets the version for this sysdiagram.
        /// </field>
        /// <field name="definition" type="Array">
        /// Gets or sets the definition for this sysdiagram.
        /// </field>
        /// <field name="details" type="msls.application.sysdiagram.Details">
        /// Gets the details for this sysdiagram.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Ticket(entitySet) {
        /// <summary>
        /// Represents the Ticket entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this ticket.
        /// </param>
        /// <field name="fest_id" type="Number">
        /// Gets or sets the fest_id for this ticket.
        /// </field>
        /// <field name="gebr_id" type="Number">
        /// Gets or sets the gebr_id for this ticket.
        /// </field>
        /// <field name="ticket_datum" type="Date">
        /// Gets or sets the ticket_datum for this ticket.
        /// </field>
        /// <field name="Festival" type="msls.application.Festival">
        /// Gets or sets the festival for this ticket.
        /// </field>
        /// <field name="GeregistreerdeGebruiker" type="msls.application.GeregistreerdeGebruiker">
        /// Gets or sets the geregistreerdeGebruiker for this ticket.
        /// </field>
        /// <field name="Tickettype" type="msls.application.Tickettype">
        /// Gets or sets the tickettype for this ticket.
        /// </field>
        /// <field name="details" type="msls.application.Ticket.Details">
        /// Gets the details for this ticket.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Tickettype(entitySet) {
        /// <summary>
        /// Represents the Tickettype entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this tickettype.
        /// </param>
        /// <field name="typ_id" type="Number">
        /// Gets or sets the typ_id for this tickettype.
        /// </field>
        /// <field name="typ_omschr" type="String">
        /// Gets or sets the typ_omschr for this tickettype.
        /// </field>
        /// <field name="typ_prijs" type="Number">
        /// Gets or sets the typ_prijs for this tickettype.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this tickettype.
        /// </field>
        /// <field name="TickettypesPerFestivals" type="msls.EntityCollection" elementType="msls.application.TickettypesPerFestival">
        /// Gets the tickettypesPerFestivals for this tickettype.
        /// </field>
        /// <field name="details" type="msls.application.Tickettype.Details">
        /// Gets the details for this tickettype.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function TickettypesPerFestival(entitySet) {
        /// <summary>
        /// Represents the TickettypesPerFestival entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this tickettypesPerFestival.
        /// </param>
        /// <field name="fest_id" type="Number">
        /// Gets or sets the fest_id for this tickettypesPerFestival.
        /// </field>
        /// <field name="typ_id" type="Number">
        /// Gets or sets the typ_id for this tickettypesPerFestival.
        /// </field>
        /// <field name="aantal" type="Number">
        /// Gets or sets the aantal for this tickettypesPerFestival.
        /// </field>
        /// <field name="Festival" type="msls.application.Festival">
        /// Gets or sets the festival for this tickettypesPerFestival.
        /// </field>
        /// <field name="Tickettype" type="msls.application.Tickettype">
        /// Gets or sets the tickettype for this tickettypesPerFestival.
        /// </field>
        /// <field name="details" type="msls.application.TickettypesPerFestival.Details">
        /// Gets the details for this tickettypesPerFestival.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function groep15_festivalsData(dataWorkspace) {
        /// <summary>
        /// Represents the groep15_festivalsData data service.
        /// </summary>
        /// <param name="dataWorkspace" type="msls.DataWorkspace">
        /// The data workspace that created this data service.
        /// </param>
        /// <field name="Bands" type="msls.EntitySet">
        /// Gets the Bands entity set.
        /// </field>
        /// <field name="BandsPerFestivals" type="msls.EntitySet">
        /// Gets the BandsPerFestivals entity set.
        /// </field>
        /// <field name="Campings" type="msls.EntitySet">
        /// Gets the Campings entity set.
        /// </field>
        /// <field name="CampingsPerFestivals" type="msls.EntitySet">
        /// Gets the CampingsPerFestivals entity set.
        /// </field>
        /// <field name="Faciliteitens" type="msls.EntitySet">
        /// Gets the Faciliteitens entity set.
        /// </field>
        /// <field name="FacPerCamps" type="msls.EntitySet">
        /// Gets the FacPerCamps entity set.
        /// </field>
        /// <field name="Festivals" type="msls.EntitySet">
        /// Gets the Festivals entity set.
        /// </field>
        /// <field name="GeregistreerdeGebruikers" type="msls.EntitySet">
        /// Gets the GeregistreerdeGebruikers entity set.
        /// </field>
        /// <field name="Podias" type="msls.EntitySet">
        /// Gets the Podias entity set.
        /// </field>
        /// <field name="sysdiagrams" type="msls.EntitySet">
        /// Gets the sysdiagrams entity set.
        /// </field>
        /// <field name="Tickets" type="msls.EntitySet">
        /// Gets the Tickets entity set.
        /// </field>
        /// <field name="Tickettypes" type="msls.EntitySet">
        /// Gets the Tickettypes entity set.
        /// </field>
        /// <field name="TickettypesPerFestivals" type="msls.EntitySet">
        /// Gets the TickettypesPerFestivals entity set.
        /// </field>
        /// <field name="details" type="msls.application.groep15_festivalsData.Details">
        /// Gets the details for this data service.
        /// </field>
        $DataService.call(this, dataWorkspace);
    };
    function DataWorkspace() {
        /// <summary>
        /// Represents the data workspace.
        /// </summary>
        /// <field name="groep15_festivalsData" type="msls.application.groep15_festivalsData">
        /// Gets the groep15_festivalsData data service.
        /// </field>
        /// <field name="details" type="msls.application.DataWorkspace.Details">
        /// Gets the details for this data workspace.
        /// </field>
        $DataWorkspace.call(this);
    };

    msls._addToNamespace("msls.application", {

        Band: $defineEntity(Band, [
            { name: "band_id", type: Number },
            { name: "band_naam", type: String },
            { name: "band_soortMuziek", type: String },
            { name: "band_url", type: String },
            { name: "BandsPerFestivals", kind: "collection", elementType: BandsPerFestival }
        ]),

        BandsPerFestival: $defineEntity(BandsPerFestival, [
            { name: "fest_id", type: Number },
            { name: "band_id", type: Number },
            { name: "datum", type: Date },
            { name: "uur", type: Object },
            { name: "Band", kind: "reference", type: Band },
            { name: "Festival", kind: "reference", type: Festival },
            { name: "Podia", kind: "reference", type: Podia }
        ]),

        Camping: $defineEntity(Camping, [
            { name: "camp_id", type: Number },
            { name: "camp_adres", type: String },
            { name: "camp_cap", type: Number },
            { name: "CampingsPerFestivals", kind: "collection", elementType: CampingsPerFestival },
            { name: "FacPerCamps", kind: "collection", elementType: FacPerCamp }
        ]),

        CampingsPerFestival: $defineEntity(CampingsPerFestival, [
            { name: "fest_id", type: Number },
            { name: "camp_id", type: Number },
            { name: "Camping", kind: "reference", type: Camping },
            { name: "Festival", kind: "reference", type: Festival }
        ]),

        Faciliteiten: $defineEntity(Faciliteiten, [
            { name: "fac_id", type: Number },
            { name: "fac_omschr", type: String },
            { name: "fac_eenhprijs", type: Number },
            { name: "FacPerCamps", kind: "collection", elementType: FacPerCamp }
        ]),

        FacPerCamp: $defineEntity(FacPerCamp, [
            { name: "camp_id", type: Number },
            { name: "fac_id", type: Number },
            { name: "aantal", type: Number },
            { name: "Camping", kind: "reference", type: Camping },
            { name: "Faciliteiten", kind: "reference", type: Faciliteiten }
        ]),

        Festival: $defineEntity(Festival, [
            { name: "fest_id", type: Number },
            { name: "fest_naam", type: String },
            { name: "fest_locatie", type: String },
            { name: "fest_datum", type: Date },
            { name: "fest_duur", type: Number },
            { name: "BandsPerFestivals", kind: "collection", elementType: BandsPerFestival },
            { name: "CampingsPerFestivals", kind: "collection", elementType: CampingsPerFestival },
            { name: "Tickets", kind: "collection", elementType: Ticket },
            { name: "TickettypesPerFestivals", kind: "collection", elementType: TickettypesPerFestival }
        ]),

        GeregistreerdeGebruiker: $defineEntity(GeregistreerdeGebruiker, [
            { name: "gebr_id", type: Number },
            { name: "gebr_naam", type: String },
            { name: "gebr_adres", type: String },
            { name: "gebr_gebDat", type: Date },
            { name: "Tickets", kind: "collection", elementType: Ticket }
        ]),

        Podia: $defineEntity(Podia, [
            { name: "pod_id", type: Number },
            { name: "pod_omschr", type: String },
            { name: "pod_locatie", type: String },
            { name: "BandsPerFestivals", kind: "collection", elementType: BandsPerFestival }
        ]),

        sysdiagram: $defineEntity(sysdiagram, [
            { name: "name", type: String },
            { name: "principal_id", type: Number },
            { name: "diagram_id", type: Number },
            { name: "version", type: Number },
            { name: "definition", type: Array }
        ]),

        Ticket: $defineEntity(Ticket, [
            { name: "fest_id", type: Number },
            { name: "gebr_id", type: Number },
            { name: "ticket_datum", type: Date },
            { name: "Festival", kind: "reference", type: Festival },
            { name: "GeregistreerdeGebruiker", kind: "reference", type: GeregistreerdeGebruiker },
            { name: "Tickettype", kind: "reference", type: Tickettype }
        ]),

        Tickettype: $defineEntity(Tickettype, [
            { name: "typ_id", type: Number },
            { name: "typ_omschr", type: String },
            { name: "typ_prijs", type: Number },
            { name: "Tickets", kind: "collection", elementType: Ticket },
            { name: "TickettypesPerFestivals", kind: "collection", elementType: TickettypesPerFestival }
        ]),

        TickettypesPerFestival: $defineEntity(TickettypesPerFestival, [
            { name: "fest_id", type: Number },
            { name: "typ_id", type: Number },
            { name: "aantal", type: Number },
            { name: "Festival", kind: "reference", type: Festival },
            { name: "Tickettype", kind: "reference", type: Tickettype }
        ]),

        groep15_festivalsData: $defineDataService(groep15_festivalsData, lightSwitchApplication.rootUri + "/groep15_festivalsData.svc", [
            { name: "Bands", elementType: Band },
            { name: "BandsPerFestivals", elementType: BandsPerFestival },
            { name: "Campings", elementType: Camping },
            { name: "CampingsPerFestivals", elementType: CampingsPerFestival },
            { name: "Faciliteitens", elementType: Faciliteiten },
            { name: "FacPerCamps", elementType: FacPerCamp },
            { name: "Festivals", elementType: Festival },
            { name: "GeregistreerdeGebruikers", elementType: GeregistreerdeGebruiker },
            { name: "Podias", elementType: Podia },
            { name: "sysdiagrams", elementType: sysdiagram },
            { name: "Tickets", elementType: Ticket },
            { name: "Tickettypes", elementType: Tickettype },
            { name: "TickettypesPerFestivals", elementType: TickettypesPerFestival }
        ], [
            {
                name: "Bands_SingleOrDefault", value: function (band_id) {
                    return new $DataServiceQuery({ _entitySet: this.Bands },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Bands(" + "band_id=" + $toODataString(band_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "BandsPerFestivals_SingleOrDefault", value: function (fest_id, band_id, datum) {
                    return new $DataServiceQuery({ _entitySet: this.BandsPerFestivals },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/BandsPerFestivals(" + "fest_id=" + $toODataString(fest_id, "Int32?") + "," + "band_id=" + $toODataString(band_id, "Int32?") + "," + "datum=" + $toODataString(datum, "DateTime?") + ")"
                    );
                }
            },
            {
                name: "Campings_SingleOrDefault", value: function (camp_id) {
                    return new $DataServiceQuery({ _entitySet: this.Campings },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Campings(" + "camp_id=" + $toODataString(camp_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "CampingsPerFestivals_SingleOrDefault", value: function (fest_id, camp_id) {
                    return new $DataServiceQuery({ _entitySet: this.CampingsPerFestivals },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/CampingsPerFestivals(" + "fest_id=" + $toODataString(fest_id, "Int32?") + "," + "camp_id=" + $toODataString(camp_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Faciliteitens_SingleOrDefault", value: function (fac_id) {
                    return new $DataServiceQuery({ _entitySet: this.Faciliteitens },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Faciliteitens(" + "fac_id=" + $toODataString(fac_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "FacPerCamps_SingleOrDefault", value: function (camp_id, fac_id) {
                    return new $DataServiceQuery({ _entitySet: this.FacPerCamps },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/FacPerCamps(" + "camp_id=" + $toODataString(camp_id, "Int32?") + "," + "fac_id=" + $toODataString(fac_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Festivals_SingleOrDefault", value: function (fest_id) {
                    return new $DataServiceQuery({ _entitySet: this.Festivals },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Festivals(" + "fest_id=" + $toODataString(fest_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "GeregistreerdeGebruikers_SingleOrDefault", value: function (gebr_id) {
                    return new $DataServiceQuery({ _entitySet: this.GeregistreerdeGebruikers },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/GeregistreerdeGebruikers(" + "gebr_id=" + $toODataString(gebr_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Podias_SingleOrDefault", value: function (pod_id) {
                    return new $DataServiceQuery({ _entitySet: this.Podias },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Podias(" + "pod_id=" + $toODataString(pod_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "sysdiagrams_SingleOrDefault", value: function (diagram_id) {
                    return new $DataServiceQuery({ _entitySet: this.sysdiagrams },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/sysdiagrams(" + "diagram_id=" + $toODataString(diagram_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Tickets_SingleOrDefault", value: function (fest_id, gebr_id) {
                    return new $DataServiceQuery({ _entitySet: this.Tickets },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Tickets(" + "fest_id=" + $toODataString(fest_id, "Int32?") + "," + "gebr_id=" + $toODataString(gebr_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Tickettypes_SingleOrDefault", value: function (typ_id) {
                    return new $DataServiceQuery({ _entitySet: this.Tickettypes },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/Tickettypes(" + "typ_id=" + $toODataString(typ_id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "TickettypesPerFestivals_SingleOrDefault", value: function (fest_id, typ_id) {
                    return new $DataServiceQuery({ _entitySet: this.TickettypesPerFestivals },
                        lightSwitchApplication.rootUri + "/groep15_festivalsData.svc" + "/TickettypesPerFestivals(" + "fest_id=" + $toODataString(fest_id, "Int32?") + "," + "typ_id=" + $toODataString(typ_id, "Int32?") + ")"
                    );
                }
            }
        ]),

        DataWorkspace: $defineDataWorkspace(DataWorkspace, [
            { name: "groep15_festivalsData", type: groep15_festivalsData }
        ])

    });

}(msls.application));
