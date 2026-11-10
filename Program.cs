// string text = "Код 2026";
// Console.WriteLine(text.Length);
// Console.WriteLine(text[0]);
// Console.WriteLine(text[text.Length - 1]);


// foreach (char symbol in text)
// {
//     Console.WriteLine(symbol);
// }
// for (int i = 0; i < text.Length; i++)
// {
//     Console.WriteLine($"{i}: {text[i]}");
// }
// int CountCharacter(string text, char target)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (symbol == target)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("Код 2026", ' '));
// Console.WriteLine(CountCharacter("", 'а'));


// int CountCharacter(string text, char target)
// {
//     int count = 0;
//     for (int i = 0; i <= text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("", 'м'));

// using System.Diagnostics.SymbolStore;

// int CountDigits(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }
//     return count;

//     int CountLetters(string text)
//     {
//         int count = 0;
//         foreach (char symbol in text)
//         {
//             if (char.IsLetter(symbol))
//                 count++;
//         }
//         return count;
//     }
// }
// Console.WriteLine(CountDigits("Код 2026!"));
// Console.WriteLine(CountLetters("Код 2026!"));

