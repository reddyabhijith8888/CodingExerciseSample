using CodingExerciseSample;
using FluentAssertions;
using System;
using Xunit;

namespace CodingExerciseSampleTest
{
    public class FormatterTests
    {
        [Fact]
        public void ValidSentenceShouldBeConvertedInExpectedFormat()
        {
            var request = "Here Is My Application BuddY";
            var response = StringFormatter.GetExpectedResult(request);

            Assert.Equal("H2e Is My A7n B2Y", response);
        }

        [Fact]
        public void InputWithSpecialCharactersShouldThrowException()
        {
            var request = "Her!e Is My Application BuddY";

            Action act = () => StringFormatter.GetExpectedResult(request);
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void InputAsEmptyStringShouldThrowException()
        {
            var request = string.Empty;

            Action act = () => StringFormatter.GetExpectedResult(request);
            act.Should().Throw<ArgumentException>();
        }
    }
}
