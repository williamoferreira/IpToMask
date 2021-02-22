using System;
using System.Collections.Generic;

namespace IpToMask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcular Mascara para o IP ---");
            Console.WriteLine();
            Console.Write("Informe o IP: ");
            string sourceIP = Console.ReadLine();

            string[] stringIpOctets = sourceIP.Split('.');
            List<byte> ipOctets = new List<byte>();

            foreach (string octet in stringIpOctets)
            {
                ipOctets.Add(byte.Parse(octet));
            }

            
            Console.Write(Convert.ToString(ipOctets.ToArray()[0], 2) + "." +
                          Convert.ToString(ipOctets.ToArray()[1], 2) + "." +
                          Convert.ToString(ipOctets.ToArray()[2], 2) + "." +
                          Convert.ToString(ipOctets.ToArray()[3], 2));
            

        }
    }
}
