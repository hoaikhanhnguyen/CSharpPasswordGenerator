using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a small program to randomly create a password that is all lower case and 10 characters long

            //Using random Class...
            //We use the ASCII code for the letters
            //Since strings are immutable, we place them into an array then create the string
            // because we cannot change the string once we create it
            var random = new Random();

            const int passwordLength = 10;
            //declare const to avoid magic number
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++ )
                buffer[i] = (char)('a' + random.Next(0,26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
