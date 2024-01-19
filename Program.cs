using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        int day = random.Next(0, 2);
        String time = Console.ReadLine();
        int duration = Convert.ToInt32(time);
        switch (day)
        {
            case 0:
                Console.WriteLine("Absent");
                break;
            case 1:
                Console.WriteLine("Present");
                break;
            default:
                Console.WriteLine("Invalid number");
                break;

        }
        switch (duration)
        {
            case 4:
                Console.WriteLine("Part time");
                Console.WriteLine("Wage is " + 20 * 4);
                break;
            case 8:
                Console.WriteLine("Full time");
                Console.WriteLine("Wage is " + 20 * 8);
                break;
            default:
                Console.WriteLine("Invalid working period");
                break;
        }
    }
}
