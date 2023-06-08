
namespace Patterns;

public readonly struct Point{
    public int X {get;}
    public int Y {get;}
    public Point(int x, int y) => (X, Y) = (x, y);
    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}

public class PointClassifier{

    public static Point[] ListOfPoints = new Point[5]{
        new Point(10, 10),
        new Point(-1, 10),
        new Point(1, -5),
        new Point(-2, -4),
        new Point(0, 0)
    };

    public static string Classify(Point point) => point switch {
        (>0, >0) => "Upper Right Quadrant",
        (<0, >0) => "Upper Left Quadrant",
        (>0, <0) => "Lower Right Quadrant",
        (<0, <0) => "Lower Left Quadrant",
        _ => "Not in a quadrant"
    };

    public static void ClassifyPoints(){
        foreach(Point point in ListOfPoints){
           Console.WriteLine(Classify(point));
        }
    }
}