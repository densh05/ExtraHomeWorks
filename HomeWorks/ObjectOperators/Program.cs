using ObjectOperators;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Number n1 = new Number(5);
        Number n2 = new Number(-3);

        Number result1 = new Number(10); // Implicit conversion from Number to int
        int x = result1;
        Console.WriteLine(x);

        Number result2 = (Number)10; // Explicit conversion from int to Number
        Console.WriteLine(result2);

        Console.WriteLine(new string ('-', 20));

        var n3 = n1 + n2;
        Console.WriteLine(n3);
        var n4 = n1 - n2;
        Console.WriteLine(n4);
        var n5 = n1 * n2;
        Console.WriteLine(n5);
        var n6 = n1 / n2;
        Console.WriteLine(n6);
        var n7 = n1 % n2;
        Console.WriteLine(n7);
        var n8 = ++n1;
        Console.WriteLine(n8);
        var n9 = --n1;
        Console.WriteLine(n9);
        var n10 = n1 == n2;
        Console.WriteLine(n10);
        var n11 = n1 != n2;
        Console.WriteLine(n11);
        var n12 = n1 > n2;
        Console.WriteLine(n12);
        var n13 = n1 < n2;
        Console.WriteLine(n13);
        var n14 = n1 <= n2;
        Console.WriteLine(n14);
        var n15 = n1 >= n2;
        Console.WriteLine(n15);

        bool res = n1.Equals(n2);
        Console.WriteLine(res);

        bool res2 = n1 == n2;
        Console.WriteLine(res2);
    }
}


