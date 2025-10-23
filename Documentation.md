# Documentation – Credit Card Number Validator (Luhn Algorithm)

**Student:** Timo Blomme  
**Assignment:** JH1 – PE 1 – Unit Testing Basics  
**Course:** CIA 01 – Unit Testing  
**Date:** October 2025  

---

## 1. Beschrijving van de service

De **CreditCardValidatorService** valideert creditcardgegevens volgens internationale standaarden.  
De service controleert:

- De geldigheid van het kaartnummer met het **Luhn-algoritme**  
- De **kaartmaatschappij** (bijv. Visa, Mastercard, American Express)  
- De **vervaldatum** van de kaart  
- De **beveiligingscode (CVC/CVV)** op lengte en formaat  

Voor deze opdracht werden enkel **unit tests** geschreven.  
De eigenlijke methodes bevatten enkel `throw new NotImplementedException()` zodat de tests correct kunnen compileren.

---

## 2. Denkproces bij het opstellen van de tests

### Doel
De tests zijn opgesteld volgens de principes van **Test Driven Development (TDD)**.  
Het doel is om eerst de verwachte werking te definiëren, zodat de implementatie later aan deze tests kan worden getoetst.

### Analyse van vereisten
De volgende controles moesten ondersteund worden:
- **Luhn-check** voor geldige kaartnummers  
- **Prefixcontrole** voor herkenning van de kaartuitgever  
- **Datums** die in het verleden of de toekomst liggen  
- **Beveiligingscodes** die numeriek zijn en een correcte lengte hebben  

### Testscenario’s

| Methode | Scenario | Verwachte uitkomst |
|----------|-----------|-------------------|
| ValidateCardNumber | Correct kaartnummer volgens Luhn | True |
| ValidateCardNumber | Foutief kaartnummer | False |
| ValidateCardNumber | Letters in kaartnummer | FormatException |
| DetectIssuer | Prefix 4 | "VISA" |
| DetectIssuer | Prefix 5 | "MASTERCARD" |
| DetectIssuer | Prefix 37 | "AMEX" |
| ValidateExpiryDate | Toekomstige datum | True |
| ValidateExpiryDate | Verlopen datum | False |
| ValidateSecurityCode | 3 cijfers | True |
| ValidateSecurityCode | Te kort of te lang | False |
| ValidateSecurityCode | Niet-numerieke invoer | False |

### Edge cases
Er werd rekening gehouden met uitzonderlijke situaties zoals:
- Kaartnummers met letters of speciale tekens  
- Vervaldatums die exact deze maand eindigen  
- Beveiligingscodes met ongeldige lengte of niet-numerieke tekens  
- Onbekende kaartprefixen  

### Naamgeving en structuur
Elke test gebruikt de conventie:
MethodName_Scenario_ExpectedResult


Bijvoorbeeld:  
`ValidateCardNumber_WithValidLuhnNumber_ReturnsTrue`

Elke test volgt het **AAA-patroon (Arrange / Act / Assert)** voor een duidelijke opbouw.

### Reden voor deze aanpak
Door eerst de tests te schrijven, wordt het verwachte gedrag van de service volledig vastgelegd.  
De tests dienen als documentatie en als controlemechanisme voor toekomstige implementaties.  
Op deze manier is de werking transparant, reproduceerbaar en goed testbaar.

---

## 3. Gebruikte bronnen

**Standaarden**  
- ISO/IEC 7812 – Identification cards: Numbering system and Luhn algorithm  

**Online bronnen**  
- [Wikipedia – Luhn algorithm](https://en.wikipedia.org/wiki/Luhn_algorithm)  
- [Visa Card Number Format](https://www.visa.com/)  
- [Mastercard BIN Ranges](https://www.mastercard.us/)  
- [American Express Card Number Rules](https://www.americanexpress.com/)  

**Cursusmateriaal**  
- Howest – CIA 01 Unit Testing  
- Lesmateriaal en voorbeelden rond TDD en xUnit  

---

## 4. Conclusie

De tests vormen een duidelijk uitgangspunt voor de toekomstige implementatie van de CreditCardValidatorService.  
Ze definiëren hoe de service zich moet gedragen en dekken zowel standaard- als randgevallen af.  
Dankzij TDD kan de implementatie later efficiënt en betrouwbaar ontwikkeld worden, met een hoge testdekking en voorspelbaar gedrag.
