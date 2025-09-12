namespace Day_2
{
    internal class Program
    {
        static int sum;
        static void Main(string[] args)
        {
            int num1, num2, number_student;
            Console.WriteLine("enter number of subject!:-");  //output command like printf,cout
            number_student = Convert.ToInt32(Console.ReadLine()); //input command like scanf,cin(user input)
            int i = 0, Total = 0;
            int[] Strudent_mark = new int[number_student];
            while (i < number_student)
            {
                Console.WriteLine("Enter marks for subject " + (i + 1) + ": ");
                Strudent_mark[i] = Convert.ToInt32(Console.ReadLine());
                Total += Strudent_mark[i];
                i++;
            }
            while (true)
            {
                int choice;
                Console.WriteLine("enter your choice");
                Console.WriteLine("total sum of all subjext press 1 :");
                Console.WriteLine("average of all subject press 2 :");
                Console.WriteLine("Exit press any other key :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("total of all subject: " + Total);
                }
                else if (choice == 2)
                {
                    float avg = Total / number_student;
                    Console.WriteLine("average of all subject: ", +avg);
                }
                else
                {
                    break;
                }
            }

        }
        static (int firstnumber, int secondnumber, int result) Addition(int firstnumber, int secondnumber)
        {
            Console.WriteLine("Reached Addition method");
            sum = firstnumber + secondnumber;
            Console.WriteLine("The sum of {0} and {1} is :{2}", firstnumber, secondnumber, sum);
            return (firstnumber, secondnumber, sum);
        }
    }
}
