using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua data de nascimento (dd/MM/yyyy): ");
        string birthdateInput = Console.ReadLine();
        DateTime birthdate;

        if (DateTime.TryParseExact(birthdateInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
        {
            Console.WriteLine("Digite o ano que deseja saber sua idade (yyyy): ");
            string futureYearInput = Console.ReadLine();
            int futureYear;

            if (int.TryParse(futureYearInput, out futureYear))
            {
                DateTime futureDate = new DateTime(futureYear, birthdate.Month, birthdate.Day);
                int age = futureDate.Year - birthdate.Year;

                if (futureDate < birthdate.AddYears(age))
                {
                    age--;
                }

                Console.WriteLine($"Você terá {age} anos em {futureYear}.");
            }
            else
            {
                Console.WriteLine("Ano inválido.");
            }
        }
        else
        {
            Console.WriteLine("Data de nascimento inválida.");
        }
    }
}
