# Программа симуляции обработки данных

Эта программа демонстрирует асинхронную обработку данных из нескольких источников с последующей записью в файл, используя возможности async/await в C#.

### Необходимые условия

- Установленный .NET Core SDK

### Запуск программы

1. Скомпилируйте код с помощью .NET CLI:
>dotnet build
   
2. Запустите программу:
>dotnet run
   

### Как это работает

- Программа создает асинхронные задачи для обработки данных из разных источников.
- Для каждой задачи применяется задержка, чтобы смоделировать обработку данных.
- Данные записываются в файл simulatedData.txt с использованием блокировки, обеспечивающей безопасный доступ из разных потоков.
- Основной поток ожидает завершения всех задач с помощью Task.WhenAll().

## Структура кода

- Асинхронный метод ProcessDataAsync: Моделирует обработку данных и записывает их в файл.
- Task.WhenAll: Обеспечивает ожидание завершения всех асинхронных задач.
- Блокировка: Используется для безопасной записи данных в файл из различных потоков.

## Результат компиляции

Обработанные данные добавляются в simulatedData.txt с каждым запуском, формат:

![image](https://github.com/user-attachments/assets/ca3a17a7-35c7-4b14-8887-41c964cbb9cf)

>Пример, в котором четыре потока асинхронно читают "данные" из разных источников и записывают их в файл. Для этого создается массив с "исходными данными" и происходит симуляция задержки при доступе к этим данным с помощью Task.Delay. Затем данные записываются в файл с >использованием блокировки lock, чтобы обеспечить безопасный доступ из разных потоков.
