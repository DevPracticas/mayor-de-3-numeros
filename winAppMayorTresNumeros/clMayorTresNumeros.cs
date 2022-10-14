using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAppMayorTresNumeros
{

    internal class clMayorTresNumeros
    {
        int num1, num2, num3;
        public clMayorTresNumeros(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public int mayorTresNumeros()
        {
            if (num1 > num2 && num1<num3)
                return num1;
            else if (num2 > num1 && num2 < num3)
                return num2;
            else return num3;
        }
    }


    
}
