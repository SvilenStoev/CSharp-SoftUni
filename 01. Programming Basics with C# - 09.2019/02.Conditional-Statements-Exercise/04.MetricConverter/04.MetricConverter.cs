//Да се напише програма, която преобразува разстояние между следните 3 мерни единици: mm, cm, m.Използвайте съответствията от таблицата по-долу:
//входна единица  изходна единица
//1 meter(m) 1000 millimeters(mm)
//1 meter(m) 100 centimeters(cm)
//Входните данни се състоят от три реда, въведени от потребителя:
//•	Първи ред: число за преобразуване - реално число
//•	Втори ред: входна мерна единица - текст
//•	Трети ред: изходна мерна единица(за резултата) - текст
//На конзолата да се отпечата резултатът от преобразуването на мерните единици форматиран до третия знак след десетичната запетая.

using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputValue = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "m" && outputUnit == "mm") //С две условности! &&
            {
                inputValue *= 1000;
            }
           
            if (inputUnit == "m" && outputUnit == "cm")
            {
                inputValue *= 100;
            }
            
            if (inputUnit == "mm" && outputUnit == "m")
            {
                inputValue /= 1000;
            }
           
            if (inputUnit == "mm" && outputUnit == "cm")
            {
                inputValue /= 10;
            }
           
            if (inputUnit == "cm" && outputUnit == "m")
            {
                inputValue /= 100;
            }
           
            if (inputUnit == "cm" && outputUnit == "mm")
            {
                inputValue *= 10;
            }
           
            Console.WriteLine($"{inputValue:f3}");

        }


    }
}

