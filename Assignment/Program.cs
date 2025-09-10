using Day_01_G03;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Load Data
            var CustomerList = ListGenerator.CustomersList;

            var ProductList = ListGenerator.ProductsList;

            var DictionaryLines = File.ReadLines("Files/dictionary_english.txt");
            #endregion

            #region LINQ - Aggregate Operators

            #region Q1:Get the total units in stock for each product category.
            //var query = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Cat = g.Key,
            //    UnitsInStock = g.Sum(p => p.UnitsInStock)
            //});
            #endregion

            #region Q2:Get the cheapest price among each category's products
            //var query = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Cat = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice),
            //});
            #endregion


            #region Q4:Get the most expensive price among each category's products.
            //var query = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Cat = g.Key,
            //    MostPrice = g.Max(p => p.UnitPrice),
            //});
            #endregion

            #region Q5:Get the products with the most expensive price in each category.
            //var query = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Cat = g.Key,
            //    Product = g.FirstOrDefault(p => p.UnitPrice == g.Max(p => p.UnitPrice)),
            //});

            //var query =
            //    from p in ProductList
            //    group p by p.Category into g
            //    let maxPrice = g.Max(p => p.UnitPrice)
            //    select new
            //    {
            //        Cat = g.Key,
            //        Product = g.FirstOrDefault(p => p.UnitPrice == maxPrice)
            //    };
            #endregion

            #region Q6:Get the average price of each category's products.
            //var query = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Cat = g.Key,
            //    AvgPrice = g.Average(p => p.UnitPrice),
            //});
            #endregion

            #endregion

            #region LINQ - Set Operators

            #region Q1:Find the unique Category names from Product List
            //var query = ProductList.Select(p => p.Category).Distinct();
            #endregion

            #region Q2:Produce a Sequence containing the unique first letter from both product and customer names.
            //var a = ProductList.Select(p => p.ProductName[0]).Distinct();
            //var b = CustomerList.Select(c => c.CustomerName[0]).Distinct();

            //var query = a.Union(b);
            #endregion

            #region Q3:Create one sequence that contains the common first letter from both product and customer names.
            //var a = ProductList.Select(p => p.ProductName[0]);

            //var b = CustomerList.Select(c => c.CustomerName[0]);

            //var query = a.Intersect(b);
            #endregion

            #region Q4:Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var a = ProductList.Select(p => p.ProductName[0]);

            //var b = CustomerList.Select(c => c.CustomerName[0]);

            //var query = a.Except(b);
            #endregion

            #region Q5:Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var a = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 1 - 3,3) : p.ProductName);

            //var b = CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 1 - 3, 3) : c.CustomerName);

            //var query = a.Concat(b);
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region Q1:Get the first 3 orders from customers in Washington

            //var query = CustomerList
            //    .Where(c => c.Address.Contains("Washington"))
            //    .SelectMany(c => c.Orders)
            //    .Take(3);
            //var query =
            //    (from c in CustomerList
            //    where c.Address.Contains("Washington")
            //    from o in c.Orders
            //    select o).Take(3);
            #endregion

            #region Q2:Get all but the first 2 orders from customers in Washington.
            //var query = CustomerList
            //    .Where(c => c.Address.Contains("Washington"))
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);
            //var query =
            //    (from c in CustomerList
            //    where c.Address.Contains("Washington")
            //    from o in c.Orders
            //select o).Skip(2);
            #endregion

            #region Q3:Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var query = numbers.TakeWhile((n,i) => n < i);
            #endregion

            #region Q4:Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var query = numbers.SkipWhile(n => n % 3 != 0);

            #endregion

            #region Q5:Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var query = numbers.SkipWhile((n, i) => n >= i);
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region Q1:Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var found = DictionaryLines.Any(l => l.Contains("ei"));
            //Console.WriteLine(found);
            #endregion

            #region Q2:Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var query = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            #endregion

            #region Q3:Return a grouped a list of products only for categories that have all of their products in stock.
            //var query = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region Q1:Use group by to partition a list of numbers by their remainder when divided by 5
            //var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var query = numbers.GroupBy(n => n % 5);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Numbers With Remainder of {item.Key} when divided by 5");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            #endregion

            #region Q2:Uses group by to partition a list of words by their first letter.(Use dictionary_english.txt for Input)

            //var query = DictionaryLines.GroupBy(l => l[0]);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"--------------{item.Key}----------");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion

            #region Q3:Use Group By with a custom comparer that matches words that are consists of the same Characters Together(Consider this Array as an Input)
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form","frmo","lsta" };

            //var query = Arr.GroupBy(s => s, new StringComparer());
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"--------------{item.Key}----------");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion

            #endregion

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Key);
            //}
        }
    }
}
