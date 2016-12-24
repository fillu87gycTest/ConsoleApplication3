using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoD
{
    static void Main()
    {
        // int t, i;
        int[,] table = new int[3, 4];
        for (int t = 0; t < 3; t++)
        {
            for (int i = 0; i < 4; i++)
            {
                table[t, i] = (t * 4) + i + 1;
                Console.Write(table[t, i] + "\t");
            }
            Console.Write("{0}" + "", '\n');
        }
    }
}
