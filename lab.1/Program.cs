using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab._1
{
	class Programm
	{
		static void Main(string[] args)
		{
			double number;
			number = double.Parse(Console.ReadLine());
			Console.WriteLine("Задание 1.1");
			Console.WriteLine(Math.Round(number,2));
			Console.ReadLine();

			double e = Math.E;
			Console.WriteLine("Задание 1.2");
            Console.WriteLine(Math.Round(e,1));

			
			Console.WriteLine("Задание 1.3");
			Console.WriteLine("Введите число - ");
			number = double.Parse((Console.ReadLine()));
			Console.WriteLine($"Вы ввели число :{number}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.4");
			Console.WriteLine("Введите число - ");
			string num = Console.ReadLine();
			Console.WriteLine($"{num}-вот какое число вы ввели");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.5");
			int an1, an2, an3;/*an-любое число*/
			an1 = 1; an2 = 13; an3 = 49;
			Console.WriteLine($"{an1} {an2} {an3}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.6");
			an1 = 7; an2 = 15; an3 = 100;/*an-любое число*/
			Console.WriteLine($"{an1}  {an2}  {an3}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.7");
			double an4;
			an4 = double.Parse(Console.ReadLine());
			double an5;
			an5 = double.Parse(Console.ReadLine());
			double an6;
			an6 = double.Parse(Console.ReadLine());
			Console.WriteLine($"{an4}  {an5}  {an6}");
			Console.ReadLine();

			Console.WriteLine("Задание 1.8");
			double an7;
			an4 = double.Parse(Console.ReadLine());
			an5 = double.Parse(Console.ReadLine());
			an6 = double.Parse(Console.ReadLine());
			an7 = double.Parse(Console.ReadLine());
			Console.WriteLine($"{an4} {an5} {an6} {an7}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.9");
			an1 = 50;
			an2 = 10;
			Console.WriteLine($"{an1}");
			Console.WriteLine($"{an2}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.10");
			an1 = 5;
			an2 = 10;
			an3 = 21;
			Console.WriteLine($"{an1}");
			Console.WriteLine($"{an2}");
			Console.WriteLine($"{an3}");
			Console.ReadLine();
			
			Console.WriteLine("Задание 1.11");
			an4 = double.Parse(Console.ReadLine());
			Console.WriteLine();
			an5 = double.Parse(Console.ReadLine());
			Console.WriteLine();
			an6 = double.Parse(Console.ReadLine());
			Console.WriteLine();
			an7 = double.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.WriteLine("Задание 1.12");
			an1 = 5;an2 = 10;
			Console.WriteLine($"{an1} {an2}");
			an1 = 7;
			string s = "см"; /*s- строка*/
			Console.WriteLine($"{an1} {s}");
			Console.ReadLine();

			Console.WriteLine("Задание 1.13");
			an1 = 2;
			s = "кг";
			Console.WriteLine($"{an1} {s}");
			an1 = 13;
			an2 = 17;
			Console.WriteLine($"{an1} {an2}");
			Console.ReadLine();

            Console.WriteLine("Задание 2.1 a");
			double x = double.Parse(Console.ReadLine());
			double y = 7 * x * x + 3 * x + 6;
            Console.WriteLine(y);

            Console.WriteLine("Задание 2.1 б");
            double a = double.Parse(Console.ReadLine());
			y = 12 * a * a + 7 * a + 12;
            Console.WriteLine(y);

            Console.WriteLine("Задание 2.2");
			a = double.Parse(Console.ReadLine());/*a-сторона квадрата*/
			double P = a + a + a + a;
            Console.WriteLine(P);
			Console.ReadLine();

            Console.WriteLine("Задание 2.4");
			double radius = 6350;
			double h = double.Parse(Console.ReadLine());
			double ras=Math.Sqrt((radius+h)*(radius+h)-(radius*radius));/*ras-расстояние до линии горизонта,radius-радиус Земли, h-высота*/
            Console.WriteLine(ras);
			Console.ReadLine();

            Console.WriteLine("Задание 2.5");
			a = double.Parse(Console.ReadLine());/*a-длина ребра куба*/
			double V = a * a * a;/*V-объем куба*/
			double S = 6 * a * a;/*S-площадь боковой поверхности*/
            Console.WriteLine($"{V},{S}");

			Console.WriteLine("Задание 2.7");
			an4 = double.Parse(Console.ReadLine());
			an5 = double.Parse(Console.ReadLine());
			double An = an4 / 2 + an5 / 2;/*An-среднее арифметическое*/
			double Bn = Math.Sqrt(an4 * an5);
            Console.WriteLine($"{An},{Bn}");

            Console.WriteLine("Задание 2.10");
			a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
            if (a==0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
				x = -b / a;
                Console.WriteLine(x);
            }

			Console.WriteLine("Задание 2.12");
			double r = double.Parse(Console.ReadLine());/*r-внутренний радиус*/
            double R = double.Parse(Console.ReadLine());/*R-внешний радиус кольца*/
			S = Math.PI*(R * R - r * r);
            Console.WriteLine(S);
			Console.ReadLine();

            Console.WriteLine("Задание 2.13A");
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			An = (Math.Abs(a) + Math.Abs(b)) / 2;/*См.Задание 2.7"*/
			Bn = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
			Console.WriteLine($"{An},{Bn}");
			Console.ReadLine();

			Console.WriteLine("Задание 2.14A");
			a = double.Parse(Console.ReadLine());/*a-длина прямоугольника*/
			b = double.Parse(Console.ReadLine());/*b-ширина прямоугольника*/
			P = 2 * (a + b);/*P-Периметр прямоугольника*/
			double D = double.Parse(Console.ReadLine());
			D = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"{P},{D}");
			Console.ReadLine();

			Console.WriteLine("Задание 2.16");
			a = double.Parse(Console.ReadLine());/*а-длина основания параллелепипеда*/
			b = double.Parse(Console.ReadLine());/*ширина основания параллелепипеда*/
			h = double.Parse(Console.ReadLine());/*высота параллелепипеда*/
			V = a * b * h;/*объем параллелепипеда*/
			S = (a + b) * h;/*площадь боковой поверхности паралелепипеда*/
			Console.WriteLine($"{V},{S}");
			Console.ReadLine();

            Console.WriteLine("Задание 2.17");
			double x1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси ординат"*/
			double y1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси абсцисс"*/
			double x2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси абсцисс"*/
			double y2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси ординат"*/
			S = Math.Abs(Math.Sqrt((x1-x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)));/*"Расстояние между двумя точками на плоскости"*/
			Console.WriteLine(S);
			Console.ReadLine();

			Console.WriteLine("Задание 2.18");
			a = double.Parse(Console.ReadLine());/*"первое основание равнобедренной трапеции"*/
			b = double.Parse(Console.ReadLine());/*"второе основание равнобедренной трапеции"*/
			h = double.Parse(Console.ReadLine());/*"высота равнобедренной трапеции"*/
			double c;
			c = ((b - a) / 2)*((b-a)/2)+h*h;/*"боковое ребро равнобедренной трапеции"*/
			P = a + b + 2 * c;/*"периметр равнобедренной трапеции"*/
			Console.WriteLine(P);
			Console.ReadLine();

			Console.WriteLine("Задание 2.20");
			x1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси абсцисс"*/
			y1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси ординат"*/
			x2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси абсцисс"*/
			y2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси ординат"*/
			double x3 = double.Parse(Console.ReadLine());/*"Координаты третьей точки по оси абсцисс"*/
			double y3 = double.Parse(Console.ReadLine());/*"Координаты третьей точки по оси ординат"*/
			a = Math.Abs(Math.Sqrt((y3 - y2) * (y3 - y2) + (x3-x2)*(x3-x2)));/*"длина первой стороны треугольника"*/
			b = Math.Abs(Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1)));/*"длина второй стороны треугольника"*/
			c = Math.Abs(Math.Sqrt(y3-y1)*(y3-y1)+(x3-x1)*(x3-x1));/*"длина третьей стороны треугольника"*/
			double p = (a + b + c)/2;/*"Полупериметр треугольника"*/
			S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));/*"Площадь треугольника по формуле Геррона"*/
			Console.WriteLine(S);
			Console.ReadLine();

			Console.WriteLine("Задание 2.21");
			x1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси абсцисс"*/
			y1 = double.Parse(Console.ReadLine());/*"Координаты первой точки по оси ординат"*/
			x2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси абсцисс"*/
			y2 = double.Parse(Console.ReadLine());/*"Координаты второй точки по оси ординат"*/
			x3 = double.Parse(Console.ReadLine());/*"Координаты третьей точки по оси абсцисс"*/
			y3 = double.Parse(Console.ReadLine());/*"Координаты третьей точки по оси ординат"*/
			double x4 = double.Parse(Console.ReadLine());/*"Координаты четвертой точки по оси абсцисс"*/
			double y4 = double.Parse(Console.ReadLine());/*"Координаты четвертой точки по оси ординат"*/
			a = Math.Abs(Math.Sqrt((y1 - y2) * (y1 - y2) + (x1 - x2) * (x1 - x2)));/*"длина первой стороны выпуклого четырехугольника"*/
			b = Math.Abs(Math.Sqrt((y3 - y2) * (y3 - y2) + (x3 - x2) * (x3 - x2)));/*"длина второй стороны выпуклого четырехугольника"*/
			c = Math.Abs(Math.Sqrt((y3 - y1) * (y3 - y1) + (x3 - x1) * (x3 - x1)));/*"длина третьей стороны выпуклого четырехугольника"*/
			double d = Math.Abs(Math.Sqrt((y4 - y3) * (y4 - y3) + (x4 - x3) * (x4 - x3)));/*"длина четвертой стороны выпуклого четырехугольника"*/
			e = Math.Abs(Math.Sqrt((y4 - y1) * (y4 - y1) + (x4 - x1) * (x4 - x1)));/*"длина одной из диагоналей выпуклого четырехугольника"*/
			double p1 = (a + b + c)/2;/*"полупериметр первого треугольника, составляющего выпуклый четырехугольник"*/
			double p2 = (e + d + c)/2;/*"полупериметр второго треугольника, составляющего выпуклый четырехугольник"*/
			double s1 = Math.Sqrt((p1 * (p1 - a) * (p1 - b) * (p1 - c)));/*"площадь первого треугольника, составляющего выпуклый четырехугольник"*/
			double s2=Math.Sqrt(p2*(p2-e)*(p2-d)*(p2-c));/*"площадь второго треугольника, составляющего выпуклый четырехугольник"*/
			S = s1 + s2;/*"площадь выпуклого четырехугольника"*/
			Console.WriteLine(S);
			Console.ReadLine();

			Console.WriteLine("Задание 2.22");
			int sweet = 200;/*"цена конфет за 1 кг"*/
			int biscuit = 160;/*"цена печенек за 1 кг"*/
			int apple = 70;/*"цена яблок за 1 кг"*/
			x = double.Parse(Console.ReadLine());/*"количество купленных кг конфет"*/
			y = double.Parse(Console.ReadLine());/*"количество купленных кг печенек"*/
			h = double.Parse(Console.ReadLine());/*"количество купленных кг яблок"*/
			s1 = sweet * x;/*"общая стоимость за количество купленных кг конфет"*/
			s2 = biscuit * y;/*"общая стоимость за количество купленных кг печенек"*/
			double s3 = apple * h;/*"общая стоимость за количество купленных кг яблок"*/
			S = s1 + s2 + s3;/*"общая стоимость покупки"*/
			Console.WriteLine(S);
			Console.ReadLine();

			Console.WriteLine("Задание 2.24");
			x = double.Parse(Console.ReadLine());/*"возраст Тани"*/
			y = double.Parse(Console.ReadLine());/*"возраст	Мити"*/
			S = (x + y)/2; /*"среднее арифметическое возраста Тани и Мити"*/
			a = Math.Abs(S - y);/*"разница между возрастом Тани и средним арифметическим возрастов Тани и Мити"*/
			b = Math.Abs(S - x);/*"разница между возрастом Мити и средним арифметическим возрастов Тани и Мити"*/
			Console.WriteLine($"{S}, {a}, {b}");

			Console.WriteLine("Задание 2.25");
			double v1 = double.Parse(Console.ReadLine());/*"скорость первого автомобиля"*/
			double v2 = double.Parse(Console.ReadLine());/*"скорость второго автомобиля"*/
			S = double.Parse(Console.ReadLine());/*"общий путь"*/
			double t;/*"общее время, за которое два навстречу двигающихся автомобиля пройдут общий путь"*/
			t = S / (v1 + v2);
			Console.WriteLine(t); ;
			Console.ReadLine();

			Console.WriteLine("Задание 2.27,a");
			t = double.Parse(Console.ReadLine());/*"температура в градусах Цельсия"*/
			double F = t * 1.8 + 32;/*"температура по шкале Фаренгейта"*/
			Console.WriteLine(F);
            Console.WriteLine("Задание 2.27,б");
			double K = 273.15 + t;/*"температура по шкале Кельвина"*/
			Console.WriteLine(K);
			Console.ReadLine();

			Console.WriteLine("Задание 3.1");
			a = 10;/*"первая переменная"*/
			b = 20;/*"вторая переменная"*/
			c = a;
			a = b;
			b=c;
            Console.WriteLine($"{a},{b}");
			Console.ReadLine();

            Console.WriteLine("Задание 3.2,а");
			a = 10;
			b = 20;
			c = 30;
			d = b;
			h = a;
			b = c;
			a = d;
			c = h;
            Console.WriteLine($"{a},{b},{c}");
			Console.ReadLine();

            Console.WriteLine("Задание 3.3,a");
			a = 2;
			a = a * a;
			a = a * a;
            Console.WriteLine(a);
			Console.ReadLine();

            Console.WriteLine("Задание 3.3,б");
			a = a * a;
			a = a * a;
			a = a * a;
            Console.WriteLine(a);
			Console.ReadLine();
		}
	}
}
