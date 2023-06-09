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

public class DateQuarterClassifier{
    public static DateTime[] Dates = new DateTime[]{
        new DateTime(2022, 2, 14),
        new DateTime(2022, 7, 19),
        new DateTime(2022, 12, 25),
        new DateTime(2022, 4, 1)
    };

    public static string ClassifyDatesByQuarter(DateTime dt) => dt.Month switch{
        (>=1 and <=3) => "Quarter 1",
        (>=4 and <=6) => "Quarter 2",
        (>=7 and <=9) => "Quarter 3",
        (>=10 and <=12) => "Quarter 4",
        _ => throw new ArgumentOutOfRangeException(nameof(dt))
    };

    public static void ClassifyDatesByBiYearly(DateTime dt){
        if(dt is DateTime {Month: >6}){
            Console.WriteLine("Date is in Second Half of year");
        }else{
            Console.WriteLine("Date is in First Half of year");
        }
    }

    public static void Controller(){
        foreach(DateTime dt in Dates){
            Console.WriteLine(ClassifyDatesByQuarter(dt));
            ClassifyDatesByBiYearly(dt);
        }
    }
}