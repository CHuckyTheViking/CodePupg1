using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Service
{
    public class Clipping : IClipping
    {

        public decimal price { get; set; }
        public string ReceiptText { get; set; }

        public Clipping()
        {
            price = 10;
            ReceiptText = $"Nails clipped: {price}";
        }

    }
}
