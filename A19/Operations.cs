using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19
{
    internal class Operations
    {
        public void Add(int n1, int n2)
        {
            Console.WriteLine($"{n1}+{n2} = {(n1 + n2)}");
        }
        public void Sub(int n1, int n2)
        {
            Console.WriteLine($"{n1}-{n2} = {(n1 - n2)}");
        }
        public void Div(int n1, int n2)
        {
            Console.WriteLine($"{n1}/{n2} = {(n1 / n2)}");
        }
        public void Mul(int n1, int n2)
        {
            Console.WriteLine($"{n1}*{n2} = {(n1 * n2)}");
        }
        
    }
}
