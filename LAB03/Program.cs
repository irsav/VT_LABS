namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========== Лабораторная работа 3 ==========\n");

            // ========== Задание 1. Создание объектов дроби ==========
            Console.WriteLine("--- Задание 1. Создание объектов дроби ---\n");

            // Задание 1.1 - конструктор с двумя параметрами
            Console.WriteLine("1.1 Конструктор Rational(3, 8):");
            Rational r1 = new Rational(3, 8);
            Console.WriteLine($"Результат: {r1}");
            Console.WriteLine($"Ожидается: 3/8\n");

            // Задание 1.2 - конструктор с одним параметром
            Console.WriteLine("1.2 Конструктор Rational(4):");
            Rational r2 = new Rational(4);
            Console.WriteLine($"Результат: {r2}");
            Console.WriteLine($"Ожидается: 4\n");

            // Задание 1.3 - конструктор без параметров
            Console.WriteLine("1.3 Конструктор Rational():");
            Rational r3 = new Rational();
            Console.WriteLine($"Результат: {r3}");
            Console.WriteLine($"Ожидается: 0\n");

            // Задание 1.4 - проверка выброса исключения при знаменателе = 0
            Console.WriteLine("1.4 Проверка исключения при знаменателе 0:");
            try
            {
                Rational r4 = new Rational(-3, 0);
                Console.WriteLine($"ОШИБКА: Исключение не было выброшено, получено: {r4}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"УСПЕШНО: Исключение перехвачено - {ex.Message}\n");
            }

            // ========== Задание 2. Проверка сокращения/упрощения дроби ==========
            Console.WriteLine("--- Задание 2. Проверка сокращения/упрощения дроби ---\n");

            // Задание 2.1 - сократимая дробь
            Console.WriteLine("2.1 Сократимая дробь Rational(4, 8):");
            Rational r5 = new Rational(4, 8);
            Console.WriteLine($"Результат: {r5}");
            Console.WriteLine($"Ожидается: 1/2\n");

            // Задание 2.2 - нормализация знаков (знаменатель отрицательный)
            Console.WriteLine("2.2.1 Нормализация знаков Rational(4, -9):");
            Rational r6 = new Rational(4, -9);
            Console.WriteLine($"Результат: {r6}");
            Console.WriteLine($"Ожидается: -4/9\n");

            // Задание 2.2 - нормализация знаков (оба отрицательные) + сокращение
            Console.WriteLine("2.2.2 Нормализация и сокращение Rational(-2, -10):");
            Rational r7 = new Rational(-2, -10);
            Console.WriteLine($"Результат: {r7}");
            Console.WriteLine($"Ожидается: 1/5\n");

            // ========== Задание 3. Перегрузка операторов ==========
            Console.WriteLine("--- Задание 3. Перегрузка операторов ---\n");

            // Подготовим дроби для арифметических операций
            Rational a = new Rational(1, 2);  // 1/2
            Rational b = new Rational(1, 3);  // 1/3
            Console.WriteLine($"Дробь A: {a}");
            Console.WriteLine($"Дробь B: {b}\n");

            // Задание 3.1 - арифметические операторы + - * /
            Console.WriteLine("3.1 Арифметические операторы:");
            
            Rational sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum} (ожидается: 5/6)");
            
            Rational diff = a - b;
            Console.WriteLine($"{a} - {b} = {diff} (ожидается: 1/6)");
            
            Rational prod = a * b;
            Console.WriteLine($"{a} * {b} = {prod} (ожидается: 1/6)");
            
            Rational quot = a / b;
            Console.WriteLine($"{a} / {b} = {quot} (ожидается: 3/2 или 1/2? Проверьте: (1/2)/(1/3)=3/2)");
            
            Console.WriteLine();

            // Дополнительная проверка оператора деления
            Rational c = new Rational(3, 4);
            Rational d = new Rational(2, 5);
            Console.WriteLine($"Дополнительно: {c} / {d} = {c / d} (ожидается: 15/8)\n");

            // Задание 3.2 - операторы сравнения == и !=
            Console.WriteLine("3.2 Операторы сравнения:");
            
            Rational same1 = new Rational(2, 4);  // сократится до 1/2
            Rational same2 = new Rational(1, 2);  // 1/2
            Rational different = new Rational(2, 3);
            
            Console.WriteLine($"{same1} == {same2} ? {same1 == same2} (ожидается: True)");
            Console.WriteLine($"{same1} != {same2} ? {same1 != same2} (ожидается: False)");
            Console.WriteLine($"{same1} == {different} ? {same1 == different} (ожидается: False)");
            Console.WriteLine($"{same1} != {different} ? {same1 != different} (ожидается: True)");

            Console.WriteLine("\n========== Программа завершена ==========");
        
        }
    }
}