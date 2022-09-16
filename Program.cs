using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.Design;

namespace KFC
{   
    class Program
    {   static void Main(string[] args)
        {
            string Menu = OutputMenu();
            Checkinputmenu(Menu);
        }

        public static string OutputMenu()
        {
            Console.WriteLine("Choose Your Menu");
            Console.WriteLine("Type {A} for shop info");
            Console.WriteLine("Type {B} for owner info");
            Console.WriteLine("Type {C} for employ info");
            Console.WriteLine("Type {D} for Income and servely info");
            Console.WriteLine("Your input is: ");
            Console.ReadLine();
        }

        static void Checkinputmenu(string A)
        {
            if(A == "A")
            {
                ShopInfo.MenuA();
            }
            else if (A == "B")
            {
                OwnerInfo.MenuB();
            }    
        }
    }
    
        

}
