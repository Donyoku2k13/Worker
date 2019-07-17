using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = new DateTime(2000, 3, 10);
            Person human = new Person();
            Console.WriteLine("Enter name :");
            human.Name = "Vasya";
            human.Surname = "Ivanov";
            human.Patronymic = "Ivanovich";
            Console.WriteLine(human.GetInfo());
            Console.WriteLine(human.GetAge());
            Console.ReadKey();

        }
    }

    class Person
    {
        private string name;
        private string surname;
        private string patronymic;
        private int birthYear;
        private long iin;

        public Person()
        {
            name = surname = patronymic = "Неизвестно";
            birthYear = 0;
            iin = 0;
        }

        public Person(int BirthYear, long IIN)
        {
            this.birthYear = BirthYear;
            this.iin = IIN;
        }

        public string GetInfo()
        {
            string str;
            str = name + " " + surname + " " + patronymic;
            return str;
        }
        public string GetInitials()
        {
            string str;
            str = surname + " " + name[0] + surname[0] + patronymic[0];
            return str;
        }
        public int GetAge()
        {
            int age = 0;

            age = DateTime.Today.Year - birthYear;

            return age;
        }



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }

        public long IIN
        {
            get
            {
                return iin;
            }
            set
            {
                iin = value;
            }

        }

        class Worker : Person
        {
            private DateTime employment_date;
            private String position;
            private int salary;

            public Worker()
            {
                GetInitials();
                GetAge();
                getEmployment();
                getPos();
            }
            public string Position
            {

                set
                {
                    position = value;
                }
            }
            public int Salary
            {

                set
                {
                    salary = value;
                }
            }

            public DateTime Employment_date
            {
                set { employment_date = value; }
            }

            public string getPos() { return position; }
            public int getSalary() { return salary; }
            public DateTime getEmployment() { return employment_date; }
        }
    }