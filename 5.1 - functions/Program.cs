using System;

namespace _5._1___functions
{
    class Program

    {
        static void Main(string[] args)
        {
				float SqrtK(float x, int k, int n)
				{
					if ((n == 0) || (x == 1)) return 1;
					if (x == 0) return 0;
					if (k == 1) return x;
					else return ((float)(SqrtK(x, k, n - 1) - (SqrtK(x, k, n - 1) - (x / Math.Pow((SqrtK(x, k, n - 1)), (k - 1)))) / k));
				}

			double O;   //Ответ
			int k, n;	//Переменные, целые
			float x, y; //вещ. параметр
			Console.WriteLine("Введите число x = ");
			x = (float)double.Parse(Console.ReadLine());	//вводим переменные
			Console.WriteLine("Введите число k = ");
			k = (int)double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число n = ");
			n = (int)double.Parse(Console.ReadLine());		//до сюда
			O = SqrtK(x, k, n);								//ответ
            Console.WriteLine("Ответ = " + O);

		}
	}
}
