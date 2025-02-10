using System.Net.NetworkInformation;
using System.Threading;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Numerics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Runtime.Intrinsics.X86;

namespace C43_G05_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initially before talking about LINQ
            // -- there three topics we will talking about them

            // 1- implicitly typed local variables :
            // var keyword , it's a shortcut to declare a variable without specifying its type
            // dynamic keyword , it's a shortcut to declare a variable without specifying its type

            // 2- anonymous types :
            // it's a shortcut to create a class without specifying its name


            // 3- Extention methods :
            // it's a way to add new methods to existing classes without modifying them



            // LINQ : Language Integrated Query 
            // it's a way to query data from different data sources like arrays, collections, databases, xml files, etc.
            // it's Extension methods and Lambda expressions Against Any Data [Data in Sequence]
            // at the category of LINQ we have 13 category every category have a set of operators
            // LINQ Operators Exists in Built-in class System.Linq.Enumerable

            // Sequence : 
            // Object from class that implement from Interfaces like  IEnumerable<T> can be used in LINQ Query
            // local Sequence : LINQ to Object , LINQ to XML
            // Remote Sequence  : LINQ TO EF CORE  

            //- LINQ shapes :   LINQ have a 3 shapes
            // Input Sequence -> LINQ Operators -> Output Sequence
            // Input Sequence -> LINQ Operators -> One Value
            //                -> LINQ Operators -> Output Sequence


            // LINQ Syntax :
            //1- Fluent Syntax :
            // use Linq Methods
            // 1.1 LINQ Operators as => class Member methods through class Enumerable

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = Enumerable.Where(n => n % 2 == 0);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //1.2 LINQ Operators as => Extension methods through Sequence [Recommended] 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //2- Query Syntax : it's like SQL Style

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var evenNumbers = from n in numbers
            //                  where n % 2 == 0
            //                  select n;
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // LINQ Excution ways :
            // 1- differed excution : it's excute the query when we iterate over the result , 10 Category
            //2- Immediate excution : it's excute the query when we call the method , 3 Category [Elements Operators,Casting Operators,Aggregate Operators]



            //Console.WriteLine(ListGenerator.ProductList[0]);
            //var result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}   


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Decumentation by Enhancements
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // LINQ Fundamentals Reference Guide

            //1.Prerequisites for LINQ
            //1.1 Implicitly Typed Local Variables
            //Concept:

            //var keyword: Declares variables with type inferred by compiler(static typing)

            //dynamic keyword: Bypasses static type checking(runtime resolution)

            //Key Differences:

            //var num = 10;        // Compiler infers int
            //dynamic dyn = 10;    // Type resolved at runtime
            //dyn = "string";      // Valid (dynamic can change type)
            //                     // num = "string";   // Compile error (var is strongly typed)



            //1.2 Anonymous Types
            //Concept:

            //objects without class definitions

            //Immutable, compiler-generated classes

            //Example:

            //var person = new
            //{
            //    Name = "John",
            //    Age = 30
            //};
            //Console.WriteLine(person.Name);  // "John"


            //1.3 Extension Methods
            //Concept:

            //Add methods to existing types without inheritance

            //Defined in static classes with this modifier

            //Example:

            //    public static class StringExtensions
            //{
            //    public static string Reverse(this string str)
            //    {
            //        return new string(str.Reverse().ToArray());
            //    }
            //}

            //string name = "Alice";
            //Console.WriteLine(name.Reverse());  // "ecilA"



            //2.LINQ Core Concepts

            //2.1 What is LINQ?
            //Language Integrated Query

            //Uniform query syntax for various data sources

            //Built on extension methods and lambda expressions

            //Data Sequence Types:

            //Local(Objects, XML)

            //Remote(Databases via EF Core)

            //2.2 LINQ Architecture
            //Three Processing Shapes:

            //Sequence → LINQ Operators → Sequence

            //Sequence → LINQ Operators → Single Value

            //Sequence → LINQ Operators → New Sequence

            //2.3 LINQ Syntax Styles
            //A.Fluent Syntax(Method Syntax)
            //Chainable extension methods

            //Full operator support

            //Example:
            //List<int> numbers = new() { 1, 2, 3, 4, 5 };
            //var evens = numbers
            //    .Where(n => n % 2 == 0)
            //    .OrderByDescending(n => n);


            //B.Query Syntax(SQL-like)
            //    Compiler - translated to method syntax

            //    Limited to supported keywords

            //    Example:


            //var evens = from n in numbers
            //  where n % 2 == 0
            //  orderby n descending
            //  select n;


            //2.4 Execution Modes
            //    Deferred Execution:

            //    Query executes when iterated

            //    Most operators(Where, Select, OrderBy)

            //    Immediate Execution:

            //    Query executes immediately

            //    Aggregates & conversion methods:


            //var count = numbers.Count();          // Single value
            //var list = numbers.ToList();          // Materialized list
            //var first = numbers.First();          // Element


            //3.Key LINQ Components
            //    3.1 Sequence Fundamentals
            //    Any IEnumerable<T> implementation

            //    LINQ operators process sequences lazily by default

            //    3.2 Operator Categories
            //    Category Examples    Execution
            //    Filtering   Where, OfType Deferred
            //    Projection Select, SelectMany  Deferred
            //    Ordering    OrderBy, ThenBy Deferred
            //    Aggregation Sum, Average, Count Immediate
            //    Conversion  ToList, ToDictionary Immediate
            //    Element First, Last, ElementAt  Immediate
            //    Set Distinct, Union, Intersect Deferred

            //4.Practical Examples
            //Deferred Execution Demo
            //var products = Product.GetProducts();
            //var query = products.Where(p => p.Price > 100);

            //products.Add(new Product { Price = 150 });  // Included in query!

            //foreach (var p in query)  // Query executes here
            //{
            //    Console.WriteLine(p.Name);
            //}


            //Immediate Execution Demo

            //var expensiveCount = products
            // .Count(p => p.Price > 100);  // Executes immediately

            //var topProduct = products
            //    .OrderByDescending(p => p.Price)
            //    .First();                   // Executes immediately


            //5.Best Practices
            //Prefer var for LINQ results

            //Use method syntax for complex queries

            //Materialize remote queries with ToList() / ToArray()

            //Understand deferred vs immediate execution

            //Combine query / method syntax when beneficial



            // Key Takeaways Table

                //Concept LINQ Benefit    Example Use Case
                //Extension Methods Enable LINQ method chaining Adding query operators
                //Anonymous Types Shape data without DTO classes Projections(select new { })
                //Deferred Execution  Optimize query execution timing Building complex queries
                //Lambda Expressions Enable inline query logic Where(p => p.Age > 18)













            // stack of progress at session topics

                    // 6- at 1:39:28 ended talking about Excution ways - started at 1:26:05
                    // 5- at 1:25:30 ended talking about LINQ Syntax - started at 1:13:33
                    // 4- at 1:13:30 ended talking about what is LINQ - started at 59:00
                    // 3- at 52:25 ended talking about Extention methods - started at 37:00
                    // 2- at 36:50 ended talking about anonymous types - started at 20:00
                    // 1- at 19:14 ended tolking about implicitly typed local variables

        }
    }
}
