// See https://aka.ms/new-console-template for more information

using System.Collections;
using HashTable_Test1;

var ht = new HashTableTest(10);

ht.Add("John", "111-111-111");
ht.Add("Taylor", "222-222");
ht.Add("Krish", "333-333");
ht.Add("Mack", "444-444");
ht.Add("Den", "555-555");
ht.Add("Mike", "666-666");
ht.Add("John", "77-77");
ht.Add("Jack", "88-88-88");
ht.Add("Jimmy", "99-99");
ht.Add("Harry", "121-121");
ht.Add("Meet", "232-232");
ht.Add("Miraj", "454-454");
ht.Add("Milan", "567-567");

// Console.WriteLine(ht.Get("John"));
// Console.WriteLine(ht.Get("Jack"));
// Console.WriteLine(ht.Get("Jimmy"));

ht.Delete("Jack");
ht.Delete("Jack");
Console.WriteLine(ht.Get("Jack"));
Console.WriteLine(ht.Get("Den"));


Console.ReadLine();