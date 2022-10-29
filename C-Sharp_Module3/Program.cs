using System;

namespace C_Sharp_Module3
{
    internal class Program
    {
        ////Завдання 5
        ////Створіть клас «Журнал». Необхідно зберігати у полях
        ////класу: назву журналу, рік заснування, опис журналу,
        ////контактний телефон, email.Реалізуйте методи класу для
        ////введення даних, виведення даних.Реалізуйте доступ до
        ////окремих полів через методи класу.

        class Journal
        {
            //Назва журналу
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 35)
                        name = value;
                    else
                        name = "No name";
                }
            }
            //Рік заснування журналу
            private int year;
            public int Year
            {
                get { return year; }
                set
                {
                    if (value <= DateTime.Now.Year)
                        year = value;
                    else
                        year = -1;

                }
            }
            //Опис журналу
            public string description { set; get; } = "no description";
            //Контактний телефон
            private string phoneNum;
            public string PhoneNum { get { return phoneNum; } }
            //Контактнийe email
            public string email { set; get; }

            ////Коструктор без параметрів
            public Journal()
            {
                name = "No name";
                year = -1;
                description = "empty";
                phoneNum = "empty";
                email = "empty";
            }
            ////Конструктор з параметрами 
            public Journal(string name, int year, string description, string phoneNum, string email)
            {
                Name = name;
                Year = year;
                this.description = description;
                setPhoneNum(phoneNum);
                this.email = email;
            }
            public Journal(string name, int year, string description, string phoneNum)
            {
                Name = name;
                Year = year;
                this.description = description;
                setPhoneNum(phoneNum);
            }
            public Journal(string name, int year, string description)
            {
                Name = name;
                Year = year;
                this.description = description;
            }
            public Journal(string name, int year)
            {
                Name = name;
                Year = year;
            }
            public Journal(string name)
            {
                Name = name;
            }

            //Метод друку інформації про Журнал
            public void print()
            {
                Console.WriteLine($"Назва журналу: {name}");
                Console.WriteLine($"Рiк заснування журналу: {year}");
                Console.WriteLine($"Опис журналу: {description}");
                Console.WriteLine($"Контактний номер: {phoneNum}");
                Console.WriteLine($"Електронна пошта: {email}");
            }

            //Сетери
            public void setYear(int year) { Year = year;}
            public void setDescr(string description) { this.description = description; }
            public void setPhoneNum(string pN)
            {
                phoneNum = "+";
                if (pN.Length == 12)
                    phoneNum += pN;
                else
                    phoneNum = "empty";
            }
            public void setEmail(string email) { this.email = email; }
        }

        static void Main(string[] args)
        {

            Journal journal1 = new Journal();
            journal1.print();

            Console.WriteLine();
            journal1.Name = "Закон & порядок";
            journal1.Year = 2022;
            journal1.setPhoneNum("380660232200");

            journal1.print();
            Console.WriteLine();

            Console.WriteLine(journal1.Name);
            Console.WriteLine(journal1.PhoneNum);

            Console.WriteLine("\n");
            Journal journal2 = new Journal("Огородник", 2019, "Про огород", "0990990099", "director@ogorod.ua");
            journal2.print();
            

        }
    }
}
