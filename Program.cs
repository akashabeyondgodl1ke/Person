using System;


class Program
{
    static void Main()
    {
        Person Anatoly = new Person("Анатолий", 32);
        Person Karl = new Person();

        Anatoly.talk();
        Karl.move();
    }
}


public class Person
{
    public string FullName;
    int Age;

    public void talk()
    {
        Console.WriteLine($"В данный момент говорит: {FullName}");
    }

    public void move()
    {
        Console.WriteLine($"В данный момент говорит: {FullName}");
    }

    public Person()
    {

    }

    public Person(string name, int age)
    {
        FullName = name;
        Age = age;
    }

}