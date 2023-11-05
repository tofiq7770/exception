using Exception;
using Exception.Exceptions;


//Repository<Person> data = new Repository<Person>();

//data.Add(new Person { Age = 19, Name = "Tofiq", Surname = "Nasibli", Id = 1 });
//data.Add(new Person { Age = 18, Name = "Ali", Surname = "Huseynov", Id = 19 });
//data.Add(new Person { Age = 20, Name = "Ali", Surname = "Shukurlu", Id = 7 });


//Task1

//Person[] datas = data.GetById(19);
//foreach (Person person in datas)
//{
//    Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
//}


//Task2
//Person[] datas = data.Delete(1);
//foreach(Person person in datas)
//{
//    Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
//}



////Task3
//static void CalculateFactorial(int n)
//{
//    try
//    {
//        if (n < 0)
//        {
//            throw new OperationExceptions("Input must be a non-negative integer.");
//        }

//        int factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }

//        Console.WriteLine("Factorial: " + factorial);
//    }
//    catch (OperationExceptions ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);
//    }
//}


//int a =int.Parse(Console.ReadLine());
//CalculateFactorial(a);