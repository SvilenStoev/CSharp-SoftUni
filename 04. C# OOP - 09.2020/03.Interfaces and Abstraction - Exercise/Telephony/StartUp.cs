using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var URLs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var mySmartphone = new Smartphone();
            var myStationaryPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currentPhoneNumber = phoneNumbers[i];

                try
                {
                    if (currentPhoneNumber.Length == 7)
                    {
                        Console.WriteLine(myStationaryPhone.Call(currentPhoneNumber));
                    }
                    else
                    {
                        Console.WriteLine(mySmartphone.Call(currentPhoneNumber));
                    }
                }
                catch (InvalidNumberException ine)
                {

                    Console.WriteLine(ine.Message);
                }
            }

            for (int i = 0; i < URLs.Length; i++)
            {
                string currentURL = URLs[i];

                Console.WriteLine(mySmartphone.Browse(currentURL));
            }
        }
    }
}
