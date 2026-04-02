using System.Xml.XPath;

namespace LAB02
{
    /// <summary>
    /// Класс Solver содержит решения задач лабораторной работы.
    /// Методы сгруппированы по блокам.
    /// Ф.И.О - 
    /// Вариант - 
    /// </summary>
    public class Solver
    {

        // =========================
        // Блок 1. Переменные и операторы
        // =========================

        /// <summary>
        /// Задача 1. Конвертирует температуру из градусов Цельсия в градусы Фаренгейта.
        /// </summary>
        /// <param name="celsius">Температура в градусах Цельсия.</param>
        /// <returns>Строку с результатом конвертации температуры.</returns>
        /// <example>
        /// CelsiusToFahrenheit(25) → "25C = 77.0F"
        /// CelsiusToFahrenheit(-13) → "-13C = 8.6F"
        /// </example>
        public static string CelsiusToFahrenheit(double celsius)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 2. Вычисляет индекс массы тела (BMI) по росту и весу.
        /// </summary>
        /// <param name="heightCm">Рост человека в сантиметрах.</param>
        /// <param name="weightKg">Вес человека в килограммах.</param>
        /// <returns>Строку с рассчитанным индексом массы тела.</returns>
        /// <example>
        /// CalculateBMI(180, 75) → "Рост: 180 см, Вес: 75 кг, ИМТ = 23.1"
        /// </example>
        public static string CalculateBMI(double heightCm, double weightKg)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 3. Конвертирует сумму рублей в доллары.
        /// </summary>
        /// <param name="rubles">Сумма в рублях.</param>
        /// <returns>Строку с результатом конвертации валюты.</returns>
        /// <example>
        /// RublesToDollars(9000) → "9000 рублей = 3061 долларов"
        /// </example>
        public static string RublesToDollars(double rubles)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 4. Преобразует количество секунд в часы, минуты и секунды.
        /// </summary>
        /// <param name="seconds">Общее количество секунд.</param>
        /// <returns>Строку с разложением времени.</returns>
        /// <example>
        /// ConvertSeconds(3665) → "3665 секунд = 1 ч 1 мин 5 сек"
        /// </example>
        public static string ConvertSeconds(int seconds)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 5. Вычисляет среднее арифметическое трёх чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>Строку со средним значением.</returns>
        /// <example>
        /// Average(4, 6, 8) → "Среднее арифметическое чисел 4, 6 и 8 = 6.00"
        /// Average(3, 1, 7) → "Среднее арифметическое чисел 3, 1 и 7 = 3.67"
        /// </example>
        public static string Average(double a, double b, double c)
        {
            double average = (a + b + c) / 3;
            return $"Среднее арифметическое чисел {a}, {b} и {c} = {average:F2}";
        }

        /// <summary>
        /// Задача 6. Вычисляет цену товара после применения скидки.
        /// </summary>
        /// <param name="price">Исходная цена товара.</param>
        /// <param name="discountPercent">Процент скидки.</param>
        /// <returns>Строку с итоговой ценой.</returns>
        /// <example>
        /// CalculateDiscountPrice(1000, 15) → "Цена: 1000, скидка: 15%, итоговая цена: 850.00"
        /// CalculateDiscountPrice(458, 8.5) → "Цена: 458, скидка: 8.5%, итоговая цена: 418.16"
        /// </example>
        public static string CalculateDiscountPrice(double price, double discountPercent)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }


        // =========================
        // Блок 2. Условные операторы (if / switch)
        // =========================

        /// <summary>
        /// Задача 1. Определяет время года по номеру месяца.
        /// </summary>
        /// <param name="month">Номер месяца (1–12).</param>
        /// <returns>Строку с названием времени года.</returns>
        /// <example>
        /// GetSeason(7) → "Месяц 7 - Лето"
        /// GetSeason(16) → "Месяц 16 - Не существует"
        /// </example>
        public static string GetSeason(int month)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 2. Определяет тип треугольника по длинам сторон.
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        /// <returns>Строку с типом треугольника.</returns>
        /// <example>
        /// GetTriangleType(5, 5, 5) → "Треугольник со сторонами 5, 5, 5 - равносторонний"
        /// GetTriangleType(1, 2, 3) → "Треугольник со сторонами 1, 2, 3 - не существует"
        /// </example>
        public static string GetTriangleType(double a, double b, double c)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 3. Определяет координатную четверть точки.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <returns>Строку с номером координатной четверти.</returns>
        /// <example>
        /// GetQuadrant(3, 4) → "Точка (3, 4) находится в I четверти"
        /// GetQuadrant(-3, 0) → "Точка (-3, 0) находится на пересечении четвертей"
        /// </example>
        public static string GetQuadrant(double x, double y)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 4. Возвращает текстовое описание оценки.
        /// </summary>
        /// <param name="grade">Оценка от 1 до 5.</param>
        /// <returns>Строку с описанием оценки.</returns>
        /// <example>
        /// GetGradeDescription(5) → "Оценка 5 - Отлично"
        /// GetGradeDescription(9) → "Оценки 9 не бывает"
        /// </example>
        public static string GetGradeDescription(int grade)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 5. Определяет время суток по номеру часа.
        /// </summary>
        /// <param name="hour">Час дня (0–23).</param>
        /// <returns>Строку с названием времени суток.</returns>
        /// <example>
        /// GetTimeOfDay(21) → "21 час - Вечер"
        /// GetTimeOfDay(26) → "26 час - Не существует"
        /// </example>
        public static string GetTimeOfDay(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                if (hour >= 5 && hour <= 11)
                {
                    return $"{hour} час - Утро";
                }
                else if (hour >= 12 && hour <= 16)
                {
                    return $"{hour} час - День";
                }
                else if (hour >= 17 && hour <= 21)
                {
                    return $"{hour} час - Вечер";
                }
                else if (hour >= 22 || hour <= 4)
                {
                    return $"{hour} час - Ночь";
                }
            }
            
