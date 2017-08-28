using System;
using Xunit;
using PalindromeApp.src;

namespace PalinDromeApp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = true;
            var actual = PalindromeChecker.Check("racecar");
            Assert.True(expected == actual);
        }
        [Fact]
        public void Test2()
        {
            var expected = true;
            var actual = PalindromeChecker.Check("civic");
            Assert.True(expected == actual);
        }
        [Fact]
        public void Test3()
        {
            var expected = true;
            var actual = PalindromeChecker.Check("never odd or even");
            Assert.True(expected == actual);
        }
        [Fact]
        public void Test4()
        {
            var expected = false;
            var actual = PalindromeChecker.Check("This ain't a palindrome");
            Assert.True(expected == actual);
        }

        [Fact]
        public void Test5()
        {
            var expected = false;
            var actual = PalindromeChecker.Check("Cat");
            Assert.True(expected == actual);
        }
        
    }
}
