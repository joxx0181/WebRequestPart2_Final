using System;

namespace WebRequest
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter request: ");
            Uri userInput = new Uri(Console.ReadLine());

            if (userInput.IsFile)
            {
                Request userRequestFile = new FILE();
                userRequestFile.GetUserRequest(userInput);
            }
            else
            {
                Request userRequest = new HTTP();
                userRequest.GetUserRequest(userInput);
            }

            Console.ReadLine();
        }
    }
}