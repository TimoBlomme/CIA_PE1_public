using Howest.Cia.Services.Core;

namespace TimoBlomme.CreditCardValidator.Tests
{
    public class CreditCardValidatorTests
    {
        // CARD NUMBER VALIDATION TESTS

        [Fact]
        public void ValidateCardNumber_WithValidLuhnNumber_ReturnsTrue()
        {
            // Arrange
            var validator = new CreditCardValidatorService();
            string validCardNumber = "4539578763621486";

            // Act
            bool result = validator.ValidateCardNumber(validCardNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateCardNumber_WithInvalidLuhnNumber_ReturnsFalse()
        {
            // Arrange
            var validator = new CreditCardValidatorService();
            string invalidCardNumber = "4539578763621487";

            // Act
            bool result = validator.ValidateCardNumber(invalidCardNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateCardNumber_WithNonNumericCharacters_ThrowsFormatException()
        {
            // Arrange
            var validator = new CreditCardValidatorService();
            string invalidInput = "4539abcd8763ef86";

            // Assert on Act
            Assert.Throws<FormatException>(() => validator.ValidateCardNumber(invalidInput));
        }

        // ISSUER DETECTION TESTS

        [Theory]
        [InlineData("4539578763621486", "VISA")]
        [InlineData("5555555555554444", "MASTERCARD")]
        [InlineData("371449635398431", "AMEX")]
        public void DetectIssuer_WithKnownPrefixes_ReturnsCorrectIssuer(string number, string expectedIssuer)
        {
            // Arrange
            var validator = new CreditCardValidatorService();

            // Act
            string issuer = validator.DetectIssuer(number);

            // Assert
            Assert.Equal(expectedIssuer, issuer);
        }

        // EXPIRY DATE TESTS

        [Fact]
        public void ValidateExpiryDate_WithFutureDate_ReturnsTrue()
        {
            // Arrange
            var validator = new CreditCardValidatorService();
            DateTime futureDate = DateTime.Now.AddMonths(6);

            // Act
            bool result = validator.ValidateExpiryDate(futureDate);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateExpiryDate_WithPastDate_ReturnsFalse()
        {
            // Arrange
            var validator = new CreditCardValidatorService();
            DateTime pastDate = DateTime.Now.AddMonths(-6);

            // Act
            bool result = validator.ValidateExpiryDate(pastDate);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("123", true)]   //valid 3-digit
        [InlineData("999", true)]   //valid 3-digit
        [InlineData("12", false)]   //too short
        [InlineData("1234", false)] //too long
        [InlineData("abc", false)]  //not numeric
        public void ValidateSecurityCode_WithVariousInputs_ReturnsExpectedResult(string code, bool expected)
        {
            // Arrange
            var validator = new CreditCardValidatorService();

            // Act
            bool result = validator.ValidateSecurityCode(code);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}