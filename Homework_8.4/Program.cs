using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Homework_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument();
            XElement people = new XElement("People");
            XElement persons = new XElement("Person");

            Console.Write("Введите ФИО человека: ");
            string UserFIO = Console.ReadLine();
            XAttribute xAttribute = new XAttribute("name", UserFIO);

            XElement Adress = new XElement("Adress", "Адрес");

            Console.Write("\nВведите улицу человека: ");
            string UserStreet = Console.ReadLine();
            XElement Street = new XElement("Street", UserStreet);

            Console.Write("\nВведите номер дома человека: ");
            int UserHouseNumber = int.Parse(Console.ReadLine());
            XElement HouseNumber = new XElement("HouseNumber", UserHouseNumber);


            Console.Write("\nВведите номер квартиры человека: ");
            string UserFlatNumber = Console.ReadLine();
            XElement FlatNumber = new XElement("FlatNumber", UserFlatNumber);

            XElement Phones = new XElement("Phones", "Телефоны");

            Console.Write("\nВведите номер мобильного телефона: ");
            string UserMobilePhone = Console.ReadLine();
            XElement MobilePhone = new XElement("MobilePhone", UserMobilePhone);

            Console.Write("\nВведите номер домашнего телефон: ");
            string UserFlatPhone = Console.ReadLine();
            XElement FlatPhone = new XElement("FlatPhone", UserFlatPhone);

            persons.Add(xAttribute);
            persons.Add(Adress);
            Adress.Add(Street);
            Adress.Add(HouseNumber);
            Adress.Add(FlatNumber);
            persons.Add(Phones);
            Phones.Add(MobilePhone);
            Phones.Add(FlatPhone);

            people.Add(persons);
            xDoc.Add(people);
            xDoc.Save("people.xml");

            Console.WriteLine("Данные сохранены.");
            Console.ReadKey();
        }
    }
}
