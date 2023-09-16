using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iphone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("1232323","Iphone11","150.01");
            Phone phone2 = new Phone("222323", "Iphone22", "333");
            Phone phone3 = new Phone("3333", "Iphone932", "69");

            Console.WriteLine("Информация о телефоне 1");
            phone1.Info();
            phone1.ReceiveCall("Evgeniiiii Polivanov", "832883");
            phone1.sendMessage("89772550187");
            Console.WriteLine();

            Console.WriteLine("Информация о телефоне 2");
            phone2.Info();
            phone2.ReceiveCall("Mammmaaa","322232323");
            phone2.sendMessage("89772550187");
            Console.WriteLine();

            Console.WriteLine("Информация о телефонеee 3");
            phone3.Info();
            phone3.ReceiveCall("mOSHEINIKII","6696955969");
            phone3.sendMessage("89772550187");
            Console.WriteLine();

        }
    }
}
