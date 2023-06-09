Алиев Тимур АСУбз 22-1
# Генератор паролей на C#

Программа на C#, которая генерирует случайные пароли с заданной длиной и сложностью. Сгенерированные пароли записываются в файл.

## Использование

1. Убедитесь, что у вас установлен .NET Framework.
2. Клонируйте репозиторий с помощью команды:
   ```shell
   git clone https://github.com/your-username/password-generator.git
Откройте проект в среде разработки C# (например, Visual Studio).
Скомпилируйте и запустите программу.
Введите длину пароля и сложность в соответствующие поля.

## Сложность пароля

Программа поддерживает три уровня сложности пароля:

1 (низкая сложность): Генерирует пароль, используя только строчные буквы английского алфавита (a-z).
2 (средняя сложность): Генерирует пароль, используя строчные и заглавные буквы английского алфавита (a-z, A-Z) и цифры (0-9).
3 (высокая сложность): Генерирует пароль, используя строчные и заглавные буквы английского алфавита (a-z, A-Z), цифры (0-9) и специальные символы (!@#$%^&*()).
Выберите уровень сложности, который соответствует вашим требованиям и безопасности пароля.

## Запись паролей
Сгенерированные пароли будут записаны в файл passwords.txt, который будет создан в том же каталоге, где находится исполняемый файл программы.
