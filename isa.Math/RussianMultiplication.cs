using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa.Math
{
    /// <summary>Russische Bauernmultiplikation</summary>
    /// <remarks>Die Russische Bauernmultiplikation (auch Ägyptisches Multiplizieren, Abessinische Bauernregel oder Verdopplungs-Halbierungs-Methode genannt) 
    /// ist ein einfaches Verfahren zur Multiplikation zweier natürlicher Zahlen.</remarks>
    public static class RussianMultiplication
    {
        /// <summary>Mul bildet das einfache Verfahren zur Multiplikation zweier natürlicher Zahlen ab. </summary>
        /// <param name="x">int , Multiplikand</param>
        /// <param name="y"> int , Multiplikator</param>
        /// <returns> int , Das Produkt der Multiplikation</returns>
        /// <remarks>https://de.wikipedia.org/wiki/Russische_Bauernmultiplikation</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException"> Bei Funktionsaufruf(multiplicand,multiplier) mit nicht natürlichen Zahlen</exception>
        /// <example>
        /// Dieses Beispiel zeigt die Verwendung der Mathematischen-Extension <see cref="Left"/>.
        /// <code>
        ///     isa.Math.RussianMultiplication.Mul(47,42);
        ///     //Returns: 1974
        /// </code>
        /// </example>
        /// 
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
