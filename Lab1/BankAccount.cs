using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    class BankAccount<T>
    {
        public T AccountNumber { get; set; }

        public string Name { get; set; }
        public double Balance { get; set; }


        public string GetInfo()
        {
            return $"{AccountNumber} {Name} {Balance}";
        }

        public void Input() 
        {
            Console.WriteLine("Введите номер счета");
            AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО владельца");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            
        }

    }

    
}
