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
        private double x;
        private int n;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Calculation(double x, int n)
        {
            this.x = x;
            this.n = n;
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
        public double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
    }
}
