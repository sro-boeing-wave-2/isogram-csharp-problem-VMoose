using System;
using Xunit;
using Isogram;

namespace IsogramTests
{
    public class IsogramTests
    {
        [Fact]
        public void Isogram_Empty()
        {
            Assert.True(Sentence.IsogramSentence(string.Empty));
        }

        [Fact]
        public void Isogram_isogram()
        {
            Assert.True(Sentence.IsogramSentence("isogram"));
        }

        [Fact]
        public void Isogram_eleven()
        {
            Assert.False(Sentence.IsogramSentence("eleven"));
        }

        [Fact]
        public void Isogram_subdermatoglyphic()
        {
            Assert.True(Sentence.IsogramSentence("subdermatoglyphic"));
        }

        [Fact]
        public void Isogram_Alphabet()
        {
            Assert.False(Sentence.IsogramSentence("Alphabet"));
        }

        [Fact]
        public void Isogram_thumbscrewjapingly()
        {
            Assert.True(Sentence.IsogramSentence("thumbscrew-japingly"));
        }

        [Fact]
        public void Isogram_sixyearold()
        {
            Assert.True(Sentence.IsogramSentence("six-year-old"));
        }

        [Fact]
        public void Isogram_myname()
        {
            Assert.True(Sentence.IsogramSentence("varun mlik"));
        }
    }
}
