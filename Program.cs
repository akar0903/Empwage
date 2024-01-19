using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        int random_number = random.Next(0, 1);
        if (random_number == 0)
        {
            Console.WriteLine("Absent");
        }
        else
        {
            Console.WriteLine("Present");
        }
    }
}