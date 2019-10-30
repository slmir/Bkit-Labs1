using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class ProgramLR2
    {
        static void Main(string[] args)
        {
            Console.Title = "Мирсонов Вячеслав РТ5-31Б";
            Rectangle obj1 = new Rectangle(10,20);//создание объекта класса Прямокгольник и передача введеных ранее параметров в конструктор
            Square obj2 = new Square(15);//создание объекта класса Квадрат и передача введеного ранее параметра в конструктор
            Circle obj3 = new Circle(20);//создание объекта класса Круг и передача введеного ранее параметра в конструктор
            Console.ForegroundColor = ConsoleColor.Green;
            obj1.Print();//вызов метода печати данных об объекте (выбранной геометрической фигуре)
            obj2.Print();//вызов метода печати данных об объекте (выбранной геометрической фигуре)           
            obj3.Print();//вызов метода печати данных об объекте (выбранной геометрической фигуре)           
            Console.ForegroundColor = ConsoleColor.Gray;    
            Console.ReadLine();
        }
    }
}
