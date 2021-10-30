using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa.Math
{
    
    public static class RussianMultiplication
    {
        
        public static int Mul(int x, int y)
        {
            int multiplicand = x;
            int multiplier = y;
            /*Zielzustand*/
            if (multiplier == 1) { return multiplicand; }

            /* Prüfung auf natürliche Zahlen (Null mit einbezogen) */
            if (multiplier < 0) { throw new ArgumentOutOfRangeException("y", "Nur natürliche Zahlen sind gültig."); }
            if (multiplicand < 0) { throw new ArgumentOutOfRangeException("x", "Nur natürliche Zahlen sind gültig."); }

            /* Ausnahme für 0 */
            if (multiplier == 0) { return 0; }
            if (multiplicand == 0) { return 0; }

            /* Durch die Teilung  multiplier/2 wird automatisch auf eine natürliche Zahl abgerundet (abschneiden der Nachkommastellen) */
            if (multiplier % 2 == 1)
            {
                return multiplicand + isa.Math.RussianMultiplication.Mul(2 * multiplicand, multiplier / 2);
            }
            else
            {
                return isa.Math.RussianMultiplication.Mul(2 * multiplicand, multiplier / 2);
            }
        }
    }

}
