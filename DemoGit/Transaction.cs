using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    public sealed class Transaction
    {
        public int[] CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string ExpiryDate { get; set; }
    }
}
