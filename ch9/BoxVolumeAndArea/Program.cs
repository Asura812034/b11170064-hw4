using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Box Calculator!");

        // 輸入寬、長、高
        Console.Write("Enter the Width of the box: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the Height of the box: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter the Length of the box: ");
        double length = double.Parse(Console.ReadLine());

        // 建立 Box 物件
        Box box = new Box(width, height, length);

        // 計算體積與表面積
        Console.WriteLine($"\nThe volume of the box is: {box.Volume()}");
        Console.WriteLine($"The surface area of the box is: {box.Area()}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}