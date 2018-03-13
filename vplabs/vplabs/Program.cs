using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vplabs
{
    class Program
    {
        static void Main(string[] args)
        {
            string name=null, contact=null, address=null;
            double amount = 0;
            welcome wel = new welcome();
            wel.Welcome();
            Console.Write("\t\t\tEnter your name : ");
            name = Console.ReadLine();
            Console.Write("\t\t\tEnter your contact : ");
            contact = Console.ReadLine();
            Console.Write("\t\t\tEnter your address : ");
            address = Console.ReadLine();
            Console.Write("\t\t\tEnter amout to invest : ");
            amount = double.Parse(Console.ReadLine());
            wel.choices();
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.Clear();
                wel.choices();
                Console.ReadLine();
            }
            if (choice == 1)
            {
                hbl hblData = new hbl();
                Console.Write("\t\tHBL policy has 10% interest so on " + amount + " amount, you will pay " + hblData.showInterest(amount) + " Rs");
            }
            if (choice == 2)
            {
                allied alliedData = new allied();
                Console.Write("\t\tAllied Bank policy has 15% interest so on " + amount + " amount, you will pay " + alliedData.showInterest(amount) + " Rs");
            }
            if (choice == 3)
            {
                mcb mcbData = new mcb();
                Console.Write("\t\tMCB policy has 9% interest so on " + amount + " amount, you will pay " + mcbData.showInterest(amount) + " Rs");
            }
            Console.ReadKey();   
        }
    }
}
