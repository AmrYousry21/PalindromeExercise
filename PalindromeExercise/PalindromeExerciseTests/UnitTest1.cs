using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Palindrome", true)]
        [InlineData("bike", false)]
        [InlineData("palindrome", true)]
        public void Test1(string word, bool expected)
        {
            WordSmith smith = new WordSmith();
            
            var actual = smith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
