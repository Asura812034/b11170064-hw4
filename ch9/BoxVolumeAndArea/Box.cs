using System;

public class Box
{
    // 成員變數
    public double Width { get; private set; }
    public double Height { get; private set; }
    public double Length { get; private set; }

    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 計算表面積
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
}