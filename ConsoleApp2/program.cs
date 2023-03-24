using System;

// Базовый класс Человек
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    // Конструктор класса
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

// Наследник класса Человек - Работник
class Employee : Person
{
    public string Position { get; set; }

    // Конструктор класса
    public Employee(string name, int age, string gender, string position)
        : base(name, age, gender)
    {
        Position = position;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры классов
        Person person = new Person("Иван", 30, "мужской");
        Employee employee = new Employee("Петр", 25, "мужской", "менеджер");

        // Выводим значения свойств объектов
        Console.WriteLine("Человек:");
        Console.WriteLine($"Имя: {person.Name}");
        Console.WriteLine($"Возраст: {person.Age}");
        Console.WriteLine($"Пол: {person.Gender}");

        Console.WriteLine();

        Console.WriteLine("Работник:");
        Console.WriteLine($"Имя: {employee.Name}");
        Console.WriteLine($"Возраст: {employee.Age}");
        Console.WriteLine($"Пол: {employee.Gender}");
        Console.WriteLine($"Должность: {employee.Position}");

        Console.ReadKey();
    }
}