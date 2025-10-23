# Opdracht: Unit Tests schrijven volgens Test Driven Development (TDD)

In deze opdracht ga je aan de slag met een basis die aansluit bij de principes van Test Driven Development (TDD).
Je krijgt één van de voorgestelde (nog niet bestaande) Services uit de lijst van Services toegekend (zie Leho) en schrijft hiervoor enkel de bijhorende Unit Tests.

Je hoeft dus **geen implementatie** van de Service zelf te voorzien, enkel de tests die als uitgangspunt zouden dienen voor een latere implementatie. Uiteraard doe je dit op zo'n manier zodat de latere implementatie **zo volledig mogelijk** geimplementeerd kan worden.

Methodes die je gebruikt/test mag je uiteraard voorzien als *'stubs'* in je Service klasse, op deze manier kan je zonder problemen aan de slag in het schrijven van je Unit Tests.

```cs
// Voorbeeld
public decimal Withdraw(decimal amount)
{
    throw new NotImplementedException();
}
```

## Concreet omvat de opdracht:
### 1. Schrijven van Unit Tests

* Schrijf duidelijke, gestructureerde en betekenisvolle unit tests **volgens de conventies en richtlijnen** die tijdens de opleiding werden aangeleerd.
* Zorg ervoor dat je tests voldoende verschillende scenario's en edge cases afdekken om een robuuste implementatie mogelijk te maken.
* Maak gebruik van **zinvolle testnamen** en zorg dat elke test **één specifiek gedrag of scenario valideert**.

### 2. Documenteren in Markdown
Maak aansluitend een helder en gestructureerd markdown-document in de root van je repository (Documentation.md) waarin je volgende zaken opneemt:

* Een korte beschrijving van de aan jou toegewezen Service.
* Jouw logische denkproces bij het opstellen van de tests: waarom koos je bepaalde testgevallen, welke edge cases heb je voorzien, hoe heb je scenario's bepaald?
* Een overzichtelijke lijst met geraadpleegde bronnen (zoals documentatie, standaarden, online bronnen of literatuur) die je hebt gebruikt om tot jouw testscenarios te komen.

### 3. Mondelinge toelichting van je uitwerking
Tijdens de eerstvolgende monitoraatsessie **na de deadline** van deze opdracht bespreek je individueel je uitwerking van deze opdracht. Exacte datum kan je terugvinden op Leho.