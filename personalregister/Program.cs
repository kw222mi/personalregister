using System;
using System.Globalization;
using System.Text;

namespace personalregister
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("sv-SE");

            var register = new PersonnelRegister();

            Console.WriteLine("PERSONALREGISTER");
            Console.WriteLine("Skriv 0 på förnamn för att avsluta.");
            Console.WriteLine();

            while (true)
            {
             
                var firstName = ReadRequired("Förnamn (0=avsluta): ");
                if (firstName == null) break; 

                var lastName = ReadRequired("Efternamn: ");
                if (lastName == null)
                {
                 
                    Console.WriteLine("⚠ Efternamn får inte vara tomt. Försök igen.\n");
                    continue;
                }

                var salary = ReadSalary("Lön (t.ex. 32000,50): ");

             
                try
                {
                    var e = new Employee(firstName, lastName, salary);
                    register.Add(e);
                    Console.WriteLine("✔ Anställd tillagd.\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"⚠ Fel: {ex.Message}");
                    Console.WriteLine("Försök igen.\n");
                }
            }

            register.PrintAll();
            Console.WriteLine("\nProgrammet avslutat.");
        }

     
        static string? ReadRequired(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();

                if (s is null) 
                {
                    Console.WriteLine("⚠ Ogiltig inmatning. Försök igen.");
                    continue;
                }

                s = s.Trim();

                if (prompt.Contains("(0=avsluta)") && s == "0")
                    return null;

                if (string.IsNullOrWhiteSpace(s))
                {
                    Console.WriteLine("⚠ Fältet får inte vara tomt.");
                    continue;
                }

                return s;
            }
        }

        static decimal ReadSalary(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out var value) && value >= 0)
                    return value;

                Console.WriteLine("⚠ Ogiltig lön. Ange ett tal ≥ 0 (ex: 32000,50).");
            }
        }
    }
}
