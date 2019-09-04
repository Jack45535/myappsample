using System;
using System.Collections.Generic;

namespace calender_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberselected;
            List<string> categories = new List<string>();
            int numberid = 1;
            categories.Add("Coding");
            categories.Add("Reading");
            categories.Add("Vocabulary");
            categories.Add("Exercise");
            categories.Add("Work");
            categories.Add("Stats");

            foreach (string category in categories)
            {
                Console.WriteLine(numberid + " " + category);
                numberid += 1;
            
            }
            Console.WriteLine("Choose a category:");
            numberselected = Convert.ToInt32(Console.ReadLine());
            if (numberselected == 1)
                {
                    Console.WriteLine("Welcome to the Coding page!");
                }
    
            if (numberselected == 2)
                {
                    Console.WriteLine("Welcome to the Reading page!");
                }
    
             if (numberselected == 3)
                {
                    Console.WriteLine("Welcome to the Vocabulary page!");
                }
    
             if (numberselected == 4)
                {
                    Console.WriteLine("Welcome to the Exercise page!");
                }
    
             if (numberselected == 5)
                {
                    Console.WriteLine("Welcome to the Work page!");
                }
    
            if (numberselected == 6)
                {
                    Console.WriteLine("Welcome to the Stat page!");
                     List<string> Statcategories = new List<string>();
                    int Statnumberid = 1;
                    Statcategories.Add("Productivity");
                    Statcategories.Add("Reading");
                    Statcategories.Add("Vocabulary");
                    Statcategories.Add("Exercise");
                    categories.Add("Work");
                    categories.Add("Stats");
                
                
                }


        }
    }
}
