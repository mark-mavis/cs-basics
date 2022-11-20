using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class MissionariesCannibals
    {
        private int _lm;
        private int _lc;
        private int _rm;
        private int _rc;

        private int _count = 0;
        
        public int userM;
        public int userC;
        
        public MissionariesCannibals(int _lm, int _lc, int _rm, int _rc)
        {
            this._lm = _lm;
            this._lc = _lc;
            this._rm = _rm;
            this._rc = _rc;
        }
        public int RunGame()
        {
            bool rightToLeft = true;
            bool leftToRight = false;

            while (true)
            {
                Console.WriteLine("Enter Number of Missionaries to Travel => ");
                userM = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number of Cannibals to Travel => ");
                userC = int.Parse(Console.ReadLine());

                while (true)
                {
                    
                    if(userM == 0 && userC == 0){
                        Console.WriteLine("Empty travel not possible");
                    }else if( ((userM + userC) > 2) && ((_lm - userM) >= 0) && ((_lc - userC) >= 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input re-enter: ");
                    }

                    _lm = (_lm-userM);
                    _lc = (_lc-userC);
                    _rm = userM;
                    _rc = userC;

                    for(int i = 0; i < _lm; i++)
                    {
                        Console.Write("M");
                    }
                    for (int i = 0; i < _lc; i++)
                    {
                        Console.Write("C");
                    }
                    Console.WriteLine("| --> |");
                    
                    for (int i = 0; i < _rm; i++)
                    {
                        Console.Write("M");
                    }
                    for (int i = 0; i < _rc; i++)
                    {
                        Console.Write("C");
                    }
                    Console.WriteLine();

                    _count++;

                    if((_lm-_lc < 0) || (_rm - _rc < 0)) {
                        Console.WriteLine("Cannibals eat missionaries:\nYou lost");
                        break;
                    }

                    if(_rm + _rc == 6)
                    {
                        Console.WriteLine("You Won the Game");
                        break;
                    }
        
                }
            }
        }
    }
}
