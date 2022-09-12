namespace Methods
{
    class UserLogger
    {
        static bool userLoggedIn = false;
        public static string userID = "unkn";
        public static string password = "unkn";

        private void GetUserID()
        {
            bool successfulparse = false;
            while (!successfulparse)
            {
                Console.WriteLine("Enter your User name:");
                string temp = Console.ReadLine();
                if(string.IsNullOrEmpty(temp)){
                    successfulparse = false;
                    Console.WriteLine("You didn't enter a UserID");
                    continue;
                }
                else
                {
                    successfulparse = true;
                    Console.WriteLine($"You entered a {temp}");
                    userID = temp;
                }
                
            }
        }

        public void login()
        {
            string tempID;
            while (userLoggedIn)
            {
                Console.WriteLine("Enter your User name:");
                tempID = Console.ReadLine();
                if (tempID == userID) userLoggedIn = true;
            }
            //int.TryParse(user, out userID)
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your user name");
            userID = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine($"You are registered as {userID} password: {password}");
        }

        public static void ParseEx()
        {
            string temp;
            Console.WriteLine("Enter a unsigned 16bit value: Range {0}-{1}", 0, (Math.Pow(2, 16) - 1));
            temp = Console.ReadLine();
            try
            {
                UInt16 int16_val = UInt16.Parse(temp);
            }
            catch (OverflowException)    //User entered a value too large for the UInt16 variable to hold
            {
                Console.WriteLine("Invalid 16-bit entry");
            }
            catch (ArgumentNullException)    //Nothing was passed in the argument
            {
                Console.WriteLine("Argument Null Exception: No Argument was passed");
            }
            finally                     //Catch Case
            {
                Console.WriteLine("You entered an invalid type to parse");
            }
        }

        public static void OperatorsEx()
        {
            int num1 = -5;
            int num2 = 3;
            int num3;

            //Urnary Operators
            Console.WriteLine("Num1 value after unary operator: {0}", -num1);   //temp == 5  

            bool isSunny = false;
            Console.WriteLine("Sunny Today: {0}", !isSunny);

            //Incremental Operators
            Console.WriteLine("Num2: {0}", num2);
            Console.WriteLine("Num2: {0}", num2++);    // Post-Increment
            Console.WriteLine("Num2: {0}", ++num2);    // Pre-Increment
        }
        public static void SwitchEx()
        {
            string temp_val;
            string instruction;

            Console.WriteLine("Please enter a value");
            temp_val = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the data type you would like to Parse too");
            instruction = Console.ReadLine().ToLower();

            switch (instruction)
            {
                case "int":
                    try
                    {
                        int val = int.Parse(temp_val);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You entered an invalid number");
                    }
                    Console.WriteLine($"the String {temp_val} has been parsed");

                    break;
                default:
                    Console.WriteLine("You didn't enter a correct instruction");
                    break;
            }
        }
    }

}
