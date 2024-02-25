using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Entities
{
    public class Wallet
    {
        public virtual int Id { get; set; }
        public virtual string Holder { get; set; }
        public virtual decimal Balance { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Holder} ({Balance})";
        }
    }
}
