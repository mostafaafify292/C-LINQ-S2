using System.Xml.Linq;
using static C__LINQ_S2.ListGenerator;
namespace C__LINQ_S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Transformation (Select & Select Many)
            //var result = productsList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = productsList.Where(p => p.UnitsInStock == 0)
            //                         .Select((p, i) => $"{i} :::: {p.ProductName} ::: {p.UnitsInStock}");

            //var result = customersList.SelectMany(c => c.Orders);

            //var result = productsList.Select(p => new {id = p.ProductID , name = p.ProductName});

            //var discountedList = productsList.Where(p => p.UnitsInStock > 0)
            //                                 .Select((p,i) => new 
            //                                 {   
            //                                     p.ProductID,
            //                                     p.ProductName,
            //                                     p.UnitsInStock,
            //                                     p.UnitPrice,
            //                                     newprice =p.UnitPrice -  p.UnitPrice  * 10/100 
            //                                 });

            //var result = customersList.SelectMany(c => c.Orders, (c, order ) => new {c.CustomerName, order });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = productsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = productsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result?.ProductName ?? "Null");
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Array.Sort(Arr);
            //var result = Arr.First(n => n > 5);
            //Console.WriteLine(result);

            #endregion

            #endregion
            #region LINQ - Aggregate Operators
            //string filepath = "dictionary_english.txt";
            //string[] data = File.ReadAllLines(filepath);
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(result);

            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var result = customersList.Select(c => new {name = c.CustomerName , countOfOrders = c.Orders.Count()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Return a list of categories and how many products each has
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Select(g => new {name = g.Key ,count = g.Count()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result1 = data.Select(s => s.Length)
            //                  .Sum();
            //Console.WriteLine(result1);

            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = data.Where(s => !string.IsNullOrWhiteSpace(s))
            //    .Min(s => s.Length);
            //Console.WriteLine(result);
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = data.Where(s => !string.IsNullOrWhiteSpace(s))
            //    .Max(s => s.Length);
            //Console.WriteLine(result);
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = data.Average(s =>s.Length);
            //Console.WriteLine(result);

            #endregion
            #region 9. Get the total units in stock for each product category.
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Select(g => new
            //                         {
            //                             category = g.Key,
            //                             totalUnitsInStock = g.Sum(c => c.UnitsInStock)
            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 10. Get the cheapest price among each category's products
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Select(s => new
            //                         {
            //                             cataegory = s.Key,
            //                             cheapestPrice = s.Min(m => m.UnitPrice)
            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in productsList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 CheapestProducts = g.Where(p => p.UnitPrice == cheapestPrice)
            //             };
            //Console.WriteLine("Cheapest Products by Category:");
            //foreach (var categoryGroup in result)
            //{
            //    Console.WriteLine($"{categoryGroup.Category}:");
            //    foreach (var product in categoryGroup.CheapestProducts)
            //    {
            //        Console.WriteLine($"  - {product.ProductName}: ${product.UnitPrice}");
            //    }
            //}
            #endregion
            #region 12. Get the most expensive price among each category's products.
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Select(s => new
            //                         {
            //                             category = s.Key,
            //                             mostExpensive = s.Max(m => m.UnitPrice)
            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 13. Get the products with the most expensive price in each category.
            //var result = productsList.GroupBy(p => p.Category)
            //                               .Select(g => new
            //                               {
            //                                   Category = g.Key,
            //                                   mostexpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //                               });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var product in item.mostexpensiveProducts)
            //    {
            //        Console.WriteLine($"{product.ProductName} :: {product.UnitPrice}");
            //    }
            //}

            #endregion
            #region 14. Get the average price of each category's products.
            //var result = productsList.GroupBy(g => g.Category)
            //                         .Select(c => new
            //                         {
            //                             category = c.Key,
            //                             AVGprice = c.Average(v => v.UnitPrice)
            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var result = productsList.Select(p => p.Category).Distinct();
            //foreach (var item in result   )
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = productsList.Select(p => p.ProductName[0] )
            //                         .Concat(customersList.Select(c => c.CustomerName[0]))
            //                         .Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = productsList.Select(p => p.ProductName[0])
            //                        .Intersect(customersList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = productsList.Select(p => p.ProductName[0])
            //                         .Except(customersList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = productsList
            //    .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName  )
            //    .Concat(customersList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string filepath = "dictionary_english.txt";
            //string[] dataArr = File.ReadAllLines(filepath);
            //var result = dataArr.Any(s => s.Contains("ei"));
            //Console.WriteLine(result);
            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Where(g => g.Any(c => c.UnitsInStock == 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"\n               ((((({item.Key})))))\n");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"NameOfProduct : {item1.ProductName} , UnitInStock : {item1.UnitsInStock}");
            //    }
            //}
            #endregion
            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = productsList.GroupBy(p => p.Category)
            //                         .Where(g => g.All(p => p.UnitsInStock != 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"\n               ((((({item.Key})))))\n");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"NameOfProduct : {item1.ProductName} , UnitInStock : {item1.UnitsInStock}");
            //    }
            //}
            #endregion
            #endregion




        }
    }
}
