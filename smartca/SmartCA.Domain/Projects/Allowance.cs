using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Domain.Projects
{
    public class Allowance
    {
        public string Title {   get; private set; }
        public decimal Amount { get; private set; }

        public Allowance(string title,decimal amount)
        {
            this.Title = title;
            this.Amount = amount;
        }
    }
}
