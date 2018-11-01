using System;

namespace ClothingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Welcome to Clothes");
            Console.WriteLine("******************");

            Console.WriteLine("0. Create an account.");
            Console.WriteLine("1. Check out these hip new clothing product!");
            Console.WriteLine("2. Exit");

            Console.Write("Please select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {

                case "0":
                    return;
                case "1":
                    try
                    {
                        Console.Write("Email Address: ");
                        var userEmailAddress = Console.ReadLine();

                        Console.Write("Shipping / Billing Address: ");
                        var userAccountAddress = Console.ReadLine();

                        var paymentInfo = Enum.GetNames(typeof(TypeOfPayment));
                        for (var i = 0; i < paymentInfo.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {paymentInfo[i]}");
                        }
                        Console.Write("Payment Method: ");
                        var userPaymentInfo = Console.ReadLine();
                        var account = Shop.CreateAccount(userEmailAddress, userAccountAddress, userPaymentInfo);
                    }
                    catch (FormatException fx)
                    {
                        Console.Write($"Error: {fx.Message}");
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("These clothes are super hip AND cool");
                        Console.WriteLine("Please select a category that interests you!");

                        var clothingInfo = Enum.GetNames(typeof(TypeOfClothing));
                        for (var i = 0; i < clothingInfo.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {clothingInfo[i]}");
                        }
                        Console.Write("Clothing choice: ");
                        var clothingTypeOption = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException nx)
                    {
                        Console.Write($"Error: {nx.Message}");
                    }
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }

    }
}
