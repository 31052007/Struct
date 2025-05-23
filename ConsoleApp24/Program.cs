using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        /// <summary>
        /// Описать структуру с полями ФИО втрое поле структруу группа 3 инофрматика 4 физика 5 историяю Создать масив или калекцию из Н обьякта даных структуры.Ввод данных осуществлять с клавиатуры. Свендение об обекто вывести в табличном виде в сдлучие отсутвие информации обьекта вывести сообщение об отсвтвие обьекта. Определить средний бал оценок по придмету от 5 оценок. Ввести следование об студентах у которых средний балл выше 4 и подсчитать их количества
        /// </summary>
        /// <param name="args"></param>
            static void Main()
            {
                Console.Write("Введите количество студентов: ");
                int n;
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Отсутствуют объекты.");
                    return;
                }

                Student[] students = new Student[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nСтудент #{i + 1}");

                    Console.Write("Введите ФИО: ");
                    string fio = Console.ReadLine();

                    Console.Write("Введите группу: ");
                    string group = Console.ReadLine();

                    List<int> informatics = ReadGrades("Информатика", 5);
                    List<int> physics = ReadGrades("Физика", 5);
                    List<int> history = ReadGrades("История", 5);

                    students[i] = new Student(fio, group, informatics, physics, history);
                }

                if (students.Length == 0)
                {
                    Console.WriteLine("Отсутствуют объекты.");
                    return;
                }

                // Вывод заголовка таблицы
                Console.WriteLine("\n{0,-25} | {1,-8} | {2,-10} | {3,-10} | {4,-10}",
                    "ФИО", "Группа", "Информатика", "Физика", "История");
                Console.WriteLine(new string('-', 70));

                foreach (var st in students)
                {
                    st.Display();
                }

                // Средний балл по предметам (по всем студентам и всем оценкам)
                double avgInf = AverageGradeAcrossStudents(students, s => s.InformaticsGrades);
                double avgPhys = AverageGradeAcrossStudents(students, s => s.PhysicsGrades);
                double avgHist = AverageGradeAcrossStudents(students, s => s.HistoryGrades);

                Console.WriteLine($"\nСредний балл по информатике: {avgInf:F2}");
                Console.WriteLine($"Средний балл по физике: {avgPhys:F2}");
                Console.WriteLine($"Средний балл по истории: {avgHist:F2}");

                // Студенты со средним баллом выше 4 по всем предметам
                Console.WriteLine("\nСтуденты со средним баллом выше 4 по всем предметам:");
                int countHigh = 0;
                foreach (var st in students)
                {
                    if (st.HasHighAverage())
                    {
                        Console.WriteLine($"{st.FullName} ({st.Group})");
                        countHigh++;
                    }
                }
                Console.WriteLine($"\nКоличество таких студентов: {countHigh}");
            Console.ReadKey();
            }

            static List<int> ReadGrades(string subject, int count)
            {
                List<int> grades = new List<int>();
                Console.WriteLine($"Введите {count} оценок по {subject} (от 0 до 5):");
                while (grades.Count < count)
                {
                    Console.Write($"Оценка {grades.Count + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 5)
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите целое число от 0 до 5.");
                    }
                }
                return grades;
            }

            static double AverageGradeAcrossStudents(Student[] students, Func<Student, List<int>> getGrades)
            {
                double sum = 0;
                int count = 0;
                foreach (var st in students)
                {
                    var grades = getGrades(st);
                    if (grades != null)
                    {
                        foreach (var g in grades)
                        {
                            sum += g;
                            count++;
                        }
                    }
                }
                return count > 0 ? sum / count : 0;
            }
        }
    }

