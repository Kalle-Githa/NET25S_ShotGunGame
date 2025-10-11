================================================================================
🎯 Shotgun konsolapplikation – Mitt första individuella uppgift (Jensen .NET25S)
================================================================================


📝 Instruktioner för denna uppgift:

Uppgiften handlar om att skapa ett spel – Shotgun.
Ni ska bygga ett program där användaren spelar Shotgun mot datorn.
Datorspelaren väljer sitt drag slumpmässigt.

Shotgun påminner en del om "sten, sax och påse", men låter spelaren välja mellan att "Skjuta", "Ladda" och "Blocka".

För att vinna en spelomgång gäller det att "skjuta" samtidigt som motspelaren inte väljer "Blocka" eller "Skjuta".
Varje spelare börjar utan skott, och för att få fler skott måste du "Ladda". Varje gång du laddar får du ett nytt skott.

"Skjuta" mot "Skjuta" resulterar i att båda spelarna förlorar ett skott, men ingen vinner.
Då en spelare samlat på sig tre skott kan denne använda sig av "Shotgun", vilket vinner även om motspelaren "blockar" eller "skjuter".

Sikta på att göra en konsolapplikation, men det går bra med Windows Forms eller något annat GUI-class library.

🎮 Nedan listas alla tänkbara scenarion:

Ladda mot ladda	  Båda spelarna får ett skott
Ladda mot blocka	Spelaren som laddar får ett skott
Blocka mot blocka	Ingenting händer
Skjuta mot blocka	Spelaren som skjuter förlorar ett skott
Skjuta mot skjuta	Båda spelarna förlorar ett skott
Skjuta mot ladda	Spelaren som skjuter vinner spelet
Shotgun mot shotgun	Se "Skjuta mot skjuta" eller slumpmässig vinnare
✅ Krav för G

- Det ska tydligt framgå hur många skott varje spelare har.
- Det ska inte vara möjligt att skjuta om man inte har några skott.
- Datorspelaren ska inte heller kunna skjuta om den inte har några skott.
- Det ska framgå när någon av spelarna vunnit och man ska kunna välja att spela igen.
- Möjligheten att använda "Shotgun" ska bara finnas så länge användaren har minst tre skott.
- Koden måste skrivas objektorienterat och ni ska använda funktionalitet kring det vi har gått igenom på lektionerna när det finns möjligheter till det.
- Koden ska fungera och applikationen ska gå att köra utan fel.

💡 Extra utmaning (ej krav för godkänt)

Vill man ha en större utmaning kan man försöka göra AIn till den datorstyrda spelaren lite bättre.
Det är exempelvis inte speciellt smart att "blocka" om motspelaren inte har några skott.
Om man har två skott och motståndaren inga finns det också ett av alternativen som är bättre än de andra.

Fler förslag:

- Färgkoda text i konsolen (röd för förlust, grön för vinst)
- Lägg till "svarstid" för datorn (Thread.Sleep)
- Felhantering (hantera felaktig inmatning utan att krascha)
- Spelare vs spelare (lokalt, turas om att skriva)

  
