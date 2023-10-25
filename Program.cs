namespace Sammie_s_____P_A_R_K_I_N_G____GARAGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anountOfMinutes, moneyPaid = 0;
            Console.WriteLine("Welcome to Sammie's Parking Garage!");
            Console.WriteLine("Please type the amount of time in minutes you've had your your car parked.");
            anountOfMinutes = Convert.ToInt32(Console.ReadLine());
            if (anountOfMinutes <= 60)
            {
                moneyPaid = 4;
                
            }
            else if (anountOfMinutes <= 120)
            {
                moneyPaid = 4 + 2;
                
            }
            else if (anountOfMinutes <= 180)
            {
                moneyPaid = 4 + 2 + 2;
            }
            else if (anountOfMinutes <= 240)
            {
                moneyPaid += 4 + 2 + 2 + 2;
            }
            else if (anountOfMinutes <= 300)
            {
                moneyPaid = 4 + 2 + 2 + 2 + 2;
            }
            else if (anountOfMinutes <= 360)
            {
                moneyPaid = 4 + 2 + 2 + 2 + 2 + 2;
            }
            else if (anountOfMinutes <= 420)
            {
                moneyPaid = 4 + 2 + 2 + 2 + 2 + 2 + 2;
            }
            else if (anountOfMinutes <= 480)
            {
                moneyPaid = 4 + 2 + 2 + 2 + 2 + 2 + 2 + 2;
            }
            else
            {
                moneyPaid = 4 + 2 + 2 + 2 + 2 + 2 + 2 + 2 + 2;
            }
            Console.WriteLine("SAMMIE'S PARKING GARAGE INC.");
            Console.WriteLine("=========================================================================================================");
            Console.WriteLine($"You must pay ${moneyPaid} for parking");
            Console.WriteLine("YOU WILL BE CHARGED EXTRA IF YOU DO NOT PAY WITHIN 24 HOURS (Amount of money charged varys on what day)");
            Console.WriteLine("USE CODE: 11829188361738182 TO PAY BILL AT OUR WEBSITE");
            Console.WriteLine("=========================================================================================================");
            Console.WriteLine("Thanks for using Sammie's Parking Garage!");






            Console.ReadLine();
            
        }
    }
}