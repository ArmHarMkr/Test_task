using FlexobaseTest.Class;

namespace NumberReplacerTests
{
    [TestClass]
    public class NumberReplacerTests
    {
        [TestMethod]
        public void ReplaceNumbers_ShouldReturnOriginalNumbers_WhenNoConditionsMet()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14 };
            NumberReplacer replacer = new NumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(numbers.ConvertAll(n => n.ToString()), result);
        }

        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByThree_WhenDivisibleByThree()
        {
            List<int> numbers = new List<int> { 3, 6, 9, 12, 18 };
            NumberReplacer replacer = new NumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "fizz", "fizz", "fizz", "fizz", "fizz" });
        }

        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByFive_WhenDivisibleByFive()
        {
            List<int> numbers = new List<int> { 5, 10, 20, 25 };
            NumberReplacer replacer = new NumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "buzz", "buzz", "buzz", "buzz" });
        }

        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByThreeAndFive_WhenDivisibleByThreeAndFive()
        {
            List<int> numbers = new List<int> { 15, 30, 45, 60, 75 };
            NumberReplacer replacer = new NumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "fizz-buzz", "fizz-buzz", "fizz-buzz", "fizz-buzz", "fizz-buzz" });
        }
    }

    [TestClass]
    public class AdvancedNumberReplacerTests
    {
        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByThree_WhenDivisibleByThree()
        {
            List<int> numbers = new List<int> { 3, 6, 9, 12, 18 };
            NumberReplacer replacer = new LastNumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "fizz", "fizz", "fizz", "fizz", "fizz" });
        }

        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByFive_WhenDivisibleByFive()
        {
            List<int> numbers = new List<int> { 5, 10, 20, 25 };
            NumberReplacer replacer = new LastNumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "buzz", "buzz", "buzz", "buzz" });
        }

        [TestMethod]
        public void ReplaceNumbers_ShouldReplaceByThreeAndFive_WhenDivisibleByThreeAndFive()
        {
            List<int> numbers = new List<int> { 15, 30, 45, 60, 75 };
            NumberReplacer replacer = new LastNumberReplacer();
            List<string> result = replacer.ReplaceNumbers(numbers);

            CollectionAssert.AreEqual(result, new List<string> { "fizz-buzz", "fizz-buzz", "fizz-buzz", "fizz-buzz", "fizz-buzz" });
        }
    }
}