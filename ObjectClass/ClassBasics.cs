using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Classes.Basics
{
    /*
 * Class is a blueprint of an Object
 * 
 * It has...
 *      Actions/Abilities - So called member functions or methods
 *      Properties - So called member variables.
 *      Inheritance Possible
 *      
 *Access Modifiers Types
 *  private
 *  public
 *  protected
 *  internal
 *  
 *Acess Modifier Combinations
 *  protected-internal
 *  private-protected
 *  
 */

    class Box
    {
        // PRIVATE & PUBLIC MEMBER FIELDS
        private int _width;
        private int _height;
        private int _length;
        private int _volume;
        private int _weight;

        // PUBLIC AND PRIVATE PROPERTIES
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                UpdateVolume();
            }
        }
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0) throw new Exception("Negative number not allowed");
                _length = value;
            }
        }
        public int Volume
        {
            get
            {
                return this._height * this._width * this._length;
            }
            set
            {
                _volume = value;
            }
        }
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0) throw new Exception("Negative Weight is not possible");
                _weight = value;
            }
        }
        public int FrontSurface
        {
            get
            {
                return _length * _height;
            }
        }

        //MEMBER CONSTRUCTOR
        public Box(int width, int height, int length)
        {
            _width = width;
            _height = height;
            _length = length;
            Volume = _width * _height * _length;
        }
        ~Box()
        {
            Console.WriteLine("Destructor Called");
        }
        //PRIVATE AND PUBLIC MEMBER FUNCTIONS OR METHODS
        public void SetWidth(int width)
        {
            if (width < 0) throw new Exception("Lenght can not be a negative number");
            this._width = width;
            UpdateVolume();
        }
        public int GetWidth()
        {
            return this._width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {_width} Height: {_height} Length: {_length} Volume: {_width * _height * _length} Weight: {Weight}");
        }
        private void UpdateVolume()
        {
            this.Volume = this._height * this._width * this._length;
        }
    }
    class Car
    {
        //Properties or Traits of class
        protected string _make;
        protected string _model;
        protected int _year;
        protected string _package;

        //This variable with only be accessible to this class and all classes 
        //that derive from this class.
        protected string _protectedVariable;
        //
        private float _wheelBase { get; set;}

        //Constructor
        public Car(string _make, string _model, int _year, string package = "unk")
        {
            this._make = _make;
            this._model = _model;
            this._year = _year;
            this._package = package;
            this._protectedVariable = "PROTECTED VARIABLE";
        }
        //----------DESTRUCTOR---------
        //The destructor is greatly useless because it just affects performance
        ~Car()
        {
            Debug.Write("Destructing car Object");
        }

        public void DisplayDetails()
        {
            Console.WriteLine(_year + " " + _make + " " + _model + " " + _package);
        }
        public void Drive() { Console.WriteLine(_model + " driving forward!"); }
        public void Brake() { Console.WriteLine(_model + " is STOPPING!"); }
        public void Turn() { }
        public void RollDownWindow() { }
    }
    class Human
    {
        string _firstName;
        string _lastName;
        int _age;

        //By putting defaults in the parameter lists, it basically creates 4 Constructors
        //It creates.....
        //      public Human() constructor
        //      public Human(string) constructor
        //      public Human(string, string) constructor
        //      public Human(string, string, int) constructor
        public Human(string firstName = "unk", string lastName = "unk", int age = 0)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }

        public void IntroduceMyself()
        {
            if(this._age < 2 && (this._firstName == "unk" || this._lastName == "unk") ){
                Console.WriteLine("GOOOOOO GOOOOOOOO");
            }
            else
            {
                if (_firstName != "unk" && _lastName != "unk") Console.WriteLine("Hello! my name is " + _firstName + " " + _lastName);
                if (_firstName != "unk" && _lastName == "unk") Console.WriteLine("Hey! I am " + _firstName);
                if (_firstName == "unk" && _lastName == "unk") Console.WriteLine("HELP! I DONT KNOW WHO I AM");
            } 
        }
    }

    class ObjectClassManager 
    {
        public static void BoxClassManager()
        {
            Box b1 = new Box(23, 25, 27);
            b1.DisplayInfo();
            b1.SetWidth(53);
            b1.DisplayInfo();
            Console.WriteLine(b1.Volume);
            b1.Weight = 125;
        }
        public static void HumanClassManager()
        {
            Human mark = new ("Mark", "Mavis", 38);
            mark.IntroduceMyself();
            Human baby = new ("Hendrix", "Mavis", 1);
            baby.IntroduceMyself();

            Human person1 = new("Billy", "", 26);
            person1.IntroduceMyself();
            Human person2 = new("Brad", "Billingsworth", 48);
            person2.IntroduceMyself();
            Human person3 = new();
            person3.IntroduceMyself();
        }
        public static void CarClassManager()
        {
            Car accord = new ("Honda", "Accord", 2001, "EX");
            accord.Drive();
            accord.Brake();
            accord.DisplayDetails();
           
        }
    } 
}


