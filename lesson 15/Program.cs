using lesson_15;
using System.Xml.Schema;

Console.WriteLine("Fun with Records!");

//используем инициализацию обьекта
Car myCar = new Car
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car:");
DisplayCarStats(myCar);
Console.WriteLine();

//использовать специальный конструктор 
Car anotherMyCar = new Car("Honda", "Pilot", "Blue");
Console.WriteLine("Another cariable for my car:");
DisplayCarStats(anotherMyCar);
Console.WriteLine();

//попытка тзменения свойства приводит к ошибке на этапе компиляции
//myCar.Color = "Red";

Console.ReadLine();

static void DisplayCarStats(Car c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

Console.ReadLine();

Console.WriteLine("********RECORDS***********");

CarRecord myCarRecord = new CarRecord
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();

//используем специальный конструктор
CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car:");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();

//попытка тзменения свойства приводит к ошибке на этапе компиляции
//myCarRecord.Color = "Red"; 

static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

Console.WriteLine($"Cars are the same reference?{ReferenceEquals(myCar, anotherMyCar)}"); //указывает ли на один и тот же обьект?

Console.ReadLine();

Console.WriteLine($"CarRecords are the smae?{myCarRecord.Equals(anotherMyCarRecord)}"); //экваивалентны СarRecord?
Console.WriteLine($"CarRecords are th same reference?{ReferenceEquals(myCarRecord, anotherMyCarRecord)}"); // указывают на один и тот же обьект?
Console.WriteLine($"CarRecords are the same? {myCarRecord == anotherMyCarRecord}");
Console.WriteLine($"CarRecords are not the same?{myCarRecord != anotherMyCarRecord}");

Console.ReadLine(  );