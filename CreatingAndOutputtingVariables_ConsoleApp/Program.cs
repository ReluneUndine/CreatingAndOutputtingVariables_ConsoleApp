using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndOutputtingVariables_ConsoleApp
{
    //   Задание: 1) объявить несколько переменных, которые будут хранить значения (Ф.И.О., возраст, Email, баллы по программированию,
    //               баллы по математике и баллы по физике) - необходимо присвоить им названия и типы;
    //            2) организовать форматированный вывод данных на экран

    internal class Program
    {
        static void Main(string[] args) /// Точка входа (приложение начинается тут)
        {
            /// Вариант 1. Использую каждый раз Console.WriteLine для вывода переменных

            string fullName = "Иванов Иван Иванович"; // Для строкового типа использую string, задаю произвольное ФИО
            Console.WriteLine("Ф.И.О.: " + fullName); // Вывожу в кавычках название переменной, затем значение

            byte age = 16; // Для численного типа (целое число) использую byte, 16 лет = 10 класс (может быть физика и др. предметы)
            Console.WriteLine("Возраст: " + age); 

            string email = "IvanIvanov@yandex.ru"; // Делаю Email по аналогии с ФИО
            Console.WriteLine("Email: " + email);

            double programmingGrades = 4.25; // Для числового типа с плавающей точкой использую double; пусть = (5+4+3+5)/4 = 4,25 
            Console.WriteLine("Баллы по программированию: " + programmingGrades);

            double mathGrades = 3.75; // Делаю другие баллы по аналогии с Баллами по программированию; пусть = (5+3+3+4)/4 = 3,75
            Console.WriteLine("Баллы по математике: " + mathGrades);

            double physicsGrades = 3.5; // пусть = (2+3+4+5)/4 = 3,5
            Console.WriteLine("Баллы по физике: " + physicsGrades);
            Console.ReadKey();

            
        }
    }
}
