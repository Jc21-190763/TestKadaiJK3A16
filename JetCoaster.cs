using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRC
{
    public class JetCoaster
    {
        public static int ride
            (int k, int[] g, int r)
        {
            int youso = 0;
            int goukei = 0;
            if (g.Length == 0)
            {
                return 0;
            }
            while (r > 0)
            {
                int i = 0;
                int count = youso;
                while (i < k + 1)
                {
                    i += g[youso];
                    if (i > k)
                    {
                        i -= g[youso];
                        goukei += i;

                        break;
                    }
                    youso += 1;

                    if (youso > g.Length - 1)
                    {
                        youso = 0;
                    }
                    if (youso == count)
                    {
                        goukei += i;
                        break;
                    }
                }
                r -= 1;
            }
            return goukei;
        }
    }
}
