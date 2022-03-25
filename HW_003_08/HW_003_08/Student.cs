using System;
namespace HW_003_08
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string secondName;
        public int group;
        public int age;
        public int [][] evaluations = new int[3][];
        //public evaluations[0] = {};
        //public evaluations2[1];
        //public evaluations3[2];

        public Student()
        {
            Console.Write("Введите фамилию студента: ");
            this.lastName = Console.ReadLine();
            Console.Write(" ");
            Console.Write("Введите имя студента: ");
            this.firstName = Console.ReadLine();
            Console.Write(" ");
            Console.Write("Введите отчество студента: ");
            this.secondName = Console.ReadLine();
            Console.Write(" ");
            Console.Write("Введите номер группы студента: ");
            this.group = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");
            Console.Write("Введите возраст студента: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");
            Console.Write("Введите оценки студента по программированию: ");
            
            //this.evaluations[0] = Convert.ToInt32(Console.ReadLine());
            
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine($"ФИО: {this.lastName} {this.firstName} {this.secondName}");
            Console.WriteLine($"возраст: {this.age}");
            Console.WriteLine($"группа: {this.group}");
            Console.WriteLine("Позже будут добалены функции работы с оценками.");
            Console.WriteLine("_____________________");
                
        }
    }
}