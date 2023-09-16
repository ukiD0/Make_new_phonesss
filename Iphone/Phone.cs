using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iphone
{
    internal class Phone
    {
        public string number;
        public string model;
        public string weight;
        public string _callerName;
        public string _callerNumber;

        public Phone(string number,string model,string weight) 
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
            
        }
        public void Info()
        {
            Console.WriteLine($"Модель {model}");
            Console.WriteLine($"Серия/номер {number}");
            Console.WriteLine($"Вес {weight}");
        }

        public void ReceiveCall(string _callerName,string _callerNumber) 
        {
            Console.WriteLine($"ОТВЕТЬ УЖЕ ЕМУ - {_callerName}\nНомер телефона {_callerNumber}");
        }

        public string _getNumber()
        {
            return _callerNumber ;
        }

        public void sendMessage(params string[] _nuners) 
        {
            Console.WriteLine("По какому номеру отправить сообщение :* ?");
            foreach (string _nuner in _nuners)
            {
                Console.WriteLine(_nuner);
            }

        }
        
    }
}
