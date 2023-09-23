using System.Collections.Generic;

int[] numeros = new int[5] { 1, 2, 3, 4, 5 }; // Array de 5 elementos

int numero = numeros[0]; // 1

Console.WriteLine(numero);

foreach (int num in numeros)
{
    Console.WriteLine(num);
}

// listas
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 }; // Lista de 5 elementos
List<int> numbers2 = new List<int>() { 6, 7, 8, 9, 10 }; // Lista de 5 elementos
numbers.Add(10);
numbers.AddRange(numbers2);
Console.WriteLine(numbers.Count); // 10

List<Person> people = new List<Person>() {
    new Person() { Name = "Juan", Age = 20 },
    new Person() { Name = "Pedro", Age = 30 },
    new Person() { Name = "Maria", Age = 40 }
};

foreach (Person person in people)
{
    Console.WriteLine(person.Name);
}



class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}

class Man : Person {
    public string LastName { get; set; }
}
class Woman : Person {
    public string LastName { get; set; }
}