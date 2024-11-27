using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5C_
{
    internal class Journal
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;
        private int employeesCount;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int YearFounded
        {
            get => yearFounded;
            set => yearFounded = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string ContactPhone
        {
            get => contactPhone;
            set => contactPhone = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int EmployeesCount
        {
            get => employeesCount;
            set
            {
                if (value >= 0)
                    employeesCount = value;
                else
                    Console.WriteLine("Кількість працівників не може бути від’ємною.");
            }
        }

        public Journal(string name, int yearFounded, string description, string contactPhone, string email, int employeesCount)
        {
            this.name = name;
            this.yearFounded = yearFounded;
            this.description = description;
            this.contactPhone = contactPhone;
            this.email = email;
            this.employeesCount = employeesCount;
        }

        public void DisplayData()
        {
            Console.WriteLine($"\nНазва: {Name}");
            Console.WriteLine($"Рік заснування: {YearFounded}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Телефон: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Кількість працівників: {EmployeesCount}");
        }

        public static Journal operator +(Journal journal, int count)
        {
            journal.EmployeesCount += count;
            return journal;
        }

        public static Journal operator -(Journal journal, int count)
        {
            journal.EmployeesCount -= count;
            return journal;
        }

        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.EmployeesCount == j2.EmployeesCount;
        }

        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1.EmployeesCount != j2.EmployeesCount;
        }

        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.EmployeesCount < j2.EmployeesCount;
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.EmployeesCount > j2.EmployeesCount;
        }

        public static bool operator <=(Journal j1, Journal j2)
        {
            return j1.EmployeesCount <= j2.EmployeesCount;
        }

        public static bool operator >=(Journal j1, Journal j2)
        {
            return j1.EmployeesCount >= j2.EmployeesCount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Journal journal)
            {
                return EmployeesCount == journal.EmployeesCount;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmployeesCount.GetHashCode();
        }
    }
}
