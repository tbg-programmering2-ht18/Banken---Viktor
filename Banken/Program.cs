using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace banken
{
    class Program
    {
        static List<customer> CustomerList = new List<customer>();

        static void Main(string[] args)
        {
            //skriver ut dom olika valen i banken som ska hända.
            Console.WriteLine("Vällkommen till banken!");
            Console.WriteLine("");
            Console.WriteLine("Ange vilket av följande alternativ önskar dugöra.");
            Console.WriteLine("");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Ta bort användare");
            Console.WriteLine("3. Visa alla befintiliga användare");
            Console.WriteLine("4. Visa saldo för en användare");
            Console.WriteLine("5. Gör en insättning för en användare");
            Console.WriteLine("6. Gör ett uttag för en användare");
            Console.WriteLine("7. Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("Skriv ditt val: ");

            int val = 0;
                
            string valStr = Console.ReadLine();
            try
            {
               val = int.Parse(valStr); //test
            }
            catch(FormatException e)
            {
                Console.WriteLine("Noo U is very gae");
            }

            while (val != 7)
            {

                switch (val)
                {
                    case 1:
                        AddCustomer(); //Lägger till en användare i programmet 
                        break;
                    case 2:
                        RemoveCustomer();//Tar bort en användare från programmet
                        break;
                    case 3:
                        foreach (customer info in CustomerList)
                        {
                            Console.WriteLine(info.CustomerInfo());//visar alla användarna man har skrivit in
                            string.mydoc // filhantering
                        }

                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;
                    case 5:
                        Console.WriteLine("Case 5");
                        break;
                    case 6:
                        Console.WriteLine("Case 6");
                        break;
                    case 7:
                        Console.WriteLine("Case 7");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                Console.WriteLine("Skriv ditt val: ");// Tar in det  du skriver som val  
                valStr = Console.ReadLine();
                val = int.Parse(valStr);

            }

        }

        public static void AddCustomer() // Lägger till en Customer i listan
        {
            Console.WriteLine("write the name of the customer: ");
            string NewCustomer = Console.ReadLine();
            customer customer = new customer();
            customer.Namn = NewCustomer;
            CustomerList.Add(customer);

        }

        public static void RemoveCustomer() // Tar bort en Customer från listan
        {
            Console.WriteLine("write the name of the customer: "); //skriver ut Namnet på en användare som ska tas bort
            string Customertodelete = Console.ReadLine();
            customer objecttodelete = null;
            foreach (customer info in CustomerList)
            {
                if (info.Namn == Customertodelete)
                    objecttodelete = info;
                Console.WriteLine(" Du tog bort " + info.CustomerInfo()); //skriver ut personen som du tog bort
               
            }
            CustomerList.Remove(objecttodelete);
        }
        
        
         
}
}









