using System;
using Patterns;
using Shapes;

namespace StructuralPatternMatching;
class Program{
    public static void Main(){
        BasicPattern.Controller();

        SwitchPattern.Controller();
        
        DiscountGenerator.TestPurchaseData();

        PointClassifier.ClassifyPoints();
    }
}