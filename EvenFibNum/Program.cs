/*
Программа с помощью цикла for расчитывает первые 40 чисел Фиббоначчи 
Затем с помощью другого цикла for выбирает лишь четные числа Фиббоначчи
Проверяет их на соответствие условию [число]<4000000
И считает их сумму

Alex Kuripko 
    2020
  */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var allFibNum = new List<int>();
            var sum = 0;
            var startit = 1; //Стартовый член последовательности Фиббоначчи
            var secit = 2;  //Второй член последовательности Фиббоначчи
            var temp = 0;   //Временная переменная для нового члена последовательности
            allFibNum.Add(1); //Добаление в список членов последовательности стартовых членов
            allFibNum.Add(2); //Добаление в список членов последовательности стартовых членов
            for (int i = 1; i < 40; i++)
            {
                //Цикл для вычесления новых членов последовательности
                temp = startit + secit; //Новый член 
                startit = secit; //Теперь стартовый член равен второму
                secit = temp;    //Второй член равен новому числу
                allFibNum.Add(temp); //Добавление нового члена в список

            }
            for(int j = 0; j < allFibNum.Count; j++)
            {
                //Цикл который проходит по всем членам последовательности
                if (allFibNum[j] % 2 == 0)
                {
                    //Цикл определения четности члена 
                    var evenfib = allFibNum[j]; //Берем j член из списка 
                    if (evenfib <= 4000000)
                    {
                        //Проверяем меньше ли наш ЧЛЕН условия
                        sum += evenfib;//Суммируем члены последовательности

                    }
                    else
                    {
                        //Если число Больше условия - выходим из цикла
                        break;
                    }
                }
            }
            Console.WriteLine(sum);// Выводим в консоль Сумму
            Console.ReadKey();
        }
    }
}
