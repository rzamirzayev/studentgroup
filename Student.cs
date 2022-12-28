using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Stundent
    {
        
        public static int id=0;
        private string _name;
        private string _surname;
        private int _avarage;
       
        public string name { 
            get { return _name;}
            set {
                if(value.Length <3 || value.Length>15) {
                    Console.WriteLine("name herf sayi 3 ve 15araliginda olmalidir");
                }
                _name = value; }

            }
        
        public string surname
        {
            get { return _surname;}
            set { _surname = value; }
        }
        public int avarage
        {
            get { return _avarage; }
            set 
            {
                if (value < 0 || value>100)
                    Console.WriteLine("Avarage 0 ve 100 araliginda olmalidir");
                else
                    _avarage = value;
          
            }
           
        }
        

    }
}
