﻿namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange
            var strOperation = new StringOperations();

            // Act
            var result = strOperation.ConcatenateStrings("Hello", "world");

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello world", result);
        }

        [Fact]
        public void IsPalindrome_True() { 
            // Arrange
            var strOperation = new StringOperations();

            // Act
            var result = strOperation.IsPalindrome("ama");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var strOperation = new StringOperations();

            // Act
            var result = strOperation.IsPalindrome("hello");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace() 
        {
            // Arrange
            var strOperation = new StringOperations();

            // Act
            var result = strOperation.RemoveWhitespace("This sentence has white spaces");

            // Assert
            var template = "Thissentencehaswhitespaces";
            Assert.Equal(template, result);
            Assert.DoesNotContain(" ", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            // Arrange
            var strOperation = new StringOperations();

            // Act
            var result = strOperation.QuantintyInWords("cat", 10);

            // Assert
            Assert.StartsWith("ten", result);
            Assert.Contains("cat", result);
            Assert.Equal("ten cats", result);
        }

        [Fact]
        public void GetStringLength()
        {
            var strOperation = new StringOperations();

            var result = strOperation.GetStringLength("MS .NET");

            Assert.True(result > 0);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>( () => strOperation.GetStringLength(null));
        }
    }
}
