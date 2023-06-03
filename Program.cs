using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Запрос у пользователя длины пароля
        Console.Write("Введите длину пароля: ");
        int length = int.Parse(Console.ReadLine());

        // Запрос у пользователя сложности пароля
        Console.Write("Введите сложность пароля (1 - низкая, 2 - средняя, 3 - высокая): ");
        int complexity = int.Parse(Console.ReadLine());

        // Генерация списка паролей
        List<string> passwords = GeneratePasswords(length, complexity);

        // Запись паролей в файл
        string fileName = "passwords.txt";
        WritePasswordsToFile(fileName, passwords);

        Console.WriteLine("Пароли успешно сгенерированы и записаны в файл " + fileName);
        Console.ReadLine();
    }

    // Функция генерации паролей
    static List<string> GeneratePasswords(int length, int complexity)
    {
        string validChars = "";

        // Определение символов, используемых в паролях в зависимости от сложности
        if (complexity == 1) // Низкая сложность - только буквы в нижнем регистре
        {
            validChars = "abcdefghijklmnopqrstuvwxyz";
        }
        else if (complexity == 2) // Средняя сложность - буквы в верхнем и нижнем регистре, цифры
        {
            validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }
        else if (complexity == 3) // Высокая сложность - буквы в верхнем и нижнем регистре, цифры, специальные символы
        {
            validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
        }
        else
        {
            Console.WriteLine("Некорректная сложность пароля");
            return new List<string>(); // Возвращаем пустой список, если сложность некорректна
        }

        List<string> passwords = new List<string>();
        Random random = new Random();

        // Генерация 10 паролей
        for (int i = 0; i < 10; i++)
        {
            StringBuilder passwordBuilder = new StringBuilder();

            // Генерация символов пароля
            for (int j = 0; j < length; j++)
            {
                int index = random.Next(validChars.Length);
                passwordBuilder.Append(validChars[index]);
            }

            string password = passwordBuilder.ToString();
            passwords.Add(password);
        }

        return passwords; // Возвращаем список сгенерированных паролей
    }

    // Функция записи паролей в файл
    static void WritePasswordsToFile(string fileName, List<string> passwords)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string password in passwords)
            {
                writer.WriteLine(password); // Записываем каждый пароль в отдельной строке файла
            }
        }
    }
}
