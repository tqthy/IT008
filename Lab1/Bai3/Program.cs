using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    //hàm tìm max trong dãy
    public static T findMax<T>(List<T> l) where T : IComparable<T>
    {
        T max = l[0];

        for (int i = 1; i < l.Count; i++)
        {
            if (max.CompareTo(l[i]) < 0)//nếu max<l[i]
            {
                max = l[i];
            }
        }

        return max;
    }


    //hàm tìm min trong dãy
    public static T findMin<T>(List<T> l) where T : IComparable<T>
    {
        T min = l[0];

        for (int i = 1; i < l.Count; i++)
        {
            if (min.CompareTo(l[i]) > 0)//nếu min>l[i]
            {
                min = l[i];
            }
        }

        return min;
    }

    static void Main()
    {
        List<int> dsSoNguyen = new List<int> { 5, 2, 8, 1000, 3 };
        List<double> dsSoThuc = new List<double> { 3.5, 1.2, -4.8, 0.9 };
        List<string> dsChuoi = new List<string> { "a", "bb", "ccc", "dddd" };

        Console.WriteLine("So nguyen lon nhat trong day la: " + findMax(dsSoNguyen));
        Console.WriteLine("So thuc lon nhat trong day la: " + findMax(dsSoThuc));
        Console.WriteLine("Chuoi lon nhat trong day la: " + findMax(dsChuoi));

        Console.WriteLine("So nguyen nho nhat trong day la: " + findMin(dsSoNguyen));
        Console.WriteLine("So thuc nho nhat trong day la: " + findMin(dsSoThuc));
        Console.WriteLine("Chuoi nho nhat trong day la: " + findMin(dsChuoi));

    }
}
