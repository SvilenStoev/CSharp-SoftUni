using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class FancyBarcodes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string barcode = string.Empty;
            var regex = new Regex(@"[@][#]+[A-Z][A-Za-z(0-9)]{4,}[A-Z][@][#]+");
            var regexCheckDigits = new Regex(@"[0-9]+");

            for (int i = 0; i < n; i++)
            {
                barcode = Console.ReadLine();

                var matches = regex.Matches(barcode);
                
                if (!regex.IsMatch(barcode))
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    if (regexCheckDigits.IsMatch(barcode))
                    {
                        var matches2 = regexCheckDigits.Matches(barcode);

                        string group = string.Join("", matches2);

                        Console.WriteLine($"Product group: {group}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
            }
        }
    }
}
