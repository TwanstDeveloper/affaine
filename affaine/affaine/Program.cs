using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affaine
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "tyuiohgygy";
            Program ob = new Program();
            Console.WriteLine(ob.enc(x));
        }
        string enc(string msg)
        {
            string cipher = "";
            int a = 5;
            int b = 10;
            for (int i = 0; i < msg.Length; i++)
            {
                if (char.IsUpper(msg[i]))
                {
                    cipher=cipher+(char)(((((a*(msg[i]-65))+b))%26)+25);
                }else if (char.IsLower(msg[i]))
                {
                    cipher = cipher + (char)(((((a * (msg[i] - 97)) + b)) % 26) + 97);
                }
            }
            return cipher;
        }
    }
}
