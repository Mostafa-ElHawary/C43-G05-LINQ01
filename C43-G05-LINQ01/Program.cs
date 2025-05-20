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


            #region Implicitly - type local variable[var - dynamic]

            #endregion
            // ***************************************************
            #region anonymous type

            #endregion
            // ***************************************************
            #region Extention methods

            #endregion
            // ***************************************************
            #region What is LINQ

            #endregion
            // ***************************************************
            #region LINQ Syntax

            // ***************************************************
            //2.3 LINQ Syntax 
            // ***************************************************

            //A.Fluent Syntax(Method Syntax)
            //B.Query Syntax(SQL-like)

            // Fluent Syntax: 
            //Using LINQ Methods
            // 1.1 LINQ Operators as class member methods through class Enumerable
            // Ex:
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //var Result = Enumerable.Where(n => n % 2 == 0);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // 1.2 LINQ Operators as Extension methods through Sequence [Recommended]
            // Ex:
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //var Result = numbers.Where(n => n % 2 == 0);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            // Query Syntax(SQL-like):

            //    Compiler - translated to method syntax
            //    Limited to supported keywords
            //    Example:

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //var evens = from n in numbers
            //  where n % 2 == 0
            //  orderby n descending
            //  select n;
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region LINQ Excution Ways

            // ***************************************************
            //2.4 Execution  Ways
            // ***************************************************

            //  -Differed Excution: 10 Category / مش بيشتغل ف نفس اللحظة ال بعمل فيها call
            // -Immediate Excution: 3 Category / بيشتغل ف نفس الوقت ال بعمل في call[Elements Operators, Casting Operators, Aggregate

            //    Deferred Execution:Query executes when iterated

            //    Most operators(Where, Select, OrderBy)
            //   Example:

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var query = numbers.Where(n => n % 2 == 0);
            // numbers.AddRange(6, 5);  // Not executed yet
            //foreach (var number in query)  // Executes here
            //{
            //    Console.WriteLine(number);
            //}


            //    Immediate Execution:Query executes immediately
            //   Example:

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var query = numbers.Where(n => n % 2 == 0).Tolist();  // Immediate => Tolist is Immediate Casting Operator
            // numbers.AddRange(6, 5);  // Not executed yet
            //foreach (var number in query)  // Executes here
            //{
            //    Console.WriteLine(number);
            //}
            //    Aggregates & conversion methods:

            #endregion


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
