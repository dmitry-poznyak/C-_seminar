// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.




bool IsPalindrome(string str)
{
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}
System.Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");