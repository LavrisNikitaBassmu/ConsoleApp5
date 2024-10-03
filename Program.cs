using System;

class AngleCalculator
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя часы, минуты и секунды
        Console.Write("Введите часы (0-11): ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минуты (0-59): ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите секунды (0-59): ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Вызываем метод CalculateAngle с полученными значениями
        CalculateAngle(hours, minutes, seconds);
    }

    static void CalculateAngle(int hours, int minutes, int seconds)
    {
        // Вычисляем угол в градусах для часов
        double hourAngle = 0.5 * (hours * 60 + minutes + seconds / 60);

        // Вычисляем угол в градусах для минут
        double minuteAngle = 6 * (minutes + seconds / 60);

        // Вычисляем угол между часовой и минутной стрелками
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Если угол больше 180 градусов, то вычитаем его из 360 градусов
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        // Выводим результат на консоль
        Console.WriteLine($"Угол между часовой и минутной стрелками: {angle} градусов.");
    }
}