using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс Квадрат определить функционал класса так, чтобы он соответствовал геометрической
//фигуре «квадрат» (задание стороны, вычисление периметра и площади).

namespace ConsoleTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(5);
            int res = sq.Perimeter();
            Console.WriteLine("Периметр: " + res);
            Console.WriteLine("Площадь: " + sq.Area());
            Console.ReadKey();
        }
    }

    public class Square
    {
        public int Side;
        public Square(int Side)
        {
            this.Side = Side;
        }
        public int Perimeter()
        {
            return 4 * Side;
        }
        public int Area()
        {
            return Side * Side;
        }

    }
}
