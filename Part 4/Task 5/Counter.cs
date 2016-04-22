using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Counter
    {

        public static int count(Rectangle rectangle1 , Rectangle rectangle2) // rectangle1 это будет большой прямоугольник, в котором нужно найти количество маленьких прямоугольникол
        {                                                                   // rectangle2 будет маленький прямоугольник

            int amount = 0; //Переменная для подсчета количества возможных маленьких прямоугольников

            int amountAAside = rectangle1.a / rectangle2.a; //сразу проверяем сколько целых кусков одной стороны маленького прямоугольник может войти в сторону большого прямоугольника
            int amountBBside = rectangle1.b / rectangle2.b;
            int amountXX = (amountAAside * amountBBside);// Количество прямоугольников в одном положении

            int amountABside = rectangle1.a / rectangle2.b; //потом проверяем сколько целых кусков одной стороны маленького прямоугольник может войти в другую сторону большого прямоугольника
            int amountBAside = rectangle1.b / rectangle2.a;
            int amountYY = (amountABside * amountBAside);// Количество прямоугольников в другом положении

            //Маленький прямоугольник можно расположить по разному, поэтому все расчеты выше и велись, чтобы узнать как много можно маленьких прямоугольников может содержаться в большом

            if (amountXX > amountYY)//Выбираем наибольшее количество
            {
                amount = amountXX;
            }
            else
            {
                amount = amountYY;
            }

            return amount;

        }
       

    }
}
