using System;

// Класс "Транспортное средство"
class Vehicle
{
    // Свойства
    public string Name { get; private set; }
    public int MaxSpeed { get; private set; }

    // Конструктор
    public Vehicle(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
}

// Наследник класса "Транспортное средство" - "Политех-машина"
class PolitechCar : Vehicle
{
    // Конструктор
    public PolitechCar(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    // Метод
    public void PlayBadMusicLoudly()
    {
        Console.WriteLine($"\"{Name}\" играет <ААААААААААААААААААААА БУУУУУУУУУУУУММММММММММ БУУУУУУУУУУУУМ АААААААААААААААА> ");
    }
}

// Наследник класса "Транспортное средство" - "Самолёт"
class Plane : Vehicle
{
    // Конструктор
    public Plane(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    // Метод
    public void DustTheField()
    {
        Console.WriteLine($"\"{Name}\" опыляет поле!");
    }
}

// Наследник класса "Транспортное средство" - "Бетономешалка"
class ConcreteMixer : Vehicle
{
    // Конструктор
    public ConcreteMixer(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    // Метод
    public void MixConcrete()
    {
        Console.WriteLine($"\"{Name}\" мешает бетон! Хорошо, что не глину!");
    }
}

// Пример использования классов
class Program
{
    static void Main()
    {
        // Создание объектов
        PolitechCar car = new PolitechCar("Политех-машина", 100);
        Plane plane = new Plane("Самолёт", 800);
        ConcreteMixer mixer = new ConcreteMixer("Бетономешалка", 50);

        // Вызов методов
        car.PlayBadMusicLoudly();
        plane.DustTheField();
        mixer.MixConcrete();

        Console.ReadKey(true);
    }
}