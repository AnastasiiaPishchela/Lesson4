using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создать класс Арифметическая прогрессия. Обеспечить получение(задание) характеристик прогрессии.

Функционал класса:
o первый член прогрессии, формулой n-го члена:  an = a1+ d · (n - 1)
o разница прогрессии, d =  an+1 - an
o n–й член прогрессии, an = a1+ d · (n - 1)
o среднее арифметическое первых n членов прогрессии, S ср = (2a1+d(n-1))/2
o сумма первых n членов прогрессии. S = ((2a1+d(n-1))/2) * n,
Арифметическая прогрессия задается значением первого ее члена и разницей, так если первый член – a1, разница
прогрессии – d, то an = a1 + (n – 1) * d). */

namespace ConsoleTask5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgress ap = new ArithmeticProgress(1, 2, 5);
            int res = ap.AnyNumberOfArithmeticProgress();
            Console.WriteLine("Первый номер: " + ap.FirtsNumberInProgress());
            Console.WriteLine("Шаг: " + ap.ProgressDifference());
            Console.WriteLine("Прогрессия: " + res);
            Console.WriteLine("Сумма: " + ap.SumOfProgressNumbers());
            Console.WriteLine("Средние: " + ap.AveregeSumOfProgressNumbers());
            Console.ReadKey();
        }
        public class ArithmeticProgress
        {
            public int firstNumber, step, lastNumber;
            public ArithmeticProgress(int firstNumber, int step, int lastNumber)
            {
                this.firstNumber = firstNumber;
                this.step = step;
                this.lastNumber = lastNumber;
            }
            public int FirtsNumberInProgress()
            {
                return firstNumber;
            }
            public int ProgressDifference()
            {
                return step;
            }
            public int AnyNumberOfArithmeticProgress()
            {
                return firstNumber + step * (lastNumber - 1);
            }
            public int SumOfProgressNumbers()
            {
                return ((2 * firstNumber + step * (lastNumber - 1)) / 2) * lastNumber;
            }
            public int AveregeSumOfProgressNumbers()
            {
                return (2 * firstNumber + step * (lastNumber - 1)) / 2;
            }

        }

    }
}

