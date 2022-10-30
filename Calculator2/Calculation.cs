using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Calculation
    {
        private int a;
        private int b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }
        public int SoSanh(int a, int b)
        {
            int r = 0;
            if (a > b)
            {
                return 1;
            }
            else
            {
                if (a < b)
                {
                    return 2;
                }
            }
            return r;
        }
    }
}
