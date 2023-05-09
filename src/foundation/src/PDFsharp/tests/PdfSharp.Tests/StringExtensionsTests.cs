using FluentAssertions;
using PdfSharp.Pdf.Internal;
using System.Globalization;
using Xunit;

namespace PdfSharp.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void AppendSingleSuffix()
        {
            var text = "One";
            text = text.AddIncrementalSuffix();
            text.Should().Be("One2");
        }

        [Fact]
        public void ZeroSuffixBecomesOne()
        {
            var text = "One0";
            text = text.AddIncrementalSuffix();
            text.Should().Be("One1");
        }

        [Fact]
        public void RepeatedlyAppendSuffix()
        {
            var text = "One";
            var number = 2;
            while (number < 1010)
            {
                text = text.AddIncrementalSuffix();
                text.Should().Be("One" + number.ToString(CultureInfo.InvariantCulture));
                number++;
            }
        }

        [Fact]
        public void AppendToNumbersOnlyString()
        {
            var text = "1234";
            text = text.AddIncrementalSuffix();
            text.Should().Be("1235");
        }

        [Fact]
        public void NullOrEmptyShouldBeReturnedUnchanged()
        {
            string text = null;
            text = text.AddIncrementalSuffix();
            text.Should().BeNull();

            text = string.Empty;
            text = text.AddIncrementalSuffix();
            text.Should().BeEmpty();
        }
    }
}
