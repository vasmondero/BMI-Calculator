internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź swoją wagę w kg");
        double waga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wprowadź swój wzrost w m");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double BMI = waga / (wzrost * wzrost);
        Console.WriteLine("Twoje BMI to:" + Math.Round(BMI, 2));
        if (BMI < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }

        else if (BMI <= 24.9)
        {
            Console.WriteLine("Waga w normie");
        }
        else if (BMI <= 34.9)
        {
            Console.WriteLine("Otyłość");
        }
        else if (BMI < 35)
        {
            Console.WriteLine("Skrajna Otyłość");
        }
    }
}
//kropka to wróg przecinek to bóg