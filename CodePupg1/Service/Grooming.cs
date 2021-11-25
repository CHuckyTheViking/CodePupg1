using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Service
{
    class Grooming : IGrooming
    {
        public decimal price { get; set; }
        public string ReceiptText { get; set; }

        public Grooming()
        {
            price = 15;
            ReceiptText = $"Groomed and cleaned: {price}";
        }
    }
}
