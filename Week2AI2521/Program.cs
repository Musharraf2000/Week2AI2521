// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Week2AI2521;

Student s1 = new Student("Alice", 20, "CB12345");
Student s2 = new Student("Bob", 22, "CB67890");

s1.loginToLMS();
s2.loginToLMS();
s1.submitAssignment("OOP Assignment 1");
s2.submitAssignment("OOP Assignment 1");

Lecturer l1 = new Lecturer("Dr. Smith", 45, "L12345");
l1.loginToLMS();
l1.MarkAssignment("OOP Assignment 1", s1);
l1.MarkAssignment("OOP Assignment 1", s2);

