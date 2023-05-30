using Cleverence.Task1;

string input = "aaabbccccccddeffdeww";

// Сжимаем строку
string compressed = Algo.CompressString(input);
Console.WriteLine("Сжатая строка: " + compressed);

// Распаковываем строку
string decompressed = Algo.DecompressString(compressed);
Console.WriteLine("Распакованная строка: " + decompressed);