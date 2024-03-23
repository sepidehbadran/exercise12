// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
        int count = 0;
        int maleCount = 0;
        while (true)
        {
            Console.WriteLine("please enter the person is age and enter to -1 finish :");
            int age = int.Parse(Console.ReadLine());
            if (age == -1)
            {
                break;
                Console.WriteLine("please enter the person is gender (M or F):");
                char gender = char.Parse(Console.ReadLine());
                if (gender == 'M' || gender == 'm')
                {
                    if (age >= 18 && age <= 20)
                    {
                        maleCount++;
                    }
                    count++;
                    {

                    }




                    double ma1ePerecentage = (double)maleCount / count * 100;
                    Console.WriteLine("number of men aged 18 to 20 :" + maleCount);
                    Console.WriteLine("perecent of men aged 18 to 20 :" + ma1ePerecentage + "%");
                }
            }
        }
    }
}