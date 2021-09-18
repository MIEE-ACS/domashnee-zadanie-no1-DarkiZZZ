using System;

namespace Prog_Sokolov_UTS_11_Var21
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Шаблон квадратного ур-я A·x^2 + B·x + C = 0. Введите поочередно A, B и C:");
            double A, B, C, Discriminant;
            POINT: A = Convert.ToDouble(Console.ReadLine());
            if(A == 0.0)
            {
                Console.WriteLine("Нарушено условие задачи. Введите A заново:");
                goto POINT;
            }
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            Discriminant = Math.Pow(B, 2) - (4*A*C);
            if(Discriminant <= 0){
                Console.WriteLine("Дискриминант не подходит под условие задачи. Попробуйте ввести данные еще раз.");
                goto POINT;

            }
            double X1 = (-B + Math.Sqrt(Discriminant)) / 2 * A;
            double X2 = (-B - Math.Sqrt(Discriminant)) / 2 * A;
            double Check = X1 - X2;
            if (Check > 0)
            {
                Console.Write("Первый корень: ");
                Console.WriteLine(String.Format("{0:0.000}", X2));
                Console.Write("Второй корень: ");
                Console.WriteLine(String.Format("{0:0.000}", X1));
            }
            else
            {
                Console.Write("Первый корень: ");
                Console.WriteLine(String.Format("{0:0.000}", X1));
                Console.Write("Второй корень: ");
                Console.WriteLine(String.Format("{0:0.000}", X2));
            }
            Console.ReadKey();
        }
    }
}
