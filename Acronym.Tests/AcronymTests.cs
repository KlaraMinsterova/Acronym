using NUnit.Framework;
using static Acronym.Acronym;

namespace Acronym.Tests
{
    public class AcronymTests
    {
        [Test]
        public void ReturnsEmptyString_When_InputIsEmpty()
        {
            Assert.That(CreateAcronym(""), Is.EqualTo(""));
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
    }
}