using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.validation
{
    internal class InputValidation
    {
        public int getInt()
        {
            while (true)
            {
                int userInput = 0;
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    Console.Write("> ");
                }
                else
                {
                    return userInput;
                }
            }
        }


        public double getDouble()
        {
            while (true)
            {
                double userInput = 0;
                if (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    Console.Write("> ");
                }
                else
                {
                    return userInput;
                }
            }
        }

        public MENU_ITEMS getMenuItems()
        {
            while (true)
            {
                MENU_ITEMS userInput = 0;
                if (!MENU_ITEMS.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    Console.Write("> ");
                }
                else
                {
                    return userInput;
                }
            }
        }

        public CHOICE getChoice()
        {
            while (true)
            {
                CHOICE userInput = 0;
                if (!CHOICE.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    Console.Write("> ");
                }
                else
                {
                    return userInput;
                }
            }
        }
    }
}
