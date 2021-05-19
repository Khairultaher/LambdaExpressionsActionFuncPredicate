using System;

namespace LambdaActionFuncPredicate
{
    class Program
    {
        delegate double CalculateAreaDel(int r);
        static CalculateAreaDel calculateArea = CalculateArea;
        static void Main(string[] args)
        {
            double area = 0;
            //area = calculateArea.Invoke(10);

            //CalculateAreaDel calculateArea = new CalculateAreaDel(
            //    delegate(int r) { return 3.14 * r * r; });
            
            //CalculateAreaDel calculateArea = (r) => 3.14 * r * r;

            Func<int, double> calculateArea = (r) => 3.14 * r * r;

            area = calculateArea(10);
            Console.WriteLine(area);

            Console.ReadLine();
        }

        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
