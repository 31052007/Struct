using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    /// <summary>
    ///Описать структуру с полями ФИО втрое поле структруу группа третье инофрматика четвертое физика пятое история. Создать масив или калекцию из n обьякта даных структуры.Ввод данных осуществлять с клавиатуры. Свендение об обекто вывести в табличном виде в сдлучие отсутвие информации обьекта вывести сообщение об отсвтвие обьекта. Определить средний бал оценок по придмету от 5 оценок. Ввести следование об студентах у которых бал выше 4 и подсчитать их количества 
    /// </summary>
    struct Student
    {
        public string FullName;
        public string Group;
        public List<int> InformaticsGrades;
        public List<int> PhysicsGrades;
        public List<int> HistoryGrades;

        public Student(string fullName, string group, List<int> informatics, List<int> physics, List<int> history)
        {
            FullName = fullName;
            Group = group;
            InformaticsGrades = informatics;
            PhysicsGrades = physics;
            HistoryGrades = history;
        }

        public double GetAverage(List<int> grades)
        {
            if (grades == null || grades.Count == 0)
                return 0;
            double sum = 0;
            foreach (int g in grades)
                sum += g;
            return sum / grades.Count;
        }

        public void Display()
        {
            Console.WriteLine($"{FullName,-25} | {Group,-8} | {GetAverage(InformaticsGrades):F2,-10} | {GetAverage(PhysicsGrades):F2,-10} | {GetAverage(HistoryGrades):F2,-10}");
        }

        public bool HasHighAverage()
        {
            return GetAverage(InformaticsGrades) > 4 &&
                   GetAverage(PhysicsGrades) > 4 &&
                   GetAverage(HistoryGrades) > 4;
        }
    }
}


