namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var familyCar = new FamilyCar(150, 50);

            familyCar.Drive(10);

            System.Console.WriteLine(familyCar.Fuel);

        }
    }
}
