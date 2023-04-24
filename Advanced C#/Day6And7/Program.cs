using Day6;
using System.Text.RegularExpressions;
using static Day6.ListGenerators;


#region Restriction Operators
Console.WriteLine("========================== (1) ==========================");

var R1 = ProductList.Where(p => p.UnitsInStock == 0);

foreach (var item in R1)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("========================= (2) ===========================");
var R2 = ProductList.Where(p => p.UnitPrice > 3);

foreach (var item in R2)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("========================= (3) ===========================");
string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


var digits = Arr.Where((digit, index) => digit.Length < index);

foreach (var x in digits)
{
    Console.WriteLine($"The digit {x} is shorter than its value.");
}
Console.ReadLine();
Console.Clear();

#endregion

# region Element Operators

Console.WriteLine("======================== (1) ==========================");
var R3 = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
Console.WriteLine(R3);
Console.ReadLine();
Console.Clear();

Console.WriteLine("========================== (2) ======================");
var R4 = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
Console.WriteLine(R4);
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (3) =======================");
int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R5 = Arr2.Where(x => x > 5).OrderBy(x => x).ElementAt(1);

Console.WriteLine(R5);
Console.ReadLine();
Console.Clear();

#endregion

# region Set Operators
Console.WriteLine("====================== (1) =========================");
var R6 = ProductList.Select(p => p.Category).Distinct();

foreach (var item in R6)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================= (2) ==========================");
var p = ProductList.Select(p => p.ProductName[0]);
var c = CustomerList.Select(c => c.CustomerID[0]);

var R7 = p.Union(c);

foreach (var item in R7)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (3) =======================");
var R8 = p.Intersect(c);

foreach (var item in R8)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (4) ========================");
var R9 = p.Except(c);

foreach (var item in R9)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("========================= (5) ========================");

var p2 = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3));
var c2 = CustomerList.Select(c => c.CustomerID.Substring(c.CustomerID.Length - 3));

var R10 = p2.Concat(c2);

foreach (var item in R10)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

#endregion

#region Aggregate Operators
Console.WriteLine("======================== (1) ==========================");
int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R11 = Arr3.Count(x => x % 2 == 1);
Console.WriteLine(R11);
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (2) ==========================");
var R12 = CustomerList.Select(c => new { c.CustomerID, orderCount = c.Orders.Count() });
foreach (var item in R12)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (3) =========================");
var R13 = ProductList.GroupBy(p => p.Category);

foreach (var item in R13)
{
    Console.WriteLine($"Category:{item.Key} , ProductCount {item.Count()}");

}

Console.ReadLine();
Console.Clear();

Console.WriteLine("========================= (4) =========================");
var R14 = Arr3.Sum();
Console.WriteLine(R14);
Console.ReadLine();
Console.Clear();

