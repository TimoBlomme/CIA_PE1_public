using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.Cia.Services.Core
{
    public class CreditCardValidatorService
    {
        // Validates a credit card number using the Luhn algorithm
        // The card number is taken as a string.
        // True if the number is valid according to the Luhn algorithm; otherwise false.
        public bool ValidateCardNumber(string cardNumber)
        {
            throw new NotImplementedException();
        }

        // Detects the card issuer based on the card number prefix (Visa, Mastercard, Amex, ...).
        // The card number is taken as a string.
        // It returns the detected issuer name.
        public string DetectIssuer(string cardNumber)
        {
            throw new NotImplementedException();
        }

        // Validates whether the expiry date of the card has not passed.
        // Takes a DateTime parameter representing the expiry date of the card.
        // Returns true if the card is still valid otherwise it returns false.
        public bool ValidateExpiryDate(DateTime expiryDate)
        {
            throw new NotImplementedException();
        }

        // Validates that the security code (CVC/CVV) is correct in length and format.
        // The code is provided as a string containing only numeric characters.
        // Returns true if the code has a valid format; otherwise, false.
        public bool ValidateSecurityCode(string cvc)
        {
            throw new NotImplementedException();
        }
    }
}
