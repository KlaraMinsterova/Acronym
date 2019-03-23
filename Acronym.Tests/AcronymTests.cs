using NUnit.Framework;
using static Acronym.Acronym;

namespace Acronym.Tests
{
    public class AcronymTests
    {
        [Test]
        [TestCase(null, TestName = "ReturnsEmptyString_When_StringIsNull")]
        [TestCase("", TestName = "ReturnsEmptyString_When_StringIsEmpty")]
        [TestCase("   ", TestName = "ReturnsEmptyString_When_StringIsWhiteSpace")]
        public void ReturnsEmptyString_When_PhraseIsInvalid(string phrase)
        {
            Assert.That(CreateAcronym(phrase), Is.EqualTo(""));
        }

        [Test]
        public void ReturnsValidAcronym_When_PhraseIsUsual()
        {
            Assert.That(CreateAcronym("Asynchronous Javascript and XML"), Is.EqualTo("AJAX"));
        }

        [Test]
        public void ReturnsValidAcronym_When_PhraseIncludesApostrophe()
        {
            Assert.That(CreateAcronym("Don't repeat yourself"), Is.EqualTo("DRY"));
        }

        [Test]
        public void ReturnsValidAcronym_When_PhraseIncludesDash()
        {
            Assert.That(CreateAcronym("Complementary metal-oxide semiconductor"), Is.EqualTo("CMOS"));
        }

        [Test]
        public void ReturnsValidAcronym_When_SpecialCaseIsApplied()
        {
            Assert.That(CreateAcronym("The International Magazine of Events"), Is.EqualTo("TIME"));
        }
    }
}