            return $"{hour} час - Не существует";
        }

        /// <summary>
        /// Задача 6. Конвертирует рубли в выбранную валюту.
        /// </summary>
        /// <param name="rubles">Сумма в рублях.</param>
        /// <param name="currency">Код валюты (USD, EUR, GBP).</param>
        /// <returns>Строку с результатом конвертации.</returns>
        /// <example>
        /// ConvertCurrency(10000, "USD") → "10000 RUB = 3333.33 USD"
        /// ConvertCurrency(10000, "ABC") → "Неизвестная валюта"
        /// </example>
        public static string ConvertCurrency(double rubles, string currency)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }


        // =========================
        // Блок 3. Циклы (for / while / do-while)
        // =========================

        /// <summary>
        /// Задача 1. Находит минимальную и максимальную цифру числа.
        /// </summary>
        /// <param name="number">Целое положительное число.</param>
        /// <returns>Строку с минимальной и максимальной цифрой.</returns>
        /// <example>
        /// GetMinMaxDigit(58324) → "Число: 58324, минимальная цифра: 2, максимальная цифра: 8"
        /// GetMinMaxDigit(7) → "Число: 7, минимальная цифра: 7, максимальная цифра: 7"
        /// </example>
        public static string GetMinMaxDigit(int number)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 2. Переворачивает число.
        /// </summary>
        /// <param name="number">Исходное число.</param>
        /// <returns>Строку с перевёрнутым числом.</returns>
        /// <example>
        /// ReverseNumber(12345) → "Перевёрнутое число: 54321"
        /// ReverseNumber(1010) → "Перевёрнутое число: 101"
        /// </example>
        public static string ReverseNumber(int number)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 3. Вычисляет сумму первых n чисел Фибоначчи.
        /// </summary>
        /// <param name="n">Количество чисел Фибоначчи.</param>
        /// <returns>Строку с суммой чисел.</returns>
        /// <example>
        /// FibonacciSum(7) → "Сумма Первых 7 чисел Фибоначчи = 20"
        /// FibonacciSum(1) → "Сумма Первых 1 чисел Фибоначчи = 0"
        /// FibonacciSum(0) → "Невозможно вычислить сумму"
        /// </example>
        public static string FibonacciSum(int n)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 4. Находит максимальное нечётное число в диапазоне.
        /// </summary>
        /// <param name="a">Начало диапазона.</param>
        /// <param name="b">Конец диапазона.</param>
        /// <returns>Строку с найденным числом.</returns>
        /// <example>
        /// MaxOdd(10, 20) → "Максимальное нечётное число в диапазоне [10, 20] = 19"
        /// MaxOdd(10, 0) → "Максимальное нечётное число в диапазоне [0, 10] = 9"
        /// MaxOdd(6, 6) → "Нечётных чисел нет"
        /// </example>
        public static string MaxOdd(int a, int b)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 5. Вычисляет среднее значение элементов массива.
        /// </summary>
        /// <param name="numbers">Массив чисел.</param>
        /// <returns>Строку со средним значением.</returns>
        /// <example>
        /// AverageArray(new int[] {3,5,7,9}) → "Среднее значение массива = 6.00"
        /// AverageArray(new int[] {15,3,-5}) → "Среднее значение массива = 4.33"
        /// </example>
        public static string AverageArray(int[] numbers)
        {
            double sum = 0;
            double zn;
            if (numbers.Length != 0) {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                zn = sum / numbers.Length;
                return $"Среднее значение массива = {zn:F2}";
            }
            else
            {
                 return $"Среднее значение массива = 0.00";
            }
            
        }

        /// <summary>
        /// Задача 6. Строит арифметическую прогрессию и вычисляет её сумму.
        /// </summary>
        /// <param name="first">Первый элемент прогрессии.</param>
        /// <param name="step">Шаг прогрессии.</param>
        /// <param name="n">Количество элементов.</param>
        /// <returns>Строку с прогрессией и её суммой.</returns>
        /// <example>
        /// ArithmeticProgression(2,3,5) → "Прогрессия: 2 5 8 11 14, сумма = 40"
        /// ArithmeticProgression(2,0,6) → "Невозможно собрать прогрессию"
        /// ArithmeticProgression(2,8,-4) → "Невозможно собрать прогрессию"
        /// </example>
        public static string ArithmeticProgression(int first, int step, int n)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }


        // =========================
        // Блок 4. Массивы
        // =========================

        /// <summary>
        /// Задача 1. Подсчитывает количество элементов массива, больших заданного значения.
        /// </summary>
        /// <param name="array">Массив чисел.</param>
        /// <param name="filter">Значение для сравнения.</param>
        /// <returns>Строку с количеством элементов.</returns>
        /// <example>
        /// SumOfGreaterThen(new int[] {4,9,2,7,5}, 6) → "Количество Элементов Больших 6 = 2"
        /// SumOfGreaterThen(new int[] {1,3,5,7,9}, 10) → "Количество Элементов Больших 10 = 0"
        /// </example>
        public static string SumOfGreaterThen(int[] array, int filter)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 2. Находит второй по величине элемент массива.
        /// </summary>
        /// <param name="array">Массив чисел.</param>
        /// <returns>Строку со вторым по величине элементом и его индексом.</returns>
        /// <example>
        /// SecondLargest(new int[] {4,9,2,7,5}) → "Второй по величине элемент: 7 (индекс 3)"
        /// SecondLargest(new int[] {4}) → "В массиве должно находиться минимум 2 элемента"
        /// </example>
        public static string SecondLargest(int[] array)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 3. Возвращает массив в обратном порядке.
        /// </summary>
        /// <param name="array">Исходный массив.</param>
        /// <returns>Строку с элементами массива в обратном порядке.</returns>
        /// <example>
        /// ReverseArray(new int[] {2,8,4,9,1}) → "Обратный массив: 1 9 4 8 2"
        /// ReverseArray(new int[] {}) → "Массив не может быть пустым"
        /// </example>
        public static string ReverseArray(int[] array)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 4. Вычисляет сумму всех чётных элементов матрицы.
        /// </summary>
        /// <param name="matrix">Двумерный массив чисел.</param>
        /// <returns>Строку с суммой чётных элементов.</returns>
        /// <example>
        /// SumEvenInMatrix(new int[,] { {2,9,4}, {8,1,3} }) → "Сумма четных элементов = 14"
        /// SumEvenInMatrix(new int[,] { {3,9,7}, {11,13,15} }) → "Сумма четных элементов = 0"
        /// </example>
        public static string SumEvenInMatrix(int[,] matrix)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }

        /// <summary>
        /// Задача 5. Разделяет массив на положительные и отрицательные элементы.
        /// </summary>
        /// <param name="array">Массив чисел.</param>
        /// <returns>Строку со списком положительных и отрицательных чисел.</returns>
        /// <example>
        /// SplitArray(new int[] {5,-3,7,-8,12,-1}) → "Положительные: 5 7 12. Отрицательные: -3 -8 -1"
        /// SplitArray(new int[] {}) → "Массив не может быть пустым"
        /// </example>
        public static string SplitArray(int[] array)
        {
            List<int> negative = new List<int>();
            List<int> positive = new List<int>();

            if (array.Length != 0)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        negative.Add(array[i]);
                    }
                    else if (array[i] > 0)
                    {
                        positive.Add(array[i]);
                    }
                    else {}
                }
                return $"Положительные: {String.Join(" ", positive)}. Отрицательные: {String.Join(" ", negative)}";
            }
            return "Массив не может быть пустым";

        }

        /// <summary>
        /// Задача 6. Находит максимальный элемент главной диагонали матрицы.
        /// </summary>
        /// <param name="matrix">Квадратная матрица.</param>
        /// <returns>Строку с максимальным элементом диагонали.</returns>
        /// <example>
        /// MatrixDiagonalMax(new int[,] { {2,9,4}, {8,1,3}, {-2,4,6} }) → "Максимальный элемент главной диагонали = 6"
        /// MatrixDiagonalMax(new int[,] { {2,9,4}, {8,1,3} }) → "Максимальный элемент главной диагонали = 0"
        /// </example>
        public static string MatrixDiagonalMax(int[,] matrix)
        {
            // Реализовать метод для решения задачи
            throw new NotImplementedException();
        }
    }
}
