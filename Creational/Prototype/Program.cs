using Prototype;

var developer1 = new Developer
{
    Name = "John",
    Age = 27,
    Seniority = "Senior"
};

var developer2 = (Developer)developer1.Clone();
developer2.Name = "Jimmy";
developer2.Seniority = "Mid-level";

Console.WriteLine(developer1);
Console.WriteLine(developer2);

var manager1 = new Manager
{
    Name = "Fred",
    Age = 35,
    Salary = 120
};

var manager2 = (Manager)manager1.Clone();
manager2.Name = "Sandy";
manager2.Age = 30;
manager2.Salary = 157;

Console.WriteLine(manager1);
Console.WriteLine(manager2);

Console.ReadKey();