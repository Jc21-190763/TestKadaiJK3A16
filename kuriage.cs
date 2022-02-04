using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRC
{
    public class kuriage
    {
        public static int kuriage10(int i)
        {
            //負の値の確認
            if (i < 0)
            {
                i = -i;
                i = i / 10;
                i++;
                i = i * 10;
                i = -i;
            }
            else
            {
                i = i / 10;
                i++;
                i = i * 10;
            }
            return i;
        }
    }
}
