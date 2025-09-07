using Assignment.Files;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starting Sunday 8 am  < status صدمة من طول الاسساينمينت :( > 
            #region Load Data And Test Steps
            // Step 01: Get Folder Files From Drive To This Project 
            // Step 02: Change Namespace of classes [Product, Order, Customer,ListGenerator]
            // Step 03: Check Files Found That You Don't Need Data subfolder because Classes are exist in Static Class ListGenerator
            // Step 04: Check ListGenerator File Found That CustomerList Load list from xml file
            // Step 05: Loading data using XDocument.Load("Customers.xml") So this is require file in this path bin/Debug/net9.0/data.xml
            // Step 06:
            //      Method 1 To Solve Copy File To This Path By Yourself
            //      Method 2 RightClick On File Then Prosperities Then
            //          Build Action => Content
            //          Copy to Output Directory => Always Copy or Copy if Newer
            //          But Customers.xml Must Be With Program.cs File :(
            //          Or Use Files/Customers.xml with XDocument.Load() (relative path)
            // Step 07: Test Get Customer List status (Ok)
            List<Customer> CustomersList = ListGenerator.CustomersList;

            //foreach (var customer in CustomersList)
            //{
            //    Console.WriteLine(customer);
            //}

            // Step 08: Test Get Product List status (Ok)
            List<Product> ProductsList = ListGenerator.ProductsList;
            //foreach (var product in ProductsList)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Part 01: LINQ - Restriction Operators

            #region Q1:Find all products that are out of stock.

            var ProductsOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //foreach (var item in ProductsOutOfStock)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2: Find all products that are in stock and cost more than 3.00 per unit.

            var ProductsInStockWithCostMoreThan3 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            //foreach (var item in ProductsInStockWithCostMoreThan3)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3: Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //// assume that this array is always sorted so the value the same as the index
            //List<string> newArr = new List<string>();
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if(Arr[i].Length < i)
            //    {
            //        newArr.Add(Arr[i]);
            //    }
            //}
            //Console.WriteLine("New Array");
            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Part 02: LINQ - Element Operators

            #region Q1: Get first Product out of Stock 

            //var FirstOutOfStockProduct = ProductsList.First(p => p.UnitsInStock == 0);
            var FirstOutOfStockProduct = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(FirstOutOfStockProduct);

            #endregion

            #region Q2: Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var FirstPriceMoreThan1000 = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000); // defualt is null if not exist
                                                                                               //Console.WriteLine(FirstPriceMoreThan1000 is null ? "Not Found" : FirstPriceMoreThan1000);
            #endregion

            #region Q3: Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int? num = null;
            // Method 1
            //bool foundBefore = false;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (foundBefore && Arr[i] > 5) // i put foundBefore first to use short-circuit evalution
            //    {
            //        num = Arr[i]; 
            //        break;
            //    }
            //    if (Arr[i] > 5)
            //    {
            //        foundBefore = true;
            //    }
            //}
            //Console.WriteLine(num is null ? "Not Found" : num);

            //Method 2

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (Arr[i] > 5)
            //    {
            //        for (int j = i + 1; j < Arr.Length; j++)
            //        {
            //            if (Arr[j] > 5)
            //            {
            //                Console.WriteLine(Arr[j]);
            //                num = Arr[j]; 
            //                break;
            //            }
            //        }
            //        break;
            //    }
            //}
            //Console.WriteLine(num is null ? "Not Found" : num);

            #endregion

            #endregion

            #region Part 03: LINQ - Aggregate Operators

            #region Q1: Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int OddNumbersCount = Arr.Count(i => i % 2 != 0);

            //Console.WriteLine(OddNumbersCount);

            #endregion

            #region Q2:Return a list of customers and how many orders each has.

            //var CustomersWithOrderNumber = CustomersList.Select(c => new
            //{
            //    Customer = c,
            //    OrderNumber = c.Orders.Count()
            //}).ToList();

            //foreach (var Customer in CustomersWithOrderNumber)
            //{
            //    Console.WriteLine($"Customer Name: {Customer.Customer.CustomerName}, Order Count: {Customer.OrderNumber}");
            //}

            #endregion

            #region Q3: Return a list of categories and how many products each has

            //var CategoriesList = ProductsList.Select(p => new { 
            //    Name = p.Category, 
            //    Products = ProductsList.Count(p2 => p2.Category == p.Category)
            //}).Distinct().ToList();

            //foreach (var category in CategoriesList)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Q4: Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int sum = 0;
            //foreach(var i in  Arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Total {sum}");

            #endregion

            #region Q5: Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //// Method 1
            ////string text = File.ReadAllText("dictionary_english.txt");
            //string text = File.ReadAllText("Files/dictionary_english.txt");
            //Console.WriteLine(text.Length);

            // Method 2 : (Read dictionary_english.txt into Array of String First)
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //int length = 0;
            //foreach (string line in lines)
            //{

            //    length += line.Length;
            //}
            //Console.WriteLine(length);

            // method 3
            //int length2 = 0;
            //foreach (string line in File.ReadLines("Files/dictionary_english.txt"))
            //{
            //    length2 += line.Length;
            //}
            //Console.WriteLine(length2);

            // Method 4
            //int charCount = 0;

            //using (StreamReader reader = new StreamReader("dictionary_english.txt"))
            //{
            //    int currentChar;
            //    while ((currentChar = reader.Read()) != -1)
            //    {
            //        charCount++;
            //    }
            //}

            //Console.WriteLine($"Number of characters: {charCount}");


            // Method 1 & 4 : 4234884:counts everything, including \r\n (2 chars on Windows).
            // Method 2 & 3 : 3494688:drop the newline characters.

            #endregion

            #region Q6: Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //string[] lines = File.ReadAllLines("Files/dictionary_english.txt");
            //string shortestString = lines[0];
            //for (int i = 1;i <lines.Length;i++)
            //{
            //    if(shortestString.Length > lines[i].Length)
            //    {
            //        shortestString = lines[i];
            //    }
            //}
            //Console.WriteLine(shortestString);

            #endregion

            #region Q7: Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("Files/dictionary_english.txt");
            //string longestString = lines[0];
            //for (int i = 1; i < lines.Length; i++)
            //{
            //    if (longestString.Length < lines[i].Length)
            //    {
            //        longestString = lines[i];
            //    }
            //}
            //Console.WriteLine(longestString);

            #endregion

            #region Q8: Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) 

            //string[] lines = File.ReadAllLines("Files/dictionary_english.txt");

            ////avg = total/count
            //int count = lines.Length;
            //int total = 0;

            //foreach (string line in lines)
            //{
            //    total += line.Length;
            //}
            //double avg = total*1.0 / count;

            //Console.WriteLine($"Avg = {total} / {count} = {avg}");

            #endregion

            #endregion

            #region Part 04: LINQ - Ordering Operators

            #region Q1: Sort a list of products by name

            //var SortedProductsByNameASC = ProductsList.OrderBy(p => p.ProductName).ToList();
            //var SortedProductsByNameDESC = ProductsList.OrderByDescending(p => p.ProductName).ToList();

            //foreach(var Product in SortedProductsByNameDESC)
            //{
            //    Console.WriteLine(Product);
            //}

            //foreach(var Product in SortedProductsByNameASC)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion

            #region Q2: Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr, new StringLengthCaseInsensitiveComparer());

            //foreach (string str in Arr)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion

            #region Q3: Sort a list of products by units in stock from highest to lowest.

            //var SortedProductsByStockDesc = ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();

            //foreach(var p in SortedProductsByStockDesc)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Q4: Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //Array.Sort(Arr,new StringLengthAlphaComparerSensitive());

            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5:Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr, new StringLengthAlphaComparerInsensitive());

            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q6: Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var SortedProductsByCatThenByPriceDesc = ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in SortedProductsByCatThenByPriceDesc)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7: Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr, new StringLengthThenByCaseInsensitiveComparer());

            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q8: Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //string[] newArr = Arr
            //    .Where(a => a.Length > 1 && a[1] == 'i')
            //    //.Reverse()
            //    .ToArray();
            //string[] reversedArray = new string[newArr.Length];

            //for(int i = reversedArray.Length - 1; i >= 0; i--)
            //{
            //    reversedArray[reversedArray.Length - 1 - i] = newArr[i];
            //}
            //Console.WriteLine("----------------before");
            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------After");

            //foreach (string str in reversedArray)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion

            #endregion

            #region Part 05: LINQ – Transformation Operators

            #region Q1: Return a sequence of just the names of a list of products.

            //var ProductSequenceNames = ProductsList.Select(p => p.ProductName).ToList();

            //foreach (var item in ProductSequenceNames)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2: Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var WordSequencedNamesWithVersions = words.Select(p => new
            //{
            //    OriginalName = p,
            //    UppercaseName = p.ToUpper(),
            //    LowercaseName = p.ToLower()
            //}).ToArray();
            //foreach (var item in WordSequencedNamesWithVersions)
            //{
            //    Console.WriteLine(item);
            //}


            //var ProductSequencedNamesWithVersions = ProductsList.Select(p => new
            //{
            //    OriginalName = p.ProductName,
            //    UppercaseName = p.ProductName.ToUpper(),
            //    LowercaseName = p.ProductName.ToLower()
            //}).ToList();

            //foreach (var item in ProductSequencedNamesWithVersions)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3: Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var ProductSequence = ProductsList.Select(p => new
            //{
            //    Price = p.UnitPrice,
            //    p.ProductName,
            //    p.UnitsInStock,

            //}).ToList();
            //ProductSequence.ForEach(p =>
            //{
            //    Console.WriteLine(p);
            //});

            #endregion

            #region Q4: Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Console.WriteLine("Number In Place?");
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine($"{Arr[i]} : {(i == Arr[i] ? "true" : "false")}");
            //}

            #endregion

            #region Q5: Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //Console.WriteLine("Numbers where a < b");
            //for (int i = 0; i < numbersA.Length; i++)
            //{
            //    for (int j = 0; j < numbersB.Length; j++)
            //    {
            //        if (numbersA[i] < numbersB[j])
            //            Console.WriteLine($"{numbersA[i]} is less than {numbersB[j]}");
            //    }
            //}

            #endregion

            #region Q6: Select all orders where the order total is less than 500.00.

            //var ordersWhereTotalLessThan500 = CustomersList.Select(c => new {
            //    Orders = c.Orders.Where(o => o.Total < 500)
            //});

            //foreach (var item in ordersWhereTotalLessThan500)
            //{
            //    foreach (var item1 in item.Orders)
            //    {
            //        Console.WriteLine(item1.Total);
            //    }
            //}

            #endregion

            #region Q7:  Select all orders where the order was made in 1998 or later.

            //var ordersWhereTotalLessThan500 = CustomersList.Select(c => new
            //{
            //    Orders = c.Orders.Where(o => o.OrderDate.Year >= 1998)
            //});

            //foreach (var item in ordersWhereTotalLessThan500)
            //{
            //    foreach (var item1 in item.Orders)
            //    {
            //        Console.WriteLine(item1.OrderDate.Year);
            //    }
            //}

            #endregion

            #endregion

            // End Sunday 11:10 am < status ظهر مكسر :((((  >
        }
    }

}

