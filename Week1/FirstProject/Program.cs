// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello from our first project");

// Data Types
// What is Staticaly typed language?
// You have to specify the type of variable or function you want to declare
// JavaScript
// == or ===
// var  name = "Nichole"
// C# 
string name = "Nichole";
// char only contains 1 letter
char singleChar = 'd';
int number = 10;
bool isTired = true;
double DicimilValue = 3.14;
float floatValue = 1.2f;


// Lists and Dictionaries
// Arrays and lists 
//1 Arrays are fixed lenght
string[] groceryList = new string[5];
// [null,null,null,null,null]
groceryList[1] = "Ham";
// [null,"Ham",null,null,null]

string[] groceryList2 = {"Carrots","Turkey","Bread","Milk"};
groceryList2[2] = "Ham";
Console.WriteLine(groceryList2[2]);


// Lists are variables lenght
List<int> NumberList = new List<int>();
// Add Number to List
NumberList.Add(3);
NumberList.Add(4);
NumberList.Add(5);
NumberList.Add(18);
NumberList.Add(56);
NumberList.Add(74);
NumberList.Add(99);
// Remove 
// this remove the value 18
NumberList.Remove(18);
// this removes the location index 3
NumberList.RemoveAt(3);
//               idx,Value
NumberList.Insert(4,55);

Console.WriteLine(NumberList);

foreach(int i in NumberList)
{
Console.WriteLine(i);
}


// Function

static void SayHello()
{
    Console.WriteLine("Hello C# Ninjas");
}
SayHello();

static string SayHi()
{
    return "Hello";
}

Console.WriteLine(SayHi());

//                parameters
static int DoMath(int a, int b)
{
    return a-b;
}
//                       arguments
Console.WriteLine(DoMath(100,80));
int answer = DoMath(70,35);
Console.WriteLine(answer);








