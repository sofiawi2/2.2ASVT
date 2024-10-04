using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    // Путь к файлу для записи данных
    private static string filePath = "simulatedData.txt";

    static async Task Main(string[] args)
    {
        // Симуляция источников данных
        string[] dataSources = {
            "Данные из источника 1",
            "Данные из источника 2",
            "Данные из источника 3",
            "Данные из источника 4"
        };

        // Запускаем задачи для получения данных
        Task[] tasks = new Task[dataSources.Length];
        for (int i = 0; i < dataSources.Length; i++)
        {
            tasks[i] = ProcessDataAsync(dataSources[i], i);
        }

        // Ожидаем завершения всех задач
        await Task.WhenAll(tasks);

        Console.WriteLine("Обработка данных завершена.");
    }

    // Метод для асинхронной симуляции обработки данных и записи их в файл
    static async Task ProcessDataAsync(string data, int index)
    {
        Console.WriteLine($"Началась обработка {data}");

        // Симулируем задержку обработки
        await Task.Delay(1000 * (index + 1));

        // Используем блокировку для безопасного доступа к файлу
        lock (filePath)
        {
            File.AppendAllText(filePath, $"{data}\n");
        }

        Console.WriteLine($"Обработка {data} завершена.");
    }
}