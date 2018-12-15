using System;

namespace areEquallyStrong
{
    //An IP address is a numerical label assigned to each device(e.g., computer, printer)
    //participating in a computer network that uses the Internet Protocol for communication.
    //There are two versions of the Internet protocol, and thus two versions of addresses.
    //One of them is the IPv4 address.

    //IPv4 addresses are represented in dot-decimal notation,
    //which consists of four decimal numbers, each ranging from 0 to 255 inclusive, 
    //separated by dots, e.g., 172.16.254.1.
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = ".254.255.0";
            Console.WriteLine(isIPv4Address(inputString));
        }

        static bool isIPv4Address(string inputString)
        {

            string[] str = inputString.Split('.');
            if (str.Length != 4)
                return false;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == string.Empty)
                    return false;
                bool t = int.TryParse(str[i], out int result);
                if (!t)
                    return false;
                if (result > 255 || result < 0)
                    return false;
                i++;
            }
            return true;
        }


    }

}

