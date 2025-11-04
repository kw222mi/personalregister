

using personalregister;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("sv-SE");

var register = new PersonnelRegister();

Console.WriteLine("PERSONALREGISTER\n");
Console.WriteLine("Lämna förnamn tomt för att avsluta.\n");

while (true)
{
    Console.Write("Förnamn: ");
    string? firstName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(firstName))
        break; // avsluta loopen

    Console.Write("Efternamn: ");
    string? lastName = Console.ReadLine();

    Console.Write("Lön: ");
    string? salaryInput = Console.ReadLine();

    if (!decimal.TryParse(salaryInput, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal salary))
    {
        Console.WriteLine("⚠ Ogiltig lön, försök igen.\n");
        continue;
    }

    try
    {
        var e = new Employee(firstName!, lastName!, salary);
        register.Add(e);
        Console.WriteLine("✔ Anställd tillagd.\n");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"⚠ Fel: {ex.Message}\n");
    }
}

register.PrintAll();
Console.WriteLine("Programmet avslutat.");