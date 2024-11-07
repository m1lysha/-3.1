
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите вещественное число X (|X| < 1): ");
        double X = Convert.ToDouble(Console.ReadLine());

        
        if (Math.Abs(X) >= 1)
        {
            Console.WriteLine("Ошибка: |X| должно быть меньше 1.");
            return;
        }

        Console.Write("Введите целое число N (> 0): ");
        int N = Convert.ToInt32(Console.ReadLine());

        
        if (N <= 0)
        {
            Console.WriteLine("Ошибка: N должно быть больше 0.");
            return;
        }

        
        double result = 0.0;

        for (int n = 1; n <= N; n++)
        {
            double term = Math.Pow(-1, n - 1) * Math.Pow(X, n) / n;
            result += term;
        }

        
        Console.WriteLine($"Приближенное значение ln(1 + {X}) равно: {result}");
    }
}