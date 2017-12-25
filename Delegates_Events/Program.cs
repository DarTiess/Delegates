﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.	Игра «Автомобильные гонки»
Разработать игру "Автомобильные гонки" с использованием
 делегатов.
●	В игре использовать несколько типов автомобилей:
спортивные, легковые, грузовые и автобусы. 
●	Реализовать игру «Гонки». Принцип игры: Автомобили
двигаются от старта к финишу со скоростями,
которые изменяются в установленных пределах случайным
образом. 
Победителем считается автомобиль, пришедший к финишу
первым.

Рекомендации по выполнению работы
●	Разработать абстрактный класс «автомобиль» 
(класс Car). 
Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать).  
●	Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств. 
В классы автомобилей добавить необходимые события (например, финиш).
●	Класс игры должен производить запуск соревнований автомобилей, выводить 
сообщения о текущем положении автомобилей, выводить сообщение об автомобиле,
победившем в гонках. Создать делегаты, обеспечивающие вызов методов из классов 
автомобилей (например, выйти на старт, начать гонку).
●	Игра заканчивается, когда какой-то из автомобилей проехал определенное расстояние 
(старт в положении 0, финиш в положении 100). Уведомление об окончании гонки (прибытии какого-либо автомобиля на финиш) реализовать с помощью событий. 
2.	Изменение свойств объекта класса
Создать интерфейс, который уведомляет пользователя программы об изменении значений свойства в классе (в котором реализуется данный интерфейс). Сигнатура интерфейса:
interface iPropertychanged
{
event PropertyeventHandler Propertychanged;
}
Делегат имеет следующий вид:
public delegate void PropertyeventHandler
(object sender, PropertyeventArgs e);
где, в качестве дополнительного параметра (Property¬EventArgs) выступает имя изменённого свойства. В методе Main() проверить работоспособность созданного интерфейса.



*/
        }
    }
}
