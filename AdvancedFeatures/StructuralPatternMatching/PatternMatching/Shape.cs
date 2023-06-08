using System;
namespace Shapes;

public abstract class Shape{
    public abstract int Area();
}

public class Circle : Shape {
    public int Radius{get; set;}
    public Circle(int r){
        Radius = r;
    }
    public override int Area(){
        return (int)(Math.PI*(Math.Pow(Radius, 2)));
    }
}

public class Rectangle : Shape {
    
    public int Height{get; set;}
    public int Width{get; set;}

    public Rectangle(int height, int width){
        Height = height;
        Width = width;
    }
    public override int Area(){
        return Height * Width;
    }    
}

public class Triangle : Shape {
    public int BaseWidth{get; set;}
    public int Height{get; set;}

    public Triangle(int base_val, int height){
        BaseWidth = base_val;
        Height = height;
    }
    public override int Area(){
        return (BaseWidth*Height)/2;
    }
}