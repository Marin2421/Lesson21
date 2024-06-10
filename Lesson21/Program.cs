//Тема 21. Работа с файловой системой. Домашнее
//задание.
//Создайте вручную папку с домашним заданием.
//Напишите программу, которая просит пользователя ввести путь к файлу и
//текст, который необходимо записать в него.
//После записи вывести на экран информацию “Файл успешно записан”.
//Создать еще 2 файла с названиями “Файл2” и “Файл3” программно
//Вывести на экран содержимое 1го файла.
//using System.IO;
//Console.WriteLine("Введите путь к файлу:");
//string path = Console.ReadLine();
//Console.Write("Введите текст для записи в файл: ");
//string fileText = Console.ReadLine();
//File.WriteAllText(path, fileText);
//Console.WriteLine("Файл успешно записан.");
//string file2Path = Path.Combine(path, "Файл2.txt");
//string file3Path = Path.Combine(path, "Файл3.txt");
//File.WriteAllText(file2Path, "Содержимое файла 2");
//File.WriteAllText(file3Path, "Содержимое файла 3");
//string firstFileContent = File.ReadAllText(path);
//Console.WriteLine("Содержимое первого файла:");
//Console.WriteLine(firstFileContent);

//Напишите программу, которая просит пользователя ввести путь к файлу на
//компьютере. Затем программа должна проверить, существует ли
//указанный файл, и вывести соответствующее сообщение. Если файл
//существует, программа должна также вывести его размер в байтах, дату
//последнего изменения и расширение файла
//Урок 2/4
//using System.IO;
//Console.Write("Введите путь к файлу: ");
//string filePath = Console.ReadLine();

//if (File.Exists(filePath))
//{
//    FileInfo fileInfo = new FileInfo(filePath);

//    Console.WriteLine("Файл существует.");
//    Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
//    Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
//    Console.WriteLine($"Расширение файла: {Path.GetExtension(filePath)}");
//}
//else
//{
//    Console.WriteLine("Файл не существует.");
//}