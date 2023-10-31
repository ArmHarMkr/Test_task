using FlexobaseTest.Class;
using FlexobaseTest.Interfaces;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

INumberReplacer replacer = new NumberReplacer();
List<string> result = replacer.ReplaceNumbers(numbers);

INumberReplacer lastReplacer = new LastNumberReplacer();
List<string> lastRes = replacer.ReplaceNumbers(numbers);

Console.WriteLine(string.Join(", ", result));
Console.WriteLine(string.Join(", ", result));
