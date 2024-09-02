using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Domain.Models
{
    public class Account
    {
        public int id {  get; set; }
        public required User AccountHolder { get; set; }
        public required IEnumerable<Order> Order {  get; set; }
    }
}
