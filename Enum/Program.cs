using System.Runtime.InteropServices;

namespace enum_example
{
    public enum ProductCode { Milk, Tea, Meat, Break};

    class Program
    {
        private enum ElectronicProductCode
        {
            Keyboard = 0, Monitor = 1, Mouse = 2,
        }

        public static void Run()
        {
            string milk_name = ProductCode.Milk.ToString();     //retrieving string MilK
            Console.WriteLine(milk_name);   

            ProductCode parse_product;
            bool status = Enum.TryParse(milk_name, out parse_product);
            Console.WriteLine(status);

            int electronic_product_code = (int)ElectronicProductCode.Keyboard;
            Console.WriteLine(electronic_product_code);
 
            Console.WriteLine(((ElectronicProductCode)electronic_product_code).ToString());

            ProductCode product_data_type;
            bool product_data_parse_status = Enum.TryParse(ElectronicProductCode.Monitor.ToString(), out product_data_type);
            
            
            Console.WriteLine(product_data_type);
            Console.WriteLine((int)product_data_type);
            Console.WriteLine(product_data_type.ToString());
            
        }
    }
}


class Program
{
    public static void Main()
    {
        enum_example.Program.Run();

    }
}