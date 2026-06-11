using CSharpBasics;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpBasics.Tests
{
    [TestFixture]
    public class BasicSyntaxProblemsTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(-4, 10, 6)]
        [TestCase(0, 0, 0)]
        public void Add_ReturnsSum(int a, int b, int expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.Add(a, b));
        }

        [TestCase(10, 3, 1)]
        [TestCase(20, 5, 0)]
        [TestCase(7, 4, 3)]
        public void Remainder_ReturnsModuloResult(int dividend, int divisor, int expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.Remainder(dividend, divisor));
        }

        [TestCase(1, Math.PI)]
        [TestCase(2, Math.PI * 4)]
        [TestCase(0, 0)]
        public void CalculateCircleArea_ReturnsArea(double radius, double expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.CalculateCircleArea(radius), 1e-10);
        }

        [TestCase(2, true)]
        [TestCase(3, false)]
        [TestCase(0, true)]
        [TestCase(-7, false)]
        public void IsEven_ReturnsWhetherNumberIsEven(int number, bool expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.IsEven(number));
        }

        [TestCase(100, "A")]
        [TestCase(90, "A")]
        [TestCase(89, "B")]
        [TestCase(80, "B")]
        [TestCase(79, "C")]
        [TestCase(70, "C")]
        [TestCase(69, "D")]
        [TestCase(60, "D")]
        [TestCase(59, "F")]
        [TestCase(-1, "Invalid")]
        [TestCase(101, "Invalid")]
        public void GetGrade_ReturnsExpectedGrade(int score, string expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.GetGrade(score));
        }

        [TestCase(1, "Monday")]
        [TestCase(2, "Tuesday")]
        [TestCase(3, "Wednesday")]
        [TestCase(4, "Thursday")]
        [TestCase(5, "Friday")]
        [TestCase(6, "Saturday")]
        [TestCase(7, "Sunday")]
        [TestCase(0, "Invalid")]
        [TestCase(8, "Invalid")]
        public void GetDayName_ReturnsExpectedDayName(int day, string expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.GetDayName(day));
        }

        [TestCase(1, 1)]
        [TestCase(5, 15)]
        [TestCase(10, 55)]
        [TestCase(0, 0)]
        [TestCase(-3, 0)]
        public void SumFromOneTo_ReturnsSum(int n, int expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.SumFromOneTo(n));
        }

        [TestCase(3, 3)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void CountDownByWhile_ReturnsLoopCount(int start, int expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.CountDownByWhile(start));
        }

        [Test]
        public void FindMax_ReturnsLargestNumber()
        {
            Assert.AreEqual(10, BasicSyntaxProblems.FindMax(new[] { 3, 10, -1, 5 }));
            Assert.AreEqual(-1, BasicSyntaxProblems.FindMax(new[] { -10, -1, -3 }));
            Assert.AreEqual(7, BasicSyntaxProblems.FindMax(new[] { 7 }));
        }

        [Test]
        public void FindMax_ThrowsWhenArrayIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => BasicSyntaxProblems.FindMax(new int[0]));
        }

        [Test]
        public void CountPositiveNumbers_ReturnsPositiveCount()
        {
            Assert.AreEqual(3, BasicSyntaxProblems.CountPositiveNumbers(new[] { -2, 0, 1, 4, 7 }));
            Assert.AreEqual(0, BasicSyntaxProblems.CountPositiveNumbers(new[] { -2, 0, -1 }));
            Assert.AreEqual(2, BasicSyntaxProblems.CountPositiveNumbers(new[] { 1, 2 }));
        }

        [Test]
        public void DoubleEachNumber_ReturnsNewDoubledList()
        {
            var source = new List<int> { 1, -2, 0, 5 };

            var result = BasicSyntaxProblems.DoubleEachNumber(source);

            CollectionAssert.AreEqual(new List<int> { 2, -4, 0, 10 }, result);
            CollectionAssert.AreEqual(new List<int> { 1, -2, 0, 5 }, source);
            Assert.AreNotSame(source, result);
        }

        [TestCase("ab", 3, "ababab")]
        [TestCase("x", 1, "x")]
        [TestCase("test", 0, "")]
        [TestCase("test", -2, "")]
        public void RepeatText_RepeatsExpectedNumberOfTimes(string text, int count, string expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.RepeatText(text, count));
        }

        [TestCase(" Taro ", " Yamada ", "Taro Yamada")]
        [TestCase("Hanako", "Suzuki", "Hanako Suzuki")]
        [TestCase("  John", "Smith  ", "John Smith")]
        public void NormalizeName_TrimsAndJoinsNames(string firstName, string lastName, string expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.NormalizeName(firstName, lastName));
        }

        [TestCase("Hello CSharp", "hello", true)]
        [TestCase("Hello CSharp", "CSHARP", true)]
        [TestCase("Hello CSharp", "Java", false)]
        public void ContainsIgnoreCase_ReturnsWhetherKeywordExists(string source, string keyword, bool expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.ContainsIgnoreCase(source, keyword));
        }

        [Test]
        public void CountWords_ReturnsWordCounts()
        {
            var result = BasicSyntaxProblems.CountWords(new[] { "apple", "banana", "apple", "orange", "banana", "apple" });

            Assert.AreEqual(3, result["apple"]);
            Assert.AreEqual(2, result["banana"]);
            Assert.AreEqual(1, result["orange"]);
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public void CountWords_ReturnsEmptyDictionaryForEmptyInput()
        {
            var result = BasicSyntaxProblems.CountWords(new string[0]);

            Assert.IsEmpty(result);
        }

        [Test]
        public void CalculateValidScoreAverage_IgnoresInvalidScores()
        {
            Assert.AreEqual(80.0, BasicSyntaxProblems.CalculateValidScoreAverage(new[] { 100, 80, -1, 60, 101 }), 1e-10);
            Assert.AreEqual(75.5, BasicSyntaxProblems.CalculateValidScoreAverage(new[] { 75, 76 }), 1e-10);
            Assert.AreEqual(0.0, BasicSyntaxProblems.CalculateValidScoreAverage(new[] { -10, 120 }), 1e-10);
            Assert.AreEqual(0.0, BasicSyntaxProblems.CalculateValidScoreAverage(new int[0]), 1e-10);
        }

        [Test]
        public void BuildFizzBuzz_ReturnsExpectedSequence()
        {
            var result = BasicSyntaxProblems.BuildFizzBuzz(1, 15);

            CollectionAssert.AreEqual(
                new List<string>
                {
                    "1",
                    "2",
                    "Fizz",
                    "4",
                    "Buzz",
                    "Fizz",
                    "7",
                    "8",
                    "Fizz",
                    "Buzz",
                    "11",
                    "Fizz",
                    "13",
                    "14",
                    "FizzBuzz"
                },
                result);
        }

        [Test]
        public void BuildFizzBuzz_ReturnsEmptyListWhenStartIsGreaterThanEnd()
        {
            Assert.IsEmpty(BasicSyntaxProblems.BuildFizzBuzz(5, 1));
        }

        [TestCase("CSharp is fun", 6)]
        [TestCase("  one   three  seven  ", 5)]
        [TestCase("     ", 0)]
        [TestCase("", 0)]
        public void GetLongestWordLength_ReturnsLongestLength(string sentence, int expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.GetLongestWordLength(sentence));
        }

        [TestCase("Never odd or even", true)]
        [TestCase("Race car", true)]
        [TestCase("step on no pets", true)]
        [TestCase("Hello", false)]
        public void IsPalindromeIgnoreCaseAndSpaces_ReturnsWhetherTextIsPalindrome(string text, bool expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.IsPalindromeIgnoreCaseAndSpaces(text));
        }

        [Test]
        public void RotateLeft_ReturnsRotatedNewList()
        {
            var source = new List<int> { 1, 2, 3, 4, 5 };

            var result = BasicSyntaxProblems.RotateLeft(source, 7);

            CollectionAssert.AreEqual(new List<int> { 3, 4, 5, 1, 2 }, result);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, source);
            Assert.AreNotSame(source, result);
        }

        [Test]
        public void RotateLeft_HandlesZeroAndEmptyList()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, BasicSyntaxProblems.RotateLeft(new List<int> { 1, 2, 3 }, 0));
            Assert.IsEmpty(BasicSyntaxProblems.RotateLeft(new List<int>(), 3));
        }

        [Test]
        public void MergeWordCounts_SumsSameKeysAndKeepsInputsUnchanged()
        {
            var first = new Dictionary<string, int>
            {
                { "apple", 2 },
                { "banana", 1 }
            };
            var second = new Dictionary<string, int>
            {
                { "banana", 3 },
                { "orange", 4 }
            };

            var result = BasicSyntaxProblems.MergeWordCounts(first, second);

            Assert.AreEqual(2, result["apple"]);
            Assert.AreEqual(4, result["banana"]);
            Assert.AreEqual(4, result["orange"]);
            Assert.AreEqual(2, first["apple"]);
            Assert.AreEqual(1, first["banana"]);
            Assert.AreEqual(3, second["banana"]);
            Assert.AreEqual(4, second["orange"]);
        }

        [Test]
        public void FindMostFrequentWord_NormalizesWordsAndUsesFirstToReachMaxOnTie()
        {
            var result = BasicSyntaxProblems.FindMostFrequentWord(
                new[] { " Apple ", "banana", "APPLE", "Banana", "banana", "apple" });

            Assert.AreEqual("banana", result);
        }

        [Test]
        public void FindMostFrequentWord_ReturnsEmptyStringWhenNoValidWordsExist()
        {
            Assert.AreEqual("", BasicSyntaxProblems.FindMostFrequentWord(new[] { " ", "", "   " }));
        }

        [TestCase("(a + b) * (c + d)", true)]
        [TestCase("text without parentheses", true)]
        [TestCase("(()())", true)]
        [TestCase("())(", false)]
        [TestCase("((value)", false)]
        public void AreParenthesesBalanced_ReturnsWhetherParenthesesAreBalanced(string text, bool expected)
        {
            Assert.AreEqual(expected, BasicSyntaxProblems.AreParenthesesBalanced(text));
        }

        [Test]
        public void CalculateRunningTotals_ReturnsCumulativeSums()
        {
            CollectionAssert.AreEqual(new List<int> { 3, 2, 6 }, BasicSyntaxProblems.CalculateRunningTotals(new[] { 3, -1, 4 }));
            CollectionAssert.AreEqual(new List<int> { 1, 3, 6, 10 }, BasicSyntaxProblems.CalculateRunningTotals(new[] { 1, 2, 3, 4 }));
            Assert.IsEmpty(BasicSyntaxProblems.CalculateRunningTotals(new int[0]));
        }

        [Test]
        public void GroupNumbersByParity_GroupsNumbersAndPreservesOrder()
        {
            var result = BasicSyntaxProblems.GroupNumbersByParity(new[] { 5, 2, 8, 3, 0, -1, -4 });

            CollectionAssert.AreEqual(new List<int> { 2, 8, 0, -4 }, result["Even"]);
            CollectionAssert.AreEqual(new List<int> { 5, 3, -1 }, result["Odd"]);
        }

        [Test]
        public void GroupNumbersByParity_IncludesBothKeysWhenOneGroupIsEmpty()
        {
            var result = BasicSyntaxProblems.GroupNumbersByParity(new[] { 2, 4 });

            CollectionAssert.AreEqual(new List<int> { 2, 4 }, result["Even"]);
            Assert.IsEmpty(result["Odd"]);
            Assert.IsTrue(result.ContainsKey("Even"));
            Assert.IsTrue(result.ContainsKey("Odd"));
        }
    }
}