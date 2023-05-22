
using enum_example;

namespace enum_example
{
    public enum ProductCode { Milk, Tea, Meat, Dairy, Deli};

    public class EnumMethods
    {
        private enum ElectronicProductCodes
        {
            Keyboard = 0, Monitor = 1, Mouse = 2, HardDrive, Motherboard, Memory, Fans
        }

        public static void GetAllElectronicProductCodes()
        {
            foreach (string epc in Enum.GetNames(typeof(ElectronicProductCodes)))
            {
                Console.WriteLine(epc);
            }
        }
        public static void GetEnumTypeByIdx(int idx)
        {
            Array narr = Enum.GetValues(typeof(ElectronicProductCodes));
            Console.WriteLine(narr.GetValue(idx));
        }




        public static void Run()
        {
            
            EnumMethods.GetAllElectronicProductCodes();
            EnumMethods.GetEnumTypeByIdx(2);


            string milk_name = ProductCode.Milk.ToString();     //retrieving string MilK
            Console.WriteLine(milk_name);
            Console.WriteLine($"Prey is Evading");
            ProductCode parse_product;
            bool status = Enum.TryParse(milk_name, out parse_product);
            Console.WriteLine(status);

            int electronic_product_code = (int)ElectronicProductCodes.Keyboard;
            Console.WriteLine(electronic_product_code);

            Console.WriteLine(((ElectronicProductCodes)electronic_product_code).ToString());

            ProductCode product_data_type;
            bool product_data_parse_status = Enum.TryParse(ElectronicProductCodes.Monitor.ToString(), out product_data_type);


            Console.WriteLine(product_data_type);
            Console.WriteLine((int)product_data_type);
            Console.WriteLine(product_data_type.ToString());
            

            Console.WriteLine("Press enter to shutdown....");
            Console.ReadLine();
        }
    }
}

class Program
{
    public static void Main()
    {
        EnumMethods.Run();

    }
}