# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  
**Grupp:**  
**Datum:**  
**GitHub:**  

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
|Anton Björquist | Zip + RAPPORT.md + REFLEKTION.md |


---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Angav de fält som krävdes för varje klass och tilldelade dem de fält i sina properties med get; och private set;. Korrekta datatyper för varje klassmedlemmar och parameter till konstruktor. 

### Metoderna

> Två metoder att fylla i kod för att kunna skriva matchens lag och vilket datum det spelades- samt metod för vilken spelare som gjort mål i matchen. Skapade ToString för klass Match.cs och Spelare.cs för att få korrekt utskrift genom objekten som skapades i mainklassen. 

### Main()

> Skapade instanser från klass Match.cs och Spelare.cs som i sin tur skickar in data till konstruktors parameter som sparar det i medlemsvariabeln genom metoden set;. 

### Git

> Skrivit koden och pushat den till min fork på Github. Inga problem eller konfliker under projektet eftersom jag enbart arbetade på main-branch. Försökte att inte skriva för mycket kod utan att commita för att enklare hålla koll på vilka ändringar som gjorts.

### Kodkvalitet

> Inte använt mig av refactoring under projektet. Försökte hålla kort med korrekt kod. Variablerna var redan tilldelade beteckningar och även metoderna. Jag vill tro att jag hade kunnat förenkla en av metoderna med hjälp av properties- det får undersökas efter projektet inlämnats. 

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> Lade till Mål som en property och _mål som medlemsvariabel, ÄrMatchHjälte som metod - för att kunna följa vilken spelare som gjort mål och som även koras till matchhjälte. Utskriften visar vilken spelare som gjort fler än två mål och då koras till matchhjälte, den eller de som gjort mindre än 2 blev tyvärr inte matchhjälte denna gång. 

### Varför vi löste det såhär

> Valde att lösa VG uppgiften genom att lägga till if sats i nya metoden ÄrMatchHjälte, hade även kunnat göra det i main-klassen men föredrar att ha den renare från kod. Nya metod var en bool, om ett värde uppfyller kraven returnerar den true med en sträng och false om det inte uppfylls med en annan sträng. 

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
49a6006 (HEAD -> main, origin/main, origin/HEAD) wrote RAPPORT.md
b1edfb9 Added bool to ÄrMatchHjälte method in Spelare.cs, along with spelareobject in Program.cs
e126ce3 added method ÄrMatchHjälte and its contents
e044610 added text to Rapport och Reflektion
30062a3 added custom output if goalscorer is a keeper
f93cd11 swapped to properties as fields in ToString-Method
576ac5a added date of match to the output
27a17a3 added some memorynotes
267c510 added _mål in Spelare.cs aa variable and its property
1f4c822 Added spelare2 as second object
6e339b3 successfully run program with output
1a41fc3 Added toString to Match.cs and Spelare.cs
1c66f6c created object spelare1
8a747bd added object spelare1 to method AnnounceraMålskytt
d050bea creating an instance
52b096a added Datetime as a field and to constructor
3773d60 added constructor fields in spelare.cs
c94a547 skrivit konstrukor i klass match.cs
1d46aad added encapsulation to properties in match.cs and spelare.cs
35825ed Solutionfile added at root
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)
```