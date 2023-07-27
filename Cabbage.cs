using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Cabbage.
/// </summary>
    internal class Cabbage : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cabbage"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        public Cabbage(double weight)
            : base("Cabbage", 25, weight)
        {
        }
    }
}
