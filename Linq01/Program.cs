using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Question 1: Get all products from the "Seafood" category. Print each product's name and price.
        {
            // var seafoodProducts = ListGenerator.ProductList
            //     .Where(p => p.Category == "Seafood");
            // 
            // foreach (var product in seafoodProducts)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 2: Get a list of only the product names from ProductList. Print each name.
        {
            // var productNames = ListGenerator.ProductList
            //     .Select(p => p.ProductName);
            // 
            // foreach (var name in productNames)
            // {
            //     Console.WriteLine(name);
            // }
        }
        #endregion

        #region Question 3: Sort all products by UnitPrice (ascending). Print each product's name and price.
        {
            // var sortedProducts = ListGenerator.ProductList
            //     .OrderBy(p => p.UnitPrice);
            // 
            // foreach (var product in sortedProducts)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 4: Get all products where UnitPrice is between 10 and 30
        {
            // var filteredProducts = ListGenerator.ProductList
            //     .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            // 
            // foreach (var product in filteredProducts)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 5: Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
        {
            // var products = ListGenerator.ProductList
            //     .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            // 
            // foreach (var product in products)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Category: {product.Category}, Stock: {product.UnitsInStock}");
            // }
        }
        #endregion

        #region Question 6: Create a new anonymous type with Name, Price, and StockStatus
        {
            // var result = ListGenerator.ProductList
            //     .Select(p => new {
            //         Name = p.ProductName,
            //         Price = p.UnitPrice,
            //         StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //     });
            // 
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            // }
        }
        #endregion

        #region Question 7: Print each product's name along with its position (1-based)
        {
            // var result = ListGenerator.ProductList
            //     .Select((p, index) => new { Position = index + 1, Name = p.ProductName });
            // 
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.Position}. {item.Name}");
            // }
        }
        #endregion

        #region Question 8: Sort ProductList by Category ascending, then UnitPrice descending
        {
            // var sorted = ListGenerator.ProductList
            //     .OrderBy(p => p.Category)
            //     .ThenByDescending(p => p.UnitPrice);
            // 
            // foreach (var product in sorted)
            // {
            //     Console.WriteLine($"Category: {product.Category}, Name: {product.ProductName}, Price: {product.UnitPrice}");
            // }
        }
        #endregion

        #region Question 9: Get all products from "Beverages" category, sorted by UnitsInStock descending
        {
            // var beverages = ListGenerator.ProductList
            //     .Where(p => p.Category == "Beverages")
            //     .OrderByDescending(p => p.UnitsInStock);
            // 
            // foreach (var product in beverages)
            // {
            //     Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            // }
        }
        #endregion

        #region Question 10: QUERY SYNTAX with compound from clause for orders in 1997 or later
        {
            // var orders = from c in ListGenerator.CustomerList
            //              from o in c.Orders
            //              where o.OrderDate >= new DateTime(1997, 1, 1)
            //              select new { c.CustomerID, o.OrderDate };
            // 
            // foreach (var order in orders)
            // {
            //     Console.WriteLine($"CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate.ToShortDateString()}");
            // }
        }
        #endregion

        #region Question 11: Show position number alongside ProductName (Indexed Select)
        {
            // var result = ListGenerator.ProductList
            //     .Select((p, index) => $"{index + 1}: {p.ProductName}");
            // 
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
        }
        #endregion

        #region Question 12: Sort first by word length, then case-insensitive sort
        {
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BIUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
        }
        #endregion

        #region Question 13: Create a list of all digits/words in the array whose second letter is 'i' reversed
        {
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BIUeBeRrY", "ClOvEr", "cHeRry" };

            //var filteredAndReversed = Arr
            //    .Where(w => w.Length > 1 && char.ToLower(w[1]) == 'i')
            //    .Reverse();

            //foreach (var word in filteredAndReversed)
            //{
            //    Console.WriteLine(word);
            //}
        }
        #endregion
    }
}