Console.WriteLine("========================= (5) =========================");
var En_Dic = File.ReadAllLines("dictionary_english.txt").ToArray();
var R15 = En_Dic.Sum(x => x.Length);
Console.WriteLine(R15);
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================== (6) ==========================");
var R16 = ProductList.GroupBy(p => p.Category);
foreach (var item in R16)
{
    Console.WriteLine($"Category:{item.Key} , units {item.Sum(x => x.UnitsInStock)}");
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (7) ===========================");

var short_word = File.ReadAllLines("dictionary_english.txt").ToArray();
var R17 = short_word.OrderByDescending(x => x.Length);
Console.WriteLine(R17.Min(l => l.Length));
Console.ReadLine();
Console.Clear();

Console.WriteLine("======================= (8) =========================");
var R18 = ProductList.GroupBy(p => p.Category);

foreach (var item in R18)
{
    Console.WriteLine($"Category {item.Key}  price : {item.Min(p => p.UnitPrice)} ");
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("======================= (9) =========================");
var R19 = from p4 in ProductList
          group p4 by p4.Category into category
          let min = category.MinBy(p4 => p4.UnitPrice)
          select new { Produc_category = category.Key, price = min };

foreach (var item in R19)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (10) ===========================");

var long_word = File.ReadAllLines("dictionary_english.txt").ToArray();
Console.WriteLine(long_word.Max(l => l.Length));
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (11) ===========================");
var R20 = ProductList.GroupBy(p => p.Category);

foreach (var item in R20)
{
    Console.WriteLine($"Category {item.Key}  price : {item.Max(p => p.UnitPrice)} ");
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (12) ===========================");
var R21 = from p5 in ProductList
          group p5 by p5.Category into category
          let max = category.Max(p5 => p5.UnitPrice)
          select new { Produc_category = category.Key, price = max };

foreach (var item in R21)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (13) ===========================");
var average_word = File.ReadAllLines("dictionary_english.txt").ToArray();
Console.WriteLine($"Average :{average_word.Average(l => l.Length)}");
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (14) ===========================");
var R22 = ProductList.GroupBy(p => p.Category);

foreach (var item in R22)
{
    Console.WriteLine($"Category : {item.Key}  , Average : {item.Average(p => p.UnitPrice)}");
}
Console.ReadLine();
Console.Clear();
#endregion

#region  Ordering Operators
Console.WriteLine("====================== (1) ===========================");
var R23 = from p6 in ProductList
          orderby p6.ProductName
          select p6;

foreach (var item in R23)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (2) ===========================");
string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
var R24 = Arr4.OrderBy(x => x, new Case_Sen_Compare());
foreach (var item in R24)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (3) ===========================");
var R25 = ProductList.OrderByDescending(p => p.UnitsInStock);

foreach (var item in R25)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (4) ===========================");
string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var R26 = Arr5.OrderBy(l => l.Length).ThenBy(l => l);
foreach (var item in R26)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (5) ===========================");
string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

var R27 = words.OrderBy(l => l.Length).ThenBy(l => l, new Case_Sen_Compare());
foreach (var item in R27)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (6) ===========================");
var R28 = ProductList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);

foreach (var item in R28)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();
Console.WriteLine("====================== (7) ===========================");
string[] Arr6 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
var R29 = Arr6.OrderBy(l => l.Length).ThenByDescending(l => l, new Case_Sen_Compare());
foreach (var item in R29)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();
Console.WriteLine("====================== (8) ===========================");
string[] Arr7 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var R30 = Arr7.Reverse().Where(x => x[1] == 'i');

foreach (var item in R30)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();
#endregion

#region Partitioning Operators
Console.WriteLine("====================== (1) ===========================");
var R31 = CustomerList.Where(c => c.City == "London").SelectMany(c => c.Orders).Take(3);

foreach (var item in R31)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (2) ===========================");
var R32 = CustomerList.Where(c => c.City == "London").SelectMany(c => c.Orders).Skip(2);

foreach (var item in R32)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (3) ===========================");
int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R33 = numbers1.TakeWhile((x, i) => x > i);

foreach (var item in R33)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (4) ===========================");
int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R34 = numbers2.SkipWhile((x => x % 3 != 0));

foreach (var item in R34)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (5) ===========================");
int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R35 = numbers3.SkipWhile((x, i) => x > i);

foreach (var item in R35)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();
#endregion

#region Projection Operators

Console.WriteLine("====================== (1) ===========================");
var R36 = ProductList.Select(p => p.ProductName);

foreach (var item in R36)
{
    Console.WriteLine(item);
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (2) ===========================");
string[] words1 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
var R37 = words1.Select(x => new { upper = x.ToUpper(), lower = x.ToLower() });
foreach (var item in R37)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (3) ===========================");
var R38 = ProductList.Select(p => new { ID = p.ProductID, Name = p.ProductName, Price = p.UnitPrice });
foreach (var item in R38)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (4) ===========================");
int[] Arr8 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var R39 = Arr8.Select((x, i) => x.ToString() + " : " + (x == i).ToString());
Console.WriteLine("Number: In-place?");
foreach (var item in R39)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (5) ===========================");
int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };
var R40 = from a in numbersA
          from b in numbersB
          where a < b
          select a + " is less than " + b;
Console.WriteLine("Pairs where a < b:");
foreach (var item in R40)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (6) ===========================");
var R41 = from c1 in CustomerList
          from order in c1.Orders
          where order.Total > 500.00M
          select order;
foreach (var item in R41)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (7) ===========================");
var R42 = from c3 in CustomerList
          from order in c3.Orders
          where order.OrderDate.Year >= 1998
          select order;
foreach (var item in R42)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.Clear();

#endregion

#region Quantifiers
Console.WriteLine("====================== (1) ===========================");
var word_Dic = File.ReadAllLines("dictionary_english.txt").ToArray();
var R43 = word_Dic.Any(e => Regex.IsMatch(e, ".ei.| .EI."));
Console.WriteLine(R43);

Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (2) ===========================");
var R44 = ProductList.GroupBy(p => p.Category);
foreach (var item in R44)
{
    if (item.Any(p => p.UnitsInStock == 0))
    {
        Console.WriteLine($"{item.Key}");
        foreach (var product in item)
        {
            Console.WriteLine(product);
        }
    }
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("====================== (3) ===========================");
var R45 = ProductList.GroupBy(p => p.Category);
foreach (var item in R45)
{
    if (item.All(p => p.UnitsInStock > 0))
    {
        Console.WriteLine($"{item.Key}");
        foreach (var product in item)
        {
            Console.WriteLine(product);
        }
    }
}
Console.ReadLine();
Console.Clear();
#endregion

#region Grouping Operators

Console.WriteLine("====================== (1) ===========================");
var list = Enumerable.Range(0, 15);

var R46 = list.GroupBy(x => x % 5);

var count = 0;

foreach (var group in R46)
{
    Console.WriteLine($" Numbers with a remainder of {count} when divided by 5 ");

    foreach (var item in group)
    {
        Console.WriteLine(item);
    }
    count++;
}

Console.ReadLine();
Console.Clear();

//Console.WriteLine("====================== (2) ===========================");
//var EN_dictionary = File.ReadLines("dictionary_english.txt").ToDictionary(w => w);

//var R47 = EN_dictionary.GroupBy(w => w.Value.ElementAt(0)).Distinct();

//foreach (var group in R47)
//{
//    foreach (var key in group)
//    {
//        Console.Write($"{key}");
//    }
//}

//Console.ReadLine();
//Console.Clear();

Console.WriteLine("====================== (3) ===========================");
string[] Arr9 = { "from", "salt", "earn", "last", "near", "form" };

var R48 = Arr9.GroupBy(x => new Same_word_comparer().GetHashCode(x));

foreach (var item in R48)
{

    foreach (var key in item)
    {
        Console.WriteLine(key);
    }

}
#endregion