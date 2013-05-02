Opdracht ASP.NET web applicatie 

Web applicatie in ASP.NET met een SQL Server databank rond het thema “MuziekFestivals”
deadline in week 8

Om deze applicatie tot een goed einde te brengen dient je eerst via zelfstudie de nodige tutorials te doorlopen. Op http://www.asp.net/web-forms vind je een verzameling aan tutorial video’s van Plurasight. Deze dien je te doorlopen. Op basis van deze informatie ben je in staat deze opdracht uit te voeren.

Deel 1:  ASP.NET Website

Implementeer een systeem met authenticatie waarbij je 3 rollen voorziet. Gebruik hiervoor de ingebouwde security van ASP.NET.

Dit niveau is toegankelijk voor gebruikers met minimum leesrechten:
Voorzie 2 pagina’s waar gegevens uit de databank worden getoond.
Voorzie 2 pagina’s waarbij je door middel van een master-detail pagina de details van 2 tabellen toont.
		

Dit niveau is enkel toegankelijk voor gebruikers met schrijfrechten:
Voorzie 1 pagina waar gegevens uit de databank getoond, gewijzigd en verwijderd kunnen worden.
		

Besteed voldoende aandacht aan het grafisch aspect van je applicatie door gebruik te maken van:
Masterpage(s) voor eenzelfde look and feel voor de gehele website.
CSS
Aangepast menu
Drukknoppen in plaats van hyperlinks gebruiken in je server controls.


	Als de bovenstaande functionaliteit aangeboden wordt kan je 12/20 voor 
	deel 1 verdienen.  Extra punten kan je verdienden adhv onderstaande 	uitbreidingen (2 pt per uitbreiding):

- Uitbreiding 1: 
Gebruik het ADO.NET Entity Framework voor de access tot je database. Het gebruik van het code first concept verdient te voorkeur.

Uitbreiding 2: 
Maak gebruik van AJAX  om page flikkering tegen te gaan. 
Maak gebruik van de nodige controls uit de AJAX control toolkit om je user interface te verfraaien. 

Details: http://www.asp.net/ajaxLibrary/AjaxControlToolkitSampleSite/Default.aspx

- Uitbreiding 3:
	Language support. 
De website moet in het Engels of het Nederlands bruikbaar zijn. De gebruiker moet kunnen wisselen tussen de 2 talen wanneer hij dat wenst.
Voor meer informatie, zie: http://www.codeproject.com/Articles/15313/Globalization-and-localization-demystified-in-ASP

Specifiek voor masterpages:
http://www.codeproject.com/Articles/18753/Developing-an-ASP-NET-page-with-MasterPage-and-Loc


Uitbreiding 4:
Maak gebruik van de meer advanced server controls zoals de listview. Creëer hiermee 1 pagina waarbij je data uit 1 tabel ophaalt. 

Informatie hieromtrent:
http://www.asp.net/web-forms/videos/aspnet-35/data-controls/the-listview-control


Deel 1 telt mee voor 100% (voor groepen met minder dan 5 studenten).
Voor de anderen telt het voor 60% mee.

Deel 2: Admin gedeelte

Voorzie een administratief gedeelte met volgende features:
Gebruikers toevoegen, verwijderen en wijzigen.
Paswoorden wijzigen.
De rol van gebruikers wijzigen.

Het administratief gedeelte moet bereikbaar zijn vanuit het menu en dit enkel zichtbaar is voor de admins. 
	

Deel 3:  CRUD tool

Ga op zoek naar een CRUD (create, read, update en delete) tool/library die je kan integreren met je ASP.NET web applicatie zodat op een snellere manier je standaard schermen kan aanmaken. 


Creëer enkele master-detail schermen gebruik makend van deze crud tool.

Groepen van 5 personen en groter dienen deel 2 of deel 3 te maken. Voor 40% van de punten.
Indien je deel 2 en 3 maakt verdien je een bonus.




Voorts dient er aandacht besteed aan volgende punten:

Duidelijke OO aanpak
Stel de nodige code conventions op en volg deze consequent.
Je code moet voorzien zijn van commentaar(XML formaat) zodanig dat de code duidelijk is.
Voorzie de nodige exception handling zodat je volledige applicatie beveiligd is tegen onvoorspelbare fouten. 
Het gebruik van een versiebeheersysteem is verplicht. Je mag het systeem gebruiken waar je reeds eerder mee werkte voor het java project.
Het alternatief is dat je een team foundation server gaat gebruiken. Via de hier vermelde link kan je een project creëren op deze server. (http://www.codeplex.com/).